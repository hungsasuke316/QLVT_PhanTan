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
    public partial class frmChonCTDDH : Form
    {
        private DataTable selectedDataTable;
        public frmChonCTDDH(DataTable dataTable)
        {
            InitializeComponent();
            selectedDataTable = dataTable;
        }

        

        private void frmChonCTDDH_Load(object sender, EventArgs e)
        {
                        
            DS.EnforceConstraints = false;

            this.vattuTableAdapter.Connection.ConnectionString = Program.connstr;
            this.vattuTableAdapter.Fill(this.DS.Vattu);

            gcChonCTDDH.DataSource = selectedDataTable;
                        
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            foreach (DataRow drv in selectedDataTable.Rows)
            {
                string soLuong = drv["SOLUONG"].ToString().Trim();
                string donGia = drv["DONGIA"].ToString().Trim();
                string maVT = drv["MAVT"].ToString().Trim();

                DataView vatTuDataView = (DataView)bds_Vattu.List;
                vatTuDataView.RowFilter = $"MAVT = '{maVT}'";

                if (vatTuDataView.Count > 0)
                {
                    Program.chonTenVT = vatTuDataView[0]["TENVT"].ToString();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy tên vật tư với mã vật tư hiện tại", "Thông báo", MessageBoxButtons.OK);
                }

                Program.chonMAVT = maVT;
                Program.chonSoLuong = soLuong;
                Program.chonDonGia = donGia;
                this.Close();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
