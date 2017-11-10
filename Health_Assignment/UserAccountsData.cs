using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health_Assignment
{
    public class UserAccountsData
    {
        public static List<UserAccount> userAccounts = new List<UserAccount>();

        public static List<UserAccount> initializeAccount()
        {
            userAccounts.Add(new UserAccount("admin", "1234"));

            return userAccounts;
        }

        public static Boolean checkAuthorization(UserAccount ua)
        {
            Boolean isAuthorized = userAccounts.Contains(ua);

            return isAuthorized;
        }

        
    }
}
