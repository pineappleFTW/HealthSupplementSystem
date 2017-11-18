namespace Health_Assignment
{
    partial class PointOfSaleUserControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label_pointOfSale = new System.Windows.Forms.Label();
            this.button_save = new System.Windows.Forms.Button();
            this.dateTimePicker_orderDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_quantity = new System.Windows.Forms.TextBox();
            this.button_searchProduct = new System.Windows.Forms.Button();
            this.comboBox_product = new System.Windows.Forms.ComboBox();
            this.button_deleteProduct = new System.Windows.Forms.Button();
            this.button_addProduct = new System.Windows.Forms.Button();
            this.dataGridView_productPurchased = new System.Windows.Forms.DataGridView();
            this.label_productPurchased = new System.Windows.Forms.Label();
            this.comboBox_paymentMode = new System.Windows.Forms.ComboBox();
            this.label_payment = new System.Windows.Forms.Label();
            this.button_search = new System.Windows.Forms.Button();
            this.comboBox_customer = new System.Windows.Forms.ComboBox();
            this.label_customer = new System.Windows.Forms.Label();
            this.button_newCustomer = new System.Windows.Forms.Button();
            this.button_payNow = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.label_addressTitle = new System.Windows.Forms.Label();
            this.label_customerTypeTitle = new System.Windows.Forms.Label();
            this.label_phoneNumber = new System.Windows.Forms.Label();
            this.label_customerAddress = new System.Windows.Forms.Label();
            this.label_customerType = new System.Windows.Forms.Label();
            this.label_customerPhoneNumber = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_productPurchased)).BeginInit();
            this.SuspendLayout();
            // 
            // label_pointOfSale
            // 
            this.label_pointOfSale.AutoSize = true;
            this.label_pointOfSale.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pointOfSale.ForeColor = System.Drawing.Color.White;
            this.label_pointOfSale.Location = new System.Drawing.Point(489, 26);
            this.label_pointOfSale.Name = "label_pointOfSale";
            this.label_pointOfSale.Size = new System.Drawing.Size(173, 32);
            this.label_pointOfSale.TabIndex = 0;
            this.label_pointOfSale.Text = "Point of Sale";
            // 
            // button_save
            // 
            this.button_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(226)))), ((int)(((byte)(183)))));
            this.button_save.FlatAppearance.BorderSize = 0;
            this.button_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_save.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.button_save.Location = new System.Drawing.Point(495, 508);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(77, 25);
            this.button_save.TabIndex = 44;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = false;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // dateTimePicker_orderDate
            // 
            this.dateTimePicker_orderDate.CalendarFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_orderDate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_orderDate.Location = new System.Drawing.Point(756, 124);
            this.dateTimePicker_orderDate.Name = "dateTimePicker_orderDate";
            this.dateTimePicker_orderDate.Size = new System.Drawing.Size(265, 23);
            this.dateTimePicker_orderDate.TabIndex = 41;
            this.dateTimePicker_orderDate.ValueChanged += new System.EventHandler(this.dateTimePicker_orderDate_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(642, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 40;
            this.label3.Text = "Order Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(642, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 39;
            this.label2.Text = "Quantity";
            // 
            // textBox_quantity
            // 
            this.textBox_quantity.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_quantity.Location = new System.Drawing.Point(712, 212);
            this.textBox_quantity.Name = "textBox_quantity";
            this.textBox_quantity.Size = new System.Drawing.Size(100, 23);
            this.textBox_quantity.TabIndex = 38;
            // 
            // button_searchProduct
            // 
            this.button_searchProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(226)))), ((int)(((byte)(183)))));
            this.button_searchProduct.FlatAppearance.BorderSize = 0;
            this.button_searchProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_searchProduct.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_searchProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.button_searchProduct.Location = new System.Drawing.Point(457, 209);
            this.button_searchProduct.Name = "button_searchProduct";
            this.button_searchProduct.Size = new System.Drawing.Size(75, 23);
            this.button_searchProduct.TabIndex = 37;
            this.button_searchProduct.Text = "Search";
            this.button_searchProduct.UseVisualStyleBackColor = false;
            this.button_searchProduct.Click += new System.EventHandler(this.button_searchProduct_Click);
            // 
            // comboBox_product
            // 
            this.comboBox_product.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_product.FormattingEnabled = true;
            this.comboBox_product.Location = new System.Drawing.Point(186, 210);
            this.comboBox_product.Name = "comboBox_product";
            this.comboBox_product.Size = new System.Drawing.Size(263, 25);
            this.comboBox_product.TabIndex = 36;
            this.comboBox_product.SelectedIndexChanged += new System.EventHandler(this.comboBox_product_SelectedIndexChanged);
            // 
            // button_deleteProduct
            // 
            this.button_deleteProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(226)))), ((int)(((byte)(183)))));
            this.button_deleteProduct.FlatAppearance.BorderSize = 0;
            this.button_deleteProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_deleteProduct.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_deleteProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.button_deleteProduct.Location = new System.Drawing.Point(967, 274);
            this.button_deleteProduct.Name = "button_deleteProduct";
            this.button_deleteProduct.Size = new System.Drawing.Size(75, 23);
            this.button_deleteProduct.TabIndex = 35;
            this.button_deleteProduct.Text = "Delete Product";
            this.button_deleteProduct.UseVisualStyleBackColor = false;
            this.button_deleteProduct.Click += new System.EventHandler(this.button_deleteProduct_Click);
            // 
            // button_addProduct
            // 
            this.button_addProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(226)))), ((int)(((byte)(183)))));
            this.button_addProduct.FlatAppearance.BorderSize = 0;
            this.button_addProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_addProduct.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_addProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.button_addProduct.Location = new System.Drawing.Point(967, 245);
            this.button_addProduct.Name = "button_addProduct";
            this.button_addProduct.Size = new System.Drawing.Size(75, 23);
            this.button_addProduct.TabIndex = 34;
            this.button_addProduct.Text = "Add Product";
            this.button_addProduct.UseVisualStyleBackColor = false;
            this.button_addProduct.Click += new System.EventHandler(this.button_addProduct_Click);
            // 
            // dataGridView_productPurchased
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dataGridView_productPurchased.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_productPurchased.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.dataGridView_productPurchased.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_productPurchased.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Raleway", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.dataGridView_productPurchased.Location = new System.Drawing.Point(54, 245);
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
            this.dataGridView_productPurchased.Size = new System.Drawing.Size(907, 239);
            this.dataGridView_productPurchased.TabIndex = 33;
            this.dataGridView_productPurchased.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_productPurchased_CellClick);
            // 
            // label_productPurchased
            // 
            this.label_productPurchased.AutoSize = true;
            this.label_productPurchased.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_productPurchased.ForeColor = System.Drawing.Color.White;
            this.label_productPurchased.Location = new System.Drawing.Point(51, 216);
            this.label_productPurchased.Name = "label_productPurchased";
            this.label_productPurchased.Size = new System.Drawing.Size(129, 16);
            this.label_productPurchased.TabIndex = 32;
            this.label_productPurchased.Text = "Product Purchased";
            // 
            // comboBox_paymentMode
            // 
            this.comboBox_paymentMode.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_paymentMode.FormattingEnabled = true;
            this.comboBox_paymentMode.Location = new System.Drawing.Point(756, 85);
            this.comboBox_paymentMode.Name = "comboBox_paymentMode";
            this.comboBox_paymentMode.Size = new System.Drawing.Size(263, 25);
            this.comboBox_paymentMode.TabIndex = 31;
            this.comboBox_paymentMode.SelectedIndexChanged += new System.EventHandler(this.comboBox_paymentMode_SelectedIndexChanged);
            // 
            // label_payment
            // 
            this.label_payment.AutoSize = true;
            this.label_payment.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_payment.ForeColor = System.Drawing.Color.White;
            this.label_payment.Location = new System.Drawing.Point(642, 89);
            this.label_payment.Name = "label_payment";
            this.label_payment.Size = new System.Drawing.Size(105, 16);
            this.label_payment.TabIndex = 29;
            this.label_payment.Text = "Payment Mode";
            // 
            // button_search
            // 
            this.button_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(226)))), ((int)(((byte)(183)))));
            this.button_search.FlatAppearance.BorderSize = 0;
            this.button_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_search.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.button_search.Location = new System.Drawing.Point(455, 85);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(77, 25);
            this.button_search.TabIndex = 25;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = false;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // comboBox_customer
            // 
            this.comboBox_customer.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_customer.FormattingEnabled = true;
            this.comboBox_customer.Location = new System.Drawing.Point(186, 86);
            this.comboBox_customer.Name = "comboBox_customer";
            this.comboBox_customer.Size = new System.Drawing.Size(263, 25);
            this.comboBox_customer.TabIndex = 24;
            this.comboBox_customer.SelectedIndexChanged += new System.EventHandler(this.comboBox_customer_SelectedIndexChanged);
            // 
            // label_customer
            // 
            this.label_customer.AutoSize = true;
            this.label_customer.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_customer.ForeColor = System.Drawing.Color.White;
            this.label_customer.Location = new System.Drawing.Point(51, 89);
            this.label_customer.Name = "label_customer";
            this.label_customer.Size = new System.Drawing.Size(69, 16);
            this.label_customer.TabIndex = 23;
            this.label_customer.Text = "Customer";
            // 
            // button_newCustomer
            // 
            this.button_newCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(226)))), ((int)(((byte)(183)))));
            this.button_newCustomer.FlatAppearance.BorderSize = 0;
            this.button_newCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_newCustomer.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_newCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.button_newCustomer.Location = new System.Drawing.Point(186, 55);
            this.button_newCustomer.Name = "button_newCustomer";
            this.button_newCustomer.Size = new System.Drawing.Size(137, 25);
            this.button_newCustomer.TabIndex = 45;
            this.button_newCustomer.Text = "New Customer";
            this.button_newCustomer.UseVisualStyleBackColor = false;
            this.button_newCustomer.Click += new System.EventHandler(this.button_newCustomer_Click);
            // 
            // button_payNow
            // 
            this.button_payNow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(226)))), ((int)(((byte)(183)))));
            this.button_payNow.FlatAppearance.BorderSize = 0;
            this.button_payNow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_payNow.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_payNow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.button_payNow.Location = new System.Drawing.Point(611, 508);
            this.button_payNow.Name = "button_payNow";
            this.button_payNow.Size = new System.Drawing.Size(76, 25);
            this.button_payNow.TabIndex = 46;
            this.button_payNow.Text = "Pay Now";
            this.button_payNow.UseVisualStyleBackColor = false;
            this.button_payNow.Click += new System.EventHandler(this.button_payNow_Click);
            // 
            // button_clear
            // 
            this.button_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(226)))), ((int)(((byte)(183)))));
            this.button_clear.FlatAppearance.BorderSize = 0;
            this.button_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_clear.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_clear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.button_clear.Location = new System.Drawing.Point(922, 0);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(151, 58);
            this.button_clear.TabIndex = 47;
            this.button_clear.Text = "CLEAR";
            this.button_clear.UseVisualStyleBackColor = false;
            this.button_clear.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // label_addressTitle
            // 
            this.label_addressTitle.AutoSize = true;
            this.label_addressTitle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_addressTitle.ForeColor = System.Drawing.Color.White;
            this.label_addressTitle.Location = new System.Drawing.Point(51, 124);
            this.label_addressTitle.Name = "label_addressTitle";
            this.label_addressTitle.Size = new System.Drawing.Size(126, 16);
            this.label_addressTitle.TabIndex = 48;
            this.label_addressTitle.Text = "Customer Address";
            // 
            // label_customerTypeTitle
            // 
            this.label_customerTypeTitle.AutoSize = true;
            this.label_customerTypeTitle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_customerTypeTitle.ForeColor = System.Drawing.Color.White;
            this.label_customerTypeTitle.Location = new System.Drawing.Point(51, 156);
            this.label_customerTypeTitle.Name = "label_customerTypeTitle";
            this.label_customerTypeTitle.Size = new System.Drawing.Size(104, 16);
            this.label_customerTypeTitle.TabIndex = 49;
            this.label_customerTypeTitle.Text = "Customer Type";
            // 
            // label_phoneNumber
            // 
            this.label_phoneNumber.AutoSize = true;
            this.label_phoneNumber.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_phoneNumber.ForeColor = System.Drawing.Color.White;
            this.label_phoneNumber.Location = new System.Drawing.Point(51, 185);
            this.label_phoneNumber.Name = "label_phoneNumber";
            this.label_phoneNumber.Size = new System.Drawing.Size(103, 16);
            this.label_phoneNumber.TabIndex = 50;
            this.label_phoneNumber.Text = "Phone Number";
            // 
            // label_customerAddress
            // 
            this.label_customerAddress.AutoSize = true;
            this.label_customerAddress.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_customerAddress.ForeColor = System.Drawing.Color.White;
            this.label_customerAddress.Location = new System.Drawing.Point(183, 124);
            this.label_customerAddress.Name = "label_customerAddress";
            this.label_customerAddress.Size = new System.Drawing.Size(0, 16);
            this.label_customerAddress.TabIndex = 51;
            // 
            // label_customerType
            // 
            this.label_customerType.AutoSize = true;
            this.label_customerType.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_customerType.ForeColor = System.Drawing.Color.White;
            this.label_customerType.Location = new System.Drawing.Point(183, 156);
            this.label_customerType.Name = "label_customerType";
            this.label_customerType.Size = new System.Drawing.Size(0, 16);
            this.label_customerType.TabIndex = 52;
            // 
            // label_customerPhoneNumber
            // 
            this.label_customerPhoneNumber.AutoSize = true;
            this.label_customerPhoneNumber.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_customerPhoneNumber.ForeColor = System.Drawing.Color.White;
            this.label_customerPhoneNumber.Location = new System.Drawing.Point(183, 185);
            this.label_customerPhoneNumber.Name = "label_customerPhoneNumber";
            this.label_customerPhoneNumber.Size = new System.Drawing.Size(0, 16);
            this.label_customerPhoneNumber.TabIndex = 53;
            // 
            // PointOfSaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(35)))), ((int)(((byte)(63)))));
            this.Controls.Add(this.label_customerPhoneNumber);
            this.Controls.Add(this.label_customerType);
            this.Controls.Add(this.label_customerAddress);
            this.Controls.Add(this.label_phoneNumber);
            this.Controls.Add(this.label_customerTypeTitle);
            this.Controls.Add(this.label_addressTitle);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.button_payNow);
            this.Controls.Add(this.button_newCustomer);
            this.Controls.Add(this.button_save);
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
            this.Controls.Add(this.label_payment);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.comboBox_customer);
            this.Controls.Add(this.label_customer);
            this.Controls.Add(this.label_pointOfSale);
            this.Name = "PointOfSaleForm";
            this.Size = new System.Drawing.Size(1073, 557);
            this.Load += new System.EventHandler(this.PointOfSaleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_productPurchased)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_pointOfSale;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.DateTimePicker dateTimePicker_orderDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_quantity;
        private System.Windows.Forms.Button button_searchProduct;
        private System.Windows.Forms.ComboBox comboBox_product;
        private System.Windows.Forms.Button button_deleteProduct;
        private System.Windows.Forms.Button button_addProduct;
        private System.Windows.Forms.DataGridView dataGridView_productPurchased;
        private System.Windows.Forms.Label label_productPurchased;
        private System.Windows.Forms.ComboBox comboBox_paymentMode;
        private System.Windows.Forms.Label label_payment;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.ComboBox comboBox_customer;
        private System.Windows.Forms.Label label_customer;
        private System.Windows.Forms.Button button_newCustomer;
        private System.Windows.Forms.Button button_payNow;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Label label_addressTitle;
        private System.Windows.Forms.Label label_customerTypeTitle;
        private System.Windows.Forms.Label label_phoneNumber;
        private System.Windows.Forms.Label label_customerAddress;
        private System.Windows.Forms.Label label_customerType;
        private System.Windows.Forms.Label label_customerPhoneNumber;
    }
}
