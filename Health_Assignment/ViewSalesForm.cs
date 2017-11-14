using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Health_Assignment
{
    public partial class ViewSalesForm : Form
    {
        public Sales CurrentSale { get; set; }
        public DataTable dt { get; set; }
        public DataRow dr { get; set; }

        public ViewSalesForm()
        {
            InitializeComponent();
        }

        public ViewSalesForm(Sales currentSale) : this()
        {
            CurrentSale = currentSale;
        }

        private void ViewSalesForm_Load(object sender, EventArgs e)
        {
            label_salesID.Text = CurrentSale.ID.ToString();
            label_customer.Text = String.Format("ID: {0} {1} {2}", CurrentSale.CurrentCustomer.ID, CurrentSale.CurrentCustomer.FirstName, CurrentSale.CurrentCustomer.LastName);
            checkBox_paid.Enabled = false;
            checkBox_paid.Checked = CurrentSale.IsPaid;
            label_status.Text = CurrentSale.Status;
            label_paymentMode.Text = CurrentSale.PaymentMode;
            label_orderDate.Text = CurrentSale.OrderDate.ToString("dd/MM/yyyy");
            label_paymentDate.Text = CurrentSale.PaymentDate.ToString("dd/MM/yyyy");
            label_totalAmount.Text = CurrentSale.totalCost().ToString();
            dataGridView_productPurchased.EnableHeadersVisualStyles = false;
            initializeDataGridView();
        }

        public void initializeDataGridView()
        {
            dt = new DataTable();
            dt.Columns.Add("Product");
            dt.Columns.Add("Quantity");
            for (int i = 0; i < CurrentSale.ProductsOrdered.Count; i++)
            {
                dr = dt.NewRow();
                dr["Product"] = CurrentSale.ProductsOrdered[i].Name + " : " + CurrentSale.ProductsOrdered[i].Manufacturer;
                dr["Quantity"] = CurrentSale.ProductsQuantity[i];
                dt.Rows.Add(dr);
            }
            dataGridView_productPurchased.DataSource = dt;
            dataGridView_productPurchased.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
