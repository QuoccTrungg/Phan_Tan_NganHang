using Microsoft.Office.Interop.Excel;
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
    public partial class Form_KH : Form
    {
        public Form_KH()
        {
            InitializeComponent();
        }

        private void Form_KH_Load(object sender, EventArgs e)
        {
            cmb_chinhanh.DataSource = Program.bds_dspm;
            cmb_chinhanh.DisplayMember = "TENCN";
            cmb_chinhanh.ValueMember = "TENSERVER";
            cmb_chinhanh.SelectedIndex = Program.mChinhanh;

            if (Program.mGroup == "NGANHANG")
            {
                btn_them.Enabled = btn_xoa.Enabled = btn_sua.Enabled = false;
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            String cmnd = listView1.SelectedItems[0].SubItems[0].Text;
            txtb_cmnd.Text = cmnd;
            String ho = listView1.SelectedItems[0].SubItems[1].Text;
            txtb_ho.Text = ho;
            String ten = listView1.SelectedItems[0].SubItems[2].Text;
            txtb_ten.Text = ten;
            String diachi = listView1.SelectedItems[0].SubItems[3].Text;
            txtb_diachi.Text = diachi;
            String phai = "";
            if (listView1.SelectedItems[0].SubItems[4].Text == "Nam")
                phai = "Nam";
            else
                phai = "Nữ";

            if (phai == "Nam")
            {
                chkb_nam.Checked = true;
                chkb_nu.Checked = false;
            }
            else if (phai == "Nữ")
            {
                chkb_nu.Checked = true;
                chkb_nam.Checked = false;
            }
            String ngaycap = listView1.SelectedItems[0].SubItems[5].Text;
            date_ngaycap.Text = ngaycap;
            String sdt = listView1.SelectedItems[0].SubItems[6].Text;
            txtb_sdt.Text = sdt;
            String chinhanh = listView1.SelectedItems[0].SubItems[7].Text;
            cmb_chinhanh.Text = chinhanh;
        }

        private void btn_xem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            listView1.Items.Clear();
            if (Program.KetNoi() == 0)
                return;
            Program.conn = new SqlConnection(Program.connstr);
            Program.conn.Open();
            SqlCommand cmd = new SqlCommand("select * from V_DSKH ", Program.conn);
            try
            {
                SqlDataReader myReader = cmd.ExecuteReader();
                int i = 0;
                while (myReader.Read())
                {
                    listView1.Items.Add(myReader[0].ToString());
                    listView1.Items[i].SubItems.Add(myReader[1].ToString());
                    listView1.Items[i].SubItems.Add(myReader[2].ToString());
                    listView1.Items[i].SubItems.Add(myReader[3].ToString());
                    listView1.Items[i].SubItems.Add(myReader[4].ToString());
                    listView1.Items[i].SubItems.Add(myReader[5].ToString());
                    listView1.Items[i].SubItems.Add(myReader[6].ToString());
                    listView1.Items[i].SubItems.Add(myReader[7].ToString());
                    i++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_them_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form_KH_Them f = new Form_KH_Them();
            f.Show();
        }

        private void btn_sua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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
            Program.conn = new SqlConnection(Program.connstr);
            Program.conn.Open();
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
            if (ktMANV == 0)
            {
                MessageBox.Show("Mã KH k tồn tại.");
                return;
            }
            Program.conn.Open();
            SqlCommand cmd = new SqlCommand("SP_CapNhatKH", Program.conn);
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

            try
            {
                myReader = cmd.ExecuteReader();
                MessageBox.Show("Sửa KH thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listView1.Items.Clear();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Không thể sửa KH\nLý do: " + ex.Message, "", MessageBoxButtons.OK);
            }
            Program.conn.Close();
        }

        private void btn_xoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtb_cmnd.Text.Trim() == "")
            {
                MessageBox.Show("Cần có CMND để xóa!", "", MessageBoxButtons.OK);
                return;
            }

            if (Program.KetNoi() == 0)
                return;
            Program.conn = new SqlConnection(Program.connstr);
            Program.conn.Open();
            String cmnd = txtb_cmnd.Text;

            SqlCommand cmd = new SqlCommand("SP_XoaKH", Program.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@cmnd", cmnd));
            SqlDataReader myReader = null;

            int ktMANV = Program.ExecSqlKiemTra("SP_KiemTraCMND", cmnd);
            if (ktMANV == 0)
            {
                MessageBox.Show("Mã KH k tồn tại.");
                return;
            }
            Program.conn.Open();

            try
            {
                myReader = cmd.ExecuteReader();
                MessageBox.Show("Xóa KH thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listView1.Items.Clear();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Không thể xóa KH\nLý do: " + ex.Message, "", MessageBoxButtons.OK);
            }
            Program.conn.Close();
        }

        private void btn_in_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Wordbook|*.xls", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                    Workbook wb = app.Workbooks.Add(XlSheetType.xlWorksheet);
                    Worksheet ws = (Worksheet)app.ActiveSheet;
                    app.Visible = false;
                    ws.Cells[1, 1] = "CMND";
                    ws.Cells[1, 2] = "Họ";
                    ws.Cells[1, 3] = "Tên";
                    ws.Cells[1, 4] = "Địa chỉ";
                    ws.Cells[1, 5] = "Phái";
                    ws.Cells[1, 6] = "Ngày cấp";
                    ws.Cells[1, 7] = "sđt";
                    ws.Cells[1, 8] = "Chi nhánh";
                    int i = 2;
                    foreach (ListViewItem item in listView1.Items)
                    {
                        ws.Cells[i, 1] = item.SubItems[0].Text;
                        ws.Cells[i, 2] = item.SubItems[1].Text;
                        ws.Cells[i, 3] = item.SubItems[2].Text;
                        ws.Cells[i, 4] = item.SubItems[3].Text;
                        ws.Cells[i, 5] = item.SubItems[4].Text;
                        ws.Cells[i, 6] = item.SubItems[5].Text;
                        ws.Cells[i, 7] = item.SubItems[6].Text;
                        ws.Cells[i, 8] = item.SubItems[7].Text;
                        i++;
                    }
                    wb.SaveAs(sfd.FileName, XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, true, false,
                        XlSaveAsAccessMode.xlNoChange, XlSaveConflictResolution.xlLocalSessionChanges, Type.Missing, Type.Missing);
                    app.Quit();
                    MessageBox.Show("Đã in dữ liệu ra file thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                Program.conn.Close();
            }
        }

        private void btn_thoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        
    }
}
