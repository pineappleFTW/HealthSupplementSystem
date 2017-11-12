using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Health_Assignment
{
    public partial class ReportUserControl : UserControl
    {
        public List<Sales> currentListOfSales;

        public ReportUserControl()
        {
            InitializeComponent();
        }

        private void ReportUserControl_Load(object sender, EventArgs e)
        {
            comboBox_month.Items.Add(1);
            comboBox_month.Items.Add(2);
            comboBox_month.Items.Add(3);
            comboBox_month.Items.Add(4);
            comboBox_month.Items.Add(5);
            comboBox_month.Items.Add(6);
            comboBox_month.Items.Add(7);
            comboBox_month.Items.Add(8);
            comboBox_month.Items.Add(9);
            comboBox_month.Items.Add(10);
            comboBox_month.Items.Add(11);
            comboBox_month.Items.Add(12);
            comboBox_month.SelectedIndex = 0;

            comboBox_year.Items.Add(2012);
            comboBox_year.Items.Add(2013);
            comboBox_year.Items.Add(2014);
            comboBox_year.Items.Add(2015);
            comboBox_year.Items.Add(2016);
            comboBox_year.Items.Add(2017);
            comboBox_year.SelectedIndex = 5;

            comboBox_yearSales.Items.Add(2012);
            comboBox_yearSales.Items.Add(2013);
            comboBox_yearSales.Items.Add(2014);
            comboBox_yearSales.Items.Add(2015);
            comboBox_yearSales.Items.Add(2016);
            comboBox_yearSales.Items.Add(2017);
            comboBox_yearSales.SelectedIndex = 5;
            populateList();
        }

        public void reloadList()
        {
            dataGridView_report.DataSource = null;
            dataGridView_report.DataSource = currentListOfSales;
            dataGridView_report.Refresh();
        }

        public void populateList()
        {
            var getTodaySales =
                from todaySales in SalesData.sales
                where todaySales.PaymentDate.Date == DateTime.Today
                select todaySales;

            List<Sales> todaySalesReport = getTodaySales.ToList();

            currentListOfSales = todaySalesReport;
            dataGridView_report.DataSource = currentListOfSales;
            label_totalSales.Text = getTotalSales().ToString();
        }

        private void button_generateMonthlySales_Click(object sender, EventArgs e)
        {
            var getMonthlySales =
                from monthlySales in SalesData.sales
                where monthlySales.PaymentDate.Month == Int32.Parse(comboBox_month.Text.Trim()) && monthlySales.PaymentDate.Year == Int32.Parse(comboBox_year.Text.Trim())
                select monthlySales;

            List<Sales> monthlySalesReport = getMonthlySales.ToList();

            currentListOfSales = monthlySalesReport;
            reloadList();
            label_totalSales.Text = getTotalSales().ToString();
        }

        private void button_year_Click(object sender, EventArgs e)
        {
            var getYearlySales =
                from yearlySales in SalesData.sales
                where yearlySales.PaymentDate.Year == Int32.Parse(comboBox_yearSales.Text.Trim())
                select yearlySales;

            List<Sales> yearlySalesReport = getYearlySales.ToList();

            currentListOfSales = yearlySalesReport;
            reloadList();
            label_totalSales.Text = getTotalSales().ToString();
        }

        private void button_allTimeSales_Click(object sender, EventArgs e)
        {
            var getAllTimeSales =
                from allTimeSales in SalesData.sales
                select allTimeSales;

            List<Sales> allTimeSalesReport = getAllTimeSales.ToList();

            currentListOfSales = allTimeSalesReport;
            reloadList();
            label_totalSales.Text = getTotalSales().ToString();
        }

        private void button_dailySales_Click(object sender, EventArgs e)
        {
            populateList();
        }

        public decimal getTotalSales()
        {
            decimal sum = 0;
            foreach(Sales s in currentListOfSales)
            {
                sum += s.totalCost();
            }

            return sum;
        }
    }
}
