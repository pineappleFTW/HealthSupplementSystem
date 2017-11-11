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
    public partial class AddNewSalesForm : Form
    {
        public AddNewSalesForm()
        {
            InitializeComponent();
        }

        private void comboBox_customer_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void AddNewSalesForm_Load(object sender, EventArgs e)
        {
            comboBox_customer.DropDownStyle = ComboBoxStyle.DropDown;
            comboBox_status.Items.Add("Pending Payment");
            comboBox_status.Items.Add("Paid");
            comboBox_status.Items.Add("Out Of Delivery");
            comboBox_status.Items.Add("Delivered");

            comboBox_paymentMode.Items.Add("Cash");
            comboBox_paymentMode.Items.Add("Credit Card");
            comboBox_paymentMode.Items.Add("Debit Card");
            comboBox_paymentMode.Items.Add("Bank Transfer");
            comboBox_paymentMode.Items.Add("Cheque");
            comboBox_paymentMode.Items.Add("Credit Limit");

        }

        private void button_search_Click(object sender, EventArgs e)
        {
            comboBox_customer.Items.Clear();
            string userQuery = comboBox_customer.Text;
            var returnedUsers =
                 from customer in CustomersData.customers
                 where customer.FirstName == userQuery
                 select customer;

            List<Customer> customerList = returnedUsers.ToList();

            foreach(Customer customer in customerList)
            {
                comboBox_customer.Items.Add("ID: "+ customer.ID + " First Name: " + customer.FirstName + " Last Name: " + customer.LastName);
            }
            
            
        }
    }
}
