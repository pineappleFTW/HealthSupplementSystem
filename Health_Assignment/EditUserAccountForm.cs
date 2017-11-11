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
    public partial class EditUserAccountForm : Form
    {
        public UserAccount CurrentUserAccount { get; set; }

        public EditUserAccountForm()
        {
            InitializeComponent();
        }

        public EditUserAccountForm(UserAccount currentUserAccount):this()
        {
            CurrentUserAccount = currentUserAccount;
        }



        private void EditUserAccountForm_Load(object sender, EventArgs e)
        {
            richTextBox_userName.Text = CurrentUserAccount.UserName;
            richTextBox_password.Text = CurrentUserAccount.Password;
            
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            string username = richTextBox_userName.Text;
            string password = richTextBox_password.Text;

            UserAccount editedUserAccount = new UserAccount(username, password);

            UserAccountsData.updateInformation(editedUserAccount);
            this.Close();
        }
    }
}
