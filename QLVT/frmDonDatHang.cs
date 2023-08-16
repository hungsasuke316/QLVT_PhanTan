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
    public partial class frmDonDatHang : Form
    {
        SqlConnection conn_publisher = new SqlConnection();
        int vitri = 0;
        bool dangThemMoi = false;
        bool contextDangThemMoi = false;
        
        public frmDonDatHang()
        {
            InitializeComponent();
        }

        private void datHangBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bds_DDH.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private int KetNoi_CSDLGOC()
        {
            if (conn_publisher != null && conn_publisher.State == ConnectionState.Open)
                conn_publisher.Close();
            try
            {
                conn_publisher.ConnectionString = Program.connstr;
                conn_publisher.Open();
                return 1;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối về CSDL gốc. \nBạn xem lại tên server của publisher, và tên CSDL trong chuỗi kết nối. \n" + e.Message, "", MessageBoxButtons.OK);
                return 0;
            }

        }

        private void frmDonDatHang_Load(object sender, EventArgs e)
        {
                        
            DS.EnforceConstraints = false;

            this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nhanVienTableAdapter.Fill(this.DS.NhanVien);

            this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.datHangTableAdapter.Fill(this.DS.DatHang);

            this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuNhapTableAdapter.Fill(this.DS.PhieuNhap);

            this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
            this.khoTableAdapter.Fill(this.DS.Kho);

            this.vattuTableAdapter.Connection.ConnectionString = Program.connstr;
            this.vattuTableAdapter.Fill(this.DS.Vattu);

            this.CTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.CTDDHTableAdapter.Fill(this.DS.CTDDH);

           
            panelNhapDDH.Enabled = panelNhapCTDH.Enabled = false;

            
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

        private void datHangGridControl_Click(object sender, EventArgs e)
        {

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
                this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
                this.datHangTableAdapter.Fill(this.DS.DatHang);
                
                this.CTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
                this.CTDDHTableAdapter.Fill(this.DS.CTDDH);

                this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
                this.phieuNhapTableAdapter.Fill(this.DS.PhieuNhap);
                
            }
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.datHangTableAdapter.Fill(this.DS.DatHang);
                
                this.CTDDHTableAdapter.Fill(this.DS.CTDDH);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
            frmMain.Instance.btnPhieuNhap.Enabled = frmMain.Instance.btnPhieuXuat.Enabled = true;
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bds_DDH.CancelEdit();
            bds_CT_DDH.CancelEdit();
            if (dangThemMoi == true)
            {
                if (bds_DDH.Current != null)
                {
                    bds_DDH.RemoveCurrent();
                }
                
                dangThemMoi = false;
                bds_DDH.Position = vitri;

            }
            if (contextDangThemMoi == true)
            {
                if (bds_CT_DDH.Current != null)
                {
                    //bds_CT_DDH.RemoveCurrent();                    
                }
                contextDangThemMoi = false;
                bds_CT_DDH.Position = vitri;
            }
            
            gcDonDatHang.Enabled = gcCT_DDH.Enabled = true;
            panelNhapDDH.Enabled = panelNhapCTDH.Enabled = false;

            btnThem.Enabled = btnXoa.Enabled = btnHieuChinh.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
            contextThem.Enabled = contextXoa.Enabled = true;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
                        
            vitri = bds_DDH.Position;
            panelNhapDDH.Enabled = true;
            bds_DDH.AddNew();

            dangThemMoi = true;

            deNGAY.DateTime = DateTime.Now;
                                    
            btnThem.Enabled = btnXoa.Enabled = btnHieuChinh.Enabled = btnReload.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            gcDonDatHang.Enabled = gcCT_DDH.Enabled = false;
            panelNhapCTDH.Enabled = false;
            contextThem.Enabled = contextXoa.Enabled = false;

            txtMANV.Text = Program.username;
            //cmbKho.DropDownStyle = ComboBoxStyle.DropDownList;
            //cmbMANV.Enabled = false;            
                      
        }

        private void btnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            vitri = bds_DDH.Position;
            panelNhapDDH.Enabled = true;

            btnThem.Enabled = btnXoa.Enabled = btnHieuChinh.Enabled = btnReload.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            gcDonDatHang.Enabled = gcCT_DDH.Enabled = false;
            panelNhapCTDH.Enabled = false;
            contextThem.Enabled = contextXoa.Enabled = false;

            //cmbKho.Enabled = false;
            //cmbMANV.Enabled = false;            

        }

        private bool kiemTraDuLieuDauVao()
        {
            if (dangThemMoi == true)
            {
                if (txtMaSoDDH.Text == "")
                {
                    MessageBox.Show("Không thể bỏ trống mã đơn hàng", "Thông báo", MessageBoxButtons.OK);
                    return false;
                }
                if (txtMaSoDDH.Text.Length > 8)
                {
                    MessageBox.Show("Mã đơn đặt hàng không quá 8 kí tự", "Thông báo", MessageBoxButtons.OK);
                    return false;
                }
                if (txtMANV.Text == "")
                {
                    MessageBox.Show("Không thể bỏ trống mã nhân viên", "Thông báo", MessageBoxButtons.OK);
                    return false;
                }
                if (txtNhaCC.Text == "")
                {
                    MessageBox.Show("Không thể bỏ trống nhà cung cấp", "Thông báo", MessageBoxButtons.OK);
                    return false;
                }
                if (txtNhaCC.Text.Length > 100)
                {
                    MessageBox.Show("Tên nhà cung cấp không quá 100 kí tự", "Thông báo", MessageBoxButtons.OK);
                    return false;
                }
                if (txtMAKHO.Text == "")
                {
                    MessageBox.Show("Không thể bỏ trống kho", "Thông báo", MessageBoxButtons.OK);
                    return false;
                }
            }
            if (contextDangThemMoi == true)
            {
                if (txtSoLuong.Text == "")
                {
                    MessageBox.Show("Không thể bỏ trống số lượng", "Thông báo", MessageBoxButtons.OK);
                    return false;
                }

                if (txtDonGia.Text == "")
                {
                    MessageBox.Show("Không thể bỏ trống đơn giá", "Thông báo", MessageBoxButtons.OK);
                    return false;
                }
                if (txtMAVT.Text == "")
                {
                    MessageBox.Show("Không thể bỏ trống vật tư", "Thông báo", MessageBoxButtons.OK);
                    return false;
                }
                foreach (DataRowView rowView in bds_CT_DDH)
                {
                    DataRow row = rowView.Row;
                    string mavt = row["MAVT"].ToString();

                    if (mavt == txtMAVT.Text)
                    {
                        MessageBox.Show($"Vật tư mã {txtMAVT.Text} đã có trong chi tiết đơn đặt hàng.");
                        return false;
                    }
                }

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

            if(dangThemMoi == true)
            {
                String cmd = "EXEC SP_KiemTra_MaSoDDH " + txtMaSoDDH.Text;

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

                int viTriConTro = bds_DDH.Position;
                int viTriMADDH = bds_DDH.Find("MasoDDH", txtMaSoDDH.Text);

                if (result == 1 && viTriConTro != viTriMADDH)
                {
                    MessageBox.Show("Mã số đơn đặt hàng này đã được sử dụng !", "Thông báo", MessageBoxButtons.OK);
                    return;
                }

                try
                {
                    bds_DDH.EndEdit();
                    bds_DDH.ResetCurrentItem();
                    dangThemMoi = false;

                    this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.datHangTableAdapter.Update(this.DS.DatHang);
                                        
                    MessageBox.Show("Ghi đơn đặt hàng thành công !", "Thông báo", MessageBoxButtons.OK);

                    gcDonDatHang.Enabled = gcCT_DDH.Enabled = true;
                    panelNhapDDH.Enabled = panelNhapCTDH.Enabled = false;
                    btnThem.Enabled = btnXoa.Enabled = btnHieuChinh.Enabled = btnGhi.Enabled = btnReload.Enabled = btnThoat.Enabled = btnPhucHoi.Enabled = true;
                    
                    //cmbMANV.Enabled = false;
                    contextThem.Enabled = contextXoa.Enabled = true;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi Ghi đơn đặt hàng. " + "\r\n" + ex.Message + "\r\n" + ex.Source);
                    return;
                }

            }

            if (contextDangThemMoi == true)
            {
                
                try
                {
                    
                    bds_CT_DDH.EndEdit();
                    //bds_CT_DDH.ResetCurrentItem();
                    contextDangThemMoi = false;

                    this.CTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.CTDDHTableAdapter.Update(this.DS.CTDDH);
                    MessageBox.Show("Ghi chi tiết đơn đặt hàng thành công !", "Thông báo", MessageBoxButtons.OK);

                    gcDonDatHang.Enabled = gcCT_DDH.Enabled = true;
                    panelNhapDDH.Enabled = panelNhapCTDH.Enabled = false;
                    btnThem.Enabled = btnXoa.Enabled = btnHieuChinh.Enabled = btnGhi.Enabled = btnReload.Enabled = btnThoat.Enabled = btnPhucHoi.Enabled = true;
                    
                    //cmbMANV.Enabled = false;
                    contextThem.Enabled = contextXoa.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi Ghi chi tiết đơn đặt hàng. " + "\r\n" + ex.Message + "\r\n" + ex.Source);
                    return;
                }
            }
                                    
        }

        private void txtMANV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bds_CT_DDH.Count > 0)
            {
                MessageBox.Show("Không thể xóa đơn đặt hàng này vì có chi tiết đơn đặt hàng", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (bds_PN.Count > 0)
            {
                MessageBox.Show("Không thể xóa đơn đặt hàng này vì có phiếu nhập", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có thật sự muốn xóa đơn đặt hàng này không ?? ", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    
                    vitri = bds_DDH.Position;
                    bds_DDH.RemoveCurrent();


                    this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.datHangTableAdapter.Update(this.DS.DatHang);

                    this.CTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.CTDDHTableAdapter.Update(this.DS.CTDDH);
                                        
                    MessageBox.Show("Xóa thành công ", "Thông báo", MessageBoxButtons.OK);
                    
                }
                catch (Exception ex)
                {
                    
                    MessageBox.Show("Lỗi xóa đơn đặt hàng. Lỗi: \n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                    this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.datHangTableAdapter.Update(this.DS.DatHang);

                    this.CTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.CTDDHTableAdapter.Update(this.DS.CTDDH);
                    
                    bds_DDH.Position = vitri;
                    
                    return;
                }
            }
            if (bds_DDH.Count == 0) btnXoa.Enabled = false;
        }

        private void contextThem_Click(object sender, EventArgs e)
        {
            
            vitri = bds_CT_DDH.Position;
            panelNhapCTDH.Enabled = true;
            bds_CT_DDH.AddNew();
            contextDangThemMoi = true;
            
            DataRowView drv = (DataRowView)bds_DDH[bds_DDH.Position];
            String maNhanVien = drv["MANV"].ToString();
            if (Program.username != maNhanVien)
            {
                MessageBox.Show("Bạn không thêm chi tiết đơn hàng trên phiếu không phải do mình tạo", "Thông báo", MessageBoxButtons.OK);
                bds_CT_DDH.RemoveCurrent();
                return;
            }

            txtMaSoDDH_CTDDH.Text = ((DataRowView)bds_DDH[bds_DDH.Position])["MasoDDH"].ToString();

            
            gcDonDatHang.Enabled = gcCT_DDH.Enabled = panelNhapDDH.Enabled = false;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = false;
            txtMaSoDDH_CTDDH.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            contextThem.Enabled = contextXoa.Enabled = false;
            //cmbVatTu.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void contextXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn xóa chi tiết đơn đặt hàng này không ?? ", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                
                    try
                    {

                        vitri = bds_CT_DDH.Position;
                        bds_CT_DDH.RemoveCurrent();


                        this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.datHangTableAdapter.Update(this.DS.DatHang);

                        this.CTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.CTDDHTableAdapter.Update(this.DS.CTDDH);

                        MessageBox.Show("Xóa thành công ", "Thông báo", MessageBoxButtons.OK);

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Lỗi xóa chi tiết đơn đặt hàng. Lỗi: \n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                        this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.datHangTableAdapter.Update(this.DS.DatHang);

                        this.CTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.CTDDHTableAdapter.Update(this.DS.CTDDH);

                        bds_DDH.Position = vitri;

                        return;
                    }
                
            }
            if (bds_CT_DDH.Count == 0) contextXoa.Enabled = false;

        }

        private void txtDonGia_EditValueChanged(object sender, EventArgs e)
        {

        }
       

        private void txtNhaCC_EditValueChanged(object sender, EventArgs e)
        {

        }

               

        private void mANVLabel_Click(object sender, EventArgs e)
        {

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

        private void txtMAVT_EditValueChanged(object sender, EventArgs e)
        {
           
        }

        private void txtMANV_EditValueChanged(object sender, EventArgs e)
        {
            DataRowView drv = ((DataRowView)(bds_DDH.Current));
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
                    return;
                }
            }
        }
    }
}
