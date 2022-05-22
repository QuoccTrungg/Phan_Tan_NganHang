
namespace frmNhanVien
{
    partial class RP_dstk
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
            this.date_bd = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.date_kt = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_priview = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Thoat = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 0;
            // 
            // date_bd
            // 
            this.date_bd.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_bd.Location = new System.Drawing.Point(209, 60);
            this.date_bd.Name = "date_bd";
            this.date_bd.Size = new System.Drawing.Size(361, 34);
            this.date_bd.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(36, 61);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 37);
            this.label8.TabIndex = 38;
            this.label8.Text = "Ngày bắt đầu";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // date_kt
            // 
            this.date_kt.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_kt.Location = new System.Drawing.Point(209, 116);
            this.date_kt.Name = "date_kt";
            this.date_kt.Size = new System.Drawing.Size(361, 34);
            this.date_kt.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 117);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 37);
            this.label2.TabIndex = 41;
            this.label2.Text = "Ngày kết thúc";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 40;
            // 
            // btn_priview
            // 
            this.btn_priview.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_priview.Appearance.Options.UseFont = true;
            this.btn_priview.Location = new System.Drawing.Point(186, 202);
            this.btn_priview.Name = "btn_priview";
            this.btn_priview.Size = new System.Drawing.Size(106, 29);
            this.btn_priview.TabIndex = 44;
            this.btn_priview.Text = "Priview";
            this.btn_priview.Click += new System.EventHandler(this.btn_priview_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat.Appearance.Options.UseFont = true;
            this.btn_Thoat.Location = new System.Drawing.Point(492, 202);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(94, 29);
            this.btn_Thoat.TabIndex = 45;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // RP_dstk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 281);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_priview);
            this.Controls.Add(this.date_kt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.date_bd);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Name = "RP_dstk";
            this.Text = "RP_dstk";
            this.Load += new System.EventHandler(this.RP_dstk_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker date_bd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker date_kt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton btn_priview;
        private DevExpress.XtraEditors.SimpleButton btn_Thoat;
    }
}