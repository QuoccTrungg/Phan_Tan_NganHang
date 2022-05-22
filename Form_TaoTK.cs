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
    public partial class Form_TaoTK : Form
    {
        public Form_TaoTK()
        {
            InitializeComponent();
            if (Program.mGroup == "CHINHANH")
            {
                rdb_nhom2.Checked = true;
                rdb_nhom1.Visible = false;
            }
            else if (Program.mGroup == "NGANHANG")
            {
                rdb_nhom1.Checked = true;
                rdb_nhom2.Visible = false;
            }
        }

        private void cmb_chinhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Form_TaoTK_Load(object sender, EventArgs e)
        {
            cmb_chinhanh.DataSource = Program.bds_dspm;
            cmb_chinhanh.DisplayMember = "TENCN";
            cmb_chinhanh.ValueMember = "TENSERVER";
            cmb_chinhanh.SelectedItem = Program.mChinhanh;
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Close();
          
        }

        private void btn_taotk_Click(object sender, EventArgs e)
        {
           
            if (txtLogin.Text.Trim() == "" || txtPass.Text.Trim() == "" || txtUser.Text.Trim() == "")
            {
                MessageBox.Show("Tài khoản, Mật khẩu và username k đc để trống!", "", MessageBoxButtons.OK);
                return;
            }

            if (Program.KetNoi() == 0)
                return;
            String TaoTK_login = txtLogin.Text;
            String TaoTK_pass = txtPass.Text;
            String TaoTK_username = txtUser.Text;
            String TaoTK_group = "";
            if (rdb_nhom1.Checked == true)
                TaoTK_group = "NGANHANG";
            else if (rdb_nhom2.Checked == true)
                TaoTK_group = "CHINHANH";

            Console.WriteLine(TaoTK_login + "  " + TaoTK_pass + "   " + TaoTK_username + "    " + TaoTK_group);

            Program.conn = new SqlConnection(Program.connstr);
            Program.conn.Open();
            SqlCommand cmd = new SqlCommand("SP_TaoLogin", Program.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@lgname", TaoTK_login));
            cmd.Parameters.Add(new SqlParameter("@pass", TaoTK_pass));
            cmd.Parameters.Add(new SqlParameter("@username", TaoTK_username));
            cmd.Parameters.Add(new SqlParameter("@role", TaoTK_group));
            SqlDataReader myReader = null;
            try
            {
                myReader = cmd.ExecuteReader();
                MessageBox.Show("Tạo tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Không thể tạo TK\nLý do: " + ex.Message, "", MessageBoxButtons.OK);
            }

        }
    }
}
