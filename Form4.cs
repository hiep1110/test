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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            hienTenKhoa();
            cbTenKhoa.SelectedIndexChanged += new EventHandler(cbTenKhoa_SelectedIndexChanged);
            //hienmaSV();
        }
        void hienTenKhoa()
        {
            string constr = ConfigurationManager.ConnectionStrings["btl_C#"].ConnectionString;          
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand("Select * from tblKhoa", cnn))
                {
                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            cbTenKhoa.Items.Add(rd["sTenKhoa"].ToString());
                        }
                    }
                }
                cnn.Close();
                cbTenKhoa.SelectedIndexChanged += new EventHandler(cbTenKhoa_SelectedIndexChanged);
            }
        }
        void hienTenLop()
        {
            string constr = ConfigurationManager.ConnectionStrings["btl_C#"].ConnectionString;
            string tenkhoa = cbTenKhoa.Text; 

            using (SqlConnection cnn = new SqlConnection(constr))
            {
                cnn.Open();
                string query = "SELECT * FROM tblLop,tblKhoa WHERE tblLop.sMaKhoa = tblKhoa.sMaKhoa and sTenKhoa = @tenkhoa";

                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    cmd.Parameters.AddWithValue("@tenkhoa", tenkhoa);
                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            cbTenLop.Items.Add(rd["sTenLop"].ToString());
                        }
                    }
                }
                cnn.Close();
                cbTenLop.SelectedIndexChanged += new EventHandler(cbTenLop_SelectedIndexChanged);
            }
        }
        private void cbTenKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbTenLop.Items.Clear(); // Xóa dữ liệu cũ khi thay đổi chọn
            hienTenLop();
            cbTenLop.SelectedIndexChanged += new EventHandler(cbTenLop_SelectedIndexChanged);

        }

        void hienmaSV()
        {
            string constr = ConfigurationManager.ConnectionStrings["btl_C#"].ConnectionString;
            string tenLop = cbTenLop.Text;
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand("Select * from tblSinhVien,tblLop where tblSinhVien.sMaLop = tblLop.sMaLop and tblLop.sTenLop = @tenlop", cnn))
                {
                    cmd.Parameters.AddWithValue("@tenlop", tenLop);
                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            cbmaSV.Items.Add(rd["sMaSV"].ToString());
                        }
                    }
                }
                cnn.Close();
            }
        }
        private void cbTenLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbmaSV.Items.Clear();
            hienmaSV();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
           
        }

        private void btchon_Click(object sender, EventArgs e)
        {
            string constr = ConfigurationManager.ConnectionStrings["btl_C#"].ConnectionString;           
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("sp_TenMonSoTinchi", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@sv", cbmaSV.Text);
                    using (SqlDataAdapter ad = new SqlDataAdapter())
                    {
                        ad.SelectCommand = cmd;
                        DataTable data = new DataTable();
                        ad.Fill(data);
                        CrystalReport2 rpt = new CrystalReport2();
                        rpt.SetDataSource(data);
                        cryMaSV.ReportSource = rpt;
                        cryMaSV.Refresh();
                    }
                }
            }
            /*ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load(@"C:\Users\dell\Downloads\BTL_2023_c\BTL_2023_c\BaoCao\CryGK.rpt");
            ParameterFieldDefinition pfd = cryRpt.DataDefinition.ParameterFields["nguoi"];
            ParameterValues pv = new ParameterValues();
            ParameterDiscreteValue pdv = new ParameterDiscreteValue();
            pdv.Value = txtTenNguoiLap.Text;
            pv.Add(pdv);
            pfd.CurrentValues.Clear();
            pfd.ApplyCurrentValues(pv);
            cryMaSV.ReportSource = cryRpt;
            cryMaSV.Refresh();*/

        }

        
    }
}
