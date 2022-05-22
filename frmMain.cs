using DevExpress.XtraBars;
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
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ribbonStatusBar_Click(object sender, EventArgs e)
        {

        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }

        public Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            rib_DanhMuc.Visible = rib_BaoCao.Visible = rib_NghiepVu.Visible = false;
            btn_taotk.Enabled = btn_dangxuat.Enabled = false;
        }

        public void HienThiMenu()
        {
            MANV.Text = "Ma NV = " + Program.username;
            HOTEN.Text = "| Ho ten = " + Program.mHoten;
            NHOM.Text = "| Nhom = " + Program.mGroup;
            rib_BaoCao.Visible = rib_DanhMuc.Visible = rib_NghiepVu.Visible = true;
            btn_taotk.Enabled = btn_dangxuat.Enabled = true;
            DangNhap.Enabled = false;
            if (Program.mGroup == "NGANHANG")
                btn_motkchokh.Enabled = GD_ChuyenTien.Enabled 
                    = btn_ruttien.Enabled = btn_guitien.Enabled = false;
        }

        private void DangNhap_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmDangNhap));
            if (frm != null) frm.Activate();
            else
            {
                frmDangNhap f = new frmDangNhap();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btn_dangxuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (Form f in this.MdiChildren)
                f.Dispose();
            rib_DanhMuc.Visible = rib_BaoCao.Visible = rib_NghiepVu.Visible = false;
            btn_taotk.Enabled = btn_dangxuat.Enabled = false;
            DangNhap.Enabled = true;
            Program.frmChinh.MANV.Text = "MANV";
            Program.frmChinh.HOTEN.Text = "HOTEN";
            Program.frmChinh.NHOM.Text = "NHOM";
            MessageBox.Show("Đăng xuất thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_taotk_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(Form_TaoTK));
            if (frm != null)
                frm.Activate();
            else
            {
                Form_TaoTK f = new Form_TaoTK();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btn_nhanvien_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(Form_NV));
            if (frm != null)
                frm.Activate();
            else
            {
                Form_NV f = new Form_NV();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btn_khachhang_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(Form_KH));
            if (frm != null)
                frm.Activate();
            else
            {
                Form_KH f = new Form_KH();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void GD_GuiTien_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmGD_GuiTien));
            if (frm != null) frm.Activate();
            else
            {
                frmGD_GuiTien f = new frmGD_GuiTien();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void GD_RutTien_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmGD_RutTien));
            if (frm != null) frm.Activate();
            else
            {
                frmGD_RutTien f = new frmGD_RutTien();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void GD_ChuyenTien_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmGD_ChuyenTien));
            if (frm != null) frm.Activate();
            else
            {
                frmGD_ChuyenTien f = new frmGD_ChuyenTien();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btn_DSKH_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(Xrpt_Liet_Ke_KH));
            if (frm != null) frm.Activate();
            else
            {
                Xrpt_Liet_Ke_KH rpt = new Xrpt_Liet_Ke_KH();
                ReportPrintTool print = new ReportPrintTool(rpt);
                print.ShowPreviewDialog();
            }
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmGD_GuiTien));
            if (frm != null) frm.Activate();
            else
            {
                frmGD_GuiTien f = new frmGD_GuiTien();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmGD_RutTien));
            if (frm != null) frm.Activate();
            else
            {
                frmGD_RutTien f = new frmGD_RutTien();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(Form_MoTK));
            if (frm != null) frm.Activate();
            else
            {
                Form_MoTK f = new Form_MoTK();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem1_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(RP_dstk));
            if (frm != null) frm.Activate();
            else
            {
                RP_dstk f = new RP_dstk();
                f.MdiParent = this;
                f.Show();
            }
        }
    }
}