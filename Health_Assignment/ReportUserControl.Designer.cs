namespace Health_Assignment
{
    partial class ReportUserControl
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
            this.label_reportTitle = new System.Windows.Forms.Label();
            this.button_dailySales = new System.Windows.Forms.Button();
            this.button_generateMonthlySales = new System.Windows.Forms.Button();
            this.button_allTimeSales = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.comboBox_month = new System.Windows.Forms.ComboBox();
            this.dataGridView_report = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentCustomerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isPaidDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentModeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox_year = new System.Windows.Forms.ComboBox();
            this.button_year = new System.Windows.Forms.Button();
            this.comboBox_yearSales = new System.Windows.Forms.ComboBox();
            this.label_totalSalesText = new System.Windows.Forms.Label();
            this.label_totalSales = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_report)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label_reportTitle
            // 
            this.label_reportTitle.AutoSize = true;
            this.label_reportTitle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_reportTitle.Location = new System.Drawing.Point(487, 43);
            this.label_reportTitle.Name = "label_reportTitle";
            this.label_reportTitle.Size = new System.Drawing.Size(58, 19);
            this.label_reportTitle.TabIndex = 0;
            this.label_reportTitle.Text = "Report";
            // 
            // button_dailySales
            // 
            this.button_dailySales.Location = new System.Drawing.Point(178, 75);
            this.button_dailySales.Name = "button_dailySales";
            this.button_dailySales.Size = new System.Drawing.Size(75, 23);
            this.button_dailySales.TabIndex = 1;
            this.button_dailySales.Text = "Daily Sales";
            this.button_dailySales.UseVisualStyleBackColor = true;
            this.button_dailySales.Click += new System.EventHandler(this.button_dailySales_Click);
            // 
            // button_generateMonthlySales
            // 
            this.button_generateMonthlySales.Location = new System.Drawing.Point(327, 77);
            this.button_generateMonthlySales.Name = "button_generateMonthlySales";
            this.button_generateMonthlySales.Size = new System.Drawing.Size(158, 23);
            this.button_generateMonthlySales.TabIndex = 2;
            this.button_generateMonthlySales.Text = "Monthly Sales";
            this.button_generateMonthlySales.UseVisualStyleBackColor = true;
            this.button_generateMonthlySales.Click += new System.EventHandler(this.button_generateMonthlySales_Click);
            // 
            // button_allTimeSales
            // 
            this.button_allTimeSales.Location = new System.Drawing.Point(842, 73);
            this.button_allTimeSales.Name = "button_allTimeSales";
            this.button_allTimeSales.Size = new System.Drawing.Size(146, 23);
            this.button_allTimeSales.TabIndex = 3;
            this.button_allTimeSales.Text = "All Time Sales";
            this.button_allTimeSales.UseVisualStyleBackColor = true;
            this.button_allTimeSales.Click += new System.EventHandler(this.button_allTimeSales_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // comboBox_month
            // 
            this.comboBox_month.FormattingEnabled = true;
            this.comboBox_month.Location = new System.Drawing.Point(491, 77);
            this.comboBox_month.Name = "comboBox_month";
            this.comboBox_month.Size = new System.Drawing.Size(121, 21);
            this.comboBox_month.TabIndex = 6;
            // 
            // dataGridView_report
            // 
            this.dataGridView_report.AutoGenerateColumns = false;
            this.dataGridView_report.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_report.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.currentCustomerDataGridViewTextBoxColumn,
            this.isPaidDataGridViewCheckBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.paymentModeDataGridViewTextBoxColumn,
            this.orderDateDataGridViewTextBoxColumn,
            this.paymentDateDataGridViewTextBoxColumn});
            this.dataGridView_report.DataSource = this.salesBindingSource;
            this.dataGridView_report.Location = new System.Drawing.Point(153, 133);
            this.dataGridView_report.Name = "dataGridView_report";
            this.dataGridView_report.Size = new System.Drawing.Size(815, 353);
            this.dataGridView_report.TabIndex = 7;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // currentCustomerDataGridViewTextBoxColumn
            // 
            this.currentCustomerDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.currentCustomerDataGridViewTextBoxColumn.DataPropertyName = "CurrentCustomer";
            this.currentCustomerDataGridViewTextBoxColumn.HeaderText = "CurrentCustomer";
            this.currentCustomerDataGridViewTextBoxColumn.Name = "currentCustomerDataGridViewTextBoxColumn";
            // 
            // isPaidDataGridViewCheckBoxColumn
            // 
            this.isPaidDataGridViewCheckBoxColumn.DataPropertyName = "IsPaid";
            this.isPaidDataGridViewCheckBoxColumn.HeaderText = "IsPaid";
            this.isPaidDataGridViewCheckBoxColumn.Name = "isPaidDataGridViewCheckBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // paymentModeDataGridViewTextBoxColumn
            // 
            this.paymentModeDataGridViewTextBoxColumn.DataPropertyName = "PaymentMode";
            this.paymentModeDataGridViewTextBoxColumn.HeaderText = "PaymentMode";
            this.paymentModeDataGridViewTextBoxColumn.Name = "paymentModeDataGridViewTextBoxColumn";
            // 
            // orderDateDataGridViewTextBoxColumn
            // 
            this.orderDateDataGridViewTextBoxColumn.DataPropertyName = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.HeaderText = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
            // 
            // paymentDateDataGridViewTextBoxColumn
            // 
            this.paymentDateDataGridViewTextBoxColumn.DataPropertyName = "PaymentDate";
            this.paymentDateDataGridViewTextBoxColumn.HeaderText = "PaymentDate";
            this.paymentDateDataGridViewTextBoxColumn.Name = "paymentDateDataGridViewTextBoxColumn";
            // 
            // salesBindingSource
            // 
            this.salesBindingSource.DataSource = typeof(Health_Assignment.Sales);
            // 
            // comboBox_year
            // 
            this.comboBox_year.FormattingEnabled = true;
            this.comboBox_year.Location = new System.Drawing.Point(491, 106);
            this.comboBox_year.Name = "comboBox_year";
            this.comboBox_year.Size = new System.Drawing.Size(121, 21);
            this.comboBox_year.TabIndex = 8;
            // 
            // button_year
            // 
            this.button_year.Location = new System.Drawing.Point(633, 77);
            this.button_year.Name = "button_year";
            this.button_year.Size = new System.Drawing.Size(75, 23);
            this.button_year.TabIndex = 9;
            this.button_year.Text = "Yearly Sales";
            this.button_year.UseVisualStyleBackColor = true;
            this.button_year.Click += new System.EventHandler(this.button_year_Click);
            // 
            // comboBox_yearSales
            // 
            this.comboBox_yearSales.FormattingEnabled = true;
            this.comboBox_yearSales.Location = new System.Drawing.Point(715, 75);
            this.comboBox_yearSales.Name = "comboBox_yearSales";
            this.comboBox_yearSales.Size = new System.Drawing.Size(121, 21);
            this.comboBox_yearSales.TabIndex = 10;
            // 
            // label_totalSalesText
            // 
            this.label_totalSalesText.AutoSize = true;
            this.label_totalSalesText.Location = new System.Drawing.Point(776, 489);
            this.label_totalSalesText.Name = "label_totalSalesText";
            this.label_totalSalesText.Size = new System.Drawing.Size(60, 13);
            this.label_totalSalesText.TabIndex = 11;
            this.label_totalSalesText.Text = "Total Sales";
            // 
            // label_totalSales
            // 
            this.label_totalSales.AutoSize = true;
            this.label_totalSales.Location = new System.Drawing.Point(910, 489);
            this.label_totalSales.Name = "label_totalSales";
            this.label_totalSales.Size = new System.Drawing.Size(31, 13);
            this.label_totalSales.TabIndex = 12;
            this.label_totalSales.Text = "1000";
            // 
            // ReportUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_totalSales);
            this.Controls.Add(this.label_totalSalesText);
            this.Controls.Add(this.comboBox_yearSales);
            this.Controls.Add(this.button_year);
            this.Controls.Add(this.comboBox_year);
            this.Controls.Add(this.dataGridView_report);
            this.Controls.Add(this.comboBox_month);
            this.Controls.Add(this.button_allTimeSales);
            this.Controls.Add(this.button_generateMonthlySales);
            this.Controls.Add(this.button_dailySales);
            this.Controls.Add(this.label_reportTitle);
            this.Name = "ReportUserControl";
            this.Size = new System.Drawing.Size(1072, 531);
            this.Load += new System.EventHandler(this.ReportUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_report)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_reportTitle;
        private System.Windows.Forms.Button button_dailySales;
        private System.Windows.Forms.Button button_generateMonthlySales;
        private System.Windows.Forms.Button button_allTimeSales;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ComboBox comboBox_month;
        private System.Windows.Forms.DataGridView dataGridView_report;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentCustomerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isPaidDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentModeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource salesBindingSource;
        private System.Windows.Forms.ComboBox comboBox_year;
        private System.Windows.Forms.Button button_year;
        private System.Windows.Forms.ComboBox comboBox_yearSales;
        private System.Windows.Forms.Label label_totalSalesText;
        private System.Windows.Forms.Label label_totalSales;
    }
}
