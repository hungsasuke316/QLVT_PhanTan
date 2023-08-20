using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLVT
{
    public partial class frmVattu : Form
    {
        int vitri = 0;
        public frmVattu()
        {
            InitializeComponent();
        }

        private void frmVattu_Load(object sender, EventArgs e)
        {

            DS.EnforceConstraints = false;
            
            this.vattuTableAdapter.Connection.ConnectionString = Program.connstr;
            this.vattuTableAdapter.Fill(this.DS.Vattu);
            
            this.CTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.CTDDHTableAdapter.Fill(this.DS.CTDDH);
            
            this.CTPNTableAdapter.Connection.ConnectionString = Program.connstr;
            this.CTPNTableAdapter.Fill(this.DS.CTPN);
            
            this.CTPXTableAdapter.Connection.ConnectionString = Program.connstr;
            this.CTPXTableAdapter.Fill(this.DS.CTPX);

            // Phân quyền
            if ("CONGTY" == Program.mGroup)
            {
                btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = false;
            }
            else
            {
                btnThem.Enabled = btnHieuChinh.Enabled = true;
                if (bdsVattu.Count == 0) btnXoa.Enabled = false;
            }

            // Vì chưa thực thi nên không cần Ghi hay Phục hồi
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
            // Khóa phần input
            pcInput.Enabled = false;

        }

        private void vattuBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsVattu.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void dVTLabel_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsVattu.Position;
            pcInput.Enabled = true;
            txtMaVT.Enabled = true;
            txtMaVT.Focus();
            bdsVattu.AddNew();

            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            gcVattu.Enabled = false;
        }

        private void btnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsVattu.Position;
            pcInput.Enabled = true;
            txtMaVT.Enabled = false;
            txtTenVT.Focus();

            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            gcVattu.Enabled = false;
        }

        private bool CheckInput()
        {
            if (String.IsNullOrWhiteSpace(txtMaVT.Text))
            {
                MessageBox.Show("Không bỏ trống mã vật tư!", "Thông báo", MessageBoxButtons.OK);
                txtMaVT.Focus();
                return false;
            }

            if (String.IsNullOrWhiteSpace(txtTenVT.Text))
            {
                MessageBox.Show("Không bỏ trống tên vật tư!", "Thông báo", MessageBoxButtons.OK);
                txtTenVT.Focus();
                return false;
            }

            if (String.IsNullOrWhiteSpace(txtDvTinh.Text))
            {
                MessageBox.Show("Không bỏ trống đơn vị tính!", "Thông báo", MessageBoxButtons.OK);
                txtDvTinh.Focus();
                return false;
            }

            if (!Regex.IsMatch(txtMaVT.Text, @"^[a-zA-Z0-9]+$"))
            {
                MessageBox.Show("Mã vật tư chỉ có chữ cái và số!", "Thông báo", MessageBoxButtons.OK);
                txtMaVT.Focus();
                return false;
            }

            if (txtMaVT.Text.Length > 4)
            {
                MessageBox.Show("Mã vật tư không quá 4 kí tự!", "Thông báo", MessageBoxButtons.OK);
                txtMaVT.Focus();
                return false;
            }

            if (txtTenVT.Text.Length > 30)
            {
                MessageBox.Show("Tên vật tư không quá 30 kí tự!", "Thông báo", MessageBoxButtons.OK);
                txtTenVT.Focus();
                return false;
            }

            if (txtDvTinh.Text.Length > 15)
            {
                MessageBox.Show("Đơn vị tính không quá 15 kí tự!", "Thông báo", MessageBoxButtons.OK);
                txtDvTinh.Focus();
                return false;
            }

            bool result = int.TryParse(txtSLT.Text, out int slt);

            if (!result)
            {
                MessageBox.Show("Số lượng tồn phải là một số!", "Thông báo", MessageBoxButtons.OK);
                txtSLT.Focus();
                return false;
            }

            if (slt <= 0)
            {
                MessageBox.Show("Số lượng tồn không thể là số nhỏ hơn 0!", "Thông báo", MessageBoxButtons.OK);
                txtSLT.Focus();
                return false;
            }

            return true;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!CheckInput())
            {
                return;
            }

            // Kiểm tra mã vật tư trong trường hợp thêm mới
            if (txtMaVT.Enabled)
            {
                try
                {
                    String cmd = "declare @result int exec @result = sp_KiemTraMaVT " + txtMaVT.Text + " select @result";
                    Program.myReader = Program.ExecSqlDataReader(cmd);

                    if (Program.myReader == null) return;

                    Program.myReader.Read();
                    int result = int.Parse(Program.myReader.GetValue(0).ToString());
                    Program.myReader.Close();

                    if (result > 0)
                    {
                        MessageBox.Show("Mã vật tư này đã được sử dụng!", "Thông báo", MessageBoxButtons.OK);
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
                bdsVattu.EndEdit();
                bdsVattu.ResetCurrentItem();

                this.vattuTableAdapter.Connection.ConnectionString = Program.connstr;
                this.vattuTableAdapter.Update(this.DS.Vattu);

                MessageBox.Show("Ghi vật tư thành công!", "Thông báo", MessageBoxButtons.OK);

                gcVattu.Enabled = true;
                pcInput.Enabled = false;
                btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
                btnGhi.Enabled = btnPhucHoi.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Ghi vật tư. " + "\r\n" + ex.Message + "\r\n" + ex.Source);
                return;
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsCTPX.Count > 0)
            {
                MessageBox.Show("Vật tư đã có trong chi tiết phiếu xuất. Không thể xóa!", "", MessageBoxButtons.OK);
                return;
            }

            if (bdsCTPN.Count > 0)
            {
                MessageBox.Show("Vật tư đã có trong chi tiết phiếu nhập. Không thể xóa!", "", MessageBoxButtons.OK);
                return;
            }

            if (bdsCTTDH.Count > 0)
            {
                MessageBox.Show("Vật tư đã có trong chi tiết đơn đặt hàng. Không thể xóa!", "", MessageBoxButtons.OK);
                return;
            }

            try
            {
                String cmd = "declare @result int exec @result = sp_KiemTraVTDaDung " + txtMaVT.Text + " select @result";
                Program.myReader = Program.ExecSqlDataReader(cmd);

                if (Program.myReader == null) return;

                Program.myReader.Read();
                int result = int.Parse(Program.myReader.GetValue(0).ToString());
                Program.myReader.Close();

                if (result > 0)
                {
                    MessageBox.Show("Vật tư này đã được sử dụng ở chi nhánh khác. Không thể xóa!", "Thông báo", MessageBoxButtons.OK);
                    return;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Thực thi database thất bại!\n\n" + ex.Message, "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Bạn có thật sự muốn xóa vật tư này không? ", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                string maVt = "";

                try
                {
                    maVt = ((DataRowView)bdsVattu[bdsVattu.Position])["MAVT"].ToString();
                    bdsVattu.RemoveCurrent();

                    this.vattuTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.vattuTableAdapter.Update(this.DS.Vattu);

                    MessageBox.Show("Xóa thành công ", "Thông báo", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa vật tư. \nLỗi: " + ex.Message, "", MessageBoxButtons.OK);
                    this.vattuTableAdapter.Fill(this.DS.Vattu);
                    bdsVattu.Position = bdsVattu.Find("MAVT", maVt);
                    return;
                }
            }

            if (bdsVattu.Count == 0) btnXoa.Enabled = false;
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsVattu.CancelEdit();

            if (txtMaVT.Enabled == true)
            {
                bdsVattu.RemoveCurrent();
                bdsVattu.Position = vitri;
            }

            pcInput.Enabled = false;
            gcVattu.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnHieuChinh.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.vattuTableAdapter.Fill(this.DS.Vattu);
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
            frmMain.Instance.btnKho.Enabled = frmMain.Instance.btnNhanVien.Enabled = true;
        }
    }
}
