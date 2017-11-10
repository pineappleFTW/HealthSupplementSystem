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

        public static List<Customer> getCurrentList()
        {
            return customers;
        }

        public static void updateInformation(Customer currentCustomer)
        {

            Customer existingCustomer = customers.Find(x => x.ID == currentCustomer.ID);
            existingCustomer.FirstName = currentCustomer.FirstName;
            existingCustomer.LastName = currentCustomer.LastName;
            existingCustomer.CustomerType = currentCustomer.CustomerType;
            existingCustomer.Address = currentCustomer.Address;
            existingCustomer.PhoneNumber = currentCustomer.PhoneNumber;

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
