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
            if (currentCustomer.CustomerType.Equals("Premium"))
            {
                PremiumCustomer CurrentCustomer = (PremiumCustomer)currentCustomer;
                richTextBox_creditLimit.Text = CurrentCustomer.CreditLimit.ToString();
            }
            else
            {
                NormalCustomer CurrentCustomer = (NormalCustomer)currentCustomer;
                richTextBox_creditLimit.Hide();
                label_creditLimit.Hide();
            }
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
            if (string.IsNullOrWhiteSpace(richTextBox_firstName.Text))
            {
                MessageBox.Show("Invalid or empty first name", "First Name is Required");
                return;
            }

            if (string.IsNullOrWhiteSpace(richTextBox_lastName.Text))
            {
                MessageBox.Show("Invalid or empty last name", "Last Name is Required");
                return;
            }

            if (string.IsNullOrWhiteSpace(richTextBox_address.Text))
            {
                MessageBox.Show("Invalid or empty address", "Address is Required");
                return;
            }

            if (string.IsNullOrWhiteSpace(richTextBox_phoneNumber.Text))
            {
                MessageBox.Show("Invalid or empty phone number", "Phone Number is Required");
                return;
            }

            if (comboBox_customerType.Text.Equals("Premium") && string.IsNullOrWhiteSpace(richTextBox_creditLimit.Text))
            {
                MessageBox.Show("Invalid or empty credit limit", "Credit linit is Required");
                return;
            }

            

            if (comboBox_customerType.Text.Equals("Premium")){

                PremiumCustomer currentPremiumCustomer = new PremiumCustomer();
                currentPremiumCustomer.ID = CurrentCustomer.ID;
                currentPremiumCustomer.FirstName = richTextBox_firstName.Text;
                currentPremiumCustomer.LastName = richTextBox_lastName.Text;
                currentPremiumCustomer.CustomerType = comboBox_customerType.Text;
                currentPremiumCustomer.Address = richTextBox_address.Text; ;
                currentPremiumCustomer.PhoneNumber = richTextBox_phoneNumber.Text;
                try
                {
                    currentPremiumCustomer.CreditLimit = Int32.Parse(richTextBox_creditLimit.Text);
                }catch(FormatException fe)
                {
                    MessageBox.Show("Invalid Format", "Invalid Credit Limit Format is Required");
                    return;
                }
                
                CurrentCustomer = currentPremiumCustomer;
            }
            else
            {
                NormalCustomer currentNormalCustomer = new NormalCustomer();
                currentNormalCustomer.ID = CurrentCustomer.ID;
                currentNormalCustomer.FirstName = richTextBox_firstName.Text;
                currentNormalCustomer.LastName = richTextBox_lastName.Text;
                currentNormalCustomer.CustomerType = comboBox_customerType.Text;
                currentNormalCustomer.Address = richTextBox_address.Text; ;
                currentNormalCustomer.PhoneNumber = richTextBox_phoneNumber.Text;
                CurrentCustomer = currentNormalCustomer;
            }
            
            CustomersData.updateInformation(CurrentCustomer);
            Form mainForm = Application.OpenForms["CustomerForm"];
            CustomerForm salesForm = (CustomerForm)mainForm;
            salesForm.reloadList();
            this.Close();
        }

        private void comboBox_customerType_SelectedIndexChanged(object sender, EventArgs e)
        {
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
    }
}
