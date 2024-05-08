using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BTL_2023_c.BaoCao;
using System.Configuration;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace BTL_2023_c
{
    public partial class QLDiem : Form
    {
        public QLDiem()
        {
            InitializeComponent();
        }
        void Decentralization()
        {
            if (Const.AccountType == false)
            {
                btn_themDiem.Enabled = btn_suaDiem.Enabled = btn_xoaDiem.Enabled = btkhoitao.Enabled = false;
            }
        }
        private void QLDiem_Load(object sender, EventArgs e)
        {
            laydataGridDiem();
            layMonHoc();
            laySinhVien();
            laytenmonhoc();
            //Decentralization();
        }


        public void laydataGridDiem()
        {
            string couter = ConfigurationManager.ConnectionStrings["btl_c#"].ConnectionString;

            using (SqlConnection cnn = new SqlConnection(couter))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT sMaSV AS N'Mã sinh viên' , sMaMH AS N'Mã môn học', dNgayHoc AS N'Ngày Học' , fDiemCC AS N'Điểm chuyên cần' " +
                    ", fDiemBK AS N'Điểm giữa kì' , fDiemHK AS N'Điểm cuối kì' , fDiemTK AS N'Điểm tổng kết' FROM tblCTDiem", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable("tb_Diem");
                        ad.Fill(tb);
                        dataGridDiem.DataSource = tb;
                        /*double tongtien = 0;
                        int count = 0;
                        for(int i = 0; i< tb.Rows.Count; i++)
                        {
                            double diem = Convert.ToDouble(tb.Rows[i]["Điểm chuyên cần"]);
                            tongtien += diem;
                            count++;
                        }
                        txtTD.Text = count.ToString();*/
                    }
                }
            }
        }

        public static void themDiem(string maSV, string maMH,string ngaysinh, float diemCC, float diemGK , float diemHK )
        {
            string counter = ConfigurationManager.ConnectionStrings["btl_C#"].ConnectionString;
            string sqlInsert = "INSERT INTO tblCTDiem (sMaSV , sMaMH, dNgayHoc , fDiemCC , fDiemBK , fDiemHK) " +
                "VALUES( '" + maSV + "' , '" + maMH + "' , '"+ngaysinh+ "' , '" + diemCC + "' , '" + diemGK + "' , '"+ diemHK +"')";
            using (SqlConnection cnn = new SqlConnection(counter))
            {
                using (SqlCommand cmd = new SqlCommand(sqlInsert, cnn))
                {
                    cmd.CommandType = System.Data.CommandType.Text;
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();

                }
            }
        }

        private void btn_themDiem_Click(object sender, EventArgs e)
        {
     
            if(Convert.ToDouble(mask_diemCC.Text) > 10 || Convert.ToDouble(mask_diemGK.Text) > 10|| Convert.ToDouble(mask_diemCK.Text) > 10 
                 || Convert.ToDouble(mask_diemCC.Text)  < 0 || Convert.ToDouble(mask_diemGK.Text) < 0 || Convert.ToDouble(mask_diemCK.Text) < 0)
            {
                MessageBox.Show("Điểm không hợp lệ!\nVui lòng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else
            {
                themDiem(Convert.ToString(cb_maSv.Text), Convert.ToString(cb.Text),Convert.ToString(cb_ngaysinh.Text), float.Parse(mask_diemCC.Text), float.Parse(mask_diemGK.Text), float.Parse(mask_diemCK.Text));
                laydataGridDiem();
            }    
           
        }
        private void btn_suaDiem_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(mask_diemCC.Text) > 10 || Convert.ToDouble(mask_diemGK.Text) > 10 || Convert.ToDouble(mask_diemCK.Text) > 10
                 || Convert.ToDouble(mask_diemCC.Text) < 0 || Convert.ToDouble(mask_diemGK.Text) < 0 || Convert.ToDouble(mask_diemCK.Text) < 0)
            {
                MessageBox.Show("Điểm không hợp lệ!\nVui lòng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                suaDiem(Convert.ToString(cb_maSv.Text), float.Parse(mask_diemCC.Text));
                cb_maSv.Enabled = true;
                cb.Enabled = true;
            }
               
        }
        public static bool suaDiem(string maSV, float diemCC)
        {
            string ctr = ConfigurationManager.ConnectionStrings["btl_C#"].ConnectionString;
            string sqlInsert = "Update tblCTDiem SET fDiemCC = '" + diemCC + "'WHERE sMaSV = '" + maSV + "'";
            using (SqlConnection cnn = new SqlConnection(ctr))
            {
                using (SqlCommand cmd = new SqlCommand(sqlInsert, cnn))
                {
                    cmd.CommandType = System.Data.CommandType.Text;
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();
                    return i > 0;
                }
            }

        }

        private void dataGridDiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cb_maSv.Text = dataGridDiem.CurrentRow.Cells["Mã sinh Viên"].Value.ToString();
            cb.Text = dataGridDiem.CurrentRow.Cells["Mã môn học"].Value.ToString();
            cb_ngaysinh.Text = dataGridDiem.CurrentRow.Cells["Ngày học"].Value.ToString();
            mask_diemCC.Text = dataGridDiem.CurrentRow.Cells["Điểm chuyên cần"].Value.ToString();
            mask_diemGK.Text = dataGridDiem.CurrentRow.Cells["Điểm giữa kì"].Value.ToString();
            mask_diemCK.Text = dataGridDiem.CurrentRow.Cells["Điểm cuối kì"].Value.ToString();

        }



        private void laySinhVien()
        {
            string constr = ConfigurationManager.ConnectionStrings["btl_C#"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM tblSinhVien", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable("SinhVien");
                        ad.Fill(tb);
                        cb_maSv.DataSource = tb;
                        cb_maSv.DisplayMember = "sMaSV";
                        cb_maSv.ValueMember = "sTenSV";
                    }
                }
            }
        }

        public static bool xoaaDiem(string maSV , string maMH , float fDiemCC)
        {
            string ctr = ConfigurationManager.ConnectionStrings["btl_C#"].ConnectionString;
            string sqlInsert = "DELETE FROM tblCTDiem WHERE sMaSV = '" + maSV + "' AND sMaMH = '" + maMH + "' AND fDiemCC = " + fDiemCC;
            using (SqlConnection cnn = new SqlConnection(ctr))
            {
                using (SqlCommand cmd = new SqlCommand(sqlInsert, cnn))
                {
                    cmd.CommandType = System.Data.CommandType.Text;
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();
                    return i > 0;
                }
            }
        }

        private void layMonHoc()
        {
            string constr = ConfigurationManager.ConnectionStrings["btl_C#"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM tblMonHoc", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable("MonHoc");
                        ad.Fill(tb);
                        cb.DataSource = tb;
                        cb.DisplayMember = "sTenMH";
                        cb.ValueMember = "sMaMH";
                    }
                }
            }
        }

        private void laytenmonhoc()
        {
            string constr = ConfigurationManager.ConnectionStrings["btl_C#"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM tblMonHoc", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable("Mb");
                        ad.Fill(tb);
                        cb.DataSource = tb;
                        cb.DisplayMember = "sTenMH";
                        cb.ValueMember = "";
                    }
                }
            }
        }
        private void btn_xoaDiem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa điểm này ??", "Thông báo ", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                xoaaDiem(Convert.ToString(cb_maSv.Text) , Convert.ToString(cb.Text) , float.Parse(mask_diemCC.Text));
                laydataGridDiem();
            }
            else
                Close();
        }
        public static bool spThem(string counter, int maSv, string hoTen, string ngaySinh, string gt)
        {
            using (SqlConnection cnn = new SqlConnection(counter))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "pr_themSua";
                    cmd.Parameters.AddWithValue("@maSv", maSv);
                    cmd.Parameters.AddWithValue("@hoTen", hoTen);
                    cmd.Parameters.AddWithValue("@ngaySinh", ngaySinh);
                    cmd.Parameters.AddWithValue("@gioiTinh", gt);
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();
                    return i > 0;

                }
            }

        }

        

        private void search_textbox(string x)
        {
            string sql = "SELECT  * FROM tblCTDiem WHERE CONCAT(sMaSV , sMaMH ) LIKE '%" + x + "%' OR sMaMH LIKE '%" + x + "%'";
            //string sql = "SELECT * FROM tblCTDiem WHERE sMaSV LIKE '&"+x+"%'";

            string couter = ConfigurationManager.ConnectionStrings["btl_c#"].ConnectionString;

            using (SqlConnection cnn = new SqlConnection(couter))
            {
                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable("tb_Diem");
                        ad.Fill(tb);
                        dataGridDiem.DataSource = tb;
                    }
                }
            }
           
        }

        private void cb_maMh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btkhoitao_Click(object sender, EventArgs e)
        {
            cb_maSv.Text = "";
            cb.Text = "";
            cb_ngaysinh.Text = "";
            mask_diemCC.Text = "";
            mask_diemGK.Text = "";
            mask_diemCK.Text = "";
        }
       
        public void sx()
        {
            string couter = ConfigurationManager.ConnectionStrings["btl_c#"].ConnectionString;

            using (SqlConnection cnn = new SqlConnection(couter))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM tblCTDiem ORDER BY fDiemTK asc", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable("tb_sx");
                        ad.Fill(tb);
                        dataGridDiem.DataSource = tb;
                        
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constr = ConfigurationManager.ConnectionStrings["btl_C#"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("tenmonho", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ten", cb.Text);
                    using (SqlDataAdapter ad = new SqlDataAdapter())
                    {
                        ad.SelectCommand = cmd;
                        DataTable data = new DataTable();
                        ad.Fill(data);
                        crClass1 rpt = new crClass1();
                        rpt.SetDataSource(data);
                        crystal.ReportSource = rpt;
                        crystal.Refresh();
                    }
                }
            }
        }

        private void tb_search_TextChanged_1(object sender, EventArgs e)
        {
            //search_textbox(tb_search.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            search_textbox(tk.Text);
        }
    }
}
