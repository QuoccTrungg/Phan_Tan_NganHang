
namespace frmNhanVien
{
    partial class frmGD_GuiTien
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtnhapCMND = new System.Windows.Forms.TextBox();
            this.btnTim = new DevExpress.XtraEditors.SimpleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.lv_dstk = new System.Windows.Forms.ListView();
            this.STK = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CMND = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SODU = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MACN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NGAYMO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_lammoi = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.date_ngayGD = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_Thoat = new DevExpress.XtraEditors.SimpleButton();
            this.btn_guiTien = new DevExpress.XtraEditors.SimpleButton();
            this.textHoTen = new System.Windows.Forms.TextBox();
            this.textCMND = new System.Windows.Forms.TextBox();
            this.textSTK = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSOTIEN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập  Số CMND";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtnhapCMND
            // 
            this.txtnhapCMND.Location = new System.Drawing.Point(275, 20);
            this.txtnhapCMND.Name = "txtnhapCMND";
            this.txtnhapCMND.Size = new System.Drawing.Size(284, 34);
            this.txtnhapCMND.TabIndex = 2;
            this.txtnhapCMND.TextChanged += new System.EventHandler(this.txtSOTK_TextChanged);
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(603, 18);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(94, 34);
            this.btnTim.TabIndex = 4;
            this.btnTim.Text = "Tìm kiếm";
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtnhapCMND);
            this.panel2.Controls.Add(this.btnTim);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1188, 72);
            this.panel2.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.btn_lammoi);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.lv_dstk);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 72);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1188, 672);
            this.panel3.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 27);
            this.label7.TabIndex = 1;
            this.label7.Text = "DS tài khoản";
            // 
            // lv_dstk
            // 
            this.lv_dstk.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lv_dstk.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.STK,
            this.CMND,
            this.SODU,
            this.MACN,
            this.NGAYMO});
            this.lv_dstk.GridLines = true;
            this.lv_dstk.HideSelection = false;
            this.lv_dstk.Location = new System.Drawing.Point(173, 26);
            this.lv_dstk.MaximumSize = new System.Drawing.Size(961, 300);
            this.lv_dstk.Name = "lv_dstk";
            this.lv_dstk.Size = new System.Drawing.Size(961, 296);
            this.lv_dstk.TabIndex = 0;
            this.lv_dstk.UseCompatibleStateImageBehavior = false;
            this.lv_dstk.View = System.Windows.Forms.View.Details;
            this.lv_dstk.Click += new System.EventHandler(this.lv_dstk_Click);
            // 
            // STK
            // 
            this.STK.Text = "Số tài khoản";
            this.STK.Width = 181;
            // 
            // CMND
            // 
            this.CMND.Text = "CMND";
            this.CMND.Width = 179;
            // 
            // SODU
            // 
            this.SODU.Text = "Số dư";
            this.SODU.Width = 175;
            // 
            // MACN
            // 
            this.MACN.Text = "Mã Chi Nhánh";
            this.MACN.Width = 261;
            // 
            // NGAYMO
            // 
            this.NGAYMO.Text = "Ngày mở TK";
            this.NGAYMO.Width = 244;
            // 
            // btn_lammoi
            // 
            this.btn_lammoi.Location = new System.Drawing.Point(36, 87);
            this.btn_lammoi.Name = "btn_lammoi";
            this.btn_lammoi.Size = new System.Drawing.Size(120, 44);
            this.btn_lammoi.TabIndex = 4;
            this.btn_lammoi.Text = "Làm mới";
            this.btn_lammoi.UseVisualStyleBackColor = true;
            this.btn_lammoi.Click += new System.EventHandler(this.btn_lammoi_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.date_ngayGD);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btn_Thoat);
            this.groupBox1.Controls.Add(this.btn_guiTien);
            this.groupBox1.Controls.Add(this.textHoTen);
            this.groupBox1.Controls.Add(this.textCMND);
            this.groupBox1.Controls.Add(this.textSTK);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSOTIEN);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(19, 346);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1115, 300);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TT Giao dịch";
            // 
            // date_ngayGD
            // 
            this.date_ngayGD.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_ngayGD.Location = new System.Drawing.Point(745, 75);
            this.date_ngayGD.Name = "date_ngayGD";
            this.date_ngayGD.Size = new System.Drawing.Size(357, 34);
            this.date_ngayGD.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(590, 71);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 37);
            this.label8.TabIndex = 36;
            this.label8.Text = "Ngày GD";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(745, 223);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(115, 41);
            this.btn_Thoat.TabIndex = 35;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_guiTien
            // 
            this.btn_guiTien.Location = new System.Drawing.Point(921, 223);
            this.btn_guiTien.Name = "btn_guiTien";
            this.btn_guiTien.Size = new System.Drawing.Size(181, 41);
            this.btn_guiTien.TabIndex = 34;
            this.btn_guiTien.Text = "Gửi TIền";
            this.btn_guiTien.Click += new System.EventHandler(this.btn_guiTien_Click_1);
            // 
            // textHoTen
            // 
            this.textHoTen.Location = new System.Drawing.Point(745, 144);
            this.textHoTen.Name = "textHoTen";
            this.textHoTen.ReadOnly = true;
            this.textHoTen.Size = new System.Drawing.Size(357, 34);
            this.textHoTen.TabIndex = 33;
            // 
            // textCMND
            // 
            this.textCMND.Location = new System.Drawing.Point(212, 133);
            this.textCMND.Name = "textCMND";
            this.textCMND.ReadOnly = true;
            this.textCMND.Size = new System.Drawing.Size(271, 34);
            this.textCMND.TabIndex = 32;
            // 
            // textSTK
            // 
            this.textSTK.Location = new System.Drawing.Point(212, 72);
            this.textSTK.Name = "textSTK";
            this.textSTK.ReadOnly = true;
            this.textSTK.Size = new System.Drawing.Size(271, 34);
            this.textSTK.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(611, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 27);
            this.label6.TabIndex = 30;
            this.label6.Text = "Họ tên KH";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 27);
            this.label4.TabIndex = 29;
            this.label4.Text = "CMND";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 27);
            this.label3.TabIndex = 28;
            this.label3.Text = "Số Tài Khoản";
            // 
            // txtSOTIEN
            // 
            this.txtSOTIEN.Location = new System.Drawing.Point(212, 203);
            this.txtSOTIEN.Name = "txtSOTIEN";
            this.txtSOTIEN.Size = new System.Drawing.Size(271, 34);
            this.txtSOTIEN.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 27);
            this.label2.TabIndex = 26;
            this.label2.Text = "Số tiền ";
            // 
            // frmGD_GuiTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 744);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmGD_GuiTien";
            this.Text = "Gửi Tiền";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnhapCMND;
        private DevExpress.XtraEditors.SimpleButton btnTim;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView lv_dstk;
        private System.Windows.Forms.ColumnHeader STK;
        private System.Windows.Forms.ColumnHeader CMND;
        private System.Windows.Forms.ColumnHeader SODU;
        private System.Windows.Forms.ColumnHeader MACN;
        private System.Windows.Forms.ColumnHeader NGAYMO;
        private System.Windows.Forms.Button btn_lammoi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker date_ngayGD;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.SimpleButton btn_Thoat;
        private DevExpress.XtraEditors.SimpleButton btn_guiTien;
        private System.Windows.Forms.TextBox textHoTen;
        private System.Windows.Forms.TextBox textCMND;
        private System.Windows.Forms.TextBox textSTK;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSOTIEN;
        private System.Windows.Forms.Label label2;
    }
}