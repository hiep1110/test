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

namespace BTL_2023_c
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            hientenMonhoc();
        }
        void hientenMonhoc()
        {
            string constr = ConfigurationManager.ConnectionStrings["btl_C#"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand("Select * from tblMonHoc", cnn))
                {
                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            cbMaMon.Items.Add(rd["sMaMH"].ToString());
                        }
                    }
                }
                cnn.Close();
            }
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            
        }

        private void cryMonhoc_Load(object sender, EventArgs e)
        {
            
        }

        private void btChon_Click(object sender, EventArgs e)
        {
            string constr = ConfigurationManager.ConnectionStrings["btl_C#"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("sp_DsMonhoc", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@mamon", cbMaMon.Text);
                    using (SqlDataAdapter ad = new SqlDataAdapter())
                    {
                        ad.SelectCommand = cmd;
                        DataTable data = new DataTable();
                        ad.Fill(data);
                        CrystalReport1 rpt = new CrystalReport1();
                        rpt.SetDataSource(data);
                        cryMonhoc.ReportSource = rpt;
                        cryMonhoc.Refresh();
                    }
                }
            }
        }
    }
}
