namespace Health_Assignment
{
    partial class EditSalesForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_customerDetails = new System.Windows.Forms.Label();
            this.label_paidStatus = new System.Windows.Forms.Label();
            this.checkBox_paid = new System.Windows.Forms.CheckBox();
            this.label_status = new System.Windows.Forms.Label();
            this.comboBox_status = new System.Windows.Forms.ComboBox();
            this.label_paymentMode = new System.Windows.Forms.Label();
            this.comboBox_paymentMode = new System.Windows.Forms.ComboBox();
            this.label_productPurchased = new System.Windows.Forms.Label();
            this.comboBox_product = new System.Windows.Forms.ComboBox();
            this.button_search = new System.Windows.Forms.Button();
            this.label_quantity = new System.Windows.Forms.Label();
            this.textBox_quantity = new System.Windows.Forms.TextBox();
            this.dataGridView_productPurchased = new System.Windows.Forms.DataGridView();
            this.button_addProduct = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.label_orderDate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker_orderDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_paymentDate = new System.Windows.Forms.DateTimePicker();
            this.button_save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_productPurchased)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(239, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Edit Sales Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(131, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer";
            // 
            // label_customerDetails
            // 
            this.label_customerDetails.AutoSize = true;
            this.label_customerDetails.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_customerDetails.ForeColor = System.Drawing.Color.White;
            this.label_customerDetails.Location = new System.Drawing.Point(272, 61);
            this.label_customerDetails.Name = "label_customerDetails";
            this.label_customerDetails.Size = new System.Drawing.Size(150, 17);
            this.label_customerDetails.TabIndex = 2;
            this.label_customerDetails.Text = "Some customer name";
            // 
            // label_paidStatus
            // 
            this.label_paidStatus.AutoSize = true;
            this.label_paidStatus.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_paidStatus.ForeColor = System.Drawing.Color.White;
            this.label_paidStatus.Location = new System.Drawing.Point(131, 91);
            this.label_paidStatus.Name = "label_paidStatus";
            this.label_paidStatus.Size = new System.Drawing.Size(79, 16);
            this.label_paidStatus.TabIndex = 3;
            this.label_paidStatus.Text = "Paid Status";
            // 
            // checkBox_paid
            // 
            this.checkBox_paid.AutoSize = true;
            this.checkBox_paid.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_paid.ForeColor = System.Drawing.Color.White;
            this.checkBox_paid.Location = new System.Drawing.Point(272, 91);
            this.checkBox_paid.Name = "checkBox_paid";
            this.checkBox_paid.Size = new System.Drawing.Size(56, 21);
            this.checkBox_paid.TabIndex = 4;
            this.checkBox_paid.Text = "Paid";
            this.checkBox_paid.UseVisualStyleBackColor = true;
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_status.ForeColor = System.Drawing.Color.White;
            this.label_status.Location = new System.Drawing.Point(130, 129);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(46, 16);
            this.label_status.TabIndex = 5;
            this.label_status.Text = "Status";
            // 
            // comboBox_status
            // 
            this.comboBox_status.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_status.FormattingEnabled = true;
            this.comboBox_status.Location = new System.Drawing.Point(272, 129);
            this.comboBox_status.Name = "comboBox_status";
            this.comboBox_status.Size = new System.Drawing.Size(203, 25);
            this.comboBox_status.TabIndex = 6;
            // 
            // label_paymentMode
            // 
            this.label_paymentMode.AutoSize = true;
            this.label_paymentMode.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_paymentMode.ForeColor = System.Drawing.Color.White;
            this.label_paymentMode.Location = new System.Drawing.Point(130, 165);
            this.label_paymentMode.Name = "label_paymentMode";
            this.label_paymentMode.Size = new System.Drawing.Size(105, 16);
            this.label_paymentMode.TabIndex = 7;
            this.label_paymentMode.Text = "Payment Mode";
            // 
            // comboBox_paymentMode
            // 
            this.comboBox_paymentMode.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_paymentMode.FormattingEnabled = true;
            this.comboBox_paymentMode.Location = new System.Drawing.Point(272, 165);
            this.comboBox_paymentMode.Name = "comboBox_paymentMode";
            this.comboBox_paymentMode.Size = new System.Drawing.Size(203, 25);
            this.comboBox_paymentMode.TabIndex = 8;
            // 
            // label_productPurchased
            // 
            this.label_productPurchased.AutoSize = true;
            this.label_productPurchased.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_productPurchased.ForeColor = System.Drawing.Color.White;
            this.label_productPurchased.Location = new System.Drawing.Point(130, 209);
            this.label_productPurchased.Name = "label_productPurchased";
            this.label_productPurchased.Size = new System.Drawing.Size(129, 16);
            this.label_productPurchased.TabIndex = 9;
            this.label_productPurchased.Text = "Product Purchased";
            // 
            // comboBox_product
            // 
            this.comboBox_product.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_product.FormattingEnabled = true;
            this.comboBox_product.Location = new System.Drawing.Point(272, 206);
            this.comboBox_product.Name = "comboBox_product";
            this.comboBox_product.Size = new System.Drawing.Size(268, 25);
            this.comboBox_product.TabIndex = 10;
            this.comboBox_product.SelectedIndexChanged += new System.EventHandler(this.comboBox_product_SelectedIndexChanged);
            // 
            // button_search
            // 
            this.button_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(226)))), ((int)(((byte)(183)))));
            this.button_search.FlatAppearance.BorderSize = 0;
            this.button_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_search.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.button_search.Location = new System.Drawing.Point(546, 206);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(75, 23);
            this.button_search.TabIndex = 11;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = false;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // label_quantity
            // 
            this.label_quantity.AutoSize = true;
            this.label_quantity.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_quantity.ForeColor = System.Drawing.Color.White;
            this.label_quantity.Location = new System.Drawing.Point(272, 241);
            this.label_quantity.Name = "label_quantity";
            this.label_quantity.Size = new System.Drawing.Size(64, 16);
            this.label_quantity.TabIndex = 12;
            this.label_quantity.Text = "Quantity";
            // 
            // textBox_quantity
            // 
            this.textBox_quantity.Location = new System.Drawing.Point(338, 238);
            this.textBox_quantity.Name = "textBox_quantity";
            this.textBox_quantity.Size = new System.Drawing.Size(107, 20);
            this.textBox_quantity.TabIndex = 13;
            // 
            // dataGridView_productPurchased
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dataGridView_productPurchased.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_productPurchased.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.dataGridView_productPurchased.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Raleway", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_productPurchased.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_productPurchased.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_productPurchased.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_productPurchased.Location = new System.Drawing.Point(134, 264);
            this.dataGridView_productPurchased.Name = "dataGridView_productPurchased";
            this.dataGridView_productPurchased.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_productPurchased.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_productPurchased.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_productPurchased.Size = new System.Drawing.Size(407, 222);
            this.dataGridView_productPurchased.TabIndex = 14;
            this.dataGridView_productPurchased.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_productPurchased_CellClick);
            this.dataGridView_productPurchased.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_productPurchased_CellContentClick);
            // 
            // button_addProduct
            // 
            this.button_addProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(226)))), ((int)(((byte)(183)))));
            this.button_addProduct.FlatAppearance.BorderSize = 0;
            this.button_addProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_addProduct.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_addProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.button_addProduct.Location = new System.Drawing.Point(546, 284);
            this.button_addProduct.Name = "button_addProduct";
            this.button_addProduct.Size = new System.Drawing.Size(75, 23);
            this.button_addProduct.TabIndex = 15;
            this.button_addProduct.Text = "Add Product";
            this.button_addProduct.UseVisualStyleBackColor = false;
            this.button_addProduct.Click += new System.EventHandler(this.button_addProduct_Click);
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(226)))), ((int)(((byte)(183)))));
            this.button_delete.FlatAppearance.BorderSize = 0;
            this.button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_delete.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.button_delete.Location = new System.Drawing.Point(546, 313);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(75, 23);
            this.button_delete.TabIndex = 16;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // label_orderDate
            // 
            this.label_orderDate.AutoSize = true;
            this.label_orderDate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_orderDate.ForeColor = System.Drawing.Color.White;
            this.label_orderDate.Location = new System.Drawing.Point(130, 508);
            this.label_orderDate.Name = "label_orderDate";
            this.label_orderDate.Size = new System.Drawing.Size(80, 16);
            this.label_orderDate.TabIndex = 17;
            this.label_orderDate.Text = "Order Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(130, 539);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Payment Date";
            // 
            // dateTimePicker_orderDate
            // 
            this.dateTimePicker_orderDate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_orderDate.Location = new System.Drawing.Point(263, 501);
            this.dateTimePicker_orderDate.Name = "dateTimePicker_orderDate";
            this.dateTimePicker_orderDate.Size = new System.Drawing.Size(231, 23);
            this.dateTimePicker_orderDate.TabIndex = 19;
            // 
            // dateTimePicker_paymentDate
            // 
            this.dateTimePicker_paymentDate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_paymentDate.Location = new System.Drawing.Point(263, 539);
            this.dateTimePicker_paymentDate.Name = "dateTimePicker_paymentDate";
            this.dateTimePicker_paymentDate.Size = new System.Drawing.Size(231, 23);
            this.dateTimePicker_paymentDate.TabIndex = 20;
            this.dateTimePicker_paymentDate.ValueChanged += new System.EventHandler(this.dateTimePicker_paymentDate_ValueChanged);
            // 
            // button_save
            // 
            this.button_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(226)))), ((int)(((byte)(183)))));
            this.button_save.FlatAppearance.BorderSize = 0;
            this.button_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_save.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.button_save.Location = new System.Drawing.Point(287, 602);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(75, 23);
            this.button_save.TabIndex = 21;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = false;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // EditSalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(35)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(706, 661);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.dateTimePicker_paymentDate);
            this.Controls.Add(this.dateTimePicker_orderDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_orderDate);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_addProduct);
            this.Controls.Add(this.dataGridView_productPurchased);
            this.Controls.Add(this.textBox_quantity);
            this.Controls.Add(this.label_quantity);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.comboBox_product);
            this.Controls.Add(this.label_productPurchased);
            this.Controls.Add(this.comboBox_paymentMode);
            this.Controls.Add(this.label_paymentMode);
            this.Controls.Add(this.comboBox_status);
            this.Controls.Add(this.label_status);
            this.Controls.Add(this.checkBox_paid);
            this.Controls.Add(this.label_paidStatus);
            this.Controls.Add(this.label_customerDetails);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditSalesForm";
            this.Text = "EditSalesForm";
            this.Load += new System.EventHandler(this.EditSalesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_productPurchased)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_customerDetails;
        private System.Windows.Forms.Label label_paidStatus;
        private System.Windows.Forms.CheckBox checkBox_paid;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.ComboBox comboBox_status;
        private System.Windows.Forms.Label label_paymentMode;
        private System.Windows.Forms.ComboBox comboBox_paymentMode;
        private System.Windows.Forms.Label label_productPurchased;
        private System.Windows.Forms.ComboBox comboBox_product;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Label label_quantity;
        private System.Windows.Forms.TextBox textBox_quantity;
        private System.Windows.Forms.DataGridView dataGridView_productPurchased;
        private System.Windows.Forms.Button button_addProduct;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Label label_orderDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker_orderDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker_paymentDate;
        private System.Windows.Forms.Button button_save;
    }
}