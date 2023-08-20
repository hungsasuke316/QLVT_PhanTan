using System;
using System.Windows.Forms;

namespace QLVT
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public static frmMain Instance;
        public frmMain()
        {
            InitializeComponent();
            Instance = this;
        }

        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        public void HienThiMenu()
        {
            MANV.Text = "Mã NV : " + Program.username;
            HOTEN.Text = "Họ Tên : " + Program.mHoten;
            NHOM.Text = "Nhóm : " + Program.mGroup;
            // phân quyền
            rib_BaoCao.Visible = rib_DanhMuc.Visible = rib_NghiepVu.Visible = true;
            btnDangNhap.Enabled = false;
            btnDangXuat.Enabled = true;
            btnTaoTaiKhoan.Enabled = true;
            // tiếp tục if trên Program.mGroup để bật/ tắt các nút lệnh trên menu chính
            if (Program.mGroup == "USER")
            {
                btnTaoTaiKhoan.Enabled = false;
            }
            if (Program.mGroup == "CHINHANH")
            {
                
            }
            if (Program.mGroup == "CONGTY")
            {
                
            }
        }

        private void btnDangNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmDangNhap));
            if (frm != null) frm.Activate();
            else
            {
                frmDangNhap f = new frmDangNhap();
                f.MdiParent = this;
                f.Show();
            }

        }

        private void btnNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmNhanVien));
            if (frm != null) frm.Activate();
            else
            {
                frmNhanVien f = new frmNhanVien();
                f.MdiParent = this;                
                f.Show();
                
            }
            btnVatTu.Enabled = btnKho.Enabled = false;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            frmDangNhap dangNhapForm = new frmDangNhap();
            dangNhapForm.MdiParent = this;
            dangNhapForm.Show();
            btnTaoTaiKhoan.Enabled = btnDangXuat.Enabled = false;
        }

        private void btnTaoTaiKhoan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmTaoTaiKhoan));
            if (frm != null) frm.Activate();
            else
            {
                frmTaoTaiKhoan f = new frmTaoTaiKhoan();
                f.MdiParent = this;                
                f.Show();
            }
            btnDangXuat.Enabled = false;
        }

        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnDangNhap.Enabled = true;
            btnDangXuat.Enabled = btnTaoTaiKhoan.Enabled = false;
            rib_BaoCao.Visible = rib_DanhMuc.Visible = rib_NghiepVu.Visible = false;
            MANV.Text = "MANV";
            HOTEN.Text = "HOTEN";
            NHOM.Text = "NHOM";

            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                Form form = Application.OpenForms[i];

                // Đóng các Form khác trừ Form chính (frmMain)
                if (form != this)
                {
                    form.Close();
                }
            }

            Form frm = this.CheckExists(typeof(frmDangNhap));
            if (frm != null) frm.Activate();
            else
            {
                frmDangNhap f = new frmDangNhap();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDDH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmDonDatHang));
            if (frm != null) frm.Activate();
            else
            {
                frmDonDatHang f = new frmDonDatHang();
                f.MdiParent = this;
                f.Show();
            }
            btnPhieuNhap.Enabled = btnPhieuXuat.Enabled = false;
        }

        private void btnInDSNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmInDanhSachNhanVien));
            if (frm != null) frm.Activate();
            else
            {
                frmInDanhSachNhanVien f = new frmInDanhSachNhanVien();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnPhieuNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmPhieuNhap));
            if (frm != null) frm.Activate();
            else
            {
                frmPhieuNhap f = new frmPhieuNhap();
                f.MdiParent = this;
                f.Show();
            }
            btnPhieuXuat.Enabled = btnDDH.Enabled = false;
        }

        private void btnInDSDDHChuaCoPhieuNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmInDonHangChuaPhieuNhap));
            if (frm != null) frm.Activate();
            else
            {
                frmInDonHangChuaPhieuNhap f = new frmInDonHangChuaPhieuNhap();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnVatTu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmVattu));
            if (frm != null) frm.Activate();
            else
            {
                frmVattu f = new frmVattu();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnPhieuXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmPhieuXuat));
            if (frm != null) frm.Activate();
            else
            {
                frmPhieuXuat f = new frmPhieuXuat();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnTongHopNhapXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmInTongHopNhatXuat));
            if (frm != null) frm.Activate();
            else
            {
                frmInTongHopNhatXuat f = new frmInTongHopNhatXuat();
                f.MdiParent = this;
                f.Show();
            }
        }
    }
}
