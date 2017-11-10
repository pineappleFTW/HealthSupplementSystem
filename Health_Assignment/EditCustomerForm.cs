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
    public partial class EditCustomerForm : Form
    {
        public Customer CurrentCustomer { get; set; }

        public EditCustomerForm()
        {
            InitializeComponent();
            
        }

        public EditCustomerForm(Customer currentCustomer):this()
        {
            CurrentCustomer = currentCustomer;
            
        }

     
        private void CustomerForm_Load(object sender, EventArgs e)
        {
            richTextBox_firstName.Text = CurrentCustomer.FirstName;
            richTextBox_lastName.Text = CurrentCustomer.LastName;
            richTextBox_address.Text = CurrentCustomer.Address;
            richTextBox_phoneNumber.Text = CurrentCustomer.PhoneNumber;
            comboBox_customerType.Items.Add("Normal");
            comboBox_customerType.Items.Add("Premium");
            if (CurrentCustomer.CustomerType.Equals("Normal"))
            {
                comboBox_customerType.SelectedIndex = 0;
            }
            else
            {
                comboBox_customerType.SelectedIndex = 1;
            }
        }

        private void textBox_firstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_lastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_save_Click(object sender, EventArgs e)
        {
            CurrentCustomer.FirstName = richTextBox_firstName.Text;
            CurrentCustomer.LastName = richTextBox_lastName.Text;
            CurrentCustomer.CustomerType = comboBox_customerType.Text;
            CurrentCustomer.Address = richTextBox_address.Text; ;
            CurrentCustomer.PhoneNumber = richTextBox_phoneNumber.Text;
            CustomersData.updateInformation(CurrentCustomer);
            Form mainForm = Application.OpenForms["CustomerForm"];
            CustomerForm salesForm = (CustomerForm)mainForm;
            salesForm.reloadList();
            this.Close();
        }

    }
}
