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
    public partial class NewUserAccountForm : Form
    {
        public NewUserAccountForm()
        {
            InitializeComponent();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            string userName = richTextBox_userName.Text;
            string password = richTextBox_password.Text;
            UserAccount newUserAccount = new UserAccount(userName, password);
            Boolean isAddedToAccounts = UserAccountsData.addUserAccount(newUserAccount);
            if (isAddedToAccounts)
            {
                MessageBox.Show("User Account successfully added");
            }
            else
            {
                MessageBox.Show("User Account existed");
                return;
            }

            Form mainForm = Application.OpenForms["MainMenu"];
            MainMenu mainMenu = (MainMenu)mainForm;


            mainMenu.userAccountUserControl1.reloadList();

            this.Close();
        }
    }
}
