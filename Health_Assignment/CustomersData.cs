using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health_Assignment
{
    public class CustomersData
    {
        static List<Customer> customers = new List<Customer>();

        public static List<Customer> initializeData()
        {
            
            customers.Add(new Customer("lisheng", "ong", "address", "premium", "34573487"));
            customers.Add(new Customer("hahhaa", "ong", "sdaddress", "normal", "34573487"));

            return customers;
        }

        public static void updateInformation(Customer currentCustomer)
        {
            foreach(Customer currentCust in customers)
            {
                if (currentCust.ID == currentCustomer.ID)
                {
                    currentCust.FirstName = currentCustomer.FirstName;
                    currentCust.LastName = currentCustomer.LastName;
                }
            }
        }
    }
}
