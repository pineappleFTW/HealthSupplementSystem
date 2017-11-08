using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health_Assignment
{
    class Sales
    {
        public int ID { set; get; }
        public int CustomerID { set; get; }
        public string CustomerName { set; get; }
        public Boolean IsPaid { set; get; }
        public string Status { set; get; }
        public string PaymentMode { set; get; }
        public List<int> ProductsOrdered { set; get; }
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
                OrderDate = orderDate;
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
                PaymentDate = paymentDate;
            }
        }


        public int generateID()
        {
            return ++ID_INCREMENT;
        }

        public Sales() { }

        public Sales(int customerID,string customerName,Boolean isPaid,string status,string paymentMode,List<int> productsOrdered,List<int> productsQuantity,DateTime orderDate,DateTime paymentDate)
        {
            ID = generateID();
            CustomerID = customerID;
            CustomerName = customerName;
            IsPaid = isPaid;
            Status = status;
            PaymentMode = paymentMode;
            ProductsOrdered = productsOrdered;
            ProductsQuantity = productsQuantity;
            OrderDate = orderDate;
            PaymentDate = paymentDate;
        }



    }
}
