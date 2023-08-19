namespace QLVT
{
    partial class frmPhieuNhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label mAPNLabel;
            System.Windows.Forms.Label nGAYLabel;
            System.Windows.Forms.Label mAPNLabel1;
            System.Windows.Forms.Label sOLUONGLabel;
            System.Windows.Forms.Label dONGIALabel;
            System.Windows.Forms.Label mAKHOLabel;
            System.Windows.Forms.Label mAVTLabel;
            System.Windows.Forms.Label mANVLabel;
            System.Windows.Forms.Label masoDDHLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhieuNhap));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnHieuChinh = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.cbbChiNhanh = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.DS = new QLVT.DS();
            this.bds_PN = new System.Windows.Forms.BindingSource(this.components);
            this.phieuNhapTableAdapter = new QLVT.DSTableAdapters.PhieuNhapTableAdapter();
            this.tableAdapterManager = new QLVT.DSTableAdapters.TableAdapterManager();
            this.CTPNTableAdapter = new QLVT.DSTableAdapters.CTPNTableAdapter();
            this.datHangTableAdapter = new QLVT.DSTableAdapters.DatHangTableAdapter();
            this.nhanVienTableAdapter = new QLVT.DSTableAdapters.NhanVienTableAdapter();
            this.gc_PN = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAPN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMasoDDH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelNhapLieuPN = new DevExpress.XtraEditors.PanelControl();
            this.txtHOTEN = new System.Windows.Forms.TextBox();
            this.btnChonDDH = new System.Windows.Forms.Button();
            this.txtMasoDDH = new DevExpress.XtraEditors.TextEdit();
            this.txtMANV = new DevExpress.XtraEditors.TextEdit();
            this.cmbTenKho = new System.Windows.Forms.ComboBox();
            this.bds_Kho = new System.Windows.Forms.BindingSource(this.components);
            this.txtMAKHO = new DevExpress.XtraEditors.TextEdit();
            this.dtNGAY = new DevExpress.XtraEditors.DateEdit();
            this.txtMAPN = new DevExpress.XtraEditors.TextEdit();
            this.bds_DDH = new System.Windows.Forms.BindingSource(this.components);
            this.bdsNV = new System.Windows.Forms.BindingSource(this.components);
            this.bds_CTPN = new System.Windows.Forms.BindingSource(this.components);
            this.gc_CTPN = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAPN1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDONGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelNhapLieuCTPN = new DevExpress.XtraEditors.PanelControl();
            this.btnChonCTDDH = new System.Windows.Forms.Button();
            this.cmbTenVT = new System.Windows.Forms.ComboBox();
            this.bds_VatTu = new System.Windows.Forms.BindingSource(this.components);
            this.txtMAVT = new DevExpress.XtraEditors.TextEdit();
            this.txtDonGia = new DevExpress.XtraEditors.TextEdit();
            this.txtSoLuong = new DevExpress.XtraEditors.TextEdit();
            this.txtMAPN_CTPN = new DevExpress.XtraEditors.TextEdit();
            this.contextThem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.khoTableAdapter = new QLVT.DSTableAdapters.KhoTableAdapter();
            this.vattuTableAdapter = new QLVT.DSTableAdapters.VattuTableAdapter();
            this.bds_CT_DDH = new System.Windows.Forms.BindingSource(this.components);
            this.CTDDHTableAdapter = new QLVT.DSTableAdapters.CTDDHTableAdapter();
            mAPNLabel = new System.Windows.Forms.Label();
            nGAYLabel = new System.Windows.Forms.Label();
            mAPNLabel1 = new System.Windows.Forms.Label();
            sOLUONGLabel = new System.Windows.Forms.Label();
            dONGIALabel = new System.Windows.Forms.Label();
            mAKHOLabel = new System.Windows.Forms.Label();
            mAVTLabel = new System.Windows.Forms.Label();
            mANVLabel = new System.Windows.Forms.Label();
            masoDDHLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_PN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_PN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelNhapLieuPN)).BeginInit();
            this.panelNhapLieuPN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMasoDDH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMANV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_Kho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMAKHO.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNGAY.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNGAY.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMAPN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_DDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_CTPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_CTPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelNhapLieuCTPN)).BeginInit();
            this.panelNhapLieuCTPN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bds_VatTu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMAVT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonGia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMAPN_CTPN.Properties)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bds_CT_DDH)).BeginInit();
            this.SuspendLayout();
            // 
            // mAPNLabel
            // 
            mAPNLabel.AutoSize = true;
            mAPNLabel.Location = new System.Drawing.Point(38, 31);
            mAPNLabel.Name = "mAPNLabel";
            mAPNLabel.Size = new System.Drawing.Size(48, 16);
            mAPNLabel.TabIndex = 0;
            mAPNLabel.Text = "Mã PN:";
            // 
            // nGAYLabel
            // 
            nGAYLabel.AutoSize = true;
            nGAYLabel.Location = new System.Drawing.Point(38, 71);
            nGAYLabel.Name = "nGAYLabel";
            nGAYLabel.Size = new System.Drawing.Size(64, 16);
            nGAYLabel.TabIndex = 2;
            nGAYLabel.Text = "Ngày Lập:";
            // 
            // mAPNLabel1
            // 
            mAPNLabel1.AutoSize = true;
            mAPNLabel1.Location = new System.Drawing.Point(30, 14);
            mAPNLabel1.Name = "mAPNLabel1";
            mAPNLabel1.Size = new System.Drawing.Size(48, 16);
            mAPNLabel1.TabIndex = 0;
            mAPNLabel1.Text = "Mã PN:";
            // 
            // sOLUONGLabel
            // 
            sOLUONGLabel.AutoSize = true;
            sOLUONGLabel.Location = new System.Drawing.Point(418, 12);
            sOLUONGLabel.Name = "sOLUONGLabel";
            sOLUONGLabel.Size = new System.Drawing.Size(66, 16);
            sOLUONGLabel.TabIndex = 4;
            sOLUONGLabel.Text = "Số Lượng:";
            // 
            // dONGIALabel
            // 
            dONGIALabel.AutoSize = true;
            dONGIALabel.Location = new System.Drawing.Point(418, 67);
            dONGIALabel.Name = "dONGIALabel";
            dONGIALabel.Size = new System.Drawing.Size(57, 16);
            dONGIALabel.TabIndex = 6;
            dONGIALabel.Text = "Đơn Giá:";
            // 
            // mAKHOLabel
            // 
            mAKHOLabel.AutoSize = true;
            mAKHOLabel.Location = new System.Drawing.Point(39, 193);
            mAKHOLabel.Name = "mAKHOLabel";
            mAKHOLabel.Size = new System.Drawing.Size(33, 16);
            mAKHOLabel.TabIndex = 10;
            mAKHOLabel.Text = "Kho:";
            // 
            // mAVTLabel
            // 
            mAVTLabel.AutoSize = true;
            mAVTLabel.Location = new System.Drawing.Point(29, 66);
            mAVTLabel.Name = "mAVTLabel";
            mAVTLabel.Size = new System.Drawing.Size(47, 16);
            mAVTLabel.TabIndex = 7;
            mAVTLabel.Text = "Vật tư:";
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Location = new System.Drawing.Point(39, 149);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(70, 16);
            mANVLabel.TabIndex = 12;
            mANVLabel.Text = "Nhân Viên:";
            // 
            // masoDDHLabel
            // 
            masoDDHLabel.AutoSize = true;
            masoDDHLabel.Location = new System.Drawing.Point(39, 109);
            masoDDHLabel.Name = "masoDDHLabel";
            masoDDHLabel.Size = new System.Drawing.Size(67, 16);
            masoDDHLabel.TabIndex = 13;
            masoDDHLabel.Text = "Đơn hàng:";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.barButtonItem2,
            this.btnHieuChinh,
            this.btnXoa,
            this.btnPhucHoi,
            this.btnReload,
            this.btnThoat,
            this.btnGhi,
            this.barButtonItem1});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 10;
            this.barManager1.OptionsStubGlyphs.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barManager1.OptionsStubGlyphs.UseFont = true;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHieuChinh, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnPhucHoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnReload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.LargeImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnHieuChinh
            // 
            this.btnHieuChinh.Caption = "Hiệu chỉnh\r\n";
            this.btnHieuChinh.Id = 2;
            this.btnHieuChinh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHieuChinh.ImageOptions.Image")));
            this.btnHieuChinh.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnHieuChinh.ImageOptions.LargeImage")));
            this.btnHieuChinh.Name = "btnHieuChinh";
            this.btnHieuChinh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHieuChinh_ItemClick);
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "Ghi";
            this.btnGhi.Id = 8;
            this.btnGhi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.Image")));
            this.btnGhi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.LargeImage")));
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhi_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 3;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.LargeImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnPhucHoi
            // 
            this.btnPhucHoi.Caption = "Phục Hồi";
            this.btnPhucHoi.Id = 4;
            this.btnPhucHoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPhucHoi.ImageOptions.Image")));
            this.btnPhucHoi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPhucHoi.ImageOptions.LargeImage")));
            this.btnPhucHoi.Name = "btnPhucHoi";
            this.btnPhucHoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhucHoi_ItemClick);
            // 
            // btnReload
            // 
            this.btnReload.Caption = "Reload";
            this.btnReload.Id = 5;
            this.btnReload.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.ImageOptions.Image")));
            this.btnReload.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnReload.ImageOptions.LargeImage")));
            this.btnReload.Name = "btnReload";
            this.btnReload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReload_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 7;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.LargeImage")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barDockControlTop.Appearance.Options.UseFont = true;
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1208, 51);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 611);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1208, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 51);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 560);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1208, 51);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 560);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Hiệu Chỉnh";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.barButtonItem2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 9;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // cbbChiNhanh
            // 
            this.cbbChiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbChiNhanh.Enabled = false;
            this.cbbChiNhanh.FormattingEnabled = true;
            this.cbbChiNhanh.Location = new System.Drawing.Point(260, 22);
            this.cbbChiNhanh.Margin = new System.Windows.Forms.Padding(15);
            this.cbbChiNhanh.Name = "cbbChiNhanh";
            this.cbbChiNhanh.Size = new System.Drawing.Size(472, 24);
            this.cbbChiNhanh.TabIndex = 1;
            this.cbbChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cbbChiNhanh_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chi Nhánh";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cbbChiNhanh);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 51);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(19);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1208, 73);
            this.panelControl1.TabIndex = 6;
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bds_PN
            // 
            this.bds_PN.DataMember = "PhieuNhap";
            this.bds_PN.DataSource = this.DS;
            // 
            // phieuNhapTableAdapter
            // 
            this.phieuNhapTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.CTDDHTableAdapter = null;
            this.tableAdapterManager.CTPNTableAdapter = this.CTPNTableAdapter;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = this.datHangTableAdapter;
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = this.nhanVienTableAdapter;
            this.tableAdapterManager.PhieuNhapTableAdapter = this.phieuNhapTableAdapter;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVT.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // CTPNTableAdapter
            // 
            this.CTPNTableAdapter.ClearBeforeFill = true;
            // 
            // datHangTableAdapter
            // 
            this.datHangTableAdapter.ClearBeforeFill = true;
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // gc_PN
            // 
            this.gc_PN.DataSource = this.bds_PN;
            this.gc_PN.Dock = System.Windows.Forms.DockStyle.Top;
            this.gc_PN.Location = new System.Drawing.Point(0, 124);
            this.gc_PN.MainView = this.gridView1;
            this.gc_PN.MenuManager = this.barManager1;
            this.gc_PN.Name = "gc_PN";
            this.gc_PN.Size = new System.Drawing.Size(1208, 193);
            this.gc_PN.TabIndex = 7;
            this.gc_PN.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAPN,
            this.colNGAY,
            this.colMasoDDH,
            this.colMANV,
            this.colMAKHO});
            this.gridView1.GridControl = this.gc_PN;
            this.gridView1.Name = "gridView1";
            // 
            // colMAPN
            // 
            this.colMAPN.FieldName = "MAPN";
            this.colMAPN.MinWidth = 25;
            this.colMAPN.Name = "colMAPN";
            this.colMAPN.OptionsColumn.ReadOnly = true;
            this.colMAPN.Visible = true;
            this.colMAPN.VisibleIndex = 0;
            this.colMAPN.Width = 94;
            // 
            // colNGAY
            // 
            this.colNGAY.DisplayFormat.FormatString = "dd-MM-yyyy";
            this.colNGAY.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colNGAY.FieldName = "NGAY";
            this.colNGAY.MinWidth = 25;
            this.colNGAY.Name = "colNGAY";
            this.colNGAY.OptionsColumn.ReadOnly = true;
            this.colNGAY.Visible = true;
            this.colNGAY.VisibleIndex = 1;
            this.colNGAY.Width = 94;
            // 
            // colMasoDDH
            // 
            this.colMasoDDH.FieldName = "MasoDDH";
            this.colMasoDDH.MinWidth = 25;
            this.colMasoDDH.Name = "colMasoDDH";
            this.colMasoDDH.OptionsColumn.ReadOnly = true;
            this.colMasoDDH.Visible = true;
            this.colMasoDDH.VisibleIndex = 2;
            this.colMasoDDH.Width = 94;
            // 
            // colMANV
            // 
            this.colMANV.FieldName = "MANV";
            this.colMANV.MinWidth = 25;
            this.colMANV.Name = "colMANV";
            this.colMANV.OptionsColumn.ReadOnly = true;
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 3;
            this.colMANV.Width = 94;
            // 
            // colMAKHO
            // 
            this.colMAKHO.FieldName = "MAKHO";
            this.colMAKHO.MinWidth = 25;
            this.colMAKHO.Name = "colMAKHO";
            this.colMAKHO.OptionsColumn.ReadOnly = true;
            this.colMAKHO.Visible = true;
            this.colMAKHO.VisibleIndex = 4;
            this.colMAKHO.Width = 94;
            // 
            // panelNhapLieuPN
            // 
            this.panelNhapLieuPN.Controls.Add(this.txtHOTEN);
            this.panelNhapLieuPN.Controls.Add(this.btnChonDDH);
            this.panelNhapLieuPN.Controls.Add(masoDDHLabel);
            this.panelNhapLieuPN.Controls.Add(this.txtMasoDDH);
            this.panelNhapLieuPN.Controls.Add(mANVLabel);
            this.panelNhapLieuPN.Controls.Add(this.txtMANV);
            this.panelNhapLieuPN.Controls.Add(this.cmbTenKho);
            this.panelNhapLieuPN.Controls.Add(mAKHOLabel);
            this.panelNhapLieuPN.Controls.Add(this.txtMAKHO);
            this.panelNhapLieuPN.Controls.Add(nGAYLabel);
            this.panelNhapLieuPN.Controls.Add(this.dtNGAY);
            this.panelNhapLieuPN.Controls.Add(mAPNLabel);
            this.panelNhapLieuPN.Controls.Add(this.txtMAPN);
            this.panelNhapLieuPN.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelNhapLieuPN.Location = new System.Drawing.Point(0, 317);
            this.panelNhapLieuPN.Name = "panelNhapLieuPN";
            this.panelNhapLieuPN.Size = new System.Drawing.Size(493, 294);
            this.panelNhapLieuPN.TabIndex = 8;
            // 
            // txtHOTEN
            // 
            this.txtHOTEN.Enabled = false;
            this.txtHOTEN.Location = new System.Drawing.Point(203, 146);
            this.txtHOTEN.Name = "txtHOTEN";
            this.txtHOTEN.Size = new System.Drawing.Size(194, 23);
            this.txtHOTEN.TabIndex = 16;
            this.txtHOTEN.TextChanged += new System.EventHandler(this.txtHOTEN_TextChanged);
            // 
            // btnChonDDH
            // 
            this.btnChonDDH.Location = new System.Drawing.Point(273, 104);
            this.btnChonDDH.Name = "btnChonDDH";
            this.btnChonDDH.Size = new System.Drawing.Size(124, 26);
            this.btnChonDDH.TabIndex = 15;
            this.btnChonDDH.Text = "Chọn đơn hàng";
            this.btnChonDDH.UseVisualStyleBackColor = true;
            this.btnChonDDH.Click += new System.EventHandler(this.btnChonDDH_Click);
            // 
            // txtMasoDDH
            // 
            this.txtMasoDDH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_PN, "MasoDDH", true));
            this.txtMasoDDH.Enabled = false;
            this.txtMasoDDH.Location = new System.Drawing.Point(115, 106);
            this.txtMasoDDH.MenuManager = this.barManager1;
            this.txtMasoDDH.Name = "txtMasoDDH";
            this.txtMasoDDH.Size = new System.Drawing.Size(125, 22);
            this.txtMasoDDH.TabIndex = 14;
            // 
            // txtMANV
            // 
            this.txtMANV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bds_PN, "MANV", true));
            this.txtMANV.Enabled = false;
            this.txtMANV.Location = new System.Drawing.Point(114, 146);
            this.txtMANV.MenuManager = this.barManager1;
            this.txtMANV.Name = "txtMANV";
            this.txtMANV.Size = new System.Drawing.Size(65, 22);
            this.txtMANV.TabIndex = 13;
            this.txtMANV.EditValueChanged += new System.EventHandler(this.txtMANV_EditValueChanged);
            // 
            // cmbTenKho
            // 
            this.cmbTenKho.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bds_PN, "MAKHO", true));
            this.cmbTenKho.DataSource = this.bds_Kho;
            this.cmbTenKho.DisplayMember = "TENKHO";
            this.cmbTenKho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTenKho.FormattingEnabled = true;
            this.cmbTenKho.Location = new System.Drawing.Point(203, 190);
            this.cmbTenKho.Name = "cmbTenKho";
            this.cmbTenKho.Size = new System.Drawing.Size(121, 24);
            this.cmbTenKho.TabIndex = 12;
            this.cmbTenKho.ValueMember = "MAKHO";
            this.cmbTenKho.SelectedIndexChanged += new System.EventHandler(this.cmbTenKho_SelectedIndexChanged);
            // 
            // bds_Kho
            // 
            this.bds_Kho.DataMember = "Kho";
            this.bds_Kho.DataSource = this.DS;
            // 
            // txtMAKHO
            // 
            this.txtMAKHO.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bds_PN, "MAKHO", true));
            this.txtMAKHO.Enabled = false;
            this.txtMAKHO.Location = new System.Drawing.Point(114, 190);
            this.txtMAKHO.MenuManager = this.barManager1;
            this.txtMAKHO.Name = "txtMAKHO";
            this.txtMAKHO.Size = new System.Drawing.Size(68, 22);
            this.txtMAKHO.TabIndex = 11;
            this.txtMAKHO.EditValueChanged += new System.EventHandler(this.txtMAKHO_EditValueChanged);
            // 
            // dtNGAY
            // 
            this.dtNGAY.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_PN, "NGAY", true));
            this.dtNGAY.EditValue = null;
            this.dtNGAY.Location = new System.Drawing.Point(115, 68);
            this.dtNGAY.MenuManager = this.barManager1;
            this.dtNGAY.Name = "dtNGAY";
            this.dtNGAY.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtNGAY.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtNGAY.Properties.DisplayFormat.FormatString = "dd-MM-yyyy";
            this.dtNGAY.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtNGAY.Size = new System.Drawing.Size(125, 22);
            this.dtNGAY.TabIndex = 3;
            // 
            // txtMAPN
            // 
            this.txtMAPN.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_PN, "MAPN", true));
            this.txtMAPN.Location = new System.Drawing.Point(115, 28);
            this.txtMAPN.MenuManager = this.barManager1;
            this.txtMAPN.Name = "txtMAPN";
            this.txtMAPN.Size = new System.Drawing.Size(125, 22);
            this.txtMAPN.TabIndex = 1;
            // 
            // bds_DDH
            // 
            this.bds_DDH.DataMember = "DatHang";
            this.bds_DDH.DataSource = this.DS;
            // 
            // bdsNV
            // 
            this.bdsNV.DataMember = "NhanVien";
            this.bdsNV.DataSource = this.DS;
            // 
            // bds_CTPN
            // 
            this.bds_CTPN.DataMember = "FK_CTPN_PhieuNhap";
            this.bds_CTPN.DataSource = this.bds_PN;
            // 
            // gc_CTPN
            // 
            this.gc_CTPN.DataSource = this.bds_CTPN;
            this.gc_CTPN.Dock = System.Windows.Forms.DockStyle.Top;
            this.gc_CTPN.Location = new System.Drawing.Point(493, 317);
            this.gc_CTPN.MainView = this.gridView2;
            this.gc_CTPN.MenuManager = this.barManager1;
            this.gc_CTPN.Name = "gc_CTPN";
            this.gc_CTPN.Size = new System.Drawing.Size(715, 198);
            this.gc_CTPN.TabIndex = 8;
            this.gc_CTPN.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAPN1,
            this.colMAVT,
            this.colSOLUONG,
            this.colDONGIA});
            this.gridView2.GridControl = this.gc_CTPN;
            this.gridView2.Name = "gridView2";
            // 
            // colMAPN1
            // 
            this.colMAPN1.FieldName = "MAPN";
            this.colMAPN1.MinWidth = 25;
            this.colMAPN1.Name = "colMAPN1";
            this.colMAPN1.OptionsColumn.ReadOnly = true;
            this.colMAPN1.Visible = true;
            this.colMAPN1.VisibleIndex = 0;
            this.colMAPN1.Width = 94;
            // 
            // colMAVT
            // 
            this.colMAVT.FieldName = "MAVT";
            this.colMAVT.MinWidth = 25;
            this.colMAVT.Name = "colMAVT";
            this.colMAVT.OptionsColumn.ReadOnly = true;
            this.colMAVT.Visible = true;
            this.colMAVT.VisibleIndex = 1;
            this.colMAVT.Width = 94;
            // 
            // colSOLUONG
            // 
            this.colSOLUONG.FieldName = "SOLUONG";
            this.colSOLUONG.MinWidth = 25;
            this.colSOLUONG.Name = "colSOLUONG";
            this.colSOLUONG.OptionsColumn.ReadOnly = true;
            this.colSOLUONG.Visible = true;
            this.colSOLUONG.VisibleIndex = 2;
            this.colSOLUONG.Width = 94;
            // 
            // colDONGIA
            // 
            this.colDONGIA.FieldName = "DONGIA";
            this.colDONGIA.MinWidth = 25;
            this.colDONGIA.Name = "colDONGIA";
            this.colDONGIA.OptionsColumn.ReadOnly = true;
            this.colDONGIA.Visible = true;
            this.colDONGIA.VisibleIndex = 3;
            this.colDONGIA.Width = 94;
            // 
            // panelNhapLieuCTPN
            // 
            this.panelNhapLieuCTPN.Controls.Add(this.btnChonCTDDH);
            this.panelNhapLieuCTPN.Controls.Add(this.cmbTenVT);
            this.panelNhapLieuCTPN.Controls.Add(mAVTLabel);
            this.panelNhapLieuCTPN.Controls.Add(this.txtMAVT);
            this.panelNhapLieuCTPN.Controls.Add(dONGIALabel);
            this.panelNhapLieuCTPN.Controls.Add(this.txtDonGia);
            this.panelNhapLieuCTPN.Controls.Add(sOLUONGLabel);
            this.panelNhapLieuCTPN.Controls.Add(this.txtSoLuong);
            this.panelNhapLieuCTPN.Controls.Add(mAPNLabel1);
            this.panelNhapLieuCTPN.Controls.Add(this.txtMAPN_CTPN);
            this.panelNhapLieuCTPN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNhapLieuCTPN.Location = new System.Drawing.Point(493, 515);
            this.panelNhapLieuCTPN.Name = "panelNhapLieuCTPN";
            this.panelNhapLieuCTPN.Size = new System.Drawing.Size(715, 96);
            this.panelNhapLieuCTPN.TabIndex = 9;
            // 
            // btnChonCTDDH
            // 
            this.btnChonCTDDH.Location = new System.Drawing.Point(225, 12);
            this.btnChonCTDDH.Name = "btnChonCTDDH";
            this.btnChonCTDDH.Size = new System.Drawing.Size(133, 29);
            this.btnChonCTDDH.TabIndex = 10;
            this.btnChonCTDDH.Text = "Chọn CTDDH";
            this.btnChonCTDDH.UseVisualStyleBackColor = true;
            this.btnChonCTDDH.Click += new System.EventHandler(this.btnChonCTDDH_Click);
            // 
            // cmbTenVT
            // 
            this.cmbTenVT.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bds_CTPN, "MAVT", true));
            this.cmbTenVT.DataSource = this.bds_VatTu;
            this.cmbTenVT.DisplayMember = "TENVT";
            this.cmbTenVT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTenVT.Enabled = false;
            this.cmbTenVT.FormattingEnabled = true;
            this.cmbTenVT.Location = new System.Drawing.Point(161, 63);
            this.cmbTenVT.Name = "cmbTenVT";
            this.cmbTenVT.Size = new System.Drawing.Size(223, 24);
            this.cmbTenVT.TabIndex = 9;
            this.cmbTenVT.ValueMember = "MAVT";
            this.cmbTenVT.SelectedIndexChanged += new System.EventHandler(this.cmbTenVT_SelectedIndexChanged);
            // 
            // bds_VatTu
            // 
            this.bds_VatTu.DataMember = "Vattu";
            this.bds_VatTu.DataSource = this.DS;
            // 
            // txtMAVT
            // 
            this.txtMAVT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bds_CTPN, "MAVT", true));
            this.txtMAVT.Enabled = false;
            this.txtMAVT.Location = new System.Drawing.Point(81, 63);
            this.txtMAVT.MenuManager = this.barManager1;
            this.txtMAVT.Name = "txtMAVT";
            this.txtMAVT.Size = new System.Drawing.Size(62, 22);
            this.txtMAVT.TabIndex = 8;
            // 
            // txtDonGia
            // 
            this.txtDonGia.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_CTPN, "DONGIA", true));
            this.txtDonGia.Enabled = false;
            this.txtDonGia.Location = new System.Drawing.Point(492, 64);
            this.txtDonGia.MenuManager = this.barManager1;
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Properties.DisplayFormat.FormatString = "n0";
            this.txtDonGia.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtDonGia.Size = new System.Drawing.Size(125, 22);
            this.txtDonGia.TabIndex = 7;
            this.txtDonGia.EditValueChanged += new System.EventHandler(this.txtDonGia_EditValueChanged);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_CTPN, "SOLUONG", true));
            this.txtSoLuong.Enabled = false;
            this.txtSoLuong.Location = new System.Drawing.Point(492, 9);
            this.txtSoLuong.MenuManager = this.barManager1;
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Properties.DisplayFormat.FormatString = "n0";
            this.txtSoLuong.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtSoLuong.Size = new System.Drawing.Size(125, 22);
            this.txtSoLuong.TabIndex = 5;
            // 
            // txtMAPN_CTPN
            // 
            this.txtMAPN_CTPN.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_CTPN, "MAPN", true));
            this.txtMAPN_CTPN.Enabled = false;
            this.txtMAPN_CTPN.Location = new System.Drawing.Point(81, 11);
            this.txtMAPN_CTPN.MenuManager = this.barManager1;
            this.txtMAPN_CTPN.Name = "txtMAPN_CTPN";
            this.txtMAPN_CTPN.Size = new System.Drawing.Size(125, 22);
            this.txtMAPN_CTPN.TabIndex = 1;
            // 
            // contextThem
            // 
            this.contextThem.Name = "contextThem";
            this.contextThem.Size = new System.Drawing.Size(115, 24);
            this.contextThem.Text = "Thêm";
            this.contextThem.Click += new System.EventHandler(this.contextThem_Click);
            // 
            // contextXoa
            // 
            this.contextXoa.Name = "contextXoa";
            this.contextXoa.Size = new System.Drawing.Size(115, 24);
            this.contextXoa.Text = "Xóa";
            this.contextXoa.Click += new System.EventHandler(this.contextXoa_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextThem,
            this.contextXoa});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(116, 52);
            // 
            // khoTableAdapter
            // 
            this.khoTableAdapter.ClearBeforeFill = true;
            // 
            // vattuTableAdapter
            // 
            this.vattuTableAdapter.ClearBeforeFill = true;
            // 
            // bds_CT_DDH
            // 
            this.bds_CT_DDH.DataMember = "CTDDH";
            this.bds_CT_DDH.DataSource = this.DS;
            // 
            // CTDDHTableAdapter
            // 
            this.CTDDHTableAdapter.ClearBeforeFill = true;
            // 
            // frmPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 611);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.panelNhapLieuCTPN);
            this.Controls.Add(this.gc_CTPN);
            this.Controls.Add(this.panelNhapLieuPN);
            this.Controls.Add(this.gc_PN);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPhieuNhap";
            this.Text = "frmPhieuNhap";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPhieuNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_PN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_PN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelNhapLieuPN)).EndInit();
            this.panelNhapLieuPN.ResumeLayout(false);
            this.panelNhapLieuPN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMasoDDH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMANV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_Kho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMAKHO.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNGAY.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNGAY.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMAPN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_DDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_CTPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_CTPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelNhapLieuCTPN)).EndInit();
            this.panelNhapLieuCTPN.ResumeLayout(false);
            this.panelNhapLieuCTPN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bds_VatTu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMAVT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonGia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMAPN_CTPN.Properties)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bds_CT_DDH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnHieuChinh;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoi;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ComboBox cbbChiNhanh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bds_PN;
        private DS DS;
        private DSTableAdapters.PhieuNhapTableAdapter phieuNhapTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gc_PN;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAPN;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAY;
        private DevExpress.XtraGrid.Columns.GridColumn colMasoDDH;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHO;
        private DevExpress.XtraEditors.PanelControl panelNhapLieuPN;
        private DSTableAdapters.CTPNTableAdapter CTPNTableAdapter;
        private System.Windows.Forms.BindingSource bds_CTPN;
        private DevExpress.XtraGrid.GridControl gc_CTPN;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.DateEdit dtNGAY;
        private DevExpress.XtraEditors.TextEdit txtMAPN;
        private DevExpress.XtraEditors.PanelControl panelNhapLieuCTPN;
        private DevExpress.XtraGrid.Columns.GridColumn colMAPN1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAVT;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONG;
        private DevExpress.XtraGrid.Columns.GridColumn colDONGIA;
        private DevExpress.XtraEditors.TextEdit txtDonGia;
        private DevExpress.XtraEditors.TextEdit txtSoLuong;
        private DevExpress.XtraEditors.TextEdit txtMAPN_CTPN;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem contextThem;
        private System.Windows.Forms.ToolStripMenuItem contextXoa;
        private DSTableAdapters.DatHangTableAdapter datHangTableAdapter;
        private System.Windows.Forms.BindingSource bds_DDH;
        private DSTableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
        private System.Windows.Forms.BindingSource bdsNV;
        private System.Windows.Forms.ComboBox cmbTenKho;
        private DevExpress.XtraEditors.TextEdit txtMAKHO;
        private System.Windows.Forms.BindingSource bds_Kho;
        private DSTableAdapters.KhoTableAdapter khoTableAdapter;
        private System.Windows.Forms.BindingSource bds_VatTu;
        private DSTableAdapters.VattuTableAdapter vattuTableAdapter;
        private System.Windows.Forms.ComboBox cmbTenVT;
        private DevExpress.XtraEditors.TextEdit txtMAVT;
        private DevExpress.XtraEditors.TextEdit txtMANV;
        private DevExpress.XtraEditors.TextEdit txtMasoDDH;
        private System.Windows.Forms.Button btnChonDDH;
        private System.Windows.Forms.TextBox txtHOTEN;
        private System.Windows.Forms.Button btnChonCTDDH;
        private System.Windows.Forms.BindingSource bds_CT_DDH;
        private DSTableAdapters.CTDDHTableAdapter CTDDHTableAdapter;
    }
}