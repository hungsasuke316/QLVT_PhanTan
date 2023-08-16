using System;
using System.Data;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace QLVT
{
    public partial class frmChonNhanVien : Form
    {
        public frmChonNhanVien()
        {
            InitializeComponent();
        }

        private void frmChonNhanVien_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;

            this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nhanVienTableAdapter.Fill(this.DS.NhanVien);
            
            cbbChiNhanh.DataSource = Program.bds_dspm; //sao chép bds_dspm đã load ở đăng nhập
            cbbChiNhanh.DisplayMember = "TENCN";
            cbbChiNhanh.ValueMember = "TENSERVER";
            cbbChiNhanh.SelectedIndex = Program.mChiNhanh;
            if (Program.mGroup == "CONGTY")
            {
                cbbChiNhanh.Enabled = true;
                
            }
            else
            {
                cbbChiNhanh.Enabled = false;
            }
        }

        private string RemoveVietnameseSigns(string str)
        {
            string normalizedString = str.Normalize(NormalizationForm.FormD);
            StringBuilder result = new StringBuilder();

            foreach (char c in normalizedString)
            {
                UnicodeCategory category = CharUnicodeInfo.GetUnicodeCategory(c);
                if (category != UnicodeCategory.NonSpacingMark)
                {
                    result.Append(c);
                }
            }

            return result.ToString();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            DataRowView drv = ((DataRowView)(bdsNV.Current));
            string maNhanVien = drv["MANV"].ToString().Trim();

            string ho = drv["HO"].ToString().Trim();
            string ten = drv["TEN"].ToString().Trim();
            string hoTen = ho + ten;
            hoTen = RemoveVietnameseSigns(hoTen);

            Program.chonMANV = maNhanVien;
            Program.chonHOTEN = hoTen;
                       
            this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbChiNhanh.SelectedValue.ToString() == "System.Data.DataRowView")
                return;

            Program.servername = cbbChiNhanh.SelectedValue.ToString();
            Program.loginCurrent = Program.mlogin;
            Program.passwordCurrent = Program.password;

            if (cbbChiNhanh.SelectedIndex != Program.mChiNhanh)
            {
                Program.mlogin = Program.remotelogin;
                Program.password = Program.remotepassword;
            }

            else
            {
                Program.mlogin = Program.loginCurrent;
                Program.password = Program.passwordCurrent;
            }

            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("Xảy ra lỗi kết nối với chi nhánh hiện tại", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                
                this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                this.nhanVienTableAdapter.Fill(this.DS.NhanVien);
                               
            }
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
