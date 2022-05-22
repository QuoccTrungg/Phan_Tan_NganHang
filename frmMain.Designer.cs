
namespace frmNhanVien
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.DangNhap = new DevExpress.XtraBars.BarButtonItem();
            this.btn_taotk = new DevExpress.XtraBars.BarButtonItem();
            this.btn_dangxuat = new DevExpress.XtraBars.BarButtonItem();
            this.GD_ChuyenTien = new DevExpress.XtraBars.BarButtonItem();
            this.btn_nhanvien = new DevExpress.XtraBars.BarButtonItem();
            this.btn_khachhang = new DevExpress.XtraBars.BarButtonItem();
            this.btn_DSKH = new DevExpress.XtraBars.BarButtonItem();
            this.btn_ruttien = new DevExpress.XtraBars.BarButtonItem();
            this.btn_guitien = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.btn_motkchokh = new DevExpress.XtraBars.BarButtonItem();
            this.HeThong = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rib_DanhMuc = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rib_NghiepVu = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btn_rutien = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btn_motk = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rib_BaoCao = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btn_dstk = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btn_saokegd = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.MANV = new System.Windows.Forms.ToolStripStatusLabel();
            this.HOTEN = new System.Windows.Forms.ToolStripStatusLabel();
            this.NHOM = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.DangNhap,
            this.btn_taotk,
            this.btn_dangxuat,
            this.GD_ChuyenTien,
            this.btn_nhanvien,
            this.btn_khachhang,
            this.btn_DSKH,
            this.btn_ruttien,
            this.btn_guitien,
            this.barButtonItem1,
            this.barButtonItem2,
            this.btn_motkchokh});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 22;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.HeThong,
            this.rib_DanhMuc,
            this.rib_NghiepVu,
            this.rib_BaoCao});
            this.ribbon.Size = new System.Drawing.Size(1300, 193);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.Click += new System.EventHandler(this.ribbon_Click);
            // 
            // DangNhap
            // 
            this.DangNhap.Caption = "Đăng Nhập";
            this.DangNhap.Id = 1;
            this.DangNhap.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("DangNhap.ImageOptions.SvgImage")));
            this.DangNhap.Name = "DangNhap";
            this.DangNhap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.DangNhap_ItemClick);
            // 
            // btn_taotk
            // 
            this.btn_taotk.Caption = "Tạo TK";
            this.btn_taotk.Enabled = false;
            this.btn_taotk.Id = 2;
            this.btn_taotk.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_taotk.ImageOptions.SvgImage")));
            this.btn_taotk.Name = "btn_taotk";
            this.btn_taotk.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_taotk_ItemClick);
            // 
            // btn_dangxuat
            // 
            this.btn_dangxuat.Caption = "Đăng Xuất";
            this.btn_dangxuat.Id = 3;
            this.btn_dangxuat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_dangxuat.ImageOptions.Image")));
            this.btn_dangxuat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_dangxuat.ImageOptions.LargeImage")));
            this.btn_dangxuat.Name = "btn_dangxuat";
            this.btn_dangxuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_dangxuat_ItemClick);
            // 
            // GD_ChuyenTien
            // 
            this.GD_ChuyenTien.Caption = "Chuyển Tiền";
            this.GD_ChuyenTien.Id = 6;
            this.GD_ChuyenTien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("GD_ChuyenTien.ImageOptions.Image")));
            this.GD_ChuyenTien.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("GD_ChuyenTien.ImageOptions.LargeImage")));
            this.GD_ChuyenTien.Name = "GD_ChuyenTien";
            this.GD_ChuyenTien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.GD_ChuyenTien_ItemClick);
            // 
            // btn_nhanvien
            // 
            this.btn_nhanvien.Caption = "Nhân viên";
            this.btn_nhanvien.Id = 14;
            this.btn_nhanvien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_nhanvien.ImageOptions.Image")));
            this.btn_nhanvien.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_nhanvien.ImageOptions.LargeImage")));
            this.btn_nhanvien.Name = "btn_nhanvien";
            this.btn_nhanvien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_nhanvien_ItemClick);
            // 
            // btn_khachhang
            // 
            this.btn_khachhang.Caption = "Khách hàng";
            this.btn_khachhang.Id = 15;
            this.btn_khachhang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_khachhang.ImageOptions.Image")));
            this.btn_khachhang.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_khachhang.ImageOptions.LargeImage")));
            this.btn_khachhang.Name = "btn_khachhang";
            this.btn_khachhang.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_khachhang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_khachhang_ItemClick);
            // 
            // btn_DSKH
            // 
            this.btn_DSKH.Caption = "Danh sách khách hàng\r\n";
            this.btn_DSKH.Id = 16;
            this.btn_DSKH.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_DSKH.ImageOptions.Image")));
            this.btn_DSKH.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_DSKH.ImageOptions.LargeImage")));
            this.btn_DSKH.Name = "btn_DSKH";
            this.btn_DSKH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_DSKH_ItemClick);
            // 
            // btn_ruttien
            // 
            this.btn_ruttien.Caption = "GD Rút Tiền";
            this.btn_ruttien.Id = 17;
            this.btn_ruttien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_ruttien.ImageOptions.Image")));
            this.btn_ruttien.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_ruttien.ImageOptions.LargeImage")));
            this.btn_ruttien.Name = "btn_ruttien";
            this.btn_ruttien.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btn_ruttien.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_ruttien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // btn_guitien
            // 
            this.btn_guitien.Caption = "GD Gửi Tiền";
            this.btn_guitien.Id = 18;
            this.btn_guitien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_guitien.ImageOptions.Image")));
            this.btn_guitien.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_guitien.ImageOptions.LargeImage")));
            this.btn_guitien.Name = "btn_guitien";
            this.btn_guitien.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btn_guitien.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_guitien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "DS Tài Khoản";
            this.barButtonItem1.Id = 19;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick_1);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Sao kê GD";
            this.barButtonItem2.Id = 20;
            this.barButtonItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.barButtonItem2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // btn_motkchokh
            // 
            this.btn_motkchokh.Caption = "Mở TK cho KH";
            this.btn_motkchokh.Id = 21;
            this.btn_motkchokh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_motkchokh.ImageOptions.Image")));
            this.btn_motkchokh.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_motkchokh.ImageOptions.LargeImage")));
            this.btn_motkchokh.Name = "btn_motkchokh";
            this.btn_motkchokh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // HeThong
            // 
            this.HeThong.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.HeThong.Name = "HeThong";
            this.HeThong.Text = "Hệ Thống";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.DangNhap);
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_taotk);
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_dangxuat);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // rib_DanhMuc
            // 
            this.rib_DanhMuc.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup6});
            this.rib_DanhMuc.Name = "rib_DanhMuc";
            this.rib_DanhMuc.Text = "Danh Mục";
            this.rib_DanhMuc.Visible = false;
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_nhanvien);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.btn_khachhang);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            // 
            // rib_NghiepVu
            // 
            this.rib_NghiepVu.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3,
            this.btn_rutien,
            this.ribbonPageGroup7,
            this.btn_motk});
            this.rib_NghiepVu.Name = "rib_NghiepVu";
            this.rib_NghiepVu.Text = "Nghiệp Vụ";
            this.rib_NghiepVu.Visible = false;
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.GD_ChuyenTien);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // btn_rutien
            // 
            this.btn_rutien.ItemLinks.Add(this.btn_ruttien);
            this.btn_rutien.Name = "btn_rutien";
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.ItemLinks.Add(this.btn_guitien);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            // 
            // btn_motk
            // 
            this.btn_motk.ItemLinks.Add(this.btn_motkchokh);
            this.btn_motk.Name = "btn_motk";
            // 
            // rib_BaoCao
            // 
            this.rib_BaoCao.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4,
            this.btn_dstk,
            this.btn_saokegd});
            this.rib_BaoCao.Name = "rib_BaoCao";
            this.rib_BaoCao.Text = "Báo Cáo";
            this.rib_BaoCao.Visible = false;
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btn_DSKH);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // btn_dstk
            // 
            this.btn_dstk.ItemLinks.Add(this.barButtonItem1);
            this.btn_dstk.Name = "btn_dstk";
            // 
            // btn_saokegd
            // 
            this.btn_saokegd.ItemLinks.Add(this.barButtonItem2);
            this.btn_saokegd.Name = "btn_saokegd";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 740);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1300, 30);
            this.ribbonStatusBar.Click += new System.EventHandler(this.ribbonStatusBar_Click);
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MANV,
            this.HOTEN,
            this.NHOM});
            this.statusStrip1.Location = new System.Drawing.Point(0, 714);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1300, 26);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // MANV
            // 
            this.MANV.Name = "MANV";
            this.MANV.Size = new System.Drawing.Size(52, 20);
            this.MANV.Text = "MANV";
            // 
            // HOTEN
            // 
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.Size = new System.Drawing.Size(57, 20);
            this.HOTEN.Text = "HOTEN";
            // 
            // NHOM
            // 
            this.NHOM.Name = "NHOM";
            this.NHOM.Size = new System.Drawing.Size(55, 20);
            this.NHOM.Text = "NHOM";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 770);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage HeThong;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.Ribbon.RibbonPage rib_DanhMuc;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage rib_NghiepVu;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPage rib_BaoCao;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem DangNhap;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel MANV;
        public System.Windows.Forms.ToolStripStatusLabel HOTEN;
        public System.Windows.Forms.ToolStripStatusLabel NHOM;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup btn_rutien;
        public DevExpress.XtraBars.BarButtonItem btn_taotk;
        public DevExpress.XtraBars.BarButtonItem btn_dangxuat;
        private DevExpress.XtraBars.BarButtonItem btn_nhanvien;
        private DevExpress.XtraBars.BarButtonItem btn_khachhang;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.BarButtonItem btn_DSKH;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup btn_motk;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup btn_dstk;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup btn_saokegd;
        public DevExpress.XtraBars.BarButtonItem GD_ChuyenTien;
        public DevExpress.XtraBars.BarButtonItem btn_ruttien;
        public DevExpress.XtraBars.BarButtonItem btn_guitien;
        public DevExpress.XtraBars.BarButtonItem btn_motkchokh;
    }
}