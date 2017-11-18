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
    public partial class PointOfSaleUserControl : UserControl
    {
        public Product CurrentProduct { get; set; }
        public Customer CurrentCustomer { get; set; }
        public Sales CurrentSale { get; set; }
        public List<Product> currentListOfProducts = new List<Product>();
        public List<int> currentListOfQuantity = new List<int>();
        public DataTable dt { get; set; }
        public DataRow dr { get; set; }
        public int currentIndex = 0;
        private static int QUANTITY_LEFT = 0;


        public PointOfSaleUserControl()
        {
            InitializeComponent();
        }

        private void PointOfSaleForm_Load(object sender, EventArgs e)
        {
            comboBox_customer.DropDownStyle = ComboBoxStyle.DropDown;
            comboBox_paymentMode.Items.Add("Cash");
            comboBox_paymentMode.Items.Add("Credit Card");
            comboBox_paymentMode.Items.Add("Debit Card");
            comboBox_paymentMode.Items.Add("Bank Transfer");
            comboBox_paymentMode.Items.Add("Cheque");
            comboBox_paymentMode.SelectedIndex = 0;
            initializeDataGridView();
            dataGridView_productPurchased.EnableHeadersVisualStyles = false;
            dataGridView_productPurchased.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            comboBox_customer.Items.Clear();
            string userQuery = comboBox_customer.Text.Trim();
            var returnedUsers =
                 from customer in CustomersData.customers
                 where customer.FirstName == userQuery
                 select customer;

            List<Customer> customerList = returnedUsers.ToList();

            foreach (Customer customer in customerList)
            {
                comboBox_customer.Items.Add(customer.ID + "-" + customer.FirstName + "-" + customer.LastName);
            }

        }

        private void comboBox_customer_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] customerDetails = comboBox_customer.Text.Split('-');
            Customer currentCustomer = CustomersData.customers.Find(x => x.ID == Int32.Parse(customerDetails[0]));
            CurrentCustomer = currentCustomer;
            label_customerAddress.Text = CurrentCustomer.Address;
            label_customerType.Text = CurrentCustomer.CustomerType;
            label_customerPhoneNumber.Text = CurrentCustomer.PhoneNumber;
            if (CurrentCustomer.CustomerType.Equals("Premium"))
            {
                comboBox_paymentMode.Items.Add("Credit Payment");
            }
            else
            {
                comboBox_paymentMode.Items.Remove("Credit Payment");
            }
        }

        private void button_searchProduct_Click(object sender, EventArgs e)
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
                MessageBox.Show(QUANTITY_LEFT.ToString());
                if (currentListOfProducts.Contains(currentProduct))
                {
                    //currentProduct.Quantity -= quantity;
                    QUANTITY_LEFT -= quantity;
                    int index = currentListOfProducts.IndexOf(currentProduct);
                    currentListOfQuantity[index] += quantity;
                    refreshDataGridView();
                }
                else
                {
                    //currentProduct.Quantity -= quantity;
                    QUANTITY_LEFT -= quantity;
                    currentListOfProducts.Add(currentProduct);
                    currentListOfQuantity.Add(quantity);
                    addtoDataGridView(currentProduct, quantity);
                }
            }
            else
            {
                MessageBox.Show("There is not enough stock please reorder");
                return;
            }

            dataGridView_productPurchased.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void comboBox_product_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] productDetails = comboBox_product.Text.Split('-');
            Product currentProduct = ProductsData.products.Find(x => x.ID == Int32.Parse(productDetails[0]));
            QUANTITY_LEFT = currentProduct.Quantity;
            for(int i = 0; i < currentListOfProducts.Count; i++)
            {
                string currentProductDetails = currentProduct.Name + " : " + currentProduct.Manufacturer;
                if (currentProductDetails.Equals(dataGridView_productPurchased.Rows[i].Cells[0].Value.ToString())){
                    QUANTITY_LEFT -= Int32.Parse(dataGridView_productPurchased.Rows[i].Cells[1].Value.ToString());
                }
            }
        }

        public void refreshDataGridView()
        {
            dt = new DataTable();
            dt.Columns.Add("Product");
            dt.Columns.Add("Quantity");
            for (int i = 0; i < currentListOfProducts.Count; i++)
            {
                dr = dt.NewRow();
                dr["Product"] = currentListOfProducts[i].Name + " : " + currentListOfProducts[i].Manufacturer;
                dr["Quantity"] = currentListOfQuantity[i];
                dt.Rows.Add(dr);
            }
            dataGridView_productPurchased.DataSource = dt;
            dataGridView_productPurchased.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        public void initializeDataGridView()
        {
            dt = new DataTable();
            dt.Columns.Add("Product");
            dt.Columns.Add("Quantity");
            dataGridView_productPurchased.DataSource = dt;
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



        //need some thinking
        private void button_deleteProduct_Click(object sender, EventArgs e)
        {
            if (currentListOfProducts.Count != 0)
            {

                if (currentListOfProducts.Count <= currentIndex)
                {
                    currentIndex = 0;
                }
                

                try
                {
                    string[] productChosen = comboBox_product.Text.Split('-');
                    Product currentProduct = ProductsData.products.Find(x => x.ID == Int32.Parse(productChosen[0]));
                    string matchProduct = productChosen[1]+" : "+productChosen[2];
                    if (matchProduct.Equals(dataGridView_productPurchased.Rows[currentIndex].Cells[0].Value.ToString()))
                    {
                        MessageBox.Show("run");
                        QUANTITY_LEFT += currentListOfQuantity[currentIndex];
                    }
                    
                    currentListOfProducts.RemoveAt(currentIndex);
                    currentListOfQuantity.RemoveAt(currentIndex);
                }
                catch (Exception)
                {
                    MessageBox.Show("run2");
                    currentListOfProducts.RemoveAt(currentIndex);
                    currentListOfQuantity.RemoveAt(currentIndex);
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


        private void button_save_Click(object sender, EventArgs e)
        {
            if (currentListOfProducts.Count != 0)
            {
                string paymentMode = "";

                if (CurrentCustomer == null)
                {
                    MessageBox.Show("No customer chosen", "Customer is needed");
                    return;
                }

                if (currentListOfProducts.Count == 0)
                {
                    MessageBox.Show("No product chosen", "Product is needed");
                    return;
                }


                paymentMode = comboBox_paymentMode.Text;
                DateTime orderDate = dateTimePicker_orderDate.Value;

                Sales newSales = new Sales(CurrentCustomer, false, "Pending Payment", paymentMode, currentListOfProducts.ToList(), currentListOfQuantity.ToList(), orderDate, DateTime.MaxValue);

                if (paymentMode.Equals("Credit Payment") && CurrentCustomer is PremiumCustomer)
                {
                    PremiumCustomer premiumCustomer = (PremiumCustomer)CurrentCustomer;
                    if (newSales.totalCost() > premiumCustomer.CreditLimit)
                    {
                        MessageBox.Show("Please choose other purchase option", "Exceeded Credit Limit");
                        return;
                    }
                    else
                    {
                        int index = CustomersData.customers.IndexOf(premiumCustomer);
                        premiumCustomer.CreditLimit -= newSales.totalCost();
                        MessageBox.Show(premiumCustomer.CreditLimit.ToString());
                        CustomersData.updateInformation(premiumCustomer);
                    }
                }

                SalesData.addNewSales(newSales);
                for (int i = 0; i < currentListOfProducts.Count; i++)
                {
                    if (ProductsData.products.Contains(currentListOfProducts[i]))
                    {
                        int index = ProductsData.products.IndexOf(currentListOfProducts[i]);
                        ProductsData.products[index].Quantity -= currentListOfQuantity[i];
                    }
                }

                Form mainForm = Application.OpenForms["MainMenu"];
                MainMenu mainMenu = (MainMenu)mainForm;
                mainMenu.salesFormUserControl.reloadList();
                MessageBox.Show("Order saved!", "Order save");
                OrderConfirmationForm orderConfirmationForm = new OrderConfirmationForm(newSales);
                orderConfirmationForm.Show();
                CurrentSale = newSales;
            }
            else
            {
                MessageBox.Show("No order to be saved", "Invalid save");
            }
           

        }

        private void dateTimePicker_orderDate_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox_paymentMode_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_newCustomer_Click(object sender, EventArgs e)
        {
            NewCustomerForm newCustomerForm = new NewCustomerForm();
            newCustomerForm.Show();
        }

        private void button_payNow_Click(object sender, EventArgs e)
        {
            if (CurrentSale != null)
            {
                if (CurrentSale.IsPaid != true)
                {
                    CurrentSale.PaymentDate = DateTime.Now;
                    CurrentSale.Status = "Paid";
                    CurrentSale.IsPaid = true;
                    MessageBox.Show("Order is Paid!", "Paid Order");
                }
                else
                {
                    MessageBox.Show("Sale order is paid!p", "Sale Paid");
                }
                
            }
            else
            {
                MessageBox.Show("There is no current sale order", "No sale order");
            }
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            CurrentSale = null;
            CurrentCustomer = null;
            comboBox_paymentMode.SelectedIndex = 0;
            dateTimePicker_orderDate.Value = DateTime.Now;
            currentListOfProducts.Clear();
            currentListOfQuantity.Clear();
            comboBox_customer.Text = "";
            comboBox_product.Text = "";
            textBox_quantity.Text = "";
            label_customerAddress.Text = "";
            label_customerType.Text = "";
            label_customerPhoneNumber.Text = "";
            dataGridView_productPurchased.DataSource = null;
            currentIndex = 0;
            dt.Clear();
            
        }

       
    }
}
