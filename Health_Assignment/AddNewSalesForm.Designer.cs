namespace Health_Assignment
{
    partial class AddNewSalesForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label_customer = new System.Windows.Forms.Label();
            this.comboBox_customer = new System.Windows.Forms.ComboBox();
            this.button_search = new System.Windows.Forms.Button();
            this.label_paid = new System.Windows.Forms.Label();
            this.checkBox_paid = new System.Windows.Forms.CheckBox();
            this.label_status = new System.Windows.Forms.Label();
            this.label_payment = new System.Windows.Forms.Label();
            this.comboBox_status = new System.Windows.Forms.ComboBox();
            this.comboBox_paymentMode = new System.Windows.Forms.ComboBox();
            this.label_productPurchased = new System.Windows.Forms.Label();
            this.dataGridView_productPurchased = new System.Windows.Forms.DataGridView();
            this.button_addProduct = new System.Windows.Forms.Button();
            this.button_deleteProduct = new System.Windows.Forms.Button();
            this.comboBox_product = new System.Windows.Forms.ComboBox();
            this.button_searchProduct = new System.Windows.Forms.Button();
            this.textBox_quantity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker_orderDate = new System.Windows.Forms.DateTimePicker();
            this.label_paymentDate = new System.Windows.Forms.Label();
            this.dateTimePicker_paymentDate = new System.Windows.Forms.DateTimePicker();
            this.button_save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_productPurchased)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(285, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sales Information";
            // 
            // label_customer
            // 
            this.label_customer.AutoSize = true;
            this.label_customer.Location = new System.Drawing.Point(143, 59);
            this.label_customer.Name = "label_customer";
            this.label_customer.Size = new System.Drawing.Size(51, 13);
            this.label_customer.TabIndex = 1;
            this.label_customer.Text = "Customer";
            // 
            // comboBox_customer
            // 
            this.comboBox_customer.FormattingEnabled = true;
            this.comboBox_customer.Location = new System.Drawing.Point(288, 50);
            this.comboBox_customer.Name = "comboBox_customer";
            this.comboBox_customer.Size = new System.Drawing.Size(263, 21);
            this.comboBox_customer.TabIndex = 2;
            this.comboBox_customer.SelectedIndexChanged += new System.EventHandler(this.comboBox_customer_SelectedIndexChanged);
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(557, 48);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(75, 23);
            this.button_search.TabIndex = 3;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // label_paid
            // 
            this.label_paid.AutoSize = true;
            this.label_paid.Location = new System.Drawing.Point(143, 100);
            this.label_paid.Name = "label_paid";
            this.label_paid.Size = new System.Drawing.Size(61, 13);
            this.label_paid.TabIndex = 4;
            this.label_paid.Text = "Paid Status";
            // 
            // checkBox_paid
            // 
            this.checkBox_paid.AutoSize = true;
            this.checkBox_paid.Location = new System.Drawing.Point(288, 99);
            this.checkBox_paid.Name = "checkBox_paid";
            this.checkBox_paid.Size = new System.Drawing.Size(47, 17);
            this.checkBox_paid.TabIndex = 5;
            this.checkBox_paid.Text = "Paid";
            this.checkBox_paid.UseVisualStyleBackColor = true;
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Location = new System.Drawing.Point(143, 139);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(37, 13);
            this.label_status.TabIndex = 6;
            this.label_status.Text = "Status";
            // 
            // label_payment
            // 
            this.label_payment.AutoSize = true;
            this.label_payment.Location = new System.Drawing.Point(143, 169);
            this.label_payment.Name = "label_payment";
            this.label_payment.Size = new System.Drawing.Size(78, 13);
            this.label_payment.TabIndex = 7;
            this.label_payment.Text = "Payment Mode";
            // 
            // comboBox_status
            // 
            this.comboBox_status.FormattingEnabled = true;
            this.comboBox_status.Location = new System.Drawing.Point(288, 136);
            this.comboBox_status.Name = "comboBox_status";
            this.comboBox_status.Size = new System.Drawing.Size(263, 21);
            this.comboBox_status.TabIndex = 8;
            // 
            // comboBox_paymentMode
            // 
            this.comboBox_paymentMode.FormattingEnabled = true;
            this.comboBox_paymentMode.Location = new System.Drawing.Point(288, 169);
            this.comboBox_paymentMode.Name = "comboBox_paymentMode";
            this.comboBox_paymentMode.Size = new System.Drawing.Size(263, 21);
            this.comboBox_paymentMode.TabIndex = 9;
            this.comboBox_paymentMode.SelectedIndexChanged += new System.EventHandler(this.comboBox_paymentMode_SelectedIndexChanged);
            // 
            // label_productPurchased
            // 
            this.label_productPurchased.AutoSize = true;
            this.label_productPurchased.Location = new System.Drawing.Point(143, 210);
            this.label_productPurchased.Name = "label_productPurchased";
            this.label_productPurchased.Size = new System.Drawing.Size(98, 13);
            this.label_productPurchased.TabIndex = 10;
            this.label_productPurchased.Text = "Product Purchased";
            // 
            // dataGridView_productPurchased
            // 
            this.dataGridView_productPurchased.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_productPurchased.Location = new System.Drawing.Point(288, 262);
            this.dataGridView_productPurchased.Name = "dataGridView_productPurchased";
            this.dataGridView_productPurchased.Size = new System.Drawing.Size(269, 85);
            this.dataGridView_productPurchased.TabIndex = 11;
            this.dataGridView_productPurchased.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_productPurchased_CellClick);
            this.dataGridView_productPurchased.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_productPurchased_CellContentClick);
            // 
            // button_addProduct
            // 
            this.button_addProduct.Location = new System.Drawing.Point(573, 262);
            this.button_addProduct.Name = "button_addProduct";
            this.button_addProduct.Size = new System.Drawing.Size(75, 23);
            this.button_addProduct.TabIndex = 12;
            this.button_addProduct.Text = "Add Product";
            this.button_addProduct.UseVisualStyleBackColor = true;
            this.button_addProduct.Click += new System.EventHandler(this.button_addProduct_Click);
            // 
            // button_deleteProduct
            // 
            this.button_deleteProduct.Location = new System.Drawing.Point(573, 292);
            this.button_deleteProduct.Name = "button_deleteProduct";
            this.button_deleteProduct.Size = new System.Drawing.Size(75, 23);
            this.button_deleteProduct.TabIndex = 13;
            this.button_deleteProduct.Text = "Delete Product";
            this.button_deleteProduct.UseVisualStyleBackColor = true;
            this.button_deleteProduct.Click += new System.EventHandler(this.button_deleteProduct_Click);
            // 
            // comboBox_product
            // 
            this.comboBox_product.FormattingEnabled = true;
            this.comboBox_product.Location = new System.Drawing.Point(288, 205);
            this.comboBox_product.Name = "comboBox_product";
            this.comboBox_product.Size = new System.Drawing.Size(269, 21);
            this.comboBox_product.TabIndex = 14;
            this.comboBox_product.SelectedIndexChanged += new System.EventHandler(this.comboBox_product_SelectedIndexChanged);
            // 
            // button_searchProduct
            // 
            this.button_searchProduct.Location = new System.Drawing.Point(573, 205);
            this.button_searchProduct.Name = "button_searchProduct";
            this.button_searchProduct.Size = new System.Drawing.Size(75, 23);
            this.button_searchProduct.TabIndex = 15;
            this.button_searchProduct.Text = "Search";
            this.button_searchProduct.UseVisualStyleBackColor = true;
            this.button_searchProduct.Click += new System.EventHandler(this.button_searchProduct_Click);
            // 
            // textBox_quantity
            // 
            this.textBox_quantity.Location = new System.Drawing.Point(351, 232);
            this.textBox_quantity.Name = "textBox_quantity";
            this.textBox_quantity.Size = new System.Drawing.Size(100, 20);
            this.textBox_quantity.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 365);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Order Date";
            // 
            // dateTimePicker_orderDate
            // 
            this.dateTimePicker_orderDate.Location = new System.Drawing.Point(288, 365);
            this.dateTimePicker_orderDate.Name = "dateTimePicker_orderDate";
            this.dateTimePicker_orderDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_orderDate.TabIndex = 19;
            this.dateTimePicker_orderDate.ValueChanged += new System.EventHandler(this.dateTimePicker_orderDate_ValueChanged);
            // 
            // label_paymentDate
            // 
            this.label_paymentDate.AutoSize = true;
            this.label_paymentDate.Location = new System.Drawing.Point(145, 402);
            this.label_paymentDate.Name = "label_paymentDate";
            this.label_paymentDate.Size = new System.Drawing.Size(74, 13);
            this.label_paymentDate.TabIndex = 20;
            this.label_paymentDate.Text = "Payment Date";
            // 
            // dateTimePicker_paymentDate
            // 
            this.dateTimePicker_paymentDate.Location = new System.Drawing.Point(288, 396);
            this.dateTimePicker_paymentDate.Name = "dateTimePicker_paymentDate";
            this.dateTimePicker_paymentDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_paymentDate.TabIndex = 21;
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(322, 442);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(75, 23);
            this.button_save.TabIndex = 22;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // AddNewSalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 486);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.dateTimePicker_paymentDate);
            this.Controls.Add(this.label_paymentDate);
            this.Controls.Add(this.dateTimePicker_orderDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_quantity);
            this.Controls.Add(this.button_searchProduct);
            this.Controls.Add(this.comboBox_product);
            this.Controls.Add(this.button_deleteProduct);
            this.Controls.Add(this.button_addProduct);
            this.Controls.Add(this.dataGridView_productPurchased);
            this.Controls.Add(this.label_productPurchased);
            this.Controls.Add(this.comboBox_paymentMode);
            this.Controls.Add(this.comboBox_status);
            this.Controls.Add(this.label_payment);
            this.Controls.Add(this.label_status);
            this.Controls.Add(this.checkBox_paid);
            this.Controls.Add(this.label_paid);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.comboBox_customer);
            this.Controls.Add(this.label_customer);
            this.Controls.Add(this.label1);
            this.Name = "AddNewSalesForm";
            this.Text = "aa";
            this.Load += new System.EventHandler(this.AddNewSalesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_productPurchased)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_customer;
        private System.Windows.Forms.ComboBox comboBox_customer;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Label label_paid;
        private System.Windows.Forms.CheckBox checkBox_paid;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.Label label_payment;
        private System.Windows.Forms.ComboBox comboBox_status;
        private System.Windows.Forms.ComboBox comboBox_paymentMode;
        private System.Windows.Forms.Label label_productPurchased;
        private System.Windows.Forms.DataGridView dataGridView_productPurchased;
        private System.Windows.Forms.Button button_addProduct;
        private System.Windows.Forms.Button button_deleteProduct;
        private System.Windows.Forms.ComboBox comboBox_product;
        private System.Windows.Forms.Button button_searchProduct;
        private System.Windows.Forms.TextBox textBox_quantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker_orderDate;
        private System.Windows.Forms.Label label_paymentDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker_paymentDate;
        private System.Windows.Forms.Button button_save;
    }
}