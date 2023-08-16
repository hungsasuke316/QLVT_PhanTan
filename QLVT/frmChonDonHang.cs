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
    public partial class frmChonDonHang : Form
    {
        public frmChonDonHang()
        {
            InitializeComponent();
        }

        private void datHangBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bds_DDH.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void frmChonDonHang_Load(object sender, EventArgs e)
        {
            
            
            DS.EnforceConstraints = false;

            this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.datHangTableAdapter.Fill(this.DS.DatHang);

            this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
            this.khoTableAdapter.Fill(this.DS.Kho);

        }

        

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            DataRowView drv = ((DataRowView)(bds_DDH.Current));
            //string maNhanVien = drv["MANV"].ToString().Trim();

            string maKho = drv["MAKHO"].ToString().Trim();
            string masoDDH = drv["MasoDDH"].ToString().Trim();

            DataView khoDataView = (DataView)bds_Kho.List;
            khoDataView.RowFilter = $"MAKHO = '{maKho}'";

            
            if (khoDataView.Count > 0)
            {
                
                Program.chonTenKho = khoDataView[0]["TenKho"].ToString();
                
            }
            else
            {
                MessageBox.Show("Không tìm thấy tên kho với mã kho hiện tại", "Thông báo", MessageBoxButtons.OK);
            }
            
            Program.chonMAKHO = maKho;
            Program.chonMasoDDH = masoDDH;

            this.Close();
        }
    }
}
