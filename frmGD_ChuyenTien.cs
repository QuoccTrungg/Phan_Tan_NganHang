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
    public partial class frmGD_ChuyenTien : Form
    {
        public frmGD_ChuyenTien()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textCMNDNhan_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Load_Click(object sender, EventArgs e)
        {
           
            if (txtSTKGui.Text.Trim() == ""|| txtSTKNhan.Text.Trim() == "")
            {
                MessageBox.Show("STK gửi / STK nhận không được để  trống !!!", "", MessageBoxButtons.OK);
                return;
            }
            if (Program.KetNoi() == 0) return;
            Program.conn = new SqlConnection(Program.connstr);
            Program.conn.Open();

            String stkgui = txtSTKGui.Text;
            String stknhan = txtSTKNhan.Text;
            DateTime ngaygd = date_ngayGD.Value;
            int kttkgui = Program.ExecSqlKiemTra("SP_KiemTraSOTK", stkgui);
            Program.conn.Open();

            int kttknhan = Program.ExecSqlKiemTra("SP_KiemTraSOTK",stknhan);
            Program.conn.Open();

            if (kttkgui == 0||kttknhan==0)
            {
                MessageBox.Show("STK gửi/nhận không tồn tại!!!!", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            String strlenh1 = "EXEC SP_THONG_TIN_TK '" + stkgui + "'";
            SqlDataReader tkgui = Program.ExecSqlDataReader(strlenh1);
            tkgui.Read();
            txtSTKGui.Text = tkgui[0].ToString();
            textCMNDGui.Text = tkgui[1].ToString();
            textHoTenGui.Text= tkgui[2].ToString();
            txt_cngui.Text= tkgui[3].ToString();
            txtSoDuGui.Text= tkgui[4].ToString();

            String strlenh2 = "EXEC SP_THONG_TIN_TK '" + stknhan + "'";
            tkgui.Close();

            if (Program.KetNoi() == 0) return;
            SqlDataReader ttnhan = Program.ExecSqlDataReader(strlenh2);
            ttnhan.Read();
            txtSTKNhan.Text = ttnhan[0].ToString();
            textCMNDNhan.Text = ttnhan[1].ToString();
            textHoTenNhan.Text = ttnhan[2].ToString();
            txt_cnnhan.Text = ttnhan[3].ToString();
            txtSoDuNhan.Text = ttnhan[4].ToString();
           
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_ChuyenTien_Click(object sender, EventArgs e)
        {
            if (txtSOTIEN.Text.Trim() == "")
            {
                MessageBox.Show("khong duoc de so tien trong!!!", "", MessageBoxButtons.OK);
                return;
            }

            String stkgui = txtSTKGui.Text;
            String stknhan = txtSTKNhan.Text;
            DateTime ngaygd = date_ngayGD.Value;
            int sotien = Convert.ToInt32(txtSOTIEN.Text);

            if (sotien < 100000)
            {
                MessageBox.Show("số tiền chuyển phải hơn 100k!!!", "", MessageBoxButtons.OK);
                return;
            }

            if (Program.KetNoi() == 0) return;

            Program.conn = new SqlConnection(Program.connstr);
            Program.conn.Open();
            SqlCommand cmd = new SqlCommand("SP_GHI_GD_CHUYENTIEN", Program.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@SOTKG", stkgui));
            cmd.Parameters.Add(new SqlParameter("@NGAYGD", ngaygd));
            cmd.Parameters.Add(new SqlParameter("@SOTKN", stknhan));
            cmd.Parameters.Add(new SqlParameter("@SOTIEN", sotien));
            cmd.Parameters.Add(new SqlParameter("@MANV", Program.username));

            SqlDataReader myReader = null;
            try
            {
                myReader = cmd.ExecuteReader();
                MessageBox.Show("Chuyển tiền thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Không thể Chuyển tiền\nLý do: " + ex.Message, "", MessageBoxButtons.OK);
            }
            Program.conn.Close();
        }
    }
}
