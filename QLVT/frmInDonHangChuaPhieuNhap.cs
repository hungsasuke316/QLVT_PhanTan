using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLVT
{
    public partial class frmInDonHangChuaPhieuNhap : Form
    {
        public frmInDonHangChuaPhieuNhap()
        {
            InitializeComponent();
        }

        private void cmbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Program.servername = cmbChiNhanh.SelectedValue.ToString();
            }
            catch (Exception) { }
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            Xrpt_DonHangChuaPhieuNhap rpt = new Xrpt_DonHangChuaPhieuNhap();
            rpt.lblTieuDe.Text = "ĐƠN HÀNG KHÔNG PHIẾU NHẬP " + cmbChiNhanh.Text.ToUpper();

            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
