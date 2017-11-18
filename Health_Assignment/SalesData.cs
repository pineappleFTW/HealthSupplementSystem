using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health_Assignment
{
    public class SalesData
    {
        public static List<Sales> sales = new List<Sales>();


        public static List<Sales> initializeData()
        {
            sales.Add(new Sales(CustomersData.customers[2], true, "Delivered", "Debit Card", new List<Product>(new Product[] { ProductsData.products[0], ProductsData.products[1] } ), new List<int>(new int[] { 1, 2 }), new DateTime(2017, 1, 21), new DateTime(2017, 1, 23)));
            sales.Add(new Sales(CustomersData.customers[1], true, "Delivered", "Cash", new List<Product>(new Product[] { ProductsData.products[1], ProductsData.products[2] }), new List<int>(new int[] { 2, 3 }), new DateTime(2017, 1, 23), new DateTime(2017, 1, 25)));
            sales.Add(new Sales(CustomersData.customers[0], true, "Delivered", "Cash", new List<Product>(new Product[] { ProductsData.products[2]} ), new List<int>(new int[] { 3 }), new DateTime(2017,2,12), new DateTime(2017,2,26)));
           

            return sales;
        }

        public static List<Sales> getCurrentList()
        {
            return sales;
        }

        public static void addNewSales(Sales newSales)
        {
            sales.Add(newSales);
        }

        public static void updateInformation(Sales currentSales)
        {
            Sales existingSales = sales.Find(x => x.ID == currentSales.ID);
            int index = sales.IndexOf(existingSales);
            sales[index] = currentSales;

        }

        public static void deleteSales(Sales currentSales)
        {
            sales.Remove(currentSales);
        }
    }
}
