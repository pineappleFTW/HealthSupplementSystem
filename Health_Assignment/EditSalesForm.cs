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
        public decimal NonEditedSales { get; set; }
        public List<int> currentListOfQuantity;
        public DataTable dt { get; set; }
        public DataRow dr { get; set; }
        public int currentIndex = 0;
        private static int QUANTITY_LEFT = 0;

        public EditSalesForm()
        {
            InitializeComponent();
        }

        public EditSalesForm(Sales currentSale) : this()
        {
            CurrentSale = currentSale;
            NonEditedSales = currentSale.totalCost();
            currentListOfQuantity = CurrentSale.ProductsQuantity.ToList();
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
            if (CurrentSale.CurrentCustomer.CustomerType.Equals("Premium"))
            {
                comboBox_paymentMode.Items.Add("Credit Payment");
            }
            label_customerDetails.Text = String.Format("ID: {0} {1} {2}", CurrentSale.CurrentCustomer.ID, CurrentSale.CurrentCustomer.FirstName, CurrentSale.CurrentCustomer.LastName);
            checkBox_paid.Checked = CurrentSale.IsPaid;
            comboBox_status.Text = CurrentSale.Status;
            comboBox_paymentMode.Text = CurrentSale.PaymentMode;
            dateTimePicker_orderDate.Value = CurrentSale.OrderDate;

          
            label_cardNumber.Hide();
            textBox_cardNumber.Hide();
            

            if (CurrentSale.PaymentDate == DateTime.MaxValue)
            {
                dateTimePicker_paymentDate.Value = DateTimePicker.MaximumDateTime;
            }
            else
            {
                dateTimePicker_paymentDate.Value = CurrentSale.PaymentDate;
            }
                
           
            dateTimePicker_paymentDate.MinDate = CurrentSale.OrderDate;

            initializeDataGridView();
            dataGridView_productPurchased.EnableHeadersVisualStyles = false;
            dataGridView_productPurchased.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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
            Product currentProduct = null;
            try
            {
                currentProduct = ProductsData.products.Find(x => x.ID == Int32.Parse(productChosen[0]));
            }
            catch (Exception exception)
            {
                MessageBox.Show("Please select product");
                return;
            }

            if (QUANTITY_LEFT >= quantity)
            {
                if (CurrentSale.ProductsOrdered.Contains(currentProduct))
                {
                    //currentProduct.Quantity -= quantity;
                    QUANTITY_LEFT -= quantity;
                    int index = CurrentSale.ProductsOrdered.IndexOf(currentProduct);
                    CurrentSale.ProductsQuantity[index] += quantity;
                    refreshDataGridView();
                }
                else
                {
                    //currentProduct.Quantity -= quantity;
                    QUANTITY_LEFT -= quantity;
                    CurrentSale.ProductsOrdered.Add(currentProduct);
                    CurrentSale.ProductsQuantity.Add(quantity);
                    addtoDataGridView(currentProduct, quantity);
                }

            }
            else
            {
                MessageBox.Show("There is not enough stock please reorder");
            }
            dataGridView_productPurchased.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

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
            if (CurrentSale.ProductsOrdered.Count != 0)
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

                if ((comboBox_paymentMode.Text.Equals("Credit Card") || comboBox_paymentMode.Text.Equals("Debit Card")) && string.IsNullOrWhiteSpace(textBox_cardNumber.Text))
                {
                    MessageBox.Show("Card number is invalid or missing", "Card Number needed");
                    return;
                }

                string status = comboBox_status.Text;
                string paymentMode = comboBox_paymentMode.Text;
                DateTime orderDate = dateTimePicker_orderDate.Value;
                DateTime paymentDate = dateTimePicker_paymentDate.Value;

                Sales editedSales = new Sales(CurrentSale.ID, CurrentSale.CurrentCustomer, isPaid, status, paymentMode, CurrentSale.ProductsOrdered, CurrentSale.ProductsQuantity, orderDate, paymentDate);

                if (paymentMode.Equals("Credit Payment") && CurrentSale.CurrentCustomer is PremiumCustomer)
                {
                    PremiumCustomer premiumCustomer = (PremiumCustomer)CurrentSale.CurrentCustomer;
                    if ((editedSales.totalCost() - NonEditedSales) > premiumCustomer.CreditLimit)
                    {
                        MessageBox.Show("Please choose other purchase option", "Exceeded Credit Limit");
                        return;
                    }
                    else
                    {
                        int index = CustomersData.customers.IndexOf(premiumCustomer);
                        premiumCustomer.CreditLimit -= (editedSales.totalCost() - NonEditedSales);
                        MessageBox.Show(premiumCustomer.CreditLimit.ToString());
                        CustomersData.updateInformation(premiumCustomer);
                    }
                }

                SalesData.updateInformation(editedSales);

                for (int i = 0; i < editedSales.ProductsOrdered.Count; i++)
                {
                    if (ProductsData.products.Contains(editedSales.ProductsOrdered[i]))
                    {
                        int index = ProductsData.products.IndexOf(editedSales.ProductsOrdered[i]);
                        if (editedSales.ProductsOrdered.Count > currentListOfQuantity.Count)
                        {
                            try
                            {
                                ProductsData.products[index].Quantity -= (editedSales.ProductsQuantity[i] - currentListOfQuantity[i]);
                            }
                            catch (Exception ee)
                            {
                                ProductsData.products[index].Quantity -= editedSales.ProductsQuantity[i];
                            }
                        }
                        else
                        {
                            ProductsData.products[index].Quantity -= (editedSales.ProductsQuantity[i] - currentListOfQuantity[i]);
                        }
                    }
                }

                Form mainForm = Application.OpenForms["MainMenu"];
                MainMenu mainMenu = (MainMenu)mainForm;
                mainMenu.salesFormUserControl.reloadList();
                this.Close();
            }
           
        }

        private void comboBox_product_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] productDetails = comboBox_product.Text.Split('-');
            Product currentProduct = ProductsData.products.Find(x => x.ID == Int32.Parse(productDetails[0]));
            QUANTITY_LEFT = currentProduct.Quantity;
            for (int i = 0; i < CurrentSale.ProductsOrdered.Count; i++)
            {
                string currentProductDetails = currentProduct.Name + " : " + currentProduct.Manufacturer;
                if (currentProductDetails.Equals(dataGridView_productPurchased.Rows[i].Cells[0].Value.ToString()))
                {
                    QUANTITY_LEFT -= Int32.Parse(dataGridView_productPurchased.Rows[i].Cells[1].Value.ToString());
                }
            }
        }

        private void dateTimePicker_paymentDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (CurrentSale.ProductsOrdered.Count != 0)
            {

                if (CurrentSale.ProductsOrdered.Count <= currentIndex)
                {
                    currentIndex = 0;
                }


                try
                {
                    string[] productChosen = comboBox_product.Text.Split('-');
                    Product currentProduct = ProductsData.products.Find(x => x.ID == Int32.Parse(productChosen[0]));
                    string matchProduct = productChosen[1] + " : " + productChosen[2];
                    if (matchProduct.Equals(dataGridView_productPurchased.Rows[currentIndex].Cells[0].Value.ToString()))
                    {
                        MessageBox.Show("run");
                        QUANTITY_LEFT += currentListOfQuantity[currentIndex];
                    }

                    CurrentSale.ProductsOrdered.RemoveAt(currentIndex);
                    CurrentSale.ProductsQuantity.RemoveAt(currentIndex);
                }
                catch (Exception)
                {
                    MessageBox.Show("run2");
                    CurrentSale.ProductsOrdered.RemoveAt(currentIndex);
                    CurrentSale.ProductsQuantity.RemoveAt(currentIndex);
                    QUANTITY_LEFT = 0;
                }


                refreshDataGridView();

            }
            else
            {
                MessageBox.Show("There is no product in cart", "Empty cart");
            }
        }

        private void dataGridView_productPurchased_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            currentIndex = e.RowIndex;
        }

        private void dataGridView_productPurchased_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox_paymentMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_paymentMode.Text.Equals("Credit Card") || comboBox_paymentMode.Text.Equals("Debit Card"))
            {
                label_cardNumber.Show();
                textBox_cardNumber.Show();
            }
            else
            {
                label_cardNumber.Hide();
                textBox_cardNumber.Hide();
            }
        }
    }
}
