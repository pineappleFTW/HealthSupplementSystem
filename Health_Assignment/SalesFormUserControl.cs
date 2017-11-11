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
    public partial class SalesFormUserControl : UserControl
    {
        private List<Sales> currentListOfSales;

        public SalesFormUserControl()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void populateList()
        {
            currentListOfSales = SalesData.getCurrentList();
            dataGridView1.DataSource = currentListOfSales;

        }

        private void SalesFormUserControl_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns[5].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridView1.Columns[6].DefaultCellStyle.Format = "dd/MM/yyyy";
            populateList();
        }
    }
}
