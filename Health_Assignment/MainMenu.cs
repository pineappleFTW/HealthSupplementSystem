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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void icon_customer_Click(object sender, EventArgs e)
        {
            CustomerForm customerForm = new CustomerForm();
            customerForm.Show();
            
        }

        private void button_logOut_Click(object sender, EventArgs e)
        {
            Form mainForm = Application.OpenForms["Login"];
            Login loginForm = (Login)mainForm;
            this.Close();
            loginForm.Show();
           

            
        }

        private void label_purchase_Click(object sender, EventArgs e)
        {

        }

        private void icon_sales_Click(object sender, EventArgs e)
        {
            SalesForm salesForm = new SalesForm();
            salesForm.Show();
        }

        private void icon_users_Click(object sender, EventArgs e)
        {
            UserAccountForm userAccountForm = new UserAccountForm();
            userAccountForm.Show();
        }
    }
}
