using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmNhanVien
{
    public partial class frmGD_GuiTien : Form
    {
        public String SoTK = "";
        public String LoaiGD = "GT";
        public int Sodu = 0;
        public String sodutk = "";
        public DateTime Ngaygd;
        public frmGD_GuiTien()
        {
            InitializeComponent();
        }

        private void MANV_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtSOTK_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textSTK_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }


        private void btnTim_Click(object sender, EventArgs e)
        {
            lv_dstk.Items.Clear();
            if (txtnhapCMND.Text.Trim() == "")
            {
                MessageBox.Show("CMND khong duoc trong !!!", "", MessageBoxButtons.OK);
                return;
            }
            Program.CMND = txtnhapCMND.Text;
            if (Program.KetNoi() == 0) return;
            String strlenh = "EXEC SP_TIMSTK '" + Program.CMND + "'";
            SqlDataReader dstk = Program.ExecSqlDataReader(strlenh);
            int i = 0;
            
            while (dstk.Read())
            {             
                lv_dstk.Items.Add(dstk[0].ToString());
                lv_dstk.Items[i].SubItems.Add(dstk[1].ToString());
                lv_dstk.Items[i].SubItems.Add(dstk[2].ToString());
                lv_dstk.Items[i].SubItems.Add(dstk[3].ToString());
                lv_dstk.Items[i].SubItems.Add(dstk[4].ToString());
                i++; 
            }

            if (lv_dstk.Items.Count == 0)
            {
                MessageBox.Show(" khong co tai khoan nay !!!", "", MessageBoxButtons.OK);
                return;
            }
        }    
         

        private void lv_dstk_Click(object sender, EventArgs e)
        {
            SoTK=textSTK.Text = lv_dstk.SelectedItems[0].SubItems[0].Text;
            textCMND.Text = lv_dstk.SelectedItems[0].SubItems[1].Text=Program.CMND;
            sodutk = lv_dstk.SelectedItems[0].SubItems[2].Text;
            Sodu = Convert.ToInt32(float.Parse(sodutk));

            if (Program.KetNoi() == 0) return;
            String strlenh = "EXEC [dbo].[SP_TIM_THONG_TIN_TK] '"
                + Program.CMND + "'";
            SqlDataReader ttkh = Program.ExecSqlDataReader(strlenh);
            ttkh.Read();
            textHoTen.Text = ttkh[1].ToString();
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            lv_dstk.Items.Clear();
            if (Program.KetNoi() == 0) return;
            String strlenh = "EXEC SP_TIMSTK '" + Program.CMND + "'";
            SqlDataReader dstk = Program.ExecSqlDataReader(strlenh);
            int i = 0;

            while (dstk.Read())
            {
                lv_dstk.Items.Add(dstk[0].ToString());
                lv_dstk.Items[i].SubItems.Add(dstk[1].ToString());
                lv_dstk.Items[i].SubItems.Add(dstk[2].ToString());
                lv_dstk.Items[i].SubItems.Add(dstk[3].ToString());
                lv_dstk.Items[i].SubItems.Add(dstk[4].ToString());
                i++;
            }

            if (lv_dstk.Items.Count == 0)
            {
                MessageBox.Show(" khong co tai khoan nay !!!", "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btn_guiTien_Click_1(object sender, EventArgs e)
        {
            if (txtSOTIEN.Text.Trim() == "")
            {
                MessageBox.Show("khong duoc de so tien trong!!!", "", MessageBoxButtons.OK);
                return;
            }

            int sotien = Convert.ToInt32(txtSOTIEN.Text);
            Ngaygd = date_ngayGD.Value;

            if (sotien < 100000)
            {
                MessageBox.Show("số tiền gửi vào phải hơn 100k!!!", "", MessageBoxButtons.OK);
                return;
            }
            if (Program.KetNoi() == 0) return;

            Program.conn = new SqlConnection(Program.connstr);
            Program.conn.Open();

            SqlCommand cmd = new SqlCommand("GHI_GD_GUI_RUT_TIEN", Program.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@SOTK", SoTK));
            cmd.Parameters.Add(new SqlParameter("@LOAIGD", LoaiGD));
            cmd.Parameters.Add(new SqlParameter("@NGAYGD", Ngaygd));
            cmd.Parameters.Add(new SqlParameter("@MANV", Program.username));
            cmd.Parameters.Add(new SqlParameter("@SOTIEN", sotien));

            SqlDataReader myReader = null;
            try
            {
                myReader = cmd.ExecuteReader();
                MessageBox.Show("Thêm GD thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Không thể thêm GD\nLý do: " + ex.Message, "", MessageBoxButtons.OK);
            }
            Program.conn.Close();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
