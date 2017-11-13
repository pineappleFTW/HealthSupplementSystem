using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health_Assignment
{
    public class CustomersData
    {
        public static List<Customer> customers = new List<Customer>();

        public static List<Customer> initializeData()
        {
            
            customers.Add(new PremiumCustomer("lisheng", "ong", "address", "Premium", "34573487",100M));
            customers.Add(new NormalCustomer("hahhaa", "ong", "sdaddress", "Normal", "34573487"));
            customers.Add(new NormalCustomer("shihern", "lim", "sdaddrdsss", "Normal", "12345"));
            customers.Add(new NormalCustomer("josh", "teh", "sdaddress", "Normal", "12345"));
            customers.Add(new NormalCustomer("awad", "lol", "sdaddress", "Normal", "12345"));
            customers.Add(new NormalCustomer("awad", "lsssol", "sdaddress", "Normal", "12345"));

            return customers;
        }

        public static List<Customer> getCurrentList()
        {
            return customers;
        }

        public static void updateInformation(Customer currentCustomer)
        {

            Customer existingCustomer = customers.Find(x => x.ID == currentCustomer.ID);
            int index = customers.IndexOf(existingCustomer);
            if (currentCustomer.CustomerType.Equals("Premium"))
            {
                PremiumCustomer existingPremiumCustomer = (PremiumCustomer)currentCustomer;
                customers[index] = existingPremiumCustomer;
            }
            else
            {
                NormalCustomer existingNormalCustomer = (NormalCustomer)currentCustomer;
                customers[index] = existingNormalCustomer;
            }
            

        }

        public static void addNewCustomer(Customer newCustomer)
        {
            customers.Add(newCustomer);
        }

        public static void deleteCustomer(Customer customer)
        {
            customers.Remove(customer);
        }
    }
}
