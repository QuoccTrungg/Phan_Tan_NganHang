
namespace frmNhanVien
{
    partial class Form_MoTK
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
            this.v = new System.Windows.Forms.GroupBox();
            this.date_ngaycap = new System.Windows.Forms.DateTimePicker();
            this.cmb_chinhanh = new System.Windows.Forms.ComboBox();
            this.txtb_cmnd = new System.Windows.Forms.TextBox();
            this.txtb_sodu = new System.Windows.Forms.TextBox();
            this.txtb_sotk = new System.Windows.Forms.TextBox();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_huy = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.v.SuspendLayout();
            this.SuspendLayout();
            // 
            // v
            // 
            this.v.Controls.Add(this.date_ngaycap);
            this.v.Controls.Add(this.cmb_chinhanh);
            this.v.Controls.Add(this.txtb_cmnd);
            this.v.Controls.Add(this.txtb_sodu);
            this.v.Controls.Add(this.txtb_sotk);
            this.v.Controls.Add(this.btn_them);
            this.v.Controls.Add(this.btn_huy);
            this.v.Controls.Add(this.label8);
            this.v.Controls.Add(this.label7);
            this.v.Controls.Add(this.label3);
            this.v.Controls.Add(this.label2);
            this.v.Controls.Add(this.label1);
            this.v.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.v.Location = new System.Drawing.Point(12, 14);
            this.v.Name = "v";
            this.v.Size = new System.Drawing.Size(551, 524);
            this.v.TabIndex = 4;
            this.v.TabStop = false;
            // 
            // date_ngaycap
            // 
            this.date_ngaycap.Location = new System.Drawing.Point(166, 328);
            this.date_ngaycap.Name = "date_ngaycap";
            this.date_ngaycap.Size = new System.Drawing.Size(357, 30);
            this.date_ngaycap.TabIndex = 23;
            // 
            // cmb_chinhanh
            // 
            this.cmb_chinhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_chinhanh.FormattingEnabled = true;
            this.cmb_chinhanh.Location = new System.Drawing.Point(156, 249);
            this.cmb_chinhanh.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_chinhanh.Name = "cmb_chinhanh";
            this.cmb_chinhanh.Size = new System.Drawing.Size(367, 33);
            this.cmb_chinhanh.TabIndex = 19;
            // 
            // txtb_cmnd
            // 
            this.txtb_cmnd.Location = new System.Drawing.Point(156, 111);
            this.txtb_cmnd.Margin = new System.Windows.Forms.Padding(4);
            this.txtb_cmnd.Name = "txtb_cmnd";
            this.txtb_cmnd.Size = new System.Drawing.Size(367, 30);
            this.txtb_cmnd.TabIndex = 14;
            // 
            // txtb_sodu
            // 
            this.txtb_sodu.Location = new System.Drawing.Point(156, 181);
            this.txtb_sodu.Margin = new System.Windows.Forms.Padding(4);
            this.txtb_sodu.Name = "txtb_sodu";
            this.txtb_sodu.Size = new System.Drawing.Size(367, 30);
            this.txtb_sodu.TabIndex = 13;
            // 
            // txtb_sotk
            // 
            this.txtb_sotk.Location = new System.Drawing.Point(156, 43);
            this.txtb_sotk.Margin = new System.Windows.Forms.Padding(4);
            this.txtb_sotk.Name = "txtb_sotk";
            this.txtb_sotk.Size = new System.Drawing.Size(367, 30);
            this.txtb_sotk.TabIndex = 11;
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_them.Location = new System.Drawing.Point(398, 448);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(125, 45);
            this.btn_them.TabIndex = 10;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_huy
            // 
            this.btn_huy.Location = new System.Drawing.Point(156, 448);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(125, 45);
            this.btn_huy.TabIndex = 9;
            this.btn_huy.Text = "Hủy";
            this.btn_huy.UseVisualStyleBackColor = true;
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(16, 321);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 37);
            this.label8.TabIndex = 8;
            this.label8.Text = "Ngày mở TK";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(16, 245);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 37);
            this.label7.TabIndex = 7;
            this.label7.Text = "Chi nhánh";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(16, 174);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 37);
            this.label3.TabIndex = 3;
            this.label3.Text = "Số dư";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(16, 104);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "CMND";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(16, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Số TK";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form_MoTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 550);
            this.Controls.Add(this.v);
            this.Name = "Form_MoTK";
            this.Text = "Form_MoTK";
            this.Load += new System.EventHandler(this.Form_MoTK_Load);
            this.v.ResumeLayout(false);
            this.v.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox v;
        private System.Windows.Forms.DateTimePicker date_ngaycap;
        private System.Windows.Forms.ComboBox cmb_chinhanh;
        private System.Windows.Forms.TextBox txtb_cmnd;
        private System.Windows.Forms.TextBox txtb_sodu;
        private System.Windows.Forms.TextBox txtb_sotk;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_huy;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}