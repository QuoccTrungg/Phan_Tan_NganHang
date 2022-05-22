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
    public partial class Form_MoTK : Form
    {
        public Form_MoTK()
        {
            InitializeComponent();
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (txtb_sotk.Text.Trim() == "" || txtb_cmnd.Text.Trim() == "" 
                || txtb_sodu.Text.Trim() == "" || txtb_sodu.Text.Trim()=="" )
            {
                MessageBox.Show("Các trường thông tin k đc để trống!", "", MessageBoxButtons.OK);
                return;
            }

            if (Program.KetNoi() == 0)
                return;
            String sotk = txtb_sotk.Text;
            String cmnd = txtb_cmnd.Text;
            int sodu = Convert.ToInt32(txtb_sodu.Text);
            String macn = cmb_chinhanh.Text;
            DateTime ngaycap = date_ngaycap.Value;

            int ktMANV = Program.ExecSqlKiemTra("SP_KiemTraCMND", cmnd);
            Program.conn = new SqlConnection(Program.connstr);
            Program.conn.Open();

            SqlCommand cmd = new SqlCommand("SP_MoTKChoKH", Program.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@cmnd", cmnd));
            cmd.Parameters.Add(new SqlParameter("@sotk", sotk));
            cmd.Parameters.Add(new SqlParameter("@sodu", sodu));
            cmd.Parameters.Add(new SqlParameter("@macn", macn));
            cmd.Parameters.Add(new SqlParameter("@ngaymotk", ngaycap));
            SqlDataReader myReader = null;
            if (ktMANV == 0)
            {
                MessageBox.Show("CMND không tồn tại, k thể tạo tài khoản" 
                    , "Thông báo", MessageBoxButtons.OK);
                return;
            }

            try
            {
                myReader = cmd.ExecuteReader();
                MessageBox.Show("Tạo TK thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Không thể thêm tk\nLý do: " + ex.Message, "", MessageBoxButtons.OK);
            }
            Program.conn.Close();
        }

        private void Form_MoTK_Load(object sender, EventArgs e)
        {
            cmb_chinhanh.DataSource = Program.bds_dspm;
            cmb_chinhanh.DisplayMember = "TENCN";
            cmb_chinhanh.ValueMember = "TENSERVER";
            cmb_chinhanh.SelectedIndex = Program.mChinhanh;

        }
    }
}
