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
    public partial class PurchaseOrderUserControl : UserControl
    {
        public int currentIndex = 0;
        public List<PurchaseOrder> CurrentListOfPurchaseOrders;

        public PurchaseOrderUserControl()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PurchaseOrderUseControl_Load(object sender, EventArgs e)
        {
            comboBox_searchOption.Items.Add("Product Name");
            comboBox_searchOption.Items.Add("Date");
            comboBox_searchOption.SelectedIndex = 0;
            dataGridView_purchaseOrders.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridView_purchaseOrders.EnableHeadersVisualStyles = false;
            populateList();
        }

        public void reloadList()
        {
            dataGridView_purchaseOrders.DataSource = null;
            dataGridView_purchaseOrders.DataSource = CurrentListOfPurchaseOrders;
            dataGridView_purchaseOrders.Refresh();
        }

        public void populateList()
        {
            CurrentListOfPurchaseOrders = PurchaseOrdersData.purchaseOrders;
            dataGridView_purchaseOrders.DataSource = CurrentListOfPurchaseOrders;
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            string searchQuery = textBox_searchQuery.Text.Trim();
            string type = comboBox_searchOption.Text;

            var returnedResults =
                from currentPurchaseOrder in PurchaseOrdersData.purchaseOrders
                select currentPurchaseOrder;

            switch (type)
            {
                case "Product Name":
                    returnedResults =
                    from currentPurchaseOrder in PurchaseOrdersData.purchaseOrders
                    where currentPurchaseOrder.CurrentProduct.Name == searchQuery
                    select currentPurchaseOrder;
                    break;
                case "Date":      
                    try
                    {
                        string[] dateSearchQuery = searchQuery.Split('/');
                        DateTime date = new DateTime(Int32.Parse(dateSearchQuery[2]), Int32.Parse(dateSearchQuery[1]), Int32.Parse(dateSearchQuery[0]));
                        returnedResults =
                            from currentPurchaseOrder in PurchaseOrdersData.purchaseOrders
                            where (currentPurchaseOrder.Date.Year == date.Year) && (currentPurchaseOrder.Date.Month == date.Month)   && (currentPurchaseOrder.Date.Day == date.Day)
                            select currentPurchaseOrder;
                        
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Invalid Format! Please search in the format of DD/MM/YYYY", "Invalid Date Query");
                    }
                    break;


            }

            List<PurchaseOrder> returnedList = returnedResults.ToList();

            CurrentListOfPurchaseOrders = returnedList;
            reloadList();
        }

        private void button_completeList_Click(object sender, EventArgs e)
        {
            populateList();
        }

        private void button_completed_Click(object sender, EventArgs e)
        {
            if (CurrentListOfPurchaseOrders.Count != 0)
            {
                if (CurrentListOfPurchaseOrders.Count <= currentIndex)
                {
                    currentIndex = 0;
                }
                DataGridViewRow selectedRow = dataGridView_purchaseOrders.Rows[currentIndex];
                PurchaseOrder currentPurchaseOrder = (PurchaseOrder)dataGridView_purchaseOrders.CurrentRow.DataBoundItem;

                if (!currentPurchaseOrder.IsObtained)
                {
                    var confirmResult = MessageBox.Show("Are you sure to the order is arrived?: ",
                                       "Stock Arrival Confirmation",
                                       MessageBoxButtons.YesNo);

                    if (confirmResult == DialogResult.Yes)
                    {
                        //ADD STOCK TO PRODUCT
                        currentPurchaseOrder.CurrentProduct.Quantity += currentPurchaseOrder.Quantity;
                        currentPurchaseOrder.IsObtained = true;

                    }
                    else
                    {
                        // If 'No', do something here.
                    }

                    reloadList();
                }
                else
                {
                    MessageBox.Show("This order is completed!");
                }
               
            }
            else
            {
                MessageBox.Show("There is no more purchase order");
            }
        }

        private void button_newPurchase_Click(object sender, EventArgs e)
        {
            AddNewPurchaseOrderForm newPurchaseOrderForm = new AddNewPurchaseOrderForm();
            newPurchaseOrderForm.Show();
        }

        private void button_deletePurchase_Click(object sender, EventArgs e)
        {
            if (CurrentListOfPurchaseOrders.Count!=0){
                if (CurrentListOfPurchaseOrders.Count <= currentIndex)
                {
                    currentIndex = 0;
                }
                DataGridViewRow selectedRow = dataGridView_purchaseOrders.Rows[currentIndex];
                PurchaseOrder currentPurchaseOrder = (PurchaseOrder)dataGridView_purchaseOrders.CurrentRow.DataBoundItem;

                var confirmResult = MessageBox.Show("Are you sure to delete purchase order: " + currentPurchaseOrder.ID + " : " + currentPurchaseOrder.CurrentProduct.Name+ " which contains " + currentPurchaseOrder.Quantity+ " ?",
                                        "Delete Confirmation",
                                        MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    PurchaseOrdersData.deletePurchaseOrder(currentPurchaseOrder);
                    CurrentListOfPurchaseOrders.Remove(currentPurchaseOrder);

                }
                else
                {
                    // If 'No', do something here.
                }

                reloadList();
            }
            else
            {
                MessageBox.Show("There is no more purchase order");
            }

           
        }
    }
}
