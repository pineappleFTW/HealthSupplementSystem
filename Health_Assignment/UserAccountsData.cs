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

        public static bool addUserAccount(UserAccount newUserAccount)
        {
            if (userAccounts.Contains(newUserAccount))
            {
                return false;
            }
            else
            {
                userAccounts.Add(newUserAccount);
                return true;
            }
            
        }

        public static void removeUserAccount(UserAccount userAccount)
        {
            userAccounts.Remove(userAccount);
        }

        public static void updateInformation(UserAccount userAccount)
        {

            UserAccount existingCustomer = userAccounts.Find(x => x.UserName == userAccount.UserName);
            int index = userAccounts.IndexOf(existingCustomer);
            userAccounts[index] = userAccount;


        }

        public static void deleteUserAccount(UserAccount userAccount)
        {
            userAccounts.Remove(userAccount);
        }
    }
}
