using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace frmNhanVien
{
    public partial class Xrpt_Danh_sach_tai_khoan : DevExpress.XtraReports.UI.XtraReport
    {
        public Xrpt_Danh_sach_tai_khoan()
        {
            InitializeComponent();
        }
        public Xrpt_Danh_sach_tai_khoan(DateTime ngbd, DateTime ngkt) {
           
            this.NGANHANGConnectionString.Connection.ConnectionString = @"Data Source=LAPTOP-UEL9U0VQ\SERVER1;Initial Catalog=NGANHANG;Persist Security Info=True;User ID=sa;Password=123";
            this.NGANHANGConnectionString.Queries[0].Parameters[0].Value = ngbd;
            this.NGANHANGConnectionString.Queries[0].Parameters[1].Value = ngkt;

        }
    }
}
