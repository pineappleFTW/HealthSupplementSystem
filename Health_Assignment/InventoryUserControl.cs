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

        private void button_edit_Click(object sender, EventArgs e)
        {
            if (currentListOfProducts.Count != 0)
            {
                if (currentListOfProducts.Count <= currentIndex)
                {
                    currentIndex = 0;
                }
                DataGridViewRow selectedRow = dataGridView_products.Rows[currentIndex];
                Product currentObject = null;
                string category = selectedRow.Cells[5].Value.ToString();

                if (category.Equals("Vitamin"))
                {
                    currentObject = (Vitamin)dataGridView_products.CurrentRow.DataBoundItem;
                }
                else if(category.Equals("Protein"))
                {
                    currentObject = (Protein)dataGridView_products.CurrentRow.DataBoundItem;

                }
                else if(category.Equals("Mineral Supplement"))
                {
                    currentObject = (MineralSupplement)dataGridView_products.CurrentRow.DataBoundItem;
                }

                EditProductForm editProductForm = new EditProductForm(currentObject);
                editProductForm.Show();
            }
            else
            {
                MessageBox.Show("There is no more product");
            }
        }

        private void dataGridView_products_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            currentIndex = e.RowIndex;
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (currentListOfProducts.Count != 0)
            {
                if (currentListOfProducts.Count <= currentIndex)
                {
                    currentIndex = 0;
                }
                DataGridViewRow selectedRow = dataGridView_products.Rows[currentIndex];
                Product currentObject = (Product)dataGridView_products.CurrentRow.DataBoundItem;

                var confirmResult = MessageBox.Show("Are you sure to delete product " + currentObject.ID + " : " + currentObject.Name + " by " + currentObject.Manufacturer+ " ?",
                                         "Delete Confirmation",
                                         MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    ProductsData.deleteProduct(currentObject);
                    currentListOfProducts.Remove(currentObject);

                }
                else
                {
                    // If 'No', do something here.
                }

                reloadList();
            }
            else
            {
                MessageBox.Show("There is no more product");
            }
        }

        private void button_checkForStock_Click(object sender, EventArgs e)
        {
            var returnResults =
               from product in ProductsData.products
               where product.Quantity <= 10 
               select product;

            List<Product> returnedList = returnResults.ToList();

            currentListOfProducts = returnedList;
            reloadList();
        }

        private void button_makeOrder_Click(object sender, EventArgs e)
        {
            if (currentListOfProducts.Count != 0)
            {
                if (currentListOfProducts.Count <= currentIndex)
                {
                    currentIndex = 0;
                }
                DataGridViewRow selectedRow = dataGridView_products.Rows[currentIndex];
                Product currentObject = (Product)dataGridView_products.CurrentRow.DataBoundItem;


                AddNewPurchaseOrderForm newPurchaseOrderForm = new AddNewPurchaseOrderForm(currentObject);
                newPurchaseOrderForm.Show();
                
            }
            else
            {
                MessageBox.Show("There is no more product");
            }
           

        }
    }
}
