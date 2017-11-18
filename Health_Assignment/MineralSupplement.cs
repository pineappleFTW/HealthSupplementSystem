using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health_Assignment
{
    public class MineralSupplement:Product
    {
        public MineralSupplement() { }

        public MineralSupplement(string name, string desc, string pres, string manufacturer, decimal price, int quantity):base(name,desc,pres,manufacturer,price,quantity)
        {
            Category = "Mineral Supplement";
        }

        public MineralSupplement(int id, string name, string desc, string pres, string manufacturer, decimal price, int quantity) : base(id, name, desc, pres, manufacturer, price, quantity)
        {
            Category = "Mineral Supplement";
        }
    }
}
