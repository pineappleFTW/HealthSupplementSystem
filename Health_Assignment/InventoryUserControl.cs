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
    public partial class InventoryUserControl : UserControl
    {
        public int currentIndex = 0;
        public List<Product> currentListOfProducts;

        public InventoryUserControl()
        {
            InitializeComponent();
        }

        private void InventoryUserControl_Load(object sender, EventArgs e)
        {
            comboBox_searchOptions.Items.Add("Name");
            comboBox_searchOptions.Items.Add("Manufacturer");
            comboBox_searchOptions.Items.Add("Category");
            comboBox_searchOptions.SelectedIndex = 0;
            dataGridView_products.EnableHeadersVisualStyles = false;
            populateList();
        }

        public void reloadList()
        {
            dataGridView_products.DataSource = null;
            dataGridView_products.DataSource = currentListOfProducts;
            dataGridView_products.Refresh();
        }


        public void populateList()
        {
            currentListOfProducts = ProductsData.products;
            dataGridView_products.DataSource = currentListOfProducts;
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            string searchQuery = textBox_searchQuery.Text.Trim();
            string type = comboBox_searchOptions.Text;

            var returnResults =
                from product in ProductsData.products
                select product;

            switch (type)
            {
                case "Name":
                    returnResults=
                        from product in ProductsData.products
                        where product.Name == searchQuery
                        select product;
                    break;


                case "Manufacturer":
                    returnResults =
                        from product in ProductsData.products
                        where product.Manufacturer == searchQuery
                        select product;
                    break;

                case "Category":
                    returnResults =
                        from product in ProductsData.products
                        where product.Category == searchQuery
                        select product;
                    break;
            }

            List<Product> returnedList = returnResults.ToList();

            currentListOfProducts = returnedList;
            reloadList();
        }

        private void button_completeList_Click(object sender, EventArgs e)
        {
            populateList();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            AddNewProductForm newProductForm = new AddNewProductForm();
            newProductForm.Show();
        }
    }
}
