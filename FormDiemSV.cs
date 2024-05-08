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
    public partial class FormDiemSV : Form
    {
        public FormDiemSV()
        {
            InitializeComponent();
            /*lbTenSv.Text = ten;
            lbGt.Text = gt;
            lbNgaySinh.Text = ngaysinh;
            lbQue.Text = quequan;
            lbMaSV.Text = masv;*/

        }

        public void laydataGrid()
        {
            string couter = ConfigurationManager.ConnectionStrings["btl_c#"].ConnectionString;

            using (SqlConnection cnn = new SqlConnection(couter))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT tblSinhVien.sMaSV,tblSinhVien.sTenSV,tblMonHoc.sMaMH as 'Ma mon hoc',tblMonHoc.sTenMH as 'Ten mon hoc',tblMonHoc.iSoTC as 'So tin chi',tblCTDiem.dNgayHoc as 'Ngay hoc'" +
                    ",tblCTDiem.fDiemCC as 'Diem chuyen can',tblCTDiem.fDiemBK as 'Diem giua ki',tblCTDiem.fDiemHK as 'Diem hoc ki',tblCTDiem.fDiemTK as 'Diem tong ket'" +
                    "from tblMonHoc,tblCTDiem,tblSinhVien WHERE tblMonHoc.sMaMH = tblCTDiem.sMaMH and tblCTDiem.sMaSV = tblSinhVien.sMaSV and tblCTDiem.fDiemTK > 2", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable("tb_DSV2");
                        ad.Fill(tb);
                        dtgDiem.DataSource = tb;
                    }
                }
            }
        }

        private void FormDiemSV_Load(object sender, EventArgs e)
        {
            laydataGrid();
        }

        private void lbNgaySinh_Click(object sender, EventArgs e)
        {

        }

        
    }
}
