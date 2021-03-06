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
    public partial class Form_KH_Them : Form
    {
        public Form_KH_Them()
        {
            InitializeComponent();
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (txtb_cmnd.Text.Trim() == "" || txtb_ho.Text.Trim() == "" || txtb_ten.Text.Trim() == ""
                || txtb_diachi.Text.Trim() == "" || (chkb_nam.Checked == false && chkb_nu.Checked == false)
                || txtb_sdt.Text.Trim() == "")
            {
                MessageBox.Show("Các trường thông tin k đc để trống!", "", MessageBoxButtons.OK);
                return;
            }

            if (Program.KetNoi() == 0)
                return;
            String cmnd = txtb_cmnd.Text;
            String ho = txtb_ho.Text;
            String ten = txtb_ten.Text;
            String diachi = txtb_diachi.Text;
            String phai = "";
            if (chkb_nam.Checked == true)
                phai = "Nam";
            else if (chkb_nu.Checked == true)
                phai = "Nữ";
            int sdt = Convert.ToInt32(txtb_sdt.Text);
            String macn = cmb_chinhanh.Text;
            DateTime ngaycap = date_ngaycap.Value;

            int ktMANV = Program.ExecSqlKiemTra("SP_KiemTraCMND", cmnd);
            Program.conn = new SqlConnection(Program.connstr);
            Program.conn.Open();

            SqlCommand cmd = new SqlCommand("SP_ThemKH", Program.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@cmnd", cmnd));
            cmd.Parameters.Add(new SqlParameter("@ho", ho));
            cmd.Parameters.Add(new SqlParameter("@ten", ten));
            cmd.Parameters.Add(new SqlParameter("@diachi", diachi));
            cmd.Parameters.Add(new SqlParameter("@phai", phai));
            cmd.Parameters.Add(new SqlParameter("@sdt", sdt));
            cmd.Parameters.Add(new SqlParameter("@macn", macn));
            cmd.Parameters.Add(new SqlParameter("@ngaycap", ngaycap));
            SqlDataReader myReader = null;
            if (ktMANV == 1)
            {
                MessageBox.Show("Mã KH đã tồn tại trong database", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            try
            {
                myReader = cmd.ExecuteReader();
                MessageBox.Show("Thêm KH thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Không thể thêm KH\nLý do: " + ex.Message, "", MessageBoxButtons.OK);
            }
            Program.conn.Close();
        }

        private void Form_KH_Them_Load(object sender, EventArgs e)
        {
            cmb_chinhanh.DataSource = Program.bds_dspm;
            cmb_chinhanh.DisplayMember = "TENCN";
            cmb_chinhanh.ValueMember = "TENSERVER";
            cmb_chinhanh.SelectedIndex = Program.mChinhanh;
        }
    }
}
