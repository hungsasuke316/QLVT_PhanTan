using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLVT
{
    public partial class frmNhanVien : Form
    {
        int vitri = 0;
        string macn = "";
        bool dangThemMoi = false;
        public frmNhanVien()
        {
            InitializeComponent();
        }
        


        private void nhanVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsNV.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            
            this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nhanVienTableAdapter.Fill(this.DS.NhanVien);

            this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuXuatTableAdapter.Fill(this.DS.PhieuXuat);

            this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.datHangTableAdapter.Fill(this.DS.DatHang);

            this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuNhapTableAdapter.Fill(this.DS.PhieuNhap);

            if (bdsNV.Count > 0)
            {
                macn = ((DataRowView)bdsNV[0])["MACN"].ToString();
                cbbChiNhanh.DataSource = Program.bds_dspm; //sao chép bds_dspm đã load ở đăng nhập
                cbbChiNhanh.DisplayMember = "TENCN";
                cbbChiNhanh.ValueMember = "TENSERVER";
                cbbChiNhanh.SelectedIndex = Program.mChiNhanh;
                if (Program.mGroup == "CONGTY")
                {
                    cbbChiNhanh.Enabled = true;
                    btnThem.Enabled = btnXoa.Enabled = btnGhi.Enabled = btnHieuChinh.Enabled = btnPhucHoi.Enabled = false;
                }
                if (Program.mGroup == "CHINHANH" || Program.mGroup == "USER")
                {
                    btnThem.Enabled = btnXoa.Enabled = btnGhi.Enabled = btnHieuChinh.Enabled = btnPhucHoi.Enabled = btnChuyenChiNhanh.Enabled = btnReload.Enabled = true;
                    
                    cbbChiNhanh.Enabled = false;
                }
            }
            else
            {
                cbbChiNhanh.DataSource = Program.bds_dspm; //sao chép bds_dspm đã load ở đăng nhập
                cbbChiNhanh.DisplayMember = "TENCN";
                cbbChiNhanh.ValueMember = "TENSERVER";
                cbbChiNhanh.SelectedIndex = Program.mChiNhanh;

                string selectedValue = cbbChiNhanh.SelectedValue.ToString();
                if (selectedValue == "DESKTOP-JJGC4CI\\SERVER1")
                {
                    macn = "CN1";
                }
                if (selectedValue == "DESKTOP-JJGC4CI\\SERVER2")
                {
                    macn = "CN2";
                }

                if (Program.mGroup == "CONGTY")
                {
                    cbbChiNhanh.Enabled = true;
                    btnThem.Enabled = btnXoa.Enabled = btnGhi.Enabled = btnHieuChinh.Enabled = btnPhucHoi.Enabled = false;
                    btnChuyenChiNhanh.Enabled = true;
                }
                if (Program.mGroup == "CHINHANH" || Program.mGroup == "USER")
                {
                    btnThem.Enabled = btnXoa.Enabled = btnGhi.Enabled = btnHieuChinh.Enabled = btnPhucHoi.Enabled = btnChuyenChiNhanh.Enabled = btnReload.Enabled = true;

                    cbbChiNhanh.Enabled = false;
                }
            }    
                        
        }

        private void dIACHITextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsNV.Position;
            dangThemMoi = true;

            panelNhapLieuNV.Enabled = true;
            bdsNV.AddNew();
            txtChiNhanh.Text = macn;
            dtNGAYSINH.EditValue = "";
            cbTrangThaiXoa.Checked = false;
            cbTrangThaiXoa.Enabled = false;

            btnThem.Enabled = btnXoa.Enabled = btnHieuChinh.Enabled = btnReload.Enabled = btnThoat.Enabled = btnChuyenChiNhanh.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            gcNhanVien.Enabled = false;

        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsNV.CancelEdit();
            if (dangThemMoi == true)
            {                
                bdsNV.RemoveCurrent();                
                dangThemMoi = false;
            }
            bdsNV.Position = vitri;

            gcNhanVien.Enabled = true;
            panelNhapLieuNV.Enabled = false;
            cbTrangThaiXoa.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnHieuChinh.Enabled = btnReload.Enabled = btnThoat.Enabled = btnChuyenChiNhanh.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
        }

        private void gcNhanVien_Click(object sender, EventArgs e)
        {

        }

        private void btnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsNV.Position;
            bool trangThaiXoa = (bool)((DataRowView)bdsNV[vitri])["TrangThaiXoa"];
            if (trangThaiXoa == true)
            {
                MessageBox.Show("Nhân viên này không có ở chi nhánh này. Không thể hiệu chỉnh.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            panelNhapLieuNV.Enabled = true;
            txtMANV.Enabled = false;
            cbTrangThaiXoa.Enabled = false;

            btnThem.Enabled = btnXoa.Enabled = btnHieuChinh.Enabled = btnReload.Enabled = btnThoat.Enabled = btnChuyenChiNhanh.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            gcNhanVien.Enabled = false;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.nhanVienTableAdapter.Fill(this.DS.NhanVien);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private static int CalculateAge(DateTime dateOfBirth)
        {
            int age = 0;
            age = DateTime.Now.Year - dateOfBirth.Year;
            if (DateTime.Now.DayOfYear < dateOfBirth.DayOfYear)
                age = age - 1;

            return age;
        }

        private bool kiemTraDuLieuDauVao()
        {
            /*kiem tra txtMANV*/
            if (txtMANV.Text == "")
            {
                MessageBox.Show("Không bỏ trống mã nhân viên", "Thông báo", MessageBoxButtons.OK);
                txtMANV.Focus();
                return false;
            }

            if (Regex.IsMatch(txtMANV.Text, @"^[a-zA-Z0-9]+$") == false)
            {
                MessageBox.Show("Mã nhân viên chỉ chấp nhận số", "Thông báo", MessageBoxButtons.OK);
                txtMANV.Focus();
                return false;
            }
            /*kiem tra txtHO*/
            if (txtHO.Text == "")
            {
                MessageBox.Show("Không bỏ trống họ và tên", "Thông báo", MessageBoxButtons.OK);
                txtHO.Focus();
                return false;
            }
            //"^[0-9A-Za-z ]+$"
            //if (Regex.IsMatch(txtHO.Text, @"^[A-Za-z ]+$") == true)
            //{
            //    MessageBox.Show("Họ của người chỉ có chữ cái và khoảng trắng", "Thông báo", MessageBoxButtons.OK);
            //    txtHO.Focus();
            //    return false;
            //}
            if (txtHO.Text.Length > 40)
            {
                MessageBox.Show("Họ không thể lớn hơn 40 kí tự", "Thông báo", MessageBoxButtons.OK);
                txtHO.Focus();
                return false;
            }
            /*kiem tra txtTEN*/
            if (txtTEN.Text == "")
            {
                MessageBox.Show("Không bỏ trống họ và tên", "Thông báo", MessageBoxButtons.OK);
                txtTEN.Focus();
                return false;
            }

            //if (Regex.IsMatch(txtTEN.Text, @"^[a-zA-Z ]+$") == true)
            //{
            //    MessageBox.Show("Tên người chỉ có chữ cái và khoảng trắng", "Thông báo", MessageBoxButtons.OK);
            //    txtTEN.Focus();
            //    return false;
            //}

            if (txtTEN.Text.Length > 10)
            {
                MessageBox.Show("Tên không thể lớn hơn 10 kí tự", "Thông báo", MessageBoxButtons.OK);
                txtTEN.Focus();
                return false;
            }
            if (txtSOCMND.Text == "")
            {
                MessageBox.Show("CMND không được bỏ trống", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            if (txtSOCMND.Text.Length > 20)
            {
                MessageBox.Show("CMND không quá 20 kí tự", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            /*kiem tra txtDIACHI*/
            if (txtDIACHI.Text == "")
            {
                MessageBox.Show("Không bỏ trống địa chỉ", "Thông báo", MessageBoxButtons.OK);
                txtDIACHI.Focus();
                return false;
            }

            //if (Regex.IsMatch(txtDIACHI.Text, @"^[a-zA-Z0-9, ]+$") == true)
            //{
            //    MessageBox.Show("Địa chỉ chỉ chấp nhận chữ cái, số và khoảng trắng", "Thông báo", MessageBoxButtons.OK);
            //    txtDIACHI.Focus();
            //    return false;
            //}

            if (txtDIACHI.Text.Length > 100)
            {
                MessageBox.Show("Không bỏ trống địa chỉ", "Thông báo", MessageBoxButtons.OK);
                txtDIACHI.Focus();
                return false;
            }
            if (dtNGAYSINH.Text == "")
            {
                MessageBox.Show("Ngày sinh không được bỏ trống", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            
            if (CalculateAge(dtNGAYSINH.DateTime) < 18)
            {
                MessageBox.Show("Nhân viên chưa đủ 18 tuổi", "Thông báo", MessageBoxButtons.OK);
                dtNGAYSINH.Focus();
                return false;
            }

            if (!float.TryParse(txtLUONG.Text, out float luong) || luong < 4000000)
            {
                MessageBox.Show("Mức lương không thể bỏ trống và phải lớn hơn hoặc bằng 4,000,000 đồng.", "Thông báo", MessageBoxButtons.OK);
                txtLUONG.Focus();
                return false;
            }
            return true;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool ketQua = kiemTraDuLieuDauVao();
            if (ketQua == false)
            {
                return;
            }

            String cmd = "EXEC SP_TraCuu_KiemTra_MANV " + txtMANV.Text;


            //SqlCommand sqlCommand = new SqlCommand(kiemTraMANV, Program.conn);
            try
            {
                Program.myReader = Program.ExecSqlDataReader(cmd);
                
                if (Program.myReader == null)
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thực thi database thất bại!\n\n" + ex.Message, "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);                
                return;
            }
            Program.myReader.Read();
            int result = int.Parse(Program.myReader.GetValue(0).ToString());
            Program.myReader.Close();

            int viTriConTro = bdsNV.Position;
            int viTriMANV = bdsNV.Find("MANV", txtMANV.Text);

            if (result == 1 && viTriConTro != viTriMANV)
            {
                MessageBox.Show("Mã nhân viên này đã được sử dụng !", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            try
            {
                bdsNV.EndEdit();
                bdsNV.ResetCurrentItem();
                this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                this.nhanVienTableAdapter.Update(this.DS.NhanVien);                            
                MessageBox.Show("Ghi nhân viên thành công !", "Thông báo", MessageBoxButtons.OK);
                gcNhanVien.Enabled = true;
                panelNhapLieuNV.Enabled = false;
                btnThem.Enabled = btnXoa.Enabled = btnHieuChinh.Enabled = btnGhi.Enabled = btnReload.Enabled = btnThoat.Enabled = btnChuyenChiNhanh.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Ghi nhân viên. " + "\r\n" + ex.Message + "\r\n" + ex.Source);
                return;
            }

        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            Int32 manv = 0;
            String tenNV = ((DataRowView)bdsNV[bdsNV.Position])["MANV"].ToString();
            
            if (tenNV == Program.username)
            {
                MessageBox.Show("Không thể xóa chính tài khoản đang đăng nhập", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (bdsPX.Count > 0)
            {
                MessageBox.Show("Không thể xóa nhân viên này vì đã lập phiếu xuất", "", MessageBoxButtons.OK);
                return;
            }
            if (bdsDH.Count > 0)
            {
                MessageBox.Show("Không thể xóa nhân viên này vì đã lập đơn đặt hàng", "", MessageBoxButtons.OK);
                return;
            }
            if (bdsPN.Count > 0)
            {
                MessageBox.Show("Không thể xóa nhân viên này vì đã lập phiệu nhập", "", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có thật sự muốn xóa nhân viên này không ?? ", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    manv = int.Parse(((DataRowView)bdsNV[bdsNV.Position])["MANV"].ToString());
                    bdsNV.RemoveCurrent();
                    this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.nhanVienTableAdapter.Update(this.DS.NhanVien);
                    MessageBox.Show("Xóa thành công ", "Thông báo", MessageBoxButtons.OK);
                    btnThem.Enabled = btnXoa.Enabled = btnHieuChinh.Enabled = btnReload.Enabled = btnThoat.Enabled = btnChuyenChiNhanh.Enabled = true;
                    btnGhi.Enabled = btnPhucHoi.Enabled = true;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa nhân viên. Lỗi: " + ex.Message, "", MessageBoxButtons.OK);
                    this.nhanVienTableAdapter.Fill(this.DS.NhanVien);
                    bdsNV.Position = bdsNV.Find("MANV", manv);
                    
                    return;
                }
            }
            if (bdsNV.Count == 0) btnXoa.Enabled = false;

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
                /*Do du lieu tu dataSet vao grid Control*/
                this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                this.nhanVienTableAdapter.Fill(this.DS.NhanVien);

                this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
                this.datHangTableAdapter.Fill(this.DS.DatHang);

                this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
                this.phieuNhapTableAdapter.Fill(this.DS.PhieuNhap);

                this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
                this.phieuXuatTableAdapter.Fill(this.DS.PhieuXuat);
                
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
            frmMain.Instance.btnKho.Enabled = frmMain.Instance.btnVatTu.Enabled = true;

        }

        private void btnChuyenChiNhanh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String maChiNhanhMoi = "";
            int viTriHienTai = bdsNV.Position;
            bool trangThaiXoa = (bool)((DataRowView)bdsNV[viTriHienTai])["TrangThaiXoa"];
            string maNhanVien = ((DataRowView)(bdsNV[viTriHienTai]))["MANV"].ToString().Trim();
            string maChiNhanhCu = ((DataRowView)(bdsNV[viTriHienTai]))["MACN"].ToString().Trim();

            DialogResult dialogResult = MessageBox.Show("Bạn có muốn chuyển nhân viên này đi ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.OK)
            {
                if (maNhanVien == Program.username)
                {
                    MessageBox.Show("Không thể chuyển chính người đang đăng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (trangThaiXoa == true)
                {
                    MessageBox.Show("Nhân viên này không có ở chi nhánh này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (maChiNhanhCu == "CN1")
                {
                    maChiNhanhMoi = "CN2";
                }
                if (maChiNhanhCu == "CN2")
                {
                    maChiNhanhMoi = "CN1";
                }

                String cmd = "EXEC SP_ChuyenChiNhanh " + maNhanVien + ",'" + maChiNhanhMoi + "'";

                try
                {
                    Program.myReader = Program.ExecSqlDataReader(cmd);
                    if (Program.myReader == null)
                    {
                        return;/*khong co ket qua tra ve thi ket thuc luon*/
                    }
                    MessageBox.Show("Chuyển chi nhánh thành công", "thông báo", MessageBoxButtons.OK);
                    this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.nhanVienTableAdapter.Fill(this.DS.NhanVien);
                    bdsNV.Position = viTriHienTai;
                    

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thực thi database thất bại!\n\n" + ex.Message, "thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Console.WriteLine(ex.Message);
                    return;
                }
                Program.myReader.Close();
                this.nhanVienTableAdapter.Update(this.DS.NhanVien);
            }
                   
        }

        private void hOLabel_Click(object sender, EventArgs e)
        {

        }

        private void txtHO_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
