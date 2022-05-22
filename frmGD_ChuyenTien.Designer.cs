
namespace frmNhanVien
{
    partial class frmGD_ChuyenTien
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtSTKGui = new System.Windows.Forms.TextBox();
            this.txtSTKNhan = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Thoat = new DevExpress.XtraEditors.SimpleButton();
            this.btn_ChuyenTien = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Load = new DevExpress.XtraEditors.SimpleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.date_ngayGD = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSoDuNhan = new System.Windows.Forms.TextBox();
            this.txtSoDuGui = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textHoTenNhan = new System.Windows.Forms.TextBox();
            this.textCMNDNhan = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textHoTenGui = new System.Windows.Forms.TextBox();
            this.textCMNDGui = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSOTIEN = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_cngui = new System.Windows.Forms.TextBox();
            this.txt_cnnhan = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "STK Gửi";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(695, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "STK  Nhận";
            // 
            // txtSTKGui
            // 
            this.txtSTKGui.Location = new System.Drawing.Point(208, 30);
            this.txtSTKGui.Margin = new System.Windows.Forms.Padding(5);
            this.txtSTKGui.Name = "txtSTKGui";
            this.txtSTKGui.Size = new System.Drawing.Size(271, 34);
            this.txtSTKGui.TabIndex = 2;
            // 
            // txtSTKNhan
            // 
            this.txtSTKNhan.Location = new System.Drawing.Point(868, 30);
            this.txtSTKNhan.Margin = new System.Windows.Forms.Padding(5);
            this.txtSTKNhan.Name = "txtSTKNhan";
            this.txtSTKNhan.Size = new System.Drawing.Size(294, 34);
            this.txtSTKNhan.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Thoat);
            this.panel1.Controls.Add(this.btn_ChuyenTien);
            this.panel1.Controls.Add(this.btn_Load);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 495);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1217, 86);
            this.panel1.TabIndex = 4;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat.Appearance.Options.UseFont = true;
            this.btn_Thoat.Location = new System.Drawing.Point(702, 30);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(94, 29);
            this.btn_Thoat.TabIndex = 2;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_ChuyenTien
            // 
            this.btn_ChuyenTien.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ChuyenTien.Appearance.Options.UseFont = true;
            this.btn_ChuyenTien.Location = new System.Drawing.Point(1008, 30);
            this.btn_ChuyenTien.Name = "btn_ChuyenTien";
            this.btn_ChuyenTien.Size = new System.Drawing.Size(154, 29);
            this.btn_ChuyenTien.TabIndex = 1;
            this.btn_ChuyenTien.Text = "Chuyển Tiền";
            this.btn_ChuyenTien.Click += new System.EventHandler(this.btn_ChuyenTien_Click);
            // 
            // btn_Load
            // 
            this.btn_Load.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Load.Appearance.Options.UseFont = true;
            this.btn_Load.Location = new System.Drawing.Point(868, 30);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Size = new System.Drawing.Size(94, 29);
            this.btn_Load.TabIndex = 0;
            this.btn_Load.Text = "Load";
            this.btn_Load.Click += new System.EventHandler(this.btn_Load_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txt_cnnhan);
            this.panel2.Controls.Add(this.txt_cngui);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.date_ngayGD);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtSoDuNhan);
            this.panel2.Controls.Add(this.txtSoDuGui);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.textHoTenNhan);
            this.panel2.Controls.Add(this.textCMNDNhan);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.textHoTenGui);
            this.panel2.Controls.Add(this.textCMNDGui);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtSOTIEN);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtSTKNhan);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtSTKGui);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1217, 495);
            this.panel2.TabIndex = 5;
            // 
            // date_ngayGD
            // 
            this.date_ngayGD.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_ngayGD.Location = new System.Drawing.Point(838, 406);
            this.date_ngayGD.Name = "date_ngayGD";
            this.date_ngayGD.Size = new System.Drawing.Size(357, 34);
            this.date_ngayGD.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(683, 408);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 37);
            this.label5.TabIndex = 42;
            this.label5.Text = "Ngày GD";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSoDuNhan
            // 
            this.txtSoDuNhan.Location = new System.Drawing.Point(868, 335);
            this.txtSoDuNhan.Margin = new System.Windows.Forms.Padding(5);
            this.txtSoDuNhan.Name = "txtSoDuNhan";
            this.txtSoDuNhan.ReadOnly = true;
            this.txtSoDuNhan.Size = new System.Drawing.Size(294, 34);
            this.txtSoDuNhan.TabIndex = 41;
            // 
            // txtSoDuGui
            // 
            this.txtSoDuGui.Location = new System.Drawing.Point(208, 335);
            this.txtSoDuGui.Margin = new System.Windows.Forms.Padding(5);
            this.txtSoDuGui.Name = "txtSoDuGui";
            this.txtSoDuGui.ReadOnly = true;
            this.txtSoDuGui.Size = new System.Drawing.Size(271, 34);
            this.txtSoDuGui.TabIndex = 40;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(695, 335);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 27);
            this.label12.TabIndex = 39;
            this.label12.Text = " Số Dư ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(35, 335);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 27);
            this.label11.TabIndex = 38;
            this.label11.Text = " Số Dư ";
            // 
            // textHoTenNhan
            // 
            this.textHoTenNhan.Location = new System.Drawing.Point(868, 187);
            this.textHoTenNhan.Name = "textHoTenNhan";
            this.textHoTenNhan.ReadOnly = true;
            this.textHoTenNhan.Size = new System.Drawing.Size(294, 34);
            this.textHoTenNhan.TabIndex = 37;
            // 
            // textCMNDNhan
            // 
            this.textCMNDNhan.Location = new System.Drawing.Point(868, 112);
            this.textCMNDNhan.Name = "textCMNDNhan";
            this.textCMNDNhan.ReadOnly = true;
            this.textCMNDNhan.Size = new System.Drawing.Size(294, 34);
            this.textCMNDNhan.TabIndex = 36;
            this.textCMNDNhan.TextChanged += new System.EventHandler(this.textCMNDNhan_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(695, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 27);
            this.label8.TabIndex = 34;
            this.label8.Text = "Họ tên KH";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(695, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 27);
            this.label9.TabIndex = 33;
            this.label9.Text = "CMND";
            // 
            // textHoTenGui
            // 
            this.textHoTenGui.Location = new System.Drawing.Point(208, 180);
            this.textHoTenGui.Name = "textHoTenGui";
            this.textHoTenGui.ReadOnly = true;
            this.textHoTenGui.Size = new System.Drawing.Size(271, 34);
            this.textHoTenGui.TabIndex = 30;
            // 
            // textCMNDGui
            // 
            this.textCMNDGui.Location = new System.Drawing.Point(208, 108);
            this.textCMNDGui.Name = "textCMNDGui";
            this.textCMNDGui.ReadOnly = true;
            this.textCMNDGui.Size = new System.Drawing.Size(271, 34);
            this.textCMNDGui.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 27);
            this.label6.TabIndex = 27;
            this.label6.Text = "Họ tên KH";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 27);
            this.label4.TabIndex = 25;
            this.label4.Text = "CMND";
            // 
            // txtSOTIEN
            // 
            this.txtSOTIEN.Location = new System.Drawing.Point(208, 413);
            this.txtSOTIEN.Name = "txtSOTIEN";
            this.txtSOTIEN.Size = new System.Drawing.Size(271, 34);
            this.txtSOTIEN.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 413);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 27);
            this.label7.TabIndex = 22;
            this.label7.Text = "Số tiền ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(35, 260);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(111, 27);
            this.label13.TabIndex = 44;
            this.label13.Text = "Chi nhánh";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(695, 260);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(111, 27);
            this.label14.TabIndex = 45;
            this.label14.Text = "Chi nhánh";
            // 
            // txt_cngui
            // 
            this.txt_cngui.Location = new System.Drawing.Point(208, 253);
            this.txt_cngui.Name = "txt_cngui";
            this.txt_cngui.ReadOnly = true;
            this.txt_cngui.Size = new System.Drawing.Size(271, 34);
            this.txt_cngui.TabIndex = 46;
            // 
            // txt_cnnhan
            // 
            this.txt_cnnhan.Location = new System.Drawing.Point(868, 257);
            this.txt_cnnhan.Name = "txt_cnnhan";
            this.txt_cnnhan.ReadOnly = true;
            this.txt_cnnhan.Size = new System.Drawing.Size(294, 34);
            this.txt_cnnhan.TabIndex = 47;
            // 
            // frmGD_ChuyenTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 581);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmGD_ChuyenTien";
            this.Text = "frmGD_ChuyenTien";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSTKGui;
        private System.Windows.Forms.TextBox txtSTKNhan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton btn_Thoat;
        private DevExpress.XtraEditors.SimpleButton btn_ChuyenTien;
        private DevExpress.XtraEditors.SimpleButton btn_Load;
        private System.Windows.Forms.TextBox textHoTenGui;
        private System.Windows.Forms.TextBox textCMNDGui;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSOTIEN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textHoTenNhan;
        private System.Windows.Forms.TextBox textCMNDNhan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSoDuNhan;
        private System.Windows.Forms.TextBox txtSoDuGui;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker date_ngayGD;
        private System.Windows.Forms.TextBox txt_cnnhan;
        private System.Windows.Forms.TextBox txt_cngui;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
    }
}