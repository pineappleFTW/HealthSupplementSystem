using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health_Assignment
{
    public class UserAccount
    {
        public string UserName { get; set; }
        public string Password { get; set; }

        public UserAccount(string username,string pw)
        {
            UserName = username;
            Password = pw;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            UserAccount userAccount = (UserAccount)obj;
            {
                return ( UserName.Equals(userAccount.UserName)) && (Password.Equals(userAccount.Password));
            }


        }
    }
}
