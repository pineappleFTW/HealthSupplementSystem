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
    public partial class EditProductForm : Form
    {
        public Product CurrentProduct { get; set; }

        public EditProductForm()
        {
            InitializeComponent();
        }

        public EditProductForm(Product currentProduct) : this()
        {
            CurrentProduct = currentProduct;
        }

        private void EditProductForm_Load(object sender, EventArgs e)
        {
            comboBox_category.Items.Add("Vitamin");
            comboBox_category.Items.Add("Protein");
            comboBox_category.Items.Add("Mineral Supplement");
            richTextBox_name.Text = CurrentProduct.Name;
            richTextBox_description.Text = CurrentProduct.Description;
            richTextBox_prescription.Text = CurrentProduct.Prescription;
            richTextBox_manufacturer.Text = CurrentProduct.Manufacturer;
            comboBox_category.Text = CurrentProduct.Category;
            richTextBox_price.Text = CurrentProduct.Price.ToString();
            richTextBox_quantity.Text = CurrentProduct.Quantity.ToString();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            
            string name = richTextBox_name.Text.Trim();
            string description = richTextBox_description.Text.Trim();
            string prescription = richTextBox_prescription.Text.Trim();
            string manufacturer = richTextBox_manufacturer.Text.Trim();
            string category = comboBox_category.Text;

            decimal price;
            int quantity;


            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Invalid of empty name", "Name is Required");
                return;
            }

            if (string.IsNullOrWhiteSpace(description))
            {
                MessageBox.Show("Invalid of empty description", "Description is Required");
                return;
            }

            if (string.IsNullOrWhiteSpace(prescription))
            {
                MessageBox.Show("Invalid of empty prescription", "Prescription is Required");
                return;
            }

            if (string.IsNullOrWhiteSpace(manufacturer))
            {
                MessageBox.Show("Invalid of empty manufacturer", "Manufacturer name is Required");
                return;
            }

            try
            {
                price = Decimal.Parse(richTextBox_price.Text.Trim());
                if (price <= 0)
                {
                    MessageBox.Show("Price should not be negative", "Invalid Price");
                    return;
                }
            }
            catch (FormatException fe)
            {
                MessageBox.Show("Invalid format of price, only numbers!", "Number is Required");
                return;
            }

            try
            {
                quantity = Int32.Parse(richTextBox_quantity.Text.Trim());
                if (quantity <= 0)
                {
                    MessageBox.Show("Quantity should not be negative", "Invalid Quantity");
                    return;
                }
            }
            catch (FormatException fe)
            {
                MessageBox.Show("Invalid format of quantity, only numbers!", "Number is Required");
                return;
            }

            if (category.Equals("Vitamin"))
            {
                CurrentProduct = new Vitamin(CurrentProduct.ID,name, description, prescription, manufacturer, price, quantity);
            }
            else if (category.Equals("Protein"))
            {
                CurrentProduct = new Protein(CurrentProduct.ID,name, description, prescription, manufacturer, price, quantity);
            }
            else
            {
                CurrentProduct = new MineralSupplement(CurrentProduct.ID,name, description, prescription, manufacturer, price, quantity);
            }

            ProductsData.updateInformation(CurrentProduct);

            Form mainForm = Application.OpenForms["MainMenu"];
            MainMenu mainMenu = (MainMenu)mainForm;
            mainMenu.inventoryUserControl.reloadList();
            this.Close();
        }
    }
}
