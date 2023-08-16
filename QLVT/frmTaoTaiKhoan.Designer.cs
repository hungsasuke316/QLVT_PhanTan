namespace QLVT
{
    partial class frmTaoTaiKhoan
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMANV = new DevExpress.XtraEditors.TextEdit();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.btnChonNV = new System.Windows.Forms.Button();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lblvaiTro = new System.Windows.Forms.Label();
            this.radioCHINHANH = new System.Windows.Forms.RadioButton();
            this.radioUSER = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtMANV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Nhân Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật Khẩu";
            // 
            // txtMANV
            // 
            this.txtMANV.Enabled = false;
            this.txtMANV.Location = new System.Drawing.Point(204, 66);
            this.txtMANV.Name = "txtMANV";
            this.txtMANV.Size = new System.Drawing.Size(125, 22);
            this.txtMANV.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(204, 127);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(125, 22);
            this.txtPassword.TabIndex = 3;
            // 
            // btnChonNV
            // 
            this.btnChonNV.Location = new System.Drawing.Point(386, 64);
            this.btnChonNV.Name = "btnChonNV";
            this.btnChonNV.Size = new System.Drawing.Size(152, 27);
            this.btnChonNV.TabIndex = 4;
            this.btnChonNV.Text = "Chọn Nhân Viên";
            this.btnChonNV.UseVisualStyleBackColor = true;
            this.btnChonNV.Click += new System.EventHandler(this.btnChonNV_Click);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Location = new System.Drawing.Point(140, 259);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(104, 27);
            this.btnXacNhan.TabIndex = 5;
            this.btnXacNhan.Text = "Xác Nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(386, 259);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(92, 27);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lblvaiTro
            // 
            this.lblvaiTro.AutoSize = true;
            this.lblvaiTro.Location = new System.Drawing.Point(89, 199);
            this.lblvaiTro.Name = "lblvaiTro";
            this.lblvaiTro.Size = new System.Drawing.Size(51, 16);
            this.lblvaiTro.TabIndex = 7;
            this.lblvaiTro.Text = "Vai Trò";
            // 
            // radioCHINHANH
            // 
            this.radioCHINHANH.AutoSize = true;
            this.radioCHINHANH.Location = new System.Drawing.Point(204, 195);
            this.radioCHINHANH.Name = "radioCHINHANH";
            this.radioCHINHANH.Size = new System.Drawing.Size(99, 20);
            this.radioCHINHANH.TabIndex = 8;
            this.radioCHINHANH.TabStop = true;
            this.radioCHINHANH.Text = "CHINHANH";
            this.radioCHINHANH.UseVisualStyleBackColor = true;
            // 
            // radioUSER
            // 
            this.radioUSER.AutoSize = true;
            this.radioUSER.Location = new System.Drawing.Point(373, 195);
            this.radioUSER.Name = "radioUSER";
            this.radioUSER.Size = new System.Drawing.Size(66, 20);
            this.radioUSER.TabIndex = 9;
            this.radioUSER.TabStop = true;
            this.radioUSER.Text = "USER";
            this.radioUSER.UseVisualStyleBackColor = true;
            // 
            // frmTaoTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radioUSER);
            this.Controls.Add(this.radioCHINHANH);
            this.Controls.Add(this.lblvaiTro);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.btnChonNV);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtMANV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmTaoTaiKhoan";
            this.Text = "frmTaoTaiKhoan";
            this.Load += new System.EventHandler(this.frmTaoTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtMANV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtMANV;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private System.Windows.Forms.Button btnChonNV;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lblvaiTro;
        private System.Windows.Forms.RadioButton radioCHINHANH;
        private System.Windows.Forms.RadioButton radioUSER;
    }
}