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

namespace frmNhanVien
{
    public partial class RP_dstk : Form
    {
        public RP_dstk()
        {
            InitializeComponent();
        }
        DateTime ngaybd;
        DateTime ngaykt;

        private void RP_dstk_Load(object sender, EventArgs e)
        {
            ngaybd = date_bd.Value;
            ngaykt = date_kt.Value;
        }

        private void btn_priview_Click(object sender, EventArgs e)
        {
            Xrpt_Danh_sach_tai_khoan rpt = new Xrpt_Danh_sach_tai_khoan(ngaybd,ngaykt);
            rpt.lb_nbd.Value = date_bd.Value;
            rpt.lb_nkt.Value = date_kt.Value;
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();

        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
