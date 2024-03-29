﻿using System;
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
            sales.Add(new Sales(CustomersData.customers[2], true, "Delivered", "Cash", new List<int>(new int[] { 122, 233, 443 }), new List<int>(new int[] { 1, 2, 3 }), new DateTime(2017,1,21), new DateTime(2017,12,31)));
            sales.Add(new Sales(CustomersData.customers[0], true, "Delivered", "Cash", new List<int>(new int[] { 122, 233, 443 }), new List<int>(new int[] { 1, 2, 3 }), new DateTime(2017,2,12), new DateTime(2012,2,26)));
            sales.Add(new Sales(CustomersData.customers[1], true, "Delivered", "Cash", new List<int>(new int[] { 122, 233, 443 }), new List<int>(new int[] { 1, 2, 3 }), new DateTime(2017,1,23), new DateTime(2017,2,23)));

            return sales;
        }

        public static List<Sales> getCurrentList()
        {
            return sales;
        }

    }
}
