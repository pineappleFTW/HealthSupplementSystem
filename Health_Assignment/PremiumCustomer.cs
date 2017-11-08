using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health_Assignment
{
    class PremiumCustomer:Customer
    {
        private decimal creditLimit;

        public decimal CreditLimit
        {
            set
            {
                if (value >= 0)
                {
                    creditLimit = value;
                }
            }
            get
            {
                return creditLimit;
            }
        }

        public PremiumCustomer()
        {

        }

        public PremiumCustomer(string fn,string ln,string address,string customerType,string phoneNumber,decimal creditLimit):base(fn,ln,address,customerType,phoneNumber)
        {
            CreditLimit = creditLimit;
        }
    }


}
