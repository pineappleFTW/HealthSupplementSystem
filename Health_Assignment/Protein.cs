using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health_Assignment
{
    public class Protein:Product
    {
        public Protein() { }

        public Protein(string name, string desc, string pres, string manufacturer, decimal price, int quantity):base(name,desc,pres,manufacturer,price,quantity)
        {
            Category = "Protein";
        }

        public Protein(int id, string name, string desc, string pres, string manufacturer, decimal price, int quantity) : base(id, name, desc, pres, manufacturer, price, quantity)
        {
            Category = "Protein";
        }

    }
}
