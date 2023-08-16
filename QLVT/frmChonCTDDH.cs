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
        public frmChonCTDDH()
        {
            InitializeComponent();
        }

        private void cTDDHBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bds_CT_DDH.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void frmChonCTDDH_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.CTDDH' table. You can move, or remove it, as needed.
            DS.EnforceConstraints = false;
            this.CTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.CTDDHTableAdapter.Fill(this.DS.CTDDH);

        }
    }
}
