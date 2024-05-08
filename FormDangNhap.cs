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
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }
        bool checkLogin(string userName, string passWord)
        {
            for(int i = 0; i< ListUser.Instance.ListAcountUser.Count; i++)
            {
                if (userName == ListUser.Instance.ListAcountUser[i].UserName && passWord == ListUser.Instance.ListAcountUser[i].PassWord)
                {
                    Const.AccountType = ListUser.Instance.ListAcountUser[i].AccountType;
                    return true;
                }

            }
            return false;
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string userName = txbUserName.Text;
            string passWord = txbPass.Text;
            if (checkLogin(userName,passWord))
            {
                Form1 f = new Form1();
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Ban da nhap sai tai khoan hoac mat khau", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbUserName.Focus();
                return;
            }
            
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (cbcheck.Checked)
            
                txbPass.UseSystemPasswordChar = false;
            
            if (!cbcheck.Checked)
            
                txbPass.UseSystemPasswordChar = true;
            
        }
    }
}
