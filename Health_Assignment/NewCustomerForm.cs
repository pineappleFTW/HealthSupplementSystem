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
    public partial class NewCustomerForm : Form
    {
        string firstName;
        string lastName;
        string address;
        string customerType;
        string phoneNumber;

        public NewCustomerForm()
        {
            InitializeComponent();
        }

        private void NewCustomerForm_Load(object sender, EventArgs e)
        {
            comboBox_customerType.Items.Add("Normal");
            comboBox_customerType.Items.Add("Premium");
            comboBox_customerType.SelectedIndex = 0;
        }

        private void comboBox_customerType_SelectedIndexChanged(object sender, EventArgs e)
        {
            customerType = comboBox_customerType.Text;
            if (comboBox_customerType.SelectedIndex == 0)
            {
                richTextBox_creditLimit.Hide();
                label_creditLimit.Hide();
            }
            else
            {
                richTextBox_creditLimit.Show();
                label_creditLimit.Show();
            }
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            Customer newCustomer;
            firstName = textBox_newFirstName.Text;
            lastName = textBox_newLastName.Text;
            address = textBox_newAddress.Text;
            phoneNumber = textBox_newPhoneNumber.Text;

            if(string.IsNullOrWhiteSpace(firstName))
            {
                MessageBox.Show("Invalid or empty first name","First Name is Required");
                return;
            }

            if (string.IsNullOrWhiteSpace(lastName))
            {
                MessageBox.Show("Invalid or empty last name", "Last Name is Required");
                return;
            }

            if (string.IsNullOrWhiteSpace(address))
            {
                MessageBox.Show("Invalid or empty address", "Address is Required");
                return;
            }

            if (string.IsNullOrWhiteSpace(phoneNumber))
            {
                MessageBox.Show("Invalid or empty phone number", "Phone Number is Required");
                return;
            }

            if (comboBox_customerType.Text.Equals("Premium") && string.IsNullOrWhiteSpace(richTextBox_creditLimit.Text))
            {
                MessageBox.Show("Invalid or empty credit limit", "Credit linit is Required");
                return;
            }

            if (customerType.Equals("Premium"))
            {
                newCustomer = new PremiumCustomer(firstName, lastName, address, customerType, phoneNumber,Int32.Parse(richTextBox_creditLimit.Text));
            }
            else
            {
                newCustomer = new NormalCustomer(firstName, lastName, address, customerType, phoneNumber);
            }

            CustomersData.addNewCustomer(newCustomer);
            Form mainForm = Application.OpenForms["MainMenu"];
            MainMenu mainMenu = (MainMenu)mainForm;
            mainMenu.customerUserControlForm.reloadList();
            this.Close();
        }
    }
}
