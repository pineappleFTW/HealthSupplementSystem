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
    public partial class DeliveryNoticeForm : Form
    {
        public Sales CurrentSale { get; set; }
        public DataTable dt { get; set; }
        public DataRow dr { get; set; }

        public DeliveryNoticeForm()
        {
            InitializeComponent();
        }

        public DeliveryNoticeForm(Sales currentSale) : this()
        {
            CurrentSale = currentSale;
        }

        private void DeliveryNoticeForm_Load(object sender, EventArgs e)
        {
            label_salesID.Text = CurrentSale.ID.ToString();
            label_customerDetails.Text = String.Format("{0} {1},", CurrentSale.CurrentCustomer.FirstName, CurrentSale.CurrentCustomer.LastName);
            label_address.Text = CurrentSale.CurrentCustomer.Address;
            label_orderDate.Text = CurrentSale.OrderDate.ToString("dd/MM/yyyy");
            label_paymentDate.Text = CurrentSale.PaymentDate.ToString("dd/MM/yyyy");

            initializeDataGridView();
            dataGridView_productPurchased.EnableHeadersVisualStyles = false;
            dataGridView_productPurchased.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView_productPurchased.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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

        private void button_send_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Succesfully sent to logistics deparment", "Delivery Notification");
            this.Close();
        }
    }
}
