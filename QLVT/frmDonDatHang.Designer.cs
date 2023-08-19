namespace QLVT
{
    partial class frmDonDatHang
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
            System.Windows.Forms.Label masoDDHLabel;
            System.Windows.Forms.Label nGAYLabel;
            System.Windows.Forms.Label nhaCCLabel;
            System.Windows.Forms.Label mAKHOLabel;
            System.Windows.Forms.Label sOLUONGLabel;
            System.Windows.Forms.Label dONGIALabel;
            System.Windows.Forms.Label masoDDHLabel1;
            System.Windows.Forms.Label mAVTLabel;
            System.Windows.Forms.Label mANVLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDonDatHang));
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cbbChiNhanh = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DS = new QLVT.DS();
            this.bds_DDH = new System.Windows.Forms.BindingSource(this.components);
            this.datHangTableAdapter = new QLVT.DSTableAdapters.DatHangTableAdapter();
            this.tableAdapterManager = new QLVT.DSTableAdapters.TableAdapterManager();
            this.CTDDHTableAdapter = new QLVT.DSTableAdapters.CTDDHTableAdapter();
            this.gcDonDatHang = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMasoDDH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNhaCC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelNhapDDH = new DevExpress.XtraEditors.PanelControl();
            this.txtHOTEN = new System.Windows.Forms.TextBox();
            this.txtMANV = new DevExpress.XtraEditors.TextEdit();
            this.cmbTenKho = new System.Windows.Forms.ComboBox();
            this.bds_Kho = new System.Windows.Forms.BindingSource(this.components);
            this.txtMAKHO = new DevExpress.XtraEditors.TextEdit();
            this.txtNhaCC = new DevExpress.XtraEditors.TextEdit();
            this.deNGAY = new DevExpress.XtraEditors.DateEdit();
            this.txtMaSoDDH = new DevExpress.XtraEditors.TextEdit();
            this.bds_CT_DDH = new System.Windows.Forms.BindingSource(this.components);
            this.gcCT_DDH = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMasoDDH1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDONGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextThem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.bds_VT = new System.Windows.Forms.BindingSource(this.components);
            this.bds_PN = new System.Windows.Forms.BindingSource(this.components);
            this.phieuNhapTableAdapter = new QLVT.DSTableAdapters.PhieuNhapTableAdapter();
            this.khoTableAdapter = new QLVT.DSTableAdapters.KhoTableAdapter();
            this.vattuTableAdapter = new QLVT.DSTableAdapters.VattuTableAdapter();
            this.txtSoLuong = new DevExpress.XtraEditors.TextEdit();
            this.txtDonGia = new DevExpress.XtraEditors.TextEdit();
            this.txtMaSoDDH_CTDDH = new DevExpress.XtraEditors.TextEdit();
            this.panelNhapCTDH = new DevExpress.XtraEditors.PanelControl();
            this.cmbTenVT = new System.Windows.Forms.ComboBox();
            this.txtMAVT = new DevExpress.XtraEditors.TextEdit();
            this.bdsNV = new System.Windows.Forms.BindingSource(this.components);
            this.nhanVienTableAdapter = new QLVT.DSTableAdapters.NhanVienTableAdapter();
            this.bds_CTPN = new System.Windows.Forms.BindingSource(this.components);
            this.CTPNTableAdapter = new QLVT.DSTableAdapters.CTPNTableAdapter();
            masoDDHLabel = new System.Windows.Forms.Label();
            nGAYLabel = new System.Windows.Forms.Label();
            nhaCCLabel = new System.Windows.Forms.Label();
            mAKHOLabel = new System.Windows.Forms.Label();
            sOLUONGLabel = new System.Windows.Forms.Label();
            dONGIALabel = new System.Windows.Forms.Label();
            masoDDHLabel1 = new System.Windows.Forms.Label();
            mAVTLabel = new System.Windows.Forms.Label();
            mANVLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_DDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDonDatHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelNhapDDH)).BeginInit();
            this.panelNhapDDH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMANV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_Kho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMAKHO.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNhaCC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNGAY.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNGAY.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSoDDH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_CT_DDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCT_DDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bds_VT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_PN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonGia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSoDDH_CTDDH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelNhapCTDH)).BeginInit();
            this.panelNhapCTDH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMAVT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_CTPN)).BeginInit();
            this.SuspendLayout();
            // 
            // masoDDHLabel
            // 
            masoDDHLabel.AutoSize = true;
            masoDDHLabel.Location = new System.Drawing.Point(32, 24);
            masoDDHLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            masoDDHLabel.Name = "masoDDHLabel";
            masoDDHLabel.Size = new System.Drawing.Size(57, 16);
            masoDDHLabel.TabIndex = 0;
            masoDDHLabel.Text = "Mã DDH:";
            // 
            // nGAYLabel
            // 
            nGAYLabel.AutoSize = true;
            nGAYLabel.Location = new System.Drawing.Point(32, 68);
            nGAYLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nGAYLabel.Name = "nGAYLabel";
            nGAYLabel.Size = new System.Drawing.Size(62, 16);
            nGAYLabel.TabIndex = 2;
            nGAYLabel.Text = "Ngày đặt:";
            // 
            // nhaCCLabel
            // 
            nhaCCLabel.AutoSize = true;
            nhaCCLabel.Location = new System.Drawing.Point(30, 112);
            nhaCCLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nhaCCLabel.Name = "nhaCCLabel";
            nhaCCLabel.Size = new System.Drawing.Size(89, 16);
            nhaCCLabel.TabIndex = 4;
            nhaCCLabel.Text = "Nhà cung cấp:";
            // 
            // mAKHOLabel
            // 
            mAKHOLabel.AutoSize = true;
            mAKHOLabel.Location = new System.Drawing.Point(33, 189);
            mAKHOLabel.Name = "mAKHOLabel";
            mAKHOLabel.Size = new System.Drawing.Size(33, 16);
            mAKHOLabel.TabIndex = 9;
            mAKHOLabel.Text = "Kho:";
            // 
            // sOLUONGLabel
            // 
            sOLUONGLabel.AutoSize = true;
            sOLUONGLabel.Location = new System.Drawing.Point(28, 63);
            sOLUONGLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            sOLUONGLabel.Name = "sOLUONGLabel";
            sOLUONGLabel.Size = new System.Drawing.Size(63, 16);
            sOLUONGLabel.TabIndex = 2;
            sOLUONGLabel.Text = "Số lượng:";
            // 
            // dONGIALabel
            // 
            dONGIALabel.AutoSize = true;
            dONGIALabel.Location = new System.Drawing.Point(334, 63);
            dONGIALabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dONGIALabel.Name = "dONGIALabel";
            dONGIALabel.Size = new System.Drawing.Size(56, 16);
            dONGIALabel.TabIndex = 4;
            dONGIALabel.Text = "Đơn giá:";
            // 
            // masoDDHLabel1
            // 
            masoDDHLabel1.AutoSize = true;
            masoDDHLabel1.Enabled = false;
            masoDDHLabel1.Location = new System.Drawing.Point(26, 18);
            masoDDHLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            masoDDHLabel1.Name = "masoDDHLabel1";
            masoDDHLabel1.Size = new System.Drawing.Size(57, 16);
            masoDDHLabel1.TabIndex = 6;
            masoDDHLabel1.Text = "Mã DDH:";
            // 
            // mAVTLabel
            // 
            mAVTLabel.AutoSize = true;
            mAVTLabel.Location = new System.Drawing.Point(335, 18);
            mAVTLabel.Name = "mAVTLabel";
            mAVTLabel.Size = new System.Drawing.Size(47, 16);
            mAVTLabel.TabIndex = 7;
            mAVTLabel.Text = "Vật tư:";
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Location = new System.Drawing.Point(33, 147);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(70, 16);
            mANVLabel.TabIndex = 11;
            mANVLabel.Text = "Nhân Viên:";
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
            this.barDockControlTop.Size = new System.Drawing.Size(1265, 51);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 635);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1265, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 51);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 584);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1265, 51);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 584);
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
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cbbChiNhanh);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 51);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(24);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1265, 68);
            this.panelControl1.TabIndex = 5;
            // 
            // cbbChiNhanh
            // 
            this.cbbChiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbChiNhanh.Enabled = false;
            this.cbbChiNhanh.FormattingEnabled = true;
            this.cbbChiNhanh.Location = new System.Drawing.Point(324, 22);
            this.cbbChiNhanh.Margin = new System.Windows.Forms.Padding(19);
            this.cbbChiNhanh.Name = "cbbChiNhanh";
            this.cbbChiNhanh.Size = new System.Drawing.Size(487, 24);
            this.cbbChiNhanh.TabIndex = 1;
            this.cbbChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cbbChiNhanh_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(19, 0, 19, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chi Nhánh";
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bds_DDH
            // 
            this.bds_DDH.DataMember = "DatHang";
            this.bds_DDH.DataSource = this.DS;
            // 
            // datHangTableAdapter
            // 
            this.datHangTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.CTDDHTableAdapter = this.CTDDHTableAdapter;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = this.datHangTableAdapter;
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVT.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // CTDDHTableAdapter
            // 
            this.CTDDHTableAdapter.ClearBeforeFill = true;
            // 
            // gcDonDatHang
            // 
            this.gcDonDatHang.DataSource = this.bds_DDH;
            this.gcDonDatHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcDonDatHang.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gcDonDatHang.Location = new System.Drawing.Point(0, 119);
            this.gcDonDatHang.MainView = this.gridView1;
            this.gcDonDatHang.Margin = new System.Windows.Forms.Padding(4);
            this.gcDonDatHang.MenuManager = this.barManager1;
            this.gcDonDatHang.Name = "gcDonDatHang";
            this.gcDonDatHang.Size = new System.Drawing.Size(1265, 226);
            this.gcDonDatHang.TabIndex = 6;
            this.gcDonDatHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gcDonDatHang.Click += new System.EventHandler(this.datHangGridControl_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMasoDDH,
            this.colNGAY,
            this.colNhaCC,
            this.colMANV,
            this.colMAKHO});
            this.gridView1.DetailHeight = 437;
            this.gridView1.GridControl = this.gcDonDatHang;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsEditForm.PopupEditFormWidth = 1000;
            // 
            // colMasoDDH
            // 
            this.colMasoDDH.FieldName = "MasoDDH";
            this.colMasoDDH.MinWidth = 31;
            this.colMasoDDH.Name = "colMasoDDH";
            this.colMasoDDH.OptionsColumn.ReadOnly = true;
            this.colMasoDDH.Visible = true;
            this.colMasoDDH.VisibleIndex = 0;
            this.colMasoDDH.Width = 117;
            // 
            // colNGAY
            // 
            this.colNGAY.DisplayFormat.FormatString = "dd-MM-yyyy";
            this.colNGAY.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colNGAY.FieldName = "NGAY";
            this.colNGAY.MinWidth = 31;
            this.colNGAY.Name = "colNGAY";
            this.colNGAY.OptionsColumn.ReadOnly = true;
            this.colNGAY.Visible = true;
            this.colNGAY.VisibleIndex = 1;
            this.colNGAY.Width = 117;
            // 
            // colNhaCC
            // 
            this.colNhaCC.FieldName = "NhaCC";
            this.colNhaCC.MinWidth = 31;
            this.colNhaCC.Name = "colNhaCC";
            this.colNhaCC.OptionsColumn.ReadOnly = true;
            this.colNhaCC.Visible = true;
            this.colNhaCC.VisibleIndex = 2;
            this.colNhaCC.Width = 117;
            // 
            // colMANV
            // 
            this.colMANV.FieldName = "MANV";
            this.colMANV.MinWidth = 31;
            this.colMANV.Name = "colMANV";
            this.colMANV.OptionsColumn.ReadOnly = true;
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 3;
            this.colMANV.Width = 117;
            // 
            // colMAKHO
            // 
            this.colMAKHO.FieldName = "MAKHO";
            this.colMAKHO.MinWidth = 31;
            this.colMAKHO.Name = "colMAKHO";
            this.colMAKHO.OptionsColumn.ReadOnly = true;
            this.colMAKHO.Visible = true;
            this.colMAKHO.VisibleIndex = 4;
            this.colMAKHO.Width = 117;
            // 
            // panelNhapDDH
            // 
            this.panelNhapDDH.Controls.Add(this.txtHOTEN);
            this.panelNhapDDH.Controls.Add(mANVLabel);
            this.panelNhapDDH.Controls.Add(this.txtMANV);
            this.panelNhapDDH.Controls.Add(this.cmbTenKho);
            this.panelNhapDDH.Controls.Add(mAKHOLabel);
            this.panelNhapDDH.Controls.Add(this.txtMAKHO);
            this.panelNhapDDH.Controls.Add(nhaCCLabel);
            this.panelNhapDDH.Controls.Add(this.txtNhaCC);
            this.panelNhapDDH.Controls.Add(nGAYLabel);
            this.panelNhapDDH.Controls.Add(this.deNGAY);
            this.panelNhapDDH.Controls.Add(masoDDHLabel);
            this.panelNhapDDH.Controls.Add(this.txtMaSoDDH);
            this.panelNhapDDH.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelNhapDDH.Location = new System.Drawing.Point(0, 345);
            this.panelNhapDDH.Margin = new System.Windows.Forms.Padding(4);
            this.panelNhapDDH.Name = "panelNhapDDH";
            this.panelNhapDDH.Size = new System.Drawing.Size(504, 290);
            this.panelNhapDDH.TabIndex = 7;
            // 
            // txtHOTEN
            // 
            this.txtHOTEN.Enabled = false;
            this.txtHOTEN.Location = new System.Drawing.Point(203, 143);
            this.txtHOTEN.Name = "txtHOTEN";
            this.txtHOTEN.Size = new System.Drawing.Size(163, 23);
            this.txtHOTEN.TabIndex = 13;
            // 
            // txtMANV
            // 
            this.txtMANV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bds_DDH, "MANV", true));
            this.txtMANV.Enabled = false;
            this.txtMANV.Location = new System.Drawing.Point(127, 144);
            this.txtMANV.MenuManager = this.barManager1;
            this.txtMANV.Name = "txtMANV";
            this.txtMANV.Size = new System.Drawing.Size(59, 22);
            this.txtMANV.TabIndex = 12;
            this.txtMANV.EditValueChanged += new System.EventHandler(this.txtMANV_EditValueChanged);
            // 
            // cmbTenKho
            // 
            this.cmbTenKho.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bds_DDH, "MAKHO", true));
            this.cmbTenKho.DataSource = this.bds_Kho;
            this.cmbTenKho.DisplayMember = "TENKHO";
            this.cmbTenKho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTenKho.FormattingEnabled = true;
            this.cmbTenKho.Location = new System.Drawing.Point(245, 184);
            this.cmbTenKho.Name = "cmbTenKho";
            this.cmbTenKho.Size = new System.Drawing.Size(121, 24);
            this.cmbTenKho.TabIndex = 11;
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
            this.txtMAKHO.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bds_DDH, "MAKHO", true));
            this.txtMAKHO.Enabled = false;
            this.txtMAKHO.Location = new System.Drawing.Point(126, 186);
            this.txtMAKHO.MenuManager = this.barManager1;
            this.txtMAKHO.Name = "txtMAKHO";
            this.txtMAKHO.Size = new System.Drawing.Size(92, 22);
            this.txtMAKHO.TabIndex = 10;
            // 
            // txtNhaCC
            // 
            this.txtNhaCC.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_DDH, "NhaCC", true));
            this.txtNhaCC.Location = new System.Drawing.Point(127, 109);
            this.txtNhaCC.Margin = new System.Windows.Forms.Padding(4);
            this.txtNhaCC.MenuManager = this.barManager1;
            this.txtNhaCC.Name = "txtNhaCC";
            this.txtNhaCC.Size = new System.Drawing.Size(156, 22);
            this.txtNhaCC.TabIndex = 5;
            this.txtNhaCC.EditValueChanged += new System.EventHandler(this.txtNhaCC_EditValueChanged);
            // 
            // deNGAY
            // 
            this.deNGAY.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_DDH, "NGAY", true));
            this.deNGAY.EditValue = null;
            this.deNGAY.Enabled = false;
            this.deNGAY.Location = new System.Drawing.Point(127, 66);
            this.deNGAY.Margin = new System.Windows.Forms.Padding(4);
            this.deNGAY.MenuManager = this.barManager1;
            this.deNGAY.Name = "deNGAY";
            this.deNGAY.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deNGAY.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deNGAY.Properties.DisplayFormat.FormatString = "dd-MM-yyyy";
            this.deNGAY.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.deNGAY.Size = new System.Drawing.Size(156, 22);
            this.deNGAY.TabIndex = 3;
            // 
            // txtMaSoDDH
            // 
            this.txtMaSoDDH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_DDH, "MasoDDH", true));
            this.txtMaSoDDH.Location = new System.Drawing.Point(127, 21);
            this.txtMaSoDDH.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaSoDDH.MenuManager = this.barManager1;
            this.txtMaSoDDH.Name = "txtMaSoDDH";
            this.txtMaSoDDH.Size = new System.Drawing.Size(139, 22);
            this.txtMaSoDDH.TabIndex = 1;
            // 
            // bds_CT_DDH
            // 
            this.bds_CT_DDH.DataMember = "FK_CTDDH_DatHang";
            this.bds_CT_DDH.DataSource = this.bds_DDH;
            // 
            // gcCT_DDH
            // 
            this.gcCT_DDH.DataSource = this.bds_CT_DDH;
            this.gcCT_DDH.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcCT_DDH.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gcCT_DDH.Location = new System.Drawing.Point(504, 345);
            this.gcCT_DDH.MainView = this.gridView2;
            this.gcCT_DDH.Margin = new System.Windows.Forms.Padding(4);
            this.gcCT_DDH.MenuManager = this.barManager1;
            this.gcCT_DDH.Name = "gcCT_DDH";
            this.gcCT_DDH.Size = new System.Drawing.Size(761, 166);
            this.gcCT_DDH.TabIndex = 7;
            this.gcCT_DDH.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMasoDDH1,
            this.colMAVT,
            this.colSOLUONG,
            this.colDONGIA});
            this.gridView2.DetailHeight = 437;
            this.gridView2.GridControl = this.gcCT_DDH;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsEditForm.PopupEditFormWidth = 1000;
            // 
            // colMasoDDH1
            // 
            this.colMasoDDH1.FieldName = "MasoDDH";
            this.colMasoDDH1.MinWidth = 31;
            this.colMasoDDH1.Name = "colMasoDDH1";
            this.colMasoDDH1.OptionsColumn.ReadOnly = true;
            this.colMasoDDH1.Visible = true;
            this.colMasoDDH1.VisibleIndex = 0;
            this.colMasoDDH1.Width = 117;
            // 
            // colMAVT
            // 
            this.colMAVT.FieldName = "MAVT";
            this.colMAVT.MinWidth = 31;
            this.colMAVT.Name = "colMAVT";
            this.colMAVT.OptionsColumn.ReadOnly = true;
            this.colMAVT.Visible = true;
            this.colMAVT.VisibleIndex = 1;
            this.colMAVT.Width = 117;
            // 
            // colSOLUONG
            // 
            this.colSOLUONG.FieldName = "SOLUONG";
            this.colSOLUONG.MinWidth = 31;
            this.colSOLUONG.Name = "colSOLUONG";
            this.colSOLUONG.OptionsColumn.ReadOnly = true;
            this.colSOLUONG.Visible = true;
            this.colSOLUONG.VisibleIndex = 2;
            this.colSOLUONG.Width = 117;
            // 
            // colDONGIA
            // 
            this.colDONGIA.FieldName = "DONGIA";
            this.colDONGIA.MinWidth = 31;
            this.colDONGIA.Name = "colDONGIA";
            this.colDONGIA.OptionsColumn.ReadOnly = true;
            this.colDONGIA.Visible = true;
            this.colDONGIA.VisibleIndex = 3;
            this.colDONGIA.Width = 117;
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
            // bds_VT
            // 
            this.bds_VT.DataMember = "Vattu";
            this.bds_VT.DataSource = this.DS;
            // 
            // bds_PN
            // 
            this.bds_PN.DataMember = "FK_PhieuNhap_DatHang";
            this.bds_PN.DataSource = this.bds_DDH;
            // 
            // phieuNhapTableAdapter
            // 
            this.phieuNhapTableAdapter.ClearBeforeFill = true;
            // 
            // khoTableAdapter
            // 
            this.khoTableAdapter.ClearBeforeFill = true;
            // 
            // vattuTableAdapter
            // 
            this.vattuTableAdapter.ClearBeforeFill = true;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_CT_DDH, "SOLUONG", true));
            this.txtSoLuong.Location = new System.Drawing.Point(120, 60);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoLuong.MenuManager = this.barManager1;
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Properties.DisplayFormat.FormatString = "n0";
            this.txtSoLuong.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtSoLuong.Size = new System.Drawing.Size(156, 22);
            this.txtSoLuong.TabIndex = 3;
            // 
            // txtDonGia
            // 
            this.txtDonGia.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_CT_DDH, "DONGIA", true));
            this.txtDonGia.Location = new System.Drawing.Point(413, 60);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(4);
            this.txtDonGia.MenuManager = this.barManager1;
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Properties.DisplayFormat.FormatString = "n0";
            this.txtDonGia.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtDonGia.Size = new System.Drawing.Size(182, 22);
            this.txtDonGia.TabIndex = 5;
            this.txtDonGia.EditValueChanged += new System.EventHandler(this.txtDonGia_EditValueChanged);
            // 
            // txtMaSoDDH_CTDDH
            // 
            this.txtMaSoDDH_CTDDH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_CT_DDH, "MasoDDH", true));
            this.txtMaSoDDH_CTDDH.Enabled = false;
            this.txtMaSoDDH_CTDDH.Location = new System.Drawing.Point(121, 14);
            this.txtMaSoDDH_CTDDH.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaSoDDH_CTDDH.MenuManager = this.barManager1;
            this.txtMaSoDDH_CTDDH.Name = "txtMaSoDDH_CTDDH";
            this.txtMaSoDDH_CTDDH.Size = new System.Drawing.Size(156, 22);
            this.txtMaSoDDH_CTDDH.TabIndex = 7;
            // 
            // panelNhapCTDH
            // 
            this.panelNhapCTDH.Controls.Add(this.cmbTenVT);
            this.panelNhapCTDH.Controls.Add(mAVTLabel);
            this.panelNhapCTDH.Controls.Add(this.txtMAVT);
            this.panelNhapCTDH.Controls.Add(masoDDHLabel1);
            this.panelNhapCTDH.Controls.Add(this.txtMaSoDDH_CTDDH);
            this.panelNhapCTDH.Controls.Add(dONGIALabel);
            this.panelNhapCTDH.Controls.Add(this.txtDonGia);
            this.panelNhapCTDH.Controls.Add(sOLUONGLabel);
            this.panelNhapCTDH.Controls.Add(this.txtSoLuong);
            this.panelNhapCTDH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNhapCTDH.Location = new System.Drawing.Point(504, 511);
            this.panelNhapCTDH.Margin = new System.Windows.Forms.Padding(4);
            this.panelNhapCTDH.Name = "panelNhapCTDH";
            this.panelNhapCTDH.Size = new System.Drawing.Size(761, 124);
            this.panelNhapCTDH.TabIndex = 12;
            // 
            // cmbTenVT
            // 
            this.cmbTenVT.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bds_CT_DDH, "MAVT", true));
            this.cmbTenVT.DataSource = this.bds_VT;
            this.cmbTenVT.DisplayMember = "TENVT";
            this.cmbTenVT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTenVT.FormattingEnabled = true;
            this.cmbTenVT.Location = new System.Drawing.Point(502, 12);
            this.cmbTenVT.Name = "cmbTenVT";
            this.cmbTenVT.Size = new System.Drawing.Size(121, 24);
            this.cmbTenVT.TabIndex = 9;
            this.cmbTenVT.ValueMember = "MAVT";
            this.cmbTenVT.SelectedIndexChanged += new System.EventHandler(this.cmbTenVT_SelectedIndexChanged);
            // 
            // txtMAVT
            // 
            this.txtMAVT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bds_CT_DDH, "MAVT", true));
            this.txtMAVT.Enabled = false;
            this.txtMAVT.Location = new System.Drawing.Point(412, 15);
            this.txtMAVT.MenuManager = this.barManager1;
            this.txtMAVT.Name = "txtMAVT";
            this.txtMAVT.Size = new System.Drawing.Size(75, 22);
            this.txtMAVT.TabIndex = 8;
            this.txtMAVT.EditValueChanged += new System.EventHandler(this.txtMAVT_EditValueChanged);
            // 
            // bdsNV
            // 
            this.bdsNV.DataMember = "NhanVien";
            this.bdsNV.DataSource = this.DS;
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // bds_CTPN
            // 
            this.bds_CTPN.DataMember = "FK_CTPN_PhieuNhap";
            this.bds_CTPN.DataSource = this.bds_PN;
            // 
            // CTPNTableAdapter
            // 
            this.CTPNTableAdapter.ClearBeforeFill = true;
            // 
            // frmDonDatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 635);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.panelNhapCTDH);
            this.Controls.Add(this.gcCT_DDH);
            this.Controls.Add(this.panelNhapDDH);
            this.Controls.Add(this.gcDonDatHang);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmDonDatHang";
            this.Text = "frmDonDatHang";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDonDatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_DDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDonDatHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelNhapDDH)).EndInit();
            this.panelNhapDDH.ResumeLayout(false);
            this.panelNhapDDH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMANV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_Kho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMAKHO.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNhaCC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNGAY.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNGAY.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSoDDH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_CT_DDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCT_DDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bds_VT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_PN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonGia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSoDDH_CTDDH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelNhapCTDH)).EndInit();
            this.panelNhapCTDH.ResumeLayout(false);
            this.panelNhapCTDH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMAVT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_CTPN)).EndInit();
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
        private System.Windows.Forms.BindingSource bds_DDH;
        private DS DS;
        private DSTableAdapters.DatHangTableAdapter datHangTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcDonDatHang;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMasoDDH;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAY;
        private DevExpress.XtraGrid.Columns.GridColumn colNhaCC;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHO;
        private DevExpress.XtraEditors.PanelControl panelNhapDDH;
        private DSTableAdapters.CTDDHTableAdapter CTDDHTableAdapter;
        private System.Windows.Forms.BindingSource bds_CT_DDH;
        private DevExpress.XtraGrid.GridControl gcCT_DDH;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colMasoDDH1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAVT;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONG;
        private DevExpress.XtraGrid.Columns.GridColumn colDONGIA;
        private DevExpress.XtraEditors.TextEdit txtNhaCC;
        private DevExpress.XtraEditors.DateEdit deNGAY;
        private DevExpress.XtraEditors.TextEdit txtMaSoDDH;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem contextThem;
        private System.Windows.Forms.ToolStripMenuItem contextXoa;
        private System.Windows.Forms.BindingSource bds_PN;
        private DSTableAdapters.PhieuNhapTableAdapter phieuNhapTableAdapter;
        private System.Windows.Forms.BindingSource bds_Kho;
        private DSTableAdapters.KhoTableAdapter khoTableAdapter;
        private System.Windows.Forms.BindingSource bds_VT;
        private DSTableAdapters.VattuTableAdapter vattuTableAdapter;
        private System.Windows.Forms.ComboBox cmbTenKho;
        private DevExpress.XtraEditors.TextEdit txtMAKHO;
        private DevExpress.XtraEditors.PanelControl panelNhapCTDH;
        private System.Windows.Forms.ComboBox cmbTenVT;
        private DevExpress.XtraEditors.TextEdit txtMAVT;
        private DevExpress.XtraEditors.TextEdit txtMaSoDDH_CTDDH;
        private DevExpress.XtraEditors.TextEdit txtDonGia;
        private DevExpress.XtraEditors.TextEdit txtSoLuong;
        private System.Windows.Forms.TextBox txtHOTEN;
        private DevExpress.XtraEditors.TextEdit txtMANV;
        private System.Windows.Forms.BindingSource bdsNV;
        private DSTableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
        private System.Windows.Forms.BindingSource bds_CTPN;
        private DSTableAdapters.CTPNTableAdapter CTPNTableAdapter;
    }
}