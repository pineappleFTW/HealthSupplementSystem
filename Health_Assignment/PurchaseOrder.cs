using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health_Assignment
{
    public class PurchaseOrder
    {
        public int ID { set; get; }
        public Product CurrentProduct {set;get;}
        private DateTime date;
        private int quantity;
        public Boolean IsObtained { set; get; }
        private static int ID_INCREMENT = 0;

        public DateTime Date
        {
            get
            {
                return date;
            }
            set
            {
                DateTime currentDate = DateTime.Now;
                if (date.Year == currentDate.Year && date.Month <= currentDate.Month)
                {
                    date = value;
                }
                if (date.Year < currentDate.Year)
                {
                    date = value;
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
                
            }
        }

        public int generateID()
        {
            return ++ID_INCREMENT;
        }

        public PurchaseOrder(Product product,DateTime date,int quantity)
        {
            ID = generateID();
            CurrentProduct = product;
            Date = date;
            Quantity = quantity;
            IsObtained = false;
        }

        public PurchaseOrder(int id,Product product, DateTime date, int quantity,Boolean isObtained)
        {
            ID = id;
            CurrentProduct = product;
            Date = date;
            Quantity = quantity;
            IsObtained = isObtained;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            PurchaseOrder purchaseOrder = (PurchaseOrder)obj;
            {
                return (ID == purchaseOrder.ID) && (CurrentProduct == purchaseOrder.CurrentProduct);
            }


        }

        
    }
}
