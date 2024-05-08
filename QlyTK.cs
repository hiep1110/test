using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_2023_c
{
    public partial class QlyTK : Form
    {
        List<string> listAccountType = new List<string>() { "Giao vien", "Sinh vien" };
        int index = -1;
        public QlyTK()
        {
            InitializeComponent();
        }

        void LoadListUser()
        {
            dtgTk.DataSource = null;
            dtgTk.DataSource = ListUser.Instance.ListAcountUser;
            
        }

        private void QlyTK_Load(object sender, EventArgs e)
        {
            cbLoai.DataSource = listAccountType;
            LoadListUser();
        }

        private void dtgTk_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            txbUserName.Text = dtgTk.Rows[index].Cells[0].Value.ToString();
            txbPass.Text = dtgTk.Rows[index].Cells[1].Value.ToString();
            switch (ListUser.Instance.ListAcountUser[index].AccountType)
            {
                case true: cbLoai.Text = "Giao vien";
                    break;
                case false: cbLoai.Text = "Sinh vien";
                    break;
            }
        }

        private void btnTHem_Click(object sender, EventArgs e)
        {
            string userName = txbUserName.Text;
            string passWord = txbPass.Text;
            bool accountType = false;
            switch (cbLoai.Text)
            {
                case "Giao vien":
                    accountType = true;
                    break;
                case "Sinh vien":
                    accountType = false;
                    break;
            }
            ListUser.Instance.ListAcountUser.Add(new User(userName, passWord, accountType));
            LoadListUser();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            string userName = txbUserName.Text;
            string passWord = txbPass.Text;
            bool accountType = false;
            switch (cbLoai.Text)
            {
                case "Quan ly":
                    accountType = true;
                    break;
                case "Sinh vien":
                    accountType = false;
                    break;
            }
            ListUser.Instance.ListAcountUser[index].UserName = userName;
            ListUser.Instance.ListAcountUser[index].PassWord = passWord;
            ListUser.Instance.ListAcountUser[index].AccountType = accountType;
            LoadListUser();
        }
    }
}
