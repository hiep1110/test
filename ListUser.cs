using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_2023_c
{
    class ListUser
    {
        private static ListUser instance;
        private List<User> listAcountUser;

        public static ListUser Instance {
            get
            {
                if (instance == null)
                    instance = new ListUser();
                return instance;
            }
            set => instance = value; 
        }
        public List<User> ListAcountUser { get => listAcountUser; set => listAcountUser = value; }
        private ListUser()
        {
            listAcountUser = new List<User>();
            listAcountUser.Add(new User("dv", "1234",true));
            listAcountUser.Add(new User("hiep", "1234",false));
            listAcountUser.Add(new User("dv1", "1234", false));
        }
    }
}
