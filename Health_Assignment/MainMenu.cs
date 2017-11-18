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

   


        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void icon_customer_Click_1(object sender, EventArgs e)
        {
            customerUserControlForm.BringToFront();
        }

        private void icon_users_Click(object sender, EventArgs e)
        {
            userAccountUserControl.BringToFront();
        }

        private void button_logOut_Click(object sender, EventArgs e)
        {
            Form mainForm = Application.OpenForms["Login"];
            Login loginForm = (Login)mainForm;
            this.Close();
            loginForm.Show();
        }


        private void icon_inventory_Click(object sender, EventArgs e)
        {
            inventoryUserControl.BringToFront();
        }

        private void icon_sales_Click(object sender, EventArgs e)
        {
            salesFormUserControl.BringToFront();
        }

        private void button_home_Click(object sender, EventArgs e)
        {
            homeUserControl.BringToFront();
        }

        private void icon_report_Click(object sender, EventArgs e)
        {
            reportUserControl.BringToFront();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void icon_purchase_Click(object sender, EventArgs e)
        {
            purchaseOrderUseControl.BringToFront();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void mainMenu_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            inventoryUserControl.populateList();
            purchaseOrderUseControl.populateList();
            salesFormUserControl.populateList();
            customerUserControlForm.populateList();
            userAccountUserControl.populateList();
            reportUserControl.populateList();
        }

        private void button_pos_Click(object sender, EventArgs e)
        {
            pointOfSaleForm.BringToFront();
        }

       
    }
}
