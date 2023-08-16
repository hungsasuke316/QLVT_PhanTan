using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;

namespace QLVT
{
    public partial class frmInDanhSachNhanVien : Form
    {
        public frmInDanhSachNhanVien()
        {
            InitializeComponent();
        }

        private void nhanVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsNV.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void frmInDanhSachNhanVien_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.DS.NhanVien);            
            if (Program.mGroup == "CONGTY")
            {
                cmbChiNhanh.Text = "Chi Nhánh 1";
                cmbChiNhanh.Enabled = true;
            }
            if (Program.mGroup == "CHINHANH")
            {
                DataRow[] foundRows = this.DS.NhanVien.Select($"MANV = '{Program.username}'");
                if (foundRows.Length > 0)
                {
                    string MACN = foundRows[0]["MACN"].ToString().Trim();
                    if (MACN == "CN1")
                    {
                        cmbChiNhanh.Text = "Chi Nhánh 1";
                    }
                    if (MACN == "CN2")
                    {
                        cmbChiNhanh.Text = "Chi Nhánh 2";
                    }    
                }    
                cmbChiNhanh.Enabled = false;
            }    

        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            string maChiNhanh = "";
            if (cmbChiNhanh.SelectedIndex != -1)
            {
                string selectedValue = cmbChiNhanh.SelectedItem.ToString();
                if (selectedValue == "Chi Nhánh 1")
                {
                    maChiNhanh = "CN1";
                }
                else if (selectedValue == "Chi Nhánh 2")
                {
                    maChiNhanh = "CN2";
                }
            }
            Console.WriteLine(maChiNhanh);
            Xrpt_DanhSachNhanVien rpt = new Xrpt_DanhSachNhanVien(maChiNhanh);
            rpt.lblTieuDe.Text = "DANH SÁCH NHÂN VIÊN " + cmbChiNhanh.Text.ToUpper();

            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }

        private void cmbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
