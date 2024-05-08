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
    public partial class QLSV : Form
    {
        
        public QLSV()
        {
            InitializeComponent();
        }
        void Decentralization()
        {
            if(Const.AccountType == false)
            {
                btn_them.Enabled = btn_sua.Enabled = btn_xoa.Enabled = bt_khoitao.Enabled = false;
            }
        }
        private void laydataGrid()
        {
            string couter = ConfigurationManager.ConnectionStrings["btl_c#"].ConnectionString;

            using (SqlConnection cnn = new SqlConnection(couter))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT sMaSV 'Mã sinh viên' ,sTenSV 'Tên sinh viên' , sGT 'Giới tính' , sQueQuan 'Quê quán' ,dNgaySinh AS 'Ngày sinh' , sMaLop AS 'Mã lớp' FROM tblSinhVien", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable("tb_SV2");
                        ad.Fill(tb);

                       
                    }
                }
            }
        }
        private void QLSV_Load(object sender, EventArgs e)
        {
            laydataGrid();
            layLop();
            cbxXem.Items.Add("Hiện danh sách sinh viên theo môn học");
            cbxXem.Items.Add("Kết quả học tập");
            //Decentralization();
            
        }

        public static bool themSVV(string masv, string hoten, DateTime ngaysinh, string gt, string quequan, string malop)
        {
            string counter = ConfigurationManager.ConnectionStrings["btl_C#"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(counter))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "pr_themsvv";
                    cmd.Parameters.AddWithValue("@masv", masv);
                    cmd.Parameters.AddWithValue("@tensv", hoten);
                    cmd.Parameters.AddWithValue("@gt", ngaysinh);
                    cmd.Parameters.AddWithValue("@quequan", gt);
                    cmd.Parameters.AddWithValue("@ngaysinh", quequan);
                    cmd.Parameters.AddWithValue("@malop", malop);
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();
                    return i > 0;

                }
            }

        }
        public static bool xoa(string masv)
        {
            string counter = ConfigurationManager.ConnectionStrings["btl_C#"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(counter))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "pr_xoamasv";
                    cmd.Parameters.AddWithValue("@masv", masv);
                    
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();
                    return i > 0;

                }
            }

        }
        public static bool themSv(string masv, string hoten, DateTime ngaysinh, string gt, string quequan, string malop)
        {
            
            string counter = ConfigurationManager.ConnectionStrings["btl_C#"].ConnectionString;

            string sqlInsert = "INSERT INTO tblSinhVien (sMaSv , sTenSV, sGT , sQueQuan , dNgaysinh , sMalop) " +
                "VALUES( N'" + masv + "' , N'" + hoten + "' , N'" + gt + "' , N'" + quequan + "' , '" + ngaysinh + "','" + malop + "')";
            using (SqlConnection cnn = new SqlConnection(counter))
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

        public static bool suaSv(string masv, string hoten,string gt, DateTime ngaysinh, string que)
        {
            string ctr = ConfigurationManager.ConnectionStrings["btl_C#"].ConnectionString;
            string sqlInsert = "Update tblSinhVien SET sTenSV = N'" + hoten + "' , sGT = N'"+gt+ "', dNgaySinh = N'" + ngaysinh + "',sQueQuan = N'" + que + "' WHERE sMaSV = '" + masv + "'  ";
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

        public static bool xoaaSv(String masv)
        {
            string ctr = ConfigurationManager.ConnectionStrings["btl_C#"].ConnectionString;
            string sqlInsert = "DELETE FROM tblSinhVien WHERE sMaSV = '" + masv + "'";
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

        private void btn_them_Click(object sender, EventArgs e)
        {
            string counter = ConfigurationManager.ConnectionStrings["btl_C#"].ConnectionString;
            DateTime ngaysinh = dtTime.Value;
            int ngaysinhHt = ngaysinh.Day;
            int thangsinhHt = ngaysinh.Month;
            int namsinhHt = ngaysinh.Year;

            int ngay = DateTime.Now.Day;
            int thang = DateTime.Now.Month;
            int nam = DateTime.Now.Year;
           
            using(SqlConnection cnn = new SqlConnection(counter))
            {
                cnn.Open();
                string keyToCheck = Convert.ToString(mask_maSV.Text); // Thay thế bằng giá trị khóa bạn muốn kiểm tra
                string query = "SELECT COUNT(*) FROM tblSinhVien WHERE sMaSV = @KeyToCheck";

                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    cmd.Parameters.AddWithValue("@KeyToCheck", keyToCheck);

                    int count = (int)cmd.ExecuteScalar(); // Lấy số lượng dòng khớp với khóa

                    if (count > 0)
                    {
                        // Khóa đã tồn tại
                        MessageBox.Show("Khóa đã tồn tại trong cơ sở dữ liệu." + count);
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(mask_maSV.Text))
                            MessageBox.Show("Bạn cần nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                        {
                            if (nam - namsinhHt < 18)
                            {
                                MessageBox.Show("Nam sinh kh hop le", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                            else
                            {
                                if (thangsinhHt <= thang)
                                {
                                    if (ngaysinhHt <= ngay)
                                    {
                                        checkMaSV();
                                        themSv(Convert.ToString(mask_maSV.Text), Convert.ToString(mask_tenSv.Text), ngaysinh, Convert.ToString(mask_GT.Text), Convert.ToString(mask_queQuan.Text), Convert.ToString(combo_malop.Text));
                                        laydataGrid();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Ngay sinh kh hop le", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        return;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Thang sinh kh hop le", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;
                                }
                            }


                        }
                    }
                }
            }
                   
        }
        private void dtGridSV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            mask_maSV.Text = dtGridSV.CurrentRow.Cells["Mã sinh viên"].Value.ToString();
            mask_tenSv.Text = dtGridSV.CurrentRow.Cells["Tên sinh viên"].Value.ToString();
            mask_GT.Text = dtGridSV.CurrentRow.Cells["Giới tính"].Value.ToString();
            dtTime.Text = dtGridSV.CurrentRow.Cells["Ngày sinh"].Value.ToString();
            mask_queQuan.Text = dtGridSV.CurrentRow.Cells["Quê quán"].Value.ToString();
         
        }

        private void layLop()
        {
            string constr = ConfigurationManager.ConnectionStrings["btl_C#"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM tblLop", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable("Lop");
                        ad.Fill(tb);
                        combo_malop.DataSource = tb;
                        combo_malop.DisplayMember = "sMaLop";
                        combo_malop.ValueMember = "sTenLop";
                    }
                }
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(mask_maSV.Text))
            {
                MessageBox.Show("Bạn cần nhập mã sinh viên cần xóa",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa sinh viên này ??", "Thông báo ", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    xoa(Convert.ToString(mask_maSV.Text));
                    laydataGrid();
                }
                else
                    Close();
            }   
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(mask_maSV.Text))
            {
                MessageBox.Show("Bạn cần nhập mã sinh viên cần sửa",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                suaSv(Convert.ToString(mask_maSV.Text), Convert.ToString(mask_tenSv.Text),Convert.ToString(mask_GT.Text), dtTime.Value, Convert.ToString(mask_queQuan.Text));
                laydataGrid();
                mask_maSV.Enabled = true;
            }       
        }

        private void search_textbox(string x)
        {
            
            string sql = "SELECT * FROM tblSinhVien WHERE CONCAT(sMaSV , sTenSV ) LIKE '%" + x + "%'";
            string couter = ConfigurationManager.ConnectionStrings["btl_c#"].ConnectionString;

            using (SqlConnection cnn = new SqlConnection(couter))
            {
                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable("tb_SinhVien");
                        ad.Fill(tb);
                        dtGridSV.DataSource = tb;
                    }
                }
            }
        }

        private void tb_Search_TextChanged(object sender, EventArgs e)
        {
            //search_textbox(tb_Search.Text);
        }
        private void btnChon_Click_1(object sender, EventArgs e)
        {
            if (cbxXem.SelectedIndex == 0)
            {
                hienDSDiemTheoMon f = new hienDSDiemTheoMon();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else if(cbxXem.SelectedIndex == 1)
            {
                if (!string.IsNullOrEmpty(mask_maSV.Text))
                {
                    ketQuaHocTap f = new ketQuaHocTap();
                    f.MaSV = mask_maSV.Text;
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                    
                    
                }
                else
                {
                    MessageBox.Show("Mã sinh viên để trống\n Không thể xem!!!", 
                        "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                //throw new Exception("Bạn lựa chọn chưa chính xác");
                MessageBox.Show("Lựa chọn chưa chính xác để xem", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bt_khoitao_Click(object sender, EventArgs e)
        {
            mask_maSV.Text = "";
            mask_tenSv.Text = "";
            mask_GT.Text = "";
            
            mask_queQuan.Text = "";
         
        }

        private void btChon_Click(object sender, EventArgs e)
        {
            Form4 ql = new Form4();       
            ql.ShowDialog();
        }

        private void dtGridSV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //FormDiemSV diem = new FormDiemSV(mask_tenSv.Text, mask_GT.Text, mask_ngaySinh.Text, mask_queQuan.Text, mask_maSV.Text);
            //FormDiemSV diem = new FormDiemSV();
            //diem.Show();
        }

       void checkMaSV()
        {
            string inputText = mask_maSV.Text;
            int charactersToTake = 1; // Số ký tự bạn muốn lấy
            string leftPart = inputText.Substring(0, charactersToTake);


            string inputText1 = mask_maSV.Text;
            int charactersToTake1 = 5; // Số kí tự bạn muốn lấy
            string rightPart = inputText.Substring(inputText.Length - charactersToTake1);
            if (leftPart != "A")
            {
                MessageBox.Show("Mã sinh viên bắt đầu bằng kí tự A", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mask_maSV.Text = "";
                mask_maSV.Focus();

            }
            
        }

        private void cbxXem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
