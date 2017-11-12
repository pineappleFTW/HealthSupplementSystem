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
    public partial class EditSalesForm : Form
    {
        public Sales CurrentSale { get; set; }
        public DataTable dt { get; set; }
        public DataRow dr { get; set; }

        public EditSalesForm()
        {
            InitializeComponent();
        }

        public EditSalesForm(Sales currentSale) : this()
        {
            CurrentSale = currentSale;
        }


        private void EditSalesForm_Load(object sender, EventArgs e)
        {           
            comboBox_status.Items.Add("Pending Payment");
            comboBox_status.Items.Add("Paid");
            comboBox_status.Items.Add("Out for Delivery");
            comboBox_status.Items.Add("Delivered");

            comboBox_paymentMode.Items.Add("Cash");
            comboBox_paymentMode.Items.Add("Credit Card");
            comboBox_paymentMode.Items.Add("Debit Card");
            comboBox_paymentMode.Items.Add("Bank Transfer");
            comboBox_paymentMode.Items.Add("Cheque");
            comboBox_paymentMode.Items.Add("Credit Limit");
            label_customerDetails.Text = String.Format("ID: {0} {1} {2}", CurrentSale.CurrentCustomer.ID, CurrentSale.CurrentCustomer.FirstName, CurrentSale.CurrentCustomer.LastName);
            checkBox_paid.Checked = CurrentSale.IsPaid;
            comboBox_status.Text = CurrentSale.Status;
            comboBox_paymentMode.Text = CurrentSale.PaymentMode;
            dateTimePicker_orderDate.Value = CurrentSale.OrderDate;
            
            dateTimePicker_paymentDate.Value = CurrentSale.PaymentDate;
            dateTimePicker_paymentDate.MinDate = CurrentSale.OrderDate;

            initializeDataGridView();
        }

        public void initializeDataGridView()
        {
            dt = new DataTable();
            dt.Columns.Add("Product");
            dt.Columns.Add("Quantity");
            for(int i = 0; i < CurrentSale.ProductsOrdered.Count; i++)
            {
                dr = dt.NewRow();
                dr["Product"] = CurrentSale.ProductsOrdered[i].Name + " : " + CurrentSale.ProductsOrdered[i].Manufacturer;
                dr["Quantity"] = CurrentSale.ProductsQuantity[i];
                dt.Rows.Add(dr);
            }
            dataGridView_productPurchased.DataSource = dt;
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            comboBox_product.Items.Clear();
            string productQuery = comboBox_product.Text.Trim();
            var returnedProducts =
                from chosenProduct in ProductsData.products
                where chosenProduct.Name == productQuery
                select chosenProduct;

            List<Product> productList = returnedProducts.ToList();

            foreach (Product product in productList)
            {
                comboBox_product.Items.Add(product.ID + "-" + product.Name + "-" + product.Manufacturer);
            }
        }

        private void button_addProduct_Click(object sender, EventArgs e)
        {
            int quantity;
            try
            {
                quantity = Int32.Parse(textBox_quantity.Text.Trim());
            }
            catch (FormatException fe)
            {
                MessageBox.Show("Invalid or empty quantity", "Quantity is Required");
                return;
            }

            if (string.IsNullOrWhiteSpace(comboBox_product.Text.Trim()))
            {
                MessageBox.Show("Invalid or empty product", "Product is Required");
                return;
            }
            if (string.IsNullOrWhiteSpace(textBox_quantity.Text))
            {
                MessageBox.Show("Invalid or empty quantity", "Quantity is Required");
                return;
            }
            string[] productChosen = comboBox_product.Text.Split('-');
            Product currentProduct = ProductsData.products.Find(x => x.ID == Int32.Parse(productChosen[0]));
            if (CurrentSale.ProductsOrdered.Contains(currentProduct))
            {
                int index = CurrentSale.ProductsOrdered.IndexOf(currentProduct);
                CurrentSale.ProductsQuantity[index] += quantity;
                refreshDataGridView();
            }
            else
            {
                CurrentSale.ProductsOrdered.Add(currentProduct);
                CurrentSale.ProductsQuantity.Add(quantity);
                addtoDataGridView(currentProduct, quantity);
            }
        }

        public void refreshDataGridView()
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

        public void addtoDataGridView(Product product, int quantity)
        {
            dr = dt.NewRow();
            dr["Product"] = product.Name + " : " + product.Manufacturer;
            dr["Quantity"] = quantity;
            dt.Rows.Add(dr);

            dataGridView_productPurchased.DataSource = null;
            dataGridView_productPurchased.DataSource = dt;
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            Boolean isPaid;
            if (checkBox_paid.Checked)
            {
                isPaid = true;
            }
            else
            {
                isPaid = false;
            }
            string status = comboBox_status.Text;
            string paymentMode = comboBox_paymentMode.Text;
            DateTime orderDate = dateTimePicker_orderDate.Value;
            DateTime paymentDate = dateTimePicker_paymentDate.Value;

            Sales editedSales = new Sales(CurrentSale.ID, CurrentSale.CurrentCustomer,isPaid, status, paymentMode, CurrentSale.ProductsOrdered, CurrentSale.ProductsQuantity, orderDate, paymentDate);
            SalesData.updateInformation(editedSales);

            Form mainForm = Application.OpenForms["MainMenu"];
            MainMenu mainMenu = (MainMenu)mainForm;
            mainMenu.salesFormUserControl.reloadList();
            this.Close();
        }
    }
}
