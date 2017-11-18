using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health_Assignment
{
    class PurchaseOrdersData
    {
        public static List<PurchaseOrder> purchaseOrders = new List<PurchaseOrder>();

        public static List<PurchaseOrder> initializeData()
        {
            purchaseOrders.Add(new PurchaseOrder(ProductsData.products[0], new DateTime(2017, 11, 13), 5));
            purchaseOrders.Add(new PurchaseOrder(ProductsData.products[1], new DateTime(2017, 10, 13), 5));
            purchaseOrders.Add(new PurchaseOrder(ProductsData.products[2], new DateTime(2017, 8, 11), 15));
            purchaseOrders.Add(new PurchaseOrder(ProductsData.products[2], new DateTime(2017, 5, 1), 15));
            purchaseOrders.Add(new PurchaseOrder(ProductsData.products[2], new DateTime(2017, 3, 13), 25));
            purchaseOrders.Add(new PurchaseOrder(ProductsData.products[2], new DateTime(2017, 2, 13), 53));
            return purchaseOrders;
        }

        public static List<PurchaseOrder> getCurrentList()
        {
            return purchaseOrders;
        }

        public static void addNewPurchaseOrder(PurchaseOrder newPurchaseOrder)
        {
            purchaseOrders.Add(newPurchaseOrder);
        }

        public static void deletePurchaseOrder(PurchaseOrder purchaseOrder)
        {
            purchaseOrders.Remove(purchaseOrder);
        }
    }
}
