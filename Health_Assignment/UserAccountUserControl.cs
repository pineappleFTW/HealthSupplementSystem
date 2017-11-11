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
    public partial class UserAccountUserControl : UserControl
    {
        public UserAccountUserControl()
        {
            InitializeComponent();
        }
        
        private void UserAccountUserControl_Load(object sender, EventArgs e)
        {
            populateList();
            
        }

        public void reloadList()
        {
            dataGridView_userAccount.DataSource = null;
            dataGridView_userAccount.DataSource = UserAccountsData.userAccounts;
            dataGridView_userAccount.Refresh();
        }


        public void populateList()
        {
            dataGridView_userAccount.DataSource = UserAccountsData.userAccounts;
        }

        private void button_newUserAccount_Click(object sender, EventArgs e)
        {
            NewUserAccountForm newUserAccountForm = new NewUserAccountForm();
            newUserAccountForm.Show();
        }

        private void dataGridView_userAccount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_editUserAccount_Click(object sender, EventArgs e)
        {
            UserAccount currentUserAccount = (UserAccount)dataGridView_userAccount.CurrentRow.DataBoundItem;
            EditUserAccountForm editUserAccountForm = new EditUserAccountForm(currentUserAccount);
            editUserAccountForm.Show();
        }

        private void button_deleteUserAccount_Click(object sender, EventArgs e)
        {
            if (UserAccountsData.userAccounts.Count <= 1)
            {
                MessageBox.Show("There is only one account left");
            }
            else
            {
                UserAccount currentUserAccount = (UserAccount)dataGridView_userAccount.CurrentRow.DataBoundItem;

                var confirmResult = MessageBox.Show("Are you sure to delete user account: " + currentUserAccount.UserName + " ?",
                                         "Delete Confirmation",
                                         MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    UserAccountsData.deleteUserAccount(currentUserAccount);
                }
                else
                {
                    // If 'No', do something here.
                }
                reloadList();
            }
            
        }
    }
}
