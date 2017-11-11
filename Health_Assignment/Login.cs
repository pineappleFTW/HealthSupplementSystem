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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<UserAccount> currentUserAccounts = new List<UserAccount>();
            currentUserAccounts = UserAccountsData.initializeAccount();
            List<Customer> currentListOfCustomers = new List<Customer>();
            currentListOfCustomers = CustomersData.initializeData();
            List<Sales> currentListOfSales = new List<Sales>();
            currentListOfSales = SalesData.initializeData();

    }

        private void txtUserID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblUserID_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            string username = txt_UserID.Text;
            string password = txt_Password.Text;

            Boolean isAllowed = UserAccountsData.checkAuthorization(new UserAccount(username, password));

            if (isAllowed)
            {
                MainMenu mainMenu = new MainMenu();
                mainMenu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid user account or password", "please retry");
            }
            
        }

        
    }
}
