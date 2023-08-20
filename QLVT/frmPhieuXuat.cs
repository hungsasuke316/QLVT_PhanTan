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
    public partial class frmPhieuXuat : Form
    {
        SqlConnection conn_publisher = new SqlConnection();
        int vitri = 0;
        public frmPhieuXuat()
        {
            InitializeComponent();
        }

        private void cbbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbChiNhanh.SelectedValue.ToString() == "System.Data.DataRowView")
                return;

            Program.servername = cbChiNhanh.SelectedValue.ToString();
            Program.loginCurrent = Program.mlogin;
            Program.passwordCurrent = Program.password;


            if (cbChiNhanh.SelectedIndex != Program.mChiNhanh)
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
                this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
                this.phieuXuatTableAdapter.Fill(this.DS.PhieuXuat);

                this.CTPXTableAdapter.Connection.ConnectionString = Program.connstr;
                this.CTPXTableAdapter.Fill(this.DS.CTPX);

            }
        }

        private void phieuXuatBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsPhieuXuat.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void frmPhieuXuat_Load(object sender, EventArgs e)
        {
            
            DS.EnforceConstraints = false;

            // TODO: This line of code loads data into the 'dS.PhieuXuat' table. You can move, or remove it, as needed.
            this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuXuatTableAdapter.Fill(this.DS.PhieuXuat);

            // TODO: This line of code loads data into the 'dS.CTPX' table. You can move, or remove it, as needed.
            this.CTPXTableAdapter.Connection.ConnectionString = Program.connstr;
            this.CTPXTableAdapter.Fill(this.DS.CTPX);

            // TODO: This line of code loads data into the 'DS.Kho' table. You can move, or remove it, as needed.
            this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
            this.khoTableAdapter.Fill(this.DS.Kho);

            // TODO: This line of code loads data into the 'DS.Vattu' table. You can move, or remove it, as needed.
            this.vattuTableAdapter.Connection.ConnectionString = Program.connstr;
            this.vattuTableAdapter.Fill(this.DS.Vattu);

            cbChiNhanh.DataSource = Program.bds_dspm;
            cbChiNhanh.DisplayMember = "TENCN";
            cbChiNhanh.ValueMember = "TENSERVER";
            cbChiNhanh.SelectedIndex = Program.mChiNhanh;

            if ("CONGTY" == Program.mGroup)
            {
                cbChiNhanh.Enabled = true;
                btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = false;
                gcCTPX.Enabled = true;
            }
            else
            {
                cbChiNhanh.Enabled = false;
                btnThem.Enabled = btnHieuChinh.Enabled = true;
                gcCTPX.Enabled = false;
                if (bdsPhieuXuat.Count == 0) btnXoa.Enabled = false;
            }

            // Vì chưa thực thi nên không cần Ghi hay Phục hồi
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
            
            pcInputPX.Enabled = pcCTPX.Enabled = false;
            btnContextThem.Enabled = btnContextXoa.Enabled = false;

        }

        private int KetNoi_CSDLGOC()
        {
            if (conn_publisher != null && conn_publisher.State == ConnectionState.Open)
                conn_publisher.Close();
            try
            {
                conn_publisher.ConnectionString = Program.connstr_publisher;
                conn_publisher.Open();
                return 1;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối về CSDL gốc. \nBạn xem lại tên server của publisher, và tên CSDL trong chuỗi kết nối. \n" + e.Message, "", MessageBoxButtons.OK);
                return 0;
            }

        }

        private void mANVTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtMaNV.Text))
            {
                try
                {
                    String cmd = "EXEC sp_HoTenNV " + txtMaNV.Text;
                    Program.myReader = Program.ExecSqlDataReader(cmd);

                    if (Program.myReader == null) return;

                    Program.myReader.Read();
                    string hoTenNv = Program.myReader.GetValue(0).ToString();
                    txtHoTenNV.Text = hoTenNv;
                    Program.myReader.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thực thi database thất bại!\n\n" + ex.Message, "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                txtHoTenNV.Text = string.Empty;
            }

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsPhieuXuat.Position;
            pcInputPX.Enabled = true;
            txtMaPX.Enabled = true;
            bdsPhieuXuat.AddNew();

            txtMaPX.Focus();
            txtMaNV.Text = Program.username;
            cbKho.SelectedIndex = 1;

            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            btnContextThem.Enabled = btnContextXoa.Enabled = false;
            gcPhieuXuat.Enabled = false;
            gcCTPX.Enabled = true;
        }

        private void btnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsPhieuXuat.Position;
            pcInputPX.Enabled = true;
            txtMaPX.Enabled = false;

            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            btnContextThem.Enabled = btnContextXoa.Enabled = true;
            gcPhieuXuat.Enabled = false;
            gcCTPX.Enabled = true;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (pcInputPX.Enabled)
            {
                if (!checkInputPX()) return;

                // trường hợp thêm mới
                if (txtMaPX.Enabled)
                {
                    try
                    {
                        String cmd = "declare @result int exec @result = sp_KiemTraMaPhieuXuat " + txtMaPX.Text + " select @result";
                        Program.myReader = Program.ExecSqlDataReader(cmd);

                        if (Program.myReader == null) return;

                        Program.myReader.Read();
                        int result = int.Parse(Program.myReader.GetValue(0).ToString());

                        Program.myReader.Close();

                        if (result > 0)
                        {
                            MessageBox.Show("Mã phiếu xuất này đã được sử dụng!", "Thông báo", MessageBoxButtons.OK);
                            return;
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Thực thi database thất bại!\n\n" + ex.Message, "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                try
                {
                    bdsPhieuXuat.EndEdit();
                    bdsPhieuXuat.ResetCurrentItem();

                    this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.phieuXuatTableAdapter.Update(this.DS.PhieuXuat);

                    MessageBox.Show("Ghi thành công ", "Thông báo", MessageBoxButtons.OK);

                    gcCTPX.Enabled = pcInputPX.Enabled = false;
                    gcPhieuXuat.Enabled = true;
                    btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
                    btnGhi.Enabled = btnPhucHoi.Enabled = false;
                    btnContextThem.Enabled = btnContextXoa.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi Ghi phiếu xuất. " + "\r\n" + ex.Message + "\r\n" + ex.Source);
                    return;
                }
            }

            if (pcCTPX.Enabled)
            {
                if (!checkInputCTPX()) return;

                try
                {
                    String cmd = "Exec sp_LaySlt " + txtMaVT.Text;
                    Program.myReader = Program.ExecSqlDataReader(cmd);

                    if (Program.myReader == null) return;

                    Program.myReader.Read();
                    int result = int.Parse(Program.myReader.GetValue(0).ToString());
                    //int result = int.Parse();

                    Program.myReader.Close();

                    int sl = int.Parse(txtSoLuong.Text);

                    if (sl > result)
                    {
                        MessageBox.Show("Số lượng vượt quá số lượng tồn!", "Thông báo", MessageBoxButtons.OK);
                        return;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thực thi database thất bại!\n\n" + ex.Message, "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Program.myReader.Close();
                    return;
                }

                try
                {
                    bdsCTPX.EndEdit();
                    bdsCTPX.ResetCurrentItem();

                    this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.phieuXuatTableAdapter.Update(this.DS.PhieuXuat);

                    string cmd = "Exec sp_CapNhatSoLuongDonXuat " + txtMaVT.Text + ", " + txtSoLuong.Text;
                    Program.myReader = Program.ExecSqlDataReader(cmd);
                    if (Program.myReader == null) return;
                    Program.myReader.Read();
                    Program.myReader.Close();

                    MessageBox.Show("Ghi thành công ", "Thông báo", MessageBoxButtons.OK);

                    btnContextThem.Enabled = btnContextXoa.Enabled = true;
                    pcCTPX.Enabled = false;
                    pcInputPX.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi Ghi chi tiết phiếu xuất. " + "\r\n" + ex.Message + "\r\n" + ex.Source);
                    return;
                }
            }


        }

        private bool checkInputPX ()
        {
            if (string.IsNullOrWhiteSpace(txtMaPX.Text))
            {
                MessageBox.Show("Không bỏ trống mã phiếu xuất!", "Thông báo", MessageBoxButtons.OK);
                txtMaPX.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNgay.Text))
            {
                MessageBox.Show("Không bỏ trống ngày!", "Thông báo", MessageBoxButtons.OK);
                txtNgay.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtHoTenKH.Text))
            {
                MessageBox.Show("Không bỏ trống họ tên khách hàng!", "Thông báo", MessageBoxButtons.OK);
                txtHoTenKH.Focus();
                return false;
            }

            if (!Regex.IsMatch(txtMaPX.Text.Trim(), @"^[a-zA-Z0-9]+$"))
            {
                MessageBox.Show("Mã phiếu xuất chỉ có chữ cái và số!", "Thông báo", MessageBoxButtons.OK);
                txtMaPX.Focus();
                return false;
            }

            if (txtMaPX.Text.Length > 8)
            {
                MessageBox.Show("Mã phiếu xuất không quá 8 kí tự!", "Thông báo", MessageBoxButtons.OK);
                txtMaPX.Focus();
                return false;
            }

            if (txtHoTenKH.Text.Length > 100)
            {
                MessageBox.Show("Tên vật tư không quá 100 kí tự!", "Thông báo", MessageBoxButtons.OK);
                txtHoTenKH.Focus();
                return false;
            }

            return true;
        }

        private bool checkInputCTPX ()
        {
            bool result = false;

            // Kiểm tra số lượng
            result = int.TryParse(txtSoLuong.Text, out int sl);

            if (!result)
            {
                MessageBox.Show("Số lượng xuất không thể bỏ trống và là một chữ số!", "Thông báo", MessageBoxButtons.OK);
                txtSoLuong.Focus();
                return false;
            }

            if (sl < 0)
            {
                MessageBox.Show("Số lượng xuất phải lớn hơn 0!", "Thông báo", MessageBoxButtons.OK);
                txtSoLuong.Focus();
                return false;
            }

            // Kiểm tra đơn giá
            result = int.TryParse(txtDonGia.Text, out int dg);

            if (!result)
            {
                MessageBox.Show("Đơn giá không thể bỏ trống và là một chữ số!", "Thông báo", MessageBoxButtons.OK);
                txtDonGia.Focus();
                return false;
            }

            if (dg < 0)
            {
                MessageBox.Show("Đơn giá phải lớn hơn 0!", "Thông báo", MessageBoxButtons.OK);
                txtDonGia.Focus();
                return false;
            }

            return true;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsCTPX.Count > 0)
            {
                MessageBox.Show("Phiếu đã có chi tiết phiếu xuất. Không thể xóa!", "", MessageBoxButtons.OK);
                return;
            }

            if (MessageBox.Show("Bạn có thật sự muốn xóa phiếu xuất này không? ", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                string maPx = string.Empty;

                try
                {
                    maPx = ((DataRowView)bdsPhieuXuat[bdsPhieuXuat.Position])["MAPX"].ToString();
                    bdsPhieuXuat.RemoveCurrent();

                    this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.phieuXuatTableAdapter.Update(this.DS.PhieuXuat);

                    MessageBox.Show("Xóa thành công ", "Thông báo", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa phiếu xuất. \nLỗi: " + ex.Message, "", MessageBoxButtons.OK);
                    this.phieuXuatTableAdapter.Fill(this.DS.PhieuXuat);
                    bdsPhieuXuat.Position = bdsPhieuXuat.Find("MAPX", maPx);
                    return;
                }
            }

            if (bdsPhieuXuat.Count == 0) btnXoa.Enabled = false;
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (pcInputPX.Enabled)
            {
                bdsPhieuXuat.CancelEdit();
                this.phieuXuatTableAdapter.Fill(this.DS.PhieuXuat);

                bdsPhieuXuat.Position = vitri;

                pcInputPX.Enabled = false;
                gcPhieuXuat.Enabled = true;
                gcCTPX.Enabled = false;
                btnThem.Enabled = btnXoa.Enabled = btnHieuChinh.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
                btnGhi.Enabled = btnPhucHoi.Enabled = false;
                btnContextThem.Enabled = btnContextXoa.Enabled = false;
            }

            if (pcCTPX.Enabled)
            {
                bdsCTPX.CancelEdit();
                bdsCTPX.RemoveCurrent();

                pcCTPX.Enabled = false;
                pcInputPX.Enabled = true;
                gcPhieuXuat.Focus();
                btnContextThem.Enabled = btnContextXoa.Enabled = true;
            }
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.phieuXuatTableAdapter.Fill(this.DS.PhieuXuat);
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
            frmMain.Instance.btnPhieuNhap.Enabled = frmMain.Instance.btnDDH.Enabled = true;
        }

        private void cbKho_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbKho.SelectedIndex != -1)
            {
                txtMaKho.Text = cbKho.SelectedValue.ToString();
            }
        }

        private void btnContextThem_Click(object sender, EventArgs e)
        {
            gcCTPX.Focus();
            pcInputPX.Enabled = false;
            pcCTPX.Enabled = true;

            bdsCTPX.AddNew();

            txtMaPXCT.Text = txtMaPX.Text;
            cbVattu.SelectedIndex = 0;
            txtSoLuong.Focus();

            btnContextThem.Enabled = btnContextXoa.Enabled = false;

        }

        private void btnContextXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn xóa vật tư này không? ", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    bdsCTPX.RemoveCurrent();

                    this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.phieuXuatTableAdapter.Update(this.DS.PhieuXuat);

                    MessageBox.Show("Xóa thành công ", "Thông báo", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa phiếu xuất. \nLỗi: " + ex.Message, "", MessageBoxButtons.OK);
                    this.phieuXuatTableAdapter.Fill(this.DS.PhieuXuat);
                    return;
                }
            }

            if (bdsCTPX.Count == 0) btnContextXoa.Enabled = false;
        }

        private void cbVattu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbVattu.SelectedIndex != -1)
            {
                txtMaVT.Text = cbVattu.SelectedValue.ToString();
            }
        }

        private void mAPXLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
