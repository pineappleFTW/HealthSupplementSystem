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
    public partial class OrderConfirmationForm : Form
    {
        public Sales CurrentSale { get; set; }
        public DataTable dt { get; set; }
        public DataRow dr { get; set; }

        public OrderConfirmationForm()
        {
            InitializeComponent();
        }

        public OrderConfirmationForm(Sales currentSale) : this()
        {
            CurrentSale = currentSale;
        }

        private void OrderConfirmationForm_Load(object sender, EventArgs e)
        {
            label_salesID.Text = CurrentSale.ID.ToString();
            label_customerName.Text = String.Format("{0} {1},",CurrentSale.CurrentCustomer.FirstName, CurrentSale.CurrentCustomer.LastName);

            label_totalAmount.Text = CurrentSale.totalCost().ToString();

            initializeDataGridView();
            dataGridView_productPurchased.EnableHeadersVisualStyles = false;
            dataGridView_productPurchased.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView_productPurchased.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        public void initializeDataGridView()
        {
            dt = new DataTable();
            dt.Columns.Add("Product ID");
            dt.Columns.Add("Product Name");
            dt.Columns.Add("Quantity");
            dt.Columns.Add("Unit Price");
            dt.Columns.Add("Total");
            for (int i = 0; i < CurrentSale.ProductsOrdered.Count; i++)
            {
                dr = dt.NewRow();
                dr["Product ID"] = CurrentSale.ProductsOrdered[i].ID;
                dr["Product Name"] = CurrentSale.ProductsOrdered[i].Name;
                dr["Quantity"] = CurrentSale.ProductsQuantity[i];
                dr["Unit Price"] = CurrentSale.ProductsOrdered[i].Price;
                dr["Total"] = CurrentSale.ProductsOrdered[i].Price* CurrentSale.ProductsQuantity[i];
                dt.Rows.Add(dr);
            }
            dataGridView_productPurchased.DataSource = dt;
            dataGridView_productPurchased.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void icon_customer_Click(object sender, EventArgs e)
        {

        }

        private void button_print_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Order Confirmation is sent to printer.", "Order Sent");
            this.Close();
        }

        private void button_send_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Order Confirmation is sent to customer.", "Order Sent");
            this.Close();
        }
    }
}
