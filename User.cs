using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_2023_c
{
    class User
    {
        private string userName, passWord;
        private bool accountType;

        public string UserName { get => userName; set => userName = value; }
        public string PassWord { get => passWord; set => passWord = value; }
        public bool AccountType { get => accountType; set => accountType = value; }

        public User(string userName, string passWord,bool acoountType)
        {
            this.UserName = userName;
            this.PassWord = passWord;
            this.AccountType = acoountType;
        }
    }
}
