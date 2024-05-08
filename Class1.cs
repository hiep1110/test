using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace BTL_2023_c
{
    class Class1
    {
        public string str = ConfigurationManager.ConnectionStrings["btl_c#"].ConnectionString;
        public SqlConnection cnn = new SqlConnection();
        public bool ketnoi()
        {
            try
            {
                if (cnn.State == ConnectionState.Open) cnn.Open();
                cnn.ConnectionString = str;
                cnn.Open();

            }
            catch
            {
                MessageBox.Show("Loi ket noi co so du lieu", "Thong baos");
                return false;
            }
            return true;
        }
        public DataTable getTable(string tenbang)
        {
            string sql = "select * from" + tenbang;
            SqlDataAdapter ad = new SqlDataAdapter(sql,cnn);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt;
        }
        public DataTable getData(SqlCommand cmd)
        {
            cmd.Connection = cnn;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            da.Fill(tbl);
            return tbl;
        }
        public void loadComBoBox(SqlCommand cmd, ComboBox cbb)
        {
            DataTable tbl = getData(cmd);
            cbb.DataSource = tbl;
            cbb.ValueMember = tbl.Columns[0].ColumnName;
            cbb.DisplayMember = tbl.Columns[1].ColumnName;
        }
    }
}
