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
    public partial class SalesOrderForm : Form
    {
        private int currentIndex = 0;
      
        public SalesOrderForm()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {
            label_Sales.Text = "bye";
        }

        private void SalesOrderForm_Load_1(object sender, EventArgs e)
        {

            populateList();
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            currentIndex = e.RowIndex;
        }

        private void button_editCustomer_Click(object sender, EventArgs e)
        {
       
            DataGridViewRow selectedRow = dataGridView1.Rows[currentIndex];
            int id = Int32.Parse(selectedRow.Cells[0].Value.ToString());
            string fn = selectedRow.Cells[1].Value.ToString();
            string ln = selectedRow.Cells[2].Value.ToString();
            string add = selectedRow.Cells[3].Value.ToString();
            string custType = selectedRow.Cells[4].Value.ToString();
            string phone = selectedRow.Cells[5].Value.ToString();
            Customer currentCustomer = new Customer(id, fn, ln, add, custType, phone);
            CustomerForm customerForm = new CustomerForm(currentCustomer);
            customerForm.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void reloadList()
        {
            dataGridView1.Refresh();
        }

        public void populateList()
        {

            List<Customer> customers = CustomersData.initializeData();
            dataGridView1.DataSource = customers;

            
        }
    }
}
