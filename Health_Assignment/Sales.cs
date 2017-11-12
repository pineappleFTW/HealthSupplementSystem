using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health_Assignment
{
    public class Sales
    {
        public int ID { set; get; }
        public Customer CurrentCustomer { set; get; }
        public Boolean IsPaid { set; get; }
        public string Status { set; get; }
        public string PaymentMode { set; get; }
        public List<Product> ProductsOrdered { set; get; }
        public List<int> ProductsQuantity { set; get; }

        private DateTime orderDate;
        private DateTime paymentDate;
        private static int ID_INCREMENT = 0;

        public DateTime OrderDate {
            get
            {
                return orderDate;
            }
            set
            {
                DateTime currentDate = DateTime.Now;
                if (orderDate.Year == currentDate.Year && orderDate.Month<=currentDate.Month)
                {
                    orderDate = value;
                }
                if (orderDate.Year < currentDate.Year)
                {
                    orderDate = value;
                }
                
            }
        }

        public DateTime PaymentDate
        {
            get
            {
                return paymentDate;
            }
            set
            {
                DateTime currentDate = DateTime.Now;
                if (orderDate.Year == currentDate.Year && orderDate.Month <= currentDate.Month)
                {
                    paymentDate = value;
                }
                if (orderDate.Year < currentDate.Year)
                {
                    paymentDate = value;
                }
            }
        }


        public int generateID()
        {
            return ++ID_INCREMENT;
        }

        public Sales() { }

        public Sales(Customer currentCustomer,Boolean isPaid,string status,string paymentMode,List<Product> productsOrdered,List<int> productsQuantity,DateTime orderDate,DateTime paymentDate)
        {
            ID = generateID();
            CurrentCustomer = currentCustomer;
            IsPaid = isPaid;
            Status = status;
            PaymentMode = paymentMode;
            ProductsOrdered = productsOrdered;
            ProductsQuantity = productsQuantity;
            OrderDate = orderDate;
            PaymentDate = paymentDate;
        }

        public Sales(int id,Customer currentCustomer, Boolean isPaid, string status, string paymentMode, List<Product> productsOrdered, List<int> productsQuantity, DateTime orderDate, DateTime paymentDate)
        {
            ID = id;
            CurrentCustomer = currentCustomer;
            IsPaid = isPaid;
            Status = status;
            PaymentMode = paymentMode;
            ProductsOrdered = productsOrdered;
            ProductsQuantity = productsQuantity;
            OrderDate = orderDate;
            PaymentDate = paymentDate;
        }

        public decimal totalCost()
        {
            decimal totalSum = 0;
            for(int i = 0; i < ProductsOrdered.Count; i++)
            {
                totalSum += ProductsOrdered[i].Price * ProductsQuantity[i];
            }

            return totalSum;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            Sales sales = (Sales)obj;
            {
                return (ID == sales.ID) && (CurrentCustomer == sales.CurrentCustomer);
            }


        }

    }
}
