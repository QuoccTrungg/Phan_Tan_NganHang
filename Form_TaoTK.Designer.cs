
namespace frmNhanVien
{
    partial class Form_TaoTK
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
            this.btn_thoat = new DevExpress.XtraEditors.SimpleButton();
            this.btn_taotk = new DevExpress.XtraEditors.SimpleButton();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_chinhanh = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.rdb_nhom1 = new System.Windows.Forms.RadioButton();
            this.rdb_nhom2 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btn_thoat
            // 
            this.btn_thoat.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.Appearance.Options.UseFont = true;
            this.btn_thoat.Location = new System.Drawing.Point(118, 480);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(111, 29);
            this.btn_thoat.TabIndex = 15;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_taotk
            // 
            this.btn_taotk.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_taotk.Appearance.Options.UseFont = true;
            this.btn_taotk.Location = new System.Drawing.Point(295, 480);
            this.btn_taotk.Name = "btn_taotk";
            this.btn_taotk.Size = new System.Drawing.Size(139, 29);
            this.btn_taotk.TabIndex = 14;
            this.btn_taotk.Text = "Tạo TK";
            this.btn_taotk.Click += new System.EventHandler(this.btn_taotk_Click);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(194, 272);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(276, 22);
            this.txtPass.TabIndex = 13;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(194, 209);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(276, 22);
            this.txtLogin.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.PapayaWhip;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "Mật khẩu";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.PapayaWhip;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tài khoản";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.PapayaWhip;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 30);
            this.label1.TabIndex = 9;
            this.label1.Text = "Chi Nhánh";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmb_chinhanh
            // 
            this.cmb_chinhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_chinhanh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_chinhanh.FormattingEnabled = true;
            this.cmb_chinhanh.Location = new System.Drawing.Point(208, 137);
            this.cmb_chinhanh.Name = "cmb_chinhanh";
            this.cmb_chinhanh.Size = new System.Drawing.Size(262, 30);
            this.cmb_chinhanh.TabIndex = 8;
            this.cmb_chinhanh.SelectedIndexChanged += new System.EventHandler(this.cmb_chinhanh_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.PapayaWhip;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(53, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 24);
            this.label4.TabIndex = 16;
            this.label4.Text = "Username";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.PapayaWhip;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(53, 393);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 32);
            this.label5.TabIndex = 17;
            this.label5.Text = "Nhóm";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(194, 334);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(276, 22);
            this.txtUser.TabIndex = 18;
            // 
            // rdb_nhom1
            // 
            this.rdb_nhom1.Location = new System.Drawing.Point(194, 393);
            this.rdb_nhom1.Name = "rdb_nhom1";
            this.rdb_nhom1.Size = new System.Drawing.Size(123, 32);
            this.rdb_nhom1.TabIndex = 19;
            this.rdb_nhom1.TabStop = true;
            this.rdb_nhom1.Text = "NGANHANG";
            this.rdb_nhom1.UseVisualStyleBackColor = true;
            // 
            // rdb_nhom2
            // 
            this.rdb_nhom2.Location = new System.Drawing.Point(347, 393);
            this.rdb_nhom2.Name = "rdb_nhom2";
            this.rdb_nhom2.Size = new System.Drawing.Size(123, 32);
            this.rdb_nhom2.TabIndex = 20;
            this.rdb_nhom2.TabStop = true;
            this.rdb_nhom2.Text = "CHINHANH";
            this.rdb_nhom2.UseVisualStyleBackColor = true;
            // 
            // Form_TaoTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 546);
            this.Controls.Add(this.rdb_nhom2);
            this.Controls.Add(this.rdb_nhom1);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_taotk);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_chinhanh);
            this.Name = "Form_TaoTK";
            this.Text = "Form_TaoTK";
            this.Load += new System.EventHandler(this.Form_TaoTK_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_thoat;
        private DevExpress.XtraEditors.SimpleButton btn_taotk;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_chinhanh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.RadioButton rdb_nhom1;
        private System.Windows.Forms.RadioButton rdb_nhom2;
    }
}