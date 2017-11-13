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
    public partial class AddNewPurchaseOrderForm : Form
    {
        public Product CurrentProduct { get; set; }


        public AddNewPurchaseOrderForm()
        {
            InitializeComponent();
        }

        public AddNewPurchaseOrderForm(Product currentProduct):this()
        {
            CurrentProduct = currentProduct;
        }

        private void AddNewPurchaseOrderForm_Load(object sender, EventArgs e)
        {
            if (CurrentProduct!= null){
                comboBox_searchProduct.Text = CurrentProduct.ID + "-"+ CurrentProduct.Name;
            }
            dateTimePicker_orderDate.MinDate = DateTime.Today;
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            comboBox_searchProduct.Items.Clear();
            string productQuery = comboBox_searchProduct.Text.Trim();
            var returnedProducts =
                from product in ProductsData.products
                where product.Name == productQuery
                select product;

            List<Product> productList = returnedProducts.ToList();

            foreach(Product p in productList)
            {
                comboBox_searchProduct.Items.Add(p.ID + "-" + p.Name);
            }
        }

        private void comboBox_searchProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] productDetails = comboBox_searchProduct.Text.Split('-');
            Product currentProduct = ProductsData.products.Find(x => x.ID == Int32.Parse(productDetails[0]));
            CurrentProduct = currentProduct;
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            DateTime orderDate = dateTimePicker_orderDate.Value;
            int quantity = 0;
            try
            {
                quantity = Int32.Parse(textBox_quantity.Text.Trim());
                if (quantity <= 0)
                {
                    MessageBox.Show("Please enter positive integer", "Positive integer is needed");
                    return;
                }
            }catch(FormatException fe)
            {
                MessageBox.Show("Please enter integer", "Integer is needed");
                return;
            }

            if (CurrentProduct == null)
            {
                MessageBox.Show("No Product chosen", "Product is needed");
                return;
            }

            PurchaseOrder newPurchaseOrder = new PurchaseOrder(CurrentProduct, orderDate, quantity);
            PurchaseOrdersData.addNewPurchaseOrder(newPurchaseOrder);

            Form mainForm = Application.OpenForms["MainMenu"];
            MainMenu mainMenu = (MainMenu)mainForm;
            mainMenu.purchaseOrderUseControl.reloadList();
            this.Close();


        }
    }
}
