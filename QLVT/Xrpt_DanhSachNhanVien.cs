using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLVT
{
    public partial class Xrpt_DanhSachNhanVien : DevExpress.XtraReports.UI.XtraReport
    {
        public Xrpt_DanhSachNhanVien(String maChiNhanh)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = "Data Source=DESKTOP-JJGC4CI;Initial Catalog=QLVT;User ID=sa;Password=123";
            this.sqlDataSource1.Queries[0].Parameters[0].Value = maChiNhanh;            
            this.sqlDataSource1.Fill();

        }

    }
}
