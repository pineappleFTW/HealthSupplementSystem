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
            
            customers.Add(new PremiumCustomer("Li Sheng", "Ong", "Taman Mutiara Barat Cheras", "Premium", "0102398273",100M));
            customers.Add(new NormalCustomer("Shi Hern", "Lim", "Bandar Utama", "Normal", "012832812"));
            customers.Add(new NormalCustomer("Wei Zheng", "Chia", "Tmaman Satu Klang", "Normal", "012398289"));
            customers.Add(new NormalCustomer("Cuok Syen", "Teh", "Taman Ceras Rawang", "Normal", "0183923828"));
            customers.Add(new NormalCustomer("Awad", "Muhammad", "Jalan University Sunway", "Normal", "019302672"));
            customers.Add(new NormalCustomer("Kai Wern", "Choong", "Jalan Panglima Penang", "Normal", "0173822188"));

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
