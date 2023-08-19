using DevExpress.XtraReports.UI;
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
    public partial class frmInDonHangChuaPhieuNhap : Form
    {
        private SqlConnection conn_publisher = new SqlConnection();
        private string chiNhanh = "";
        public frmInDonHangChuaPhieuNhap()
        {
            InitializeComponent();
        }


        private void LayDSPM(String cmd)
        {
            DataTable dt = new DataTable();
            if (conn_publisher.State == ConnectionState.Closed) conn_publisher.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn_publisher);
            da.Fill(dt);
            conn_publisher.Close();
            Program.bds_dspm.DataSource = dt;
            cmbChiNhanh.DataSource = Program.bds_dspm;
            cmbChiNhanh.DisplayMember = "TENCN"; cmbChiNhanh.ValueMember = "TENSERVER";
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

        private void cmbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbChiNhanh.SelectedValue.ToString() == "System.Data.DataRowView")
                return;

            Program.servername = cmbChiNhanh.SelectedValue.ToString();
            Program.loginCurrent = Program.mlogin;
            Program.passwordCurrent = Program.password;

            if (cmbChiNhanh.SelectedIndex != Program.mChiNhanh)
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
                
            }
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

        private void frmInDonHangChuaPhieuNhap_Load(object sender, EventArgs e)
        {
            if (KetNoi_CSDLGOC() == 0) return;
            LayDSPM("SELECT * FROM Get_Subscribes");
            cmbChiNhanh.SelectedIndex = 1; cmbChiNhanh.SelectedIndex = 0;
        }
    }
}
