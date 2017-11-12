using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health_Assignment
{
    public class Product
    {
        public int ID { set; get; }
        public string Name { set; get; }
        public string Description { set; get; }
        public string Prescription { set; get; }
        public string Manufacturer { set; get; }
        private static int ID_INCREMENT=0;

        private decimal price;
        private int quantity;

        public decimal Price
        {
            get
            {
                return price;
            }
            set
            {
                if (value >= 0)
                {
                    price = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Price", value, "Price must be >=0");
                }
            }
        }

        public int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                if (value >= 0)
                {
                    quantity = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Quantity", value, "Quantity must be >=0");
                }
            }
        }

        public Product() { }

        public Product(string name,string desc,string pres,string manufacturer,decimal price,int quantity)
        {
            ID = generateID();
            Name = name;
            Description = desc;
            Prescription = pres;
            Manufacturer = manufacturer;
            Price = price;
            Quantity = quantity;
        }

        public Product(int id, string name, string desc, string pres, string manufacturer, decimal price, int quantity)
        {
            ID = id;
            Name = name;
            Description = desc;
            Prescription = pres;
            Manufacturer = manufacturer;
            Price = price;
            Quantity = quantity;
        }

        public int generateID()
        {
            return ++ID_INCREMENT;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Product product = (Product)obj;
            {
                return (ID == product.ID) && (Name == product.Name);
            }


        }

        public override string ToString()
        {
            return String.Format("{0} : {1}", ID, Name);
        }

    }
}
