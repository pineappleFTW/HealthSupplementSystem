using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health_Assignment
{
    public class Customer
    {

     
        public int ID { set; get; }
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public string Address { set; get; }
        public string CustomerType { set; get; }
        public string PhoneNumber { set; get; }
        private static int ID_INCREMENT = 0;

        public Customer() { }

        public Customer(string fn, string ln, string add,string cusType,string phone)
        {
            ID = generateID();
            FirstName = fn;
            LastName = ln;
            Address = add;
            CustomerType = cusType;
            PhoneNumber = phone;
        }
        public Customer(int id,string fn, string ln, string add, string cusType, string phone)
        {
            ID = id;
            FirstName = fn;
            LastName = ln;
            Address = add;
            CustomerType = cusType;
            PhoneNumber = phone;
        }


        public int generateID()
        {
            return ++ID_INCREMENT;
        }

        public override bool Equals(object obj)
        {
            if(obj == null || GetType() !=obj.GetType())
            {
                return false;
            }

            Customer customer = (Customer)obj;
            {
                return (ID == customer.ID) && (FirstName == customer.FirstName) && (LastName == customer.LastName);
            }


        }


    }
}
