using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health_Assignment
{
    class NormalCustomer:Customer
    {
        public NormalCustomer() { }

        public NormalCustomer(string fn, string ln, string add, string customerType, string phoneNumber) : base(fn, ln, add, customerType, phoneNumber) { }

        public NormalCustomer(int id,string fn, string ln, string add, string customerType, string phoneNumber) : base(id,fn, ln, add, customerType, phoneNumber) { }


    }
}
