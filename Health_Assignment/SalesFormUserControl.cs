﻿using System;
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
    public partial class SalesFormUserControl : UserControl
    {
        public int currentIndex = 0;
        private List<Sales> currentListOfSales;

        public SalesFormUserControl()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            currentIndex = e.RowIndex;
        }

        public void populateList()
        {
            currentListOfSales = SalesData.getCurrentList();
            dataGridView1.DataSource = currentListOfSales;

        }

        public void reloadList()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = currentListOfSales;
            dataGridView1.Refresh();
        }

        private void SalesFormUserControl_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns[5].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridView1.Columns[6].DefaultCellStyle.Format = "dd/MM/yyyy";
            populateList();
        }

        private void button_addSales_Click(object sender, EventArgs e)
        {
            AddNewSalesForm newSalesForm = new AddNewSalesForm();
            newSalesForm.Show();
        }

        private void button_editSales_Click(object sender, EventArgs e)
        {
            if (currentListOfSales.Count != 0)
            {
                if(currentListOfSales.Count <= currentIndex)
                {
                    currentIndex = 0;
                }
                DataGridViewRow selectedRow = dataGridView1.Rows[currentIndex];
                Sales currentSaleOrder = (Sales)dataGridView1.CurrentRow.DataBoundItem;

                EditSalesForm editSalesForm = new EditSalesForm(currentSaleOrder);
                editSalesForm.Show();
            }
            else
            {
                MessageBox.Show("There is no sales order");
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (currentListOfSales.Count != 0)
            {
                if (currentListOfSales.Count <= currentIndex)
                {
                    currentIndex = 0;
                }
                DataGridViewRow selectedRow = dataGridView1.Rows[currentIndex];
                Sales currentSaleOrder = (Sales)dataGridView1.CurrentRow.DataBoundItem;

                ViewSalesForm viewSalesForm = new ViewSalesForm(currentSaleOrder);
                viewSalesForm.Show();
            }
            else
            {
                MessageBox.Show("There is no sales order");
            }
        }

        private void button_deleteSales_Click(object sender, EventArgs e)
        {
            if (currentListOfSales.Count != 0)
            {
                if (currentListOfSales.Count <= currentIndex)
                {
                    currentIndex = 0;
                }
                DataGridViewRow selectedRow = dataGridView1.Rows[currentIndex];
                Sales currentSaleOrder = (Sales)dataGridView1.CurrentRow.DataBoundItem;

                var confirmResult = MessageBox.Show("Are you sure to delete sales: " + currentSaleOrder.ID +  " ?",
                                      "Delete Confirmation",
                                      MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    SalesData.deleteSales(currentSaleOrder);
                }
                else
                {
                    // If 'No', do something here.
                }

            }
            else
            {
                MessageBox.Show("There is no sales order");
            }

            reloadList();
        }

        private void button_generateOrderConfirmation_Click(object sender, EventArgs e)
        {

        }
    }
}
