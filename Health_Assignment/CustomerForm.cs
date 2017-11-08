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
    public partial class CustomerForm : Form
    {
        public Customer CurrentCustomer { get; set; }

        public CustomerForm()
        {
            InitializeComponent();
            
        }

        public CustomerForm(Customer currentCustomer):this()
        {
            CurrentCustomer = currentCustomer;
            textBox_firstName.Text = currentCustomer.FirstName;
            textBox_lastName.Text = currentCustomer.LastName;
        }

      
      

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox_firstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_lastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_save_Click(object sender, EventArgs e)
        {
            CurrentCustomer.FirstName = textBox_firstName.Text;
            CurrentCustomer.LastName = textBox_lastName.Text;
            CustomersData.updateInformation(CurrentCustomer);
            Form mainForm = Application.OpenForms["SalesOrderForm"];
            SalesOrderForm salesForm = (SalesOrderForm)mainForm;
            salesForm.reloadList();
            this.Close();
        }

    }
}
