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
            
            customers.Add(new Customer("lisheng", "ong", "address", "Premium", "34573487"));
            customers.Add(new Customer("hahhaa", "ong", "sdaddress", "Normal", "34573487"));
            customers.Add(new Customer("shihern", "lim", "sdaddrdsss", "Normal", "12345"));
            customers.Add(new Customer("josh", "teh", "sdaddress", "Normal", "12345"));
            customers.Add(new Customer("awad", "lol", "sdaddress", "Normal", "12345"));

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
