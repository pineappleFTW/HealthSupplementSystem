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
    public partial class CustomerUserControlForm : UserControl
    {
        public int currentIndex = 0;
        public List<Customer> currentListOfCustomers;

        public CustomerUserControlForm()
        {
            InitializeComponent();
        }

        private void CustomerUserControlForm_Load(object sender, EventArgs e)
        {
            comboBox_searchOptions.Items.Add("First Name");
            comboBox_searchOptions.Items.Add("Last Name");
            comboBox_searchOptions.Items.Add("Address");
            comboBox_searchOptions.Items.Add("Phone Number");
            comboBox_searchOptions.SelectedIndex = 0;
            dataGridView1.EnableHeadersVisualStyles = false;
            populateList();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            currentIndex = e.RowIndex;
        }

     

        

        public void reloadList()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = currentListOfCustomers;
            dataGridView1.Refresh();
        }


        public void populateList()
        {
            currentListOfCustomers = CustomersData.getCurrentList();
            dataGridView1.DataSource = currentListOfCustomers;
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            NewCustomerForm newCustomerForm = new NewCustomerForm();
            newCustomerForm.Show();
        }

        private void button_editCustomer_Click(object sender, EventArgs e)
        {
            if (currentListOfCustomers.Count != 0)
            {
                if (currentListOfCustomers.Count <= currentIndex)
                {
                    currentIndex = 0;
                }
                DataGridViewRow selectedRow = dataGridView1.Rows[currentIndex];
                Customer currentObject;
                string custType = selectedRow.Cells[4].Value.ToString();

                if (custType.Equals("Premium"))
                {
                    currentObject = (PremiumCustomer)dataGridView1.CurrentRow.DataBoundItem;
                }
                else
                {
                    currentObject = (NormalCustomer)dataGridView1.CurrentRow.DataBoundItem;

                }


                EditCustomerForm customerForm = new EditCustomerForm(currentObject);
                customerForm.Show();
            }
            else
            {
                MessageBox.Show("There is no more user");
            }

        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (currentListOfCustomers.Count != 0)
            {
                if (currentListOfCustomers.Count <= currentIndex)
                {
                    currentIndex = 0;
                }
                DataGridViewRow selectedRow = dataGridView1.Rows[currentIndex];
                Customer currentCustomer;
                currentCustomer = (Customer)dataGridView1.CurrentRow.DataBoundItem;

                var confirmResult = MessageBox.Show("Are you sure to delete ID: " + currentCustomer.ID + " : " + currentCustomer.FirstName + " " + currentCustomer.LastName + " ?",
                                         "Delete Confirmation",
                                         MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    CustomersData.deleteCustomer(currentCustomer);
                    currentListOfCustomers.Remove(currentCustomer);

                }
                else
                {
                    // If 'No', do something here.
                }

                reloadList();
            }
            else
            {
                MessageBox.Show("There is no more user");
            }


        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            string searchQuery = richTextBox_searchBox.Text.Trim();
            string type = comboBox_searchOptions.Text;

            var returnedResults =
                from customer in CustomersData.customers
                select customer;

            switch (type)
            {
                case "First Name":
                    returnedResults =
                    from customer in CustomersData.customers
                    where customer.FirstName == searchQuery
                    select customer;
                    break;

                case "Last Name":
                    returnedResults =
                    from customer in CustomersData.customers
                    where customer.LastName == searchQuery
                    select customer;
                    break;

                case "Address":
                    returnedResults =
                    from customer in CustomersData.customers
                    where customer.Address == searchQuery
                    select customer;
                    break;

                case "Phone Number":
                    returnedResults =
                    from customer in CustomersData.customers
                    where customer.PhoneNumber == searchQuery
                    select customer;
                    break;


            }



            List<Customer> returnedList = returnedResults.ToList();

            currentListOfCustomers = returnedList;
            reloadList();


        }

        private void button_completeList_Click(object sender, EventArgs e)
        {
            currentListOfCustomers = CustomersData.customers;
            dataGridView1.DataSource = currentListOfCustomers;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
