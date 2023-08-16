using System;
using System.Windows.Forms;

namespace QLVT
{
    public partial class frmTaoTaiKhoan : Form
    {
        public frmTaoTaiKhoan()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMain.Instance.btnDangXuat.Enabled = true;
        }

        
        private void frmTaoTaiKhoan_Load(object sender, EventArgs e)
        {
            if (Program.mGroup == "CONGTY")
            {
                lblvaiTro.Enabled = false;
                radioCHINHANH.Enabled = false;
                radioUSER.Enabled = false;
            }
            
        }

        private bool kiemTraDuLieuDauVao()
        {
            if (txtMANV.Text == "")
            {
                MessageBox.Show("Thiếu mã nhân viên", "Thông báo", MessageBoxButtons.OK);
                return false;
            }

            if (txtPassword.Text == "")
            {
                MessageBox.Show("Thiếu mật khẩu", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
           
            return true;
        }

        private void btnChonNV_Click(object sender, EventArgs e)
        {
            frmChonNhanVien form = new frmChonNhanVien();
            form.ShowDialog();

            txtMANV.Text = Program.chonMANV;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            bool ketQua = kiemTraDuLieuDauVao();
            if (ketQua == false) return;

            String tenTaiKhoan = Program.chonHOTEN;
            String matKhau = txtPassword.Text;
            String MANV = Program.chonMANV;
            String vaiTro = (radioCHINHANH.Checked == true) ? "CHINHANH" : "USER";
            if (Program.mGroup == "CONGTY")
            {
                vaiTro = "CONGTY";
            }

            
                       
            String cmd = "EXEC SP_TAOLOGIN '" + tenTaiKhoan + "' , '" + matKhau + "', '" + MANV + "', '" + vaiTro + "'";
            
            //String cmd = "EXEC SP_TAOLOGIN 'PhamDanh' , '123', '10', 'USER'";

            Console.WriteLine(Program.myReader);
            try
            {


                Program.myReader = Program.ExecSqlDataReader(cmd);
                
                if (Program.myReader == null)
                {
                    return;
                }
                Program.myReader.Read();
                MessageBox.Show("Đăng kí tài khoản thành công!\n\n Mã Nhân Viên: " + MANV + "\nTài khoản: " + tenTaiKhoan + "\nMật khẩu: " + matKhau + "\n Vai Trò: " + vaiTro, "Thông Báo", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đăng ký thất bại! Lỗi: \n\n" + ex.Message, "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
                return;
            }
        }
    }
}
