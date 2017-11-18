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
    public partial class ViewProductForm : Form
    {
        public Product CurrentProduct { get; set; }
        public ViewProductForm()
        {
            InitializeComponent();
        }

        public ViewProductForm(Product currentProduct):this()
        {
            CurrentProduct = currentProduct;
        }

        private void ViewProductForm_Load(object sender, EventArgs e)
        {
            label_productName.Text = CurrentProduct.Name;
            label_description.Text = CurrentProduct.Description;
            label_prescriptionContent.Text = CurrentProduct.Prescription;
            label_manufacturerDetails.Text = CurrentProduct.Manufacturer;
            label_categoryDetails.Text = CurrentProduct.Category;
            label_priceDetails.Text = CurrentProduct.Price.ToString();
            label_quantityDetails.Text = CurrentProduct.Quantity.ToString();
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
