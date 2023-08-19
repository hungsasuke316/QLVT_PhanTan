using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLVT
{
    public partial class frmPhieuNhap : Form
    {
        SqlConnection conn_publisher = new SqlConnection();
        int vitri = 0;
        bool dangThemMoi = false;
        bool contextDangThemMoi = false;
        public frmPhieuNhap()
        {
            InitializeComponent();
        }

        private void phieuNhapBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bds_PN.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void frmPhieuNhap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DS.CTDDH' table. You can move, or remove it, as needed.
            


            DS.EnforceConstraints = false;

            this.vattuTableAdapter.Connection.ConnectionString = Program.connstr;
            this.vattuTableAdapter.Fill(this.DS.Vattu);

            this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
            this.khoTableAdapter.Fill(this.DS.Kho);

            this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nhanVienTableAdapter.Fill(this.DS.NhanVien);

            this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.datHangTableAdapter.Fill(this.DS.DatHang);

            this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuNhapTableAdapter.Fill(this.DS.PhieuNhap);

            this.CTPNTableAdapter.Connection.ConnectionString = Program.connstr;
            this.CTPNTableAdapter.Fill(this.DS.CTPN);

            this.CTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.CTDDHTableAdapter.Fill(this.DS.CTDDH);


            panelNhapLieuPN.Enabled = panelNhapLieuCTPN.Enabled = false;


            cbbChiNhanh.DataSource = Program.bds_dspm; //sao chép bds_dspm đã load ở đăng nhập
            cbbChiNhanh.DisplayMember = "TENCN";
            cbbChiNhanh.ValueMember = "TENSERVER";
            cbbChiNhanh.SelectedIndex = Program.mChiNhanh;

            if (Program.mGroup == "CONGTY")
            {
                cbbChiNhanh.Enabled = true;
                btnThem.Enabled = btnXoa.Enabled = btnGhi.Enabled = btnHieuChinh.Enabled = btnPhucHoi.Enabled = false;
                btnReload.Enabled = btnThoat.Enabled = true;
                contextThem.Enabled = contextXoa.Enabled = false;
            }
            if (Program.mGroup == "CHINHANH" || Program.mGroup == "USER")
            {
                btnThem.Enabled = btnXoa.Enabled = btnGhi.Enabled = btnHieuChinh.Enabled = btnPhucHoi.Enabled = true;
                btnReload.Enabled = btnThoat.Enabled = true;
                cbbChiNhanh.Enabled = false;
                contextThem.Enabled = contextXoa.Enabled = true;
            }

        }

        
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bds_PN.Position;
            bds_PN.AddNew();
            dangThemMoi = true;

            txtMANV.Text = Program.username;
            txtHOTEN.Text = Program.mHoten;
            dtNGAY.DateTime = DateTime.Now;
            txtMANV.Enabled = txtMAKHO.Enabled = cmbTenKho.Enabled = dtNGAY.Enabled = txtHOTEN.Enabled = false;
            
                                   
            panelNhapLieuPN.Enabled = true;                       
            btnThem.Enabled = btnXoa.Enabled = btnHieuChinh.Enabled = btnReload.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            gc_PN.Enabled = gc_CTPN.Enabled = false;
            panelNhapLieuCTPN.Enabled = false;
            contextThem.Enabled = contextXoa.Enabled = false;
                       
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
                this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
                this.phieuNhapTableAdapter.Fill(this.DS.PhieuNhap);

                this.CTPNTableAdapter.Connection.ConnectionString = Program.connstr;
                this.CTPNTableAdapter.Fill(this.DS.CTPN);
                               
            }
        }

        private void cmbMaSoDDH_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txtDonGia_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bds_PN.Position;
                                    
            panelNhapLieuPN.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnHieuChinh.Enabled = btnReload.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            gc_PN.Enabled = gc_CTPN.Enabled = false;
            panelNhapLieuCTPN.Enabled = false;
            contextThem.Enabled = contextXoa.Enabled = false;

            //cmbMaSoDDH.Enabled   = false;
            //cmbMaSoDDH.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
            frmMain.Instance.btnPhieuXuat.Enabled = frmMain.Instance.btnDDH.Enabled = true;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.phieuNhapTableAdapter.Fill(this.DS.PhieuNhap);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void contextThem_Click(object sender, EventArgs e)
        {

            gc_CTPN.Focus();
            vitri = bds_CTPN.Position;
            bds_CTPN.AddNew();
            contextDangThemMoi = true;

            DataRowView drv = (DataRowView)bds_PN[bds_PN.Position];
            String maNhanVien = drv["MANV"].ToString();
            if (Program.username != maNhanVien)
            {
                MessageBox.Show("Bạn không thêm chi tiết phiếu nhập trên phiếu không phải do mình tạo", "Thông báo", MessageBoxButtons.OK);
                bds_CTPN.RemoveCurrent();
                return;
            }

            txtMAPN_CTPN.Text = ((DataRowView)bds_PN[bds_PN.Position])["MAPN"].ToString();

            panelNhapLieuCTPN.Enabled = true;
            gc_PN.Enabled = gc_CTPN.Enabled = panelNhapLieuPN.Enabled = false;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = false;
            txtMAPN_CTPN.Enabled = false;
            contextThem.Enabled = contextXoa.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
        }

        private void contextXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bds_PN.CancelEdit();
            bds_CTPN.CancelEdit();
            if (dangThemMoi == true)
            {
                bds_PN.RemoveCurrent();
                dangThemMoi = false;
                bds_PN.Position = vitri;
            }
            if (contextDangThemMoi == true)
            {

                bds_CTPN.RemoveCurrent();
                contextDangThemMoi = false;
                bds_CTPN.Position = vitri;

            }
            

            gc_PN.Enabled = gc_CTPN.Enabled = true;
            panelNhapLieuPN.Enabled = panelNhapLieuCTPN.Enabled = false;

            btnThem.Enabled = btnXoa.Enabled = btnHieuChinh.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
            contextThem.Enabled = contextXoa.Enabled = true;
        }

        

        private void cmbTenKho_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTenKho.SelectedIndex != -1)
            {
                txtMAKHO.Text = cmbTenKho.SelectedValue.ToString();
            }
        }

        private void cmbTenVT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTenVT.SelectedIndex != -1)
            {
                txtMAVT.Text = cmbTenVT.SelectedValue.ToString();
            }
        }

        private void btnChonDDH_Click(object sender, EventArgs e)
        {
            frmChonDonHang form = new frmChonDonHang();
            form.ShowDialog();

            txtMasoDDH.Text = Program.chonMasoDDH;
            txtMAKHO.Text = Program.chonMAKHO;
            cmbTenKho.Text = Program.chonTenKho;
        }

        private void txtMANV_EditValueChanged(object sender, EventArgs e)
        {
            DataRowView drv = ((DataRowView)(bds_PN.Current));
            string maNhanVien = drv["MANV"].ToString().Trim();
            if (!string.IsNullOrEmpty(maNhanVien))
            {                
                DataView nhanVienDataView = (DataView)bdsNV.List;
                nhanVienDataView.RowFilter = $"MANV = '{maNhanVien}'";

                if (nhanVienDataView.Count > 0)
                {

                    string ho = nhanVienDataView[0]["HO"].ToString();
                    string ten = nhanVienDataView[0]["TEN"].ToString();
                    string hoTen = ho + " " + ten;
                    txtHOTEN.Text = hoTen;

                }
                else
                {
                    MessageBox.Show("Không tìm thấy họ tên với mã nhân viên hiện tại", "Thông báo", MessageBoxButtons.OK);
                }
            }
                        
        }

        private bool kiemTraDuLieuDauVao()
        {
            if (dangThemMoi == true)
            {
                if (txtMAPN.Text == "")
                {
                    MessageBox.Show("Không thể bỏ trống mã phiếu nhập", "Thông báo", MessageBoxButtons.OK);
                    return false;
                }
                if (txtMAPN.Text.Length > 8)
                {
                    MessageBox.Show("Mã phiếu nhập không quá 8 kí tự", "Thông báo", MessageBoxButtons.OK);
                    return false;
                }
                
            }
            return true;
        }

        private void capNhatSoLuongVatTu(string maVT, int soLuong)
        {
            try
            {
                string cmd = "EXEC SP_CapNhatSoLuongNhapVatTu " + maVT + ", " + soLuong;
                Program.ExecSqlNonQuery(cmd);
                MessageBox.Show("Cập nhật số lượng vật tư thành công !", "Thông báo", MessageBoxButtons.OK);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi cập nhật số lượng vật tư. " + "\r\n" + ex.Message + "\r\n" + ex.Source);               
                return;
            }
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool ketQua = kiemTraDuLieuDauVao();
            if (ketQua == false)
            {
                return;
            }

            String cmd = "EXEC SP_KiemTra_MAPN " + txtMAPN.Text;

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

            int viTriConTro = bds_PN.Position;
            int viTriMAPN = bds_PN.Find("MAPN", txtMAPN.Text);

            if (result == 1 && viTriConTro != viTriMAPN)
            {
                MessageBox.Show("Mã phiếu nhập này đã tồn tại !", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if(dangThemMoi == true)
            {
                try
                {
                    bds_PN.EndEdit();
                    bds_PN.ResetCurrentItem();
                    dangThemMoi = false;

                    this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.phieuNhapTableAdapter.Update(this.DS.PhieuNhap);

                    this.CTPNTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.CTPNTableAdapter.Update(this.DS.CTPN);
                    MessageBox.Show("Ghi phiếu nhập thành công !", "Thông báo", MessageBoxButtons.OK);

                    gc_PN.Enabled = gc_CTPN.Enabled = true;
                    panelNhapLieuPN.Enabled = panelNhapLieuCTPN.Enabled = false;
                    btnThem.Enabled = btnXoa.Enabled = btnHieuChinh.Enabled = btnGhi.Enabled = btnReload.Enabled = btnThoat.Enabled = btnPhucHoi.Enabled = true;
                    
                    contextThem.Enabled = contextXoa.Enabled = true;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi Ghi phiếu nhập. " + "\r\n" + ex.Message + "\r\n" + ex.Source);
                    bds_PN.RemoveCurrent();
                    return;
                }
            }

            if (contextDangThemMoi == true)
            {
                try
                {
                    bds_CTPN.EndEdit();
                    //bds_CT_DDH.ResetCurrentItem();
                    contextDangThemMoi = false;

                    this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.phieuNhapTableAdapter.Update(this.DS.PhieuNhap);

                    this.CTPNTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.CTPNTableAdapter.Update(this.DS.CTPN);
                    MessageBox.Show("Ghi chi tiết phiếu nhập thành công !", "Thông báo", MessageBoxButtons.OK);

                    gc_PN.Enabled = gc_CTPN.Enabled = true;
                    panelNhapLieuPN.Enabled = panelNhapLieuCTPN.Enabled = false;
                    btnThem.Enabled = btnXoa.Enabled = btnHieuChinh.Enabled = btnGhi.Enabled = btnReload.Enabled = btnThoat.Enabled = btnPhucHoi.Enabled = true;
                    
                    contextThem.Enabled = contextXoa.Enabled = true;

                    capNhatSoLuongVatTu(txtMAVT.Text, int.Parse(txtSoLuong.Text));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi Ghi chi tiết phiếu nhập. " + "\r\n" + ex.Message + "\r\n" + ex.Source);
                    bds_CTPN.RemoveCurrent();
                    return;
                }
            }

            
        }

        private void txtMAKHO_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtHOTEN_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnChonCTDDH_Click(object sender, EventArgs e)
        {
            
            List<DataRowView> selectedRows = new List<DataRowView>();
            foreach (DataRowView drv in bds_CT_DDH)
            {
                if (drv["MasoDDH"].ToString() == txtMasoDDH.Text)
                {
                    selectedRows.Add(drv);
                }
            }

            // Tạo bảng dữ liệu mới với các dòng tương ứng
            DataTable selectedDataTable = ((DataView)bds_CT_DDH.List).Table.Clone();
            foreach (DataRowView drv in selectedRows)
            {
                selectedDataTable.ImportRow(drv.Row);
            }

            frmChonCTDDH frm = new frmChonCTDDH(selectedDataTable);
            

            // Hiển thị form
            frm.ShowDialog();
            txtSoLuong.Text = Program.chonSoLuong;
            txtDonGia.Text = Program.chonDonGia;
            cmbTenVT.Text = Program.chonTenVT;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bds_CTPN.Count > 0)
            {
                MessageBox.Show("Không thể xóa phiếu nhập này vì có chi tiết phiếu nhập", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có thật sự muốn xóa phiếu nhập này không ?? ", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {

                    vitri = bds_PN.Position;
                    bds_PN.RemoveCurrent();


                    this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.phieuNhapTableAdapter.Update(this.DS.PhieuNhap);

                    this.CTPNTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.CTPNTableAdapter.Update(this.DS.CTPN);

                    MessageBox.Show("Xóa thành công ", "Thông báo", MessageBoxButtons.OK);

                }
                catch (Exception ex)
                {

                    MessageBox.Show("Lỗi xóa phiếu nhập. Lỗi: \n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                    this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.phieuNhapTableAdapter.Update(this.DS.PhieuNhap);

                    this.CTPNTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.CTPNTableAdapter.Update(this.DS.CTPN);

                    bds_PN.Position = vitri;

                    return;
                }
            }
            if (bds_PN.Count == 0) btnXoa.Enabled = false;
        }
    }
}
