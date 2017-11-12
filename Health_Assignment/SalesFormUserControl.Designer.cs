namespace Health_Assignment
{
    partial class SalesFormUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label_sales = new System.Windows.Forms.Label();
            this.button_addSales = new System.Windows.Forms.Button();
            this.button_editSales = new System.Windows.Forms.Button();
            this.button_deleteSales = new System.Windows.Forms.Button();
            this.button_generateOrderConfirmation = new System.Windows.Forms.Button();
            this.button_generateReceipt = new System.Windows.Forms.Button();
            this.button_generateDelivery = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isPaidDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentModeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.salesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label_sales
            // 
            this.label_sales.AutoSize = true;
            this.label_sales.Location = new System.Drawing.Point(380, 28);
            this.label_sales.Name = "label_sales";
            this.label_sales.Size = new System.Drawing.Size(33, 13);
            this.label_sales.TabIndex = 0;
            this.label_sales.Text = "Sales";
            // 
            // button_addSales
            // 
            this.button_addSales.Location = new System.Drawing.Point(11, 298);
            this.button_addSales.Name = "button_addSales";
            this.button_addSales.Size = new System.Drawing.Size(107, 23);
            this.button_addSales.TabIndex = 2;
            this.button_addSales.Text = "Add New Sales";
            this.button_addSales.UseVisualStyleBackColor = true;
            this.button_addSales.Click += new System.EventHandler(this.button_addSales_Click);
            // 
            // button_editSales
            // 
            this.button_editSales.Location = new System.Drawing.Point(11, 338);
            this.button_editSales.Name = "button_editSales";
            this.button_editSales.Size = new System.Drawing.Size(107, 23);
            this.button_editSales.TabIndex = 3;
            this.button_editSales.Text = "Edit Sales";
            this.button_editSales.UseVisualStyleBackColor = true;
            this.button_editSales.Click += new System.EventHandler(this.button_editSales_Click);
            // 
            // button_deleteSales
            // 
            this.button_deleteSales.Location = new System.Drawing.Point(11, 377);
            this.button_deleteSales.Name = "button_deleteSales";
            this.button_deleteSales.Size = new System.Drawing.Size(107, 23);
            this.button_deleteSales.TabIndex = 4;
            this.button_deleteSales.Text = "Delete Sales";
            this.button_deleteSales.UseVisualStyleBackColor = true;
            this.button_deleteSales.Click += new System.EventHandler(this.button_deleteSales_Click);
            // 
            // button_generateOrderConfirmation
            // 
            this.button_generateOrderConfirmation.Location = new System.Drawing.Point(266, 298);
            this.button_generateOrderConfirmation.Name = "button_generateOrderConfirmation";
            this.button_generateOrderConfirmation.Size = new System.Drawing.Size(165, 23);
            this.button_generateOrderConfirmation.TabIndex = 5;
            this.button_generateOrderConfirmation.Text = "Generate Order Confirmation";
            this.button_generateOrderConfirmation.UseVisualStyleBackColor = true;
            this.button_generateOrderConfirmation.Click += new System.EventHandler(this.button_generateOrderConfirmation_Click);
            // 
            // button_generateReceipt
            // 
            this.button_generateReceipt.Location = new System.Drawing.Point(266, 338);
            this.button_generateReceipt.Name = "button_generateReceipt";
            this.button_generateReceipt.Size = new System.Drawing.Size(165, 23);
            this.button_generateReceipt.TabIndex = 6;
            this.button_generateReceipt.Text = "Generate Receipt";
            this.button_generateReceipt.UseVisualStyleBackColor = true;
            this.button_generateReceipt.Click += new System.EventHandler(this.button_generateReceipt_Click);
            // 
            // button_generateDelivery
            // 
            this.button_generateDelivery.Location = new System.Drawing.Point(266, 377);
            this.button_generateDelivery.Name = "button_generateDelivery";
            this.button_generateDelivery.Size = new System.Drawing.Size(165, 23);
            this.button_generateDelivery.TabIndex = 7;
            this.button_generateDelivery.Text = "Generate Delivery";
            this.button_generateDelivery.UseVisualStyleBackColor = true;
            this.button_generateDelivery.Click += new System.EventHandler(this.button_generateDelivery_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.customerID,
            this.isPaidDataGridViewCheckBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.paymentModeDataGridViewTextBoxColumn,
            this.orderDateDataGridViewTextBoxColumn,
            this.paymentDateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.salesBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(21, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(984, 150);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CurrentCustomer";
            this.dataGridViewTextBoxColumn1.HeaderText = "Customer ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CurrentCustomer";
            this.dataGridViewTextBoxColumn2.HeaderText = "Customer Details";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CurrentCustomer";
            this.dataGridViewTextBoxColumn3.HeaderText = "Customer Details";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // customerID
            // 
            this.customerID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.customerID.DataPropertyName = "CurrentCustomer";
            this.customerID.HeaderText = "Customer Details";
            this.customerID.Name = "customerID";
            this.customerID.ReadOnly = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "Sales ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isPaidDataGridViewCheckBoxColumn
            // 
            this.isPaidDataGridViewCheckBoxColumn.DataPropertyName = "IsPaid";
            this.isPaidDataGridViewCheckBoxColumn.HeaderText = "IsPaid";
            this.isPaidDataGridViewCheckBoxColumn.Name = "isPaidDataGridViewCheckBoxColumn";
            this.isPaidDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paymentModeDataGridViewTextBoxColumn
            // 
            this.paymentModeDataGridViewTextBoxColumn.DataPropertyName = "PaymentMode";
            this.paymentModeDataGridViewTextBoxColumn.HeaderText = "PaymentMode";
            this.paymentModeDataGridViewTextBoxColumn.Name = "paymentModeDataGridViewTextBoxColumn";
            this.paymentModeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderDateDataGridViewTextBoxColumn
            // 
            this.orderDateDataGridViewTextBoxColumn.DataPropertyName = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.HeaderText = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
            this.orderDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paymentDateDataGridViewTextBoxColumn
            // 
            this.paymentDateDataGridViewTextBoxColumn.DataPropertyName = "PaymentDate";
            this.paymentDateDataGridViewTextBoxColumn.HeaderText = "PaymentDate";
            this.paymentDateDataGridViewTextBoxColumn.Name = "paymentDateDataGridViewTextBoxColumn";
            this.paymentDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // salesBindingSource1
            // 
            this.salesBindingSource1.DataSource = typeof(Health_Assignment.Sales);
            // 
            // salesBindingSource
            // 
            this.salesBindingSource.DataSource = typeof(Health_Assignment.Sales);
            // 
            // SalesFormUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_generateDelivery);
            this.Controls.Add(this.button_generateReceipt);
            this.Controls.Add(this.button_generateOrderConfirmation);
            this.Controls.Add(this.button_deleteSales);
            this.Controls.Add(this.button_editSales);
            this.Controls.Add(this.button_addSales);
            this.Controls.Add(this.label_sales);
            this.Name = "SalesFormUserControl";
            this.Size = new System.Drawing.Size(1030, 522);
            this.Load += new System.EventHandler(this.SalesFormUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label_sales;
        private System.Windows.Forms.BindingSource salesBindingSource;
        private System.Windows.Forms.Button button_addSales;
        private System.Windows.Forms.Button button_editSales;
        private System.Windows.Forms.Button button_deleteSales;
        private System.Windows.Forms.Button button_generateOrderConfirmation;
        private System.Windows.Forms.Button button_generateReceipt;
        private System.Windows.Forms.Button button_generateDelivery;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource salesBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerID;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isPaidDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentModeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}
