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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewSalesForm));
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.icon_customer = new System.Windows.Forms.PictureBox();
            this.label_customerInfo = new System.Windows.Forms.Label();
            this.textBox_cardNumber = new System.Windows.Forms.TextBox();
            this.label_cardNumber = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_productPurchased)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon_customer)).BeginInit();
            this.SuspendLayout();
            // 
            // label_customer
            // 
            this.label_customer.AutoSize = true;
            this.label_customer.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_customer.ForeColor = System.Drawing.Color.White;
            this.label_customer.Location = new System.Drawing.Point(125, 135);
            this.label_customer.Name = "label_customer";
            this.label_customer.Size = new System.Drawing.Size(69, 16);
            this.label_customer.TabIndex = 1;
            this.label_customer.Text = "Customer";
            // 
            // comboBox_customer
            // 
            this.comboBox_customer.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_customer.FormattingEnabled = true;
            this.comboBox_customer.Location = new System.Drawing.Point(262, 132);
            this.comboBox_customer.Name = "comboBox_customer";
            this.comboBox_customer.Size = new System.Drawing.Size(263, 25);
            this.comboBox_customer.TabIndex = 2;
            this.comboBox_customer.SelectedIndexChanged += new System.EventHandler(this.comboBox_customer_SelectedIndexChanged);
            // 
            // button_search
            // 
            this.button_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(226)))), ((int)(((byte)(183)))));
            this.button_search.FlatAppearance.BorderSize = 0;
            this.button_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_search.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.button_search.Location = new System.Drawing.Point(531, 131);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(77, 25);
            this.button_search.TabIndex = 3;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = false;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // label_paid
            // 
            this.label_paid.AutoSize = true;
            this.label_paid.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_paid.ForeColor = System.Drawing.Color.White;
            this.label_paid.Location = new System.Drawing.Point(124, 171);
            this.label_paid.Name = "label_paid";
            this.label_paid.Size = new System.Drawing.Size(79, 16);
            this.label_paid.TabIndex = 4;
            this.label_paid.Text = "Paid Status";
            // 
            // checkBox_paid
            // 
            this.checkBox_paid.AutoSize = true;
            this.checkBox_paid.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_paid.ForeColor = System.Drawing.Color.White;
            this.checkBox_paid.Location = new System.Drawing.Point(265, 170);
            this.checkBox_paid.Name = "checkBox_paid";
            this.checkBox_paid.Size = new System.Drawing.Size(56, 21);
            this.checkBox_paid.TabIndex = 5;
            this.checkBox_paid.Text = "Paid";
            this.checkBox_paid.UseVisualStyleBackColor = true;
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_status.ForeColor = System.Drawing.Color.White;
            this.label_status.Location = new System.Drawing.Point(124, 208);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(46, 16);
            this.label_status.TabIndex = 6;
            this.label_status.Text = "Status";
            // 
            // label_payment
            // 
            this.label_payment.AutoSize = true;
            this.label_payment.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_payment.ForeColor = System.Drawing.Color.White;
            this.label_payment.Location = new System.Drawing.Point(124, 245);
            this.label_payment.Name = "label_payment";
            this.label_payment.Size = new System.Drawing.Size(105, 16);
            this.label_payment.TabIndex = 7;
            this.label_payment.Text = "Payment Mode";
            // 
            // comboBox_status
            // 
            this.comboBox_status.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_status.FormattingEnabled = true;
            this.comboBox_status.Location = new System.Drawing.Point(258, 205);
            this.comboBox_status.Name = "comboBox_status";
            this.comboBox_status.Size = new System.Drawing.Size(263, 25);
            this.comboBox_status.TabIndex = 8;
            // 
            // comboBox_paymentMode
            // 
            this.comboBox_paymentMode.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_paymentMode.FormattingEnabled = true;
            this.comboBox_paymentMode.Location = new System.Drawing.Point(259, 245);
            this.comboBox_paymentMode.Name = "comboBox_paymentMode";
            this.comboBox_paymentMode.Size = new System.Drawing.Size(263, 25);
            this.comboBox_paymentMode.TabIndex = 9;
            this.comboBox_paymentMode.SelectedIndexChanged += new System.EventHandler(this.comboBox_paymentMode_SelectedIndexChanged);
            // 
            // label_productPurchased
            // 
            this.label_productPurchased.AutoSize = true;
            this.label_productPurchased.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_productPurchased.ForeColor = System.Drawing.Color.White;
            this.label_productPurchased.Location = new System.Drawing.Point(123, 324);
            this.label_productPurchased.Name = "label_productPurchased";
            this.label_productPurchased.Size = new System.Drawing.Size(129, 16);
            this.label_productPurchased.TabIndex = 10;
            this.label_productPurchased.Text = "Product Purchased";
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
            this.dataGridView_productPurchased.Location = new System.Drawing.Point(126, 385);
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
            this.dataGridView_productPurchased.Size = new System.Drawing.Size(395, 206);
            this.dataGridView_productPurchased.TabIndex = 11;
            this.dataGridView_productPurchased.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_productPurchased_CellClick);
            this.dataGridView_productPurchased.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_productPurchased_CellContentClick);
            // 
            // button_addProduct
            // 
            this.button_addProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(226)))), ((int)(((byte)(183)))));
            this.button_addProduct.FlatAppearance.BorderSize = 0;
            this.button_addProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_addProduct.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_addProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.button_addProduct.Location = new System.Drawing.Point(527, 385);
            this.button_addProduct.Name = "button_addProduct";
            this.button_addProduct.Size = new System.Drawing.Size(75, 23);
            this.button_addProduct.TabIndex = 12;
            this.button_addProduct.Text = "Add Product";
            this.button_addProduct.UseVisualStyleBackColor = false;
            this.button_addProduct.Click += new System.EventHandler(this.button_addProduct_Click);
            // 
            // button_deleteProduct
            // 
            this.button_deleteProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(226)))), ((int)(((byte)(183)))));
            this.button_deleteProduct.FlatAppearance.BorderSize = 0;
            this.button_deleteProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_deleteProduct.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_deleteProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.button_deleteProduct.Location = new System.Drawing.Point(527, 414);
            this.button_deleteProduct.Name = "button_deleteProduct";
            this.button_deleteProduct.Size = new System.Drawing.Size(75, 23);
            this.button_deleteProduct.TabIndex = 13;
            this.button_deleteProduct.Text = "Delete Product";
            this.button_deleteProduct.UseVisualStyleBackColor = false;
            this.button_deleteProduct.Click += new System.EventHandler(this.button_deleteProduct_Click);
            // 
            // comboBox_product
            // 
            this.comboBox_product.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_product.FormattingEnabled = true;
            this.comboBox_product.Location = new System.Drawing.Point(258, 319);
            this.comboBox_product.Name = "comboBox_product";
            this.comboBox_product.Size = new System.Drawing.Size(263, 25);
            this.comboBox_product.TabIndex = 14;
            this.comboBox_product.SelectedIndexChanged += new System.EventHandler(this.comboBox_product_SelectedIndexChanged);
            // 
            // button_searchProduct
            // 
            this.button_searchProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(226)))), ((int)(((byte)(183)))));
            this.button_searchProduct.FlatAppearance.BorderSize = 0;
            this.button_searchProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_searchProduct.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_searchProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.button_searchProduct.Location = new System.Drawing.Point(527, 321);
            this.button_searchProduct.Name = "button_searchProduct";
            this.button_searchProduct.Size = new System.Drawing.Size(75, 23);
            this.button_searchProduct.TabIndex = 15;
            this.button_searchProduct.Text = "Search";
            this.button_searchProduct.UseVisualStyleBackColor = false;
            this.button_searchProduct.Click += new System.EventHandler(this.button_searchProduct_Click);
            // 
            // textBox_quantity
            // 
            this.textBox_quantity.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_quantity.Location = new System.Drawing.Point(320, 356);
            this.textBox_quantity.Name = "textBox_quantity";
            this.textBox_quantity.Size = new System.Drawing.Size(100, 23);
            this.textBox_quantity.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(256, 359);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(124, 613);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Order Date";
            // 
            // dateTimePicker_orderDate
            // 
            this.dateTimePicker_orderDate.CalendarFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_orderDate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_orderDate.Location = new System.Drawing.Point(250, 608);
            this.dateTimePicker_orderDate.Name = "dateTimePicker_orderDate";
            this.dateTimePicker_orderDate.Size = new System.Drawing.Size(265, 23);
            this.dateTimePicker_orderDate.TabIndex = 19;
            this.dateTimePicker_orderDate.ValueChanged += new System.EventHandler(this.dateTimePicker_orderDate_ValueChanged);
            // 
            // label_paymentDate
            // 
            this.label_paymentDate.AutoSize = true;
            this.label_paymentDate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_paymentDate.ForeColor = System.Drawing.Color.White;
            this.label_paymentDate.Location = new System.Drawing.Point(124, 650);
            this.label_paymentDate.Name = "label_paymentDate";
            this.label_paymentDate.Size = new System.Drawing.Size(98, 16);
            this.label_paymentDate.TabIndex = 20;
            this.label_paymentDate.Text = "Payment Date";
            // 
            // dateTimePicker_paymentDate
            // 
            this.dateTimePicker_paymentDate.CalendarFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_paymentDate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_paymentDate.Location = new System.Drawing.Point(250, 650);
            this.dateTimePicker_paymentDate.Name = "dateTimePicker_paymentDate";
            this.dateTimePicker_paymentDate.Size = new System.Drawing.Size(265, 23);
            this.dateTimePicker_paymentDate.TabIndex = 21;
            // 
            // button_save
            // 
            this.button_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(226)))), ((int)(((byte)(183)))));
            this.button_save.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.button_save.Location = new System.Drawing.Point(311, 715);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(77, 25);
            this.button_save.TabIndex = 22;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = false;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.icon_customer);
            this.panel1.Controls.Add(this.label_customerInfo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(702, 104);
            this.panel1.TabIndex = 68;
            // 
            // icon_customer
            // 
            this.icon_customer.BackColor = System.Drawing.Color.Transparent;
            this.icon_customer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("icon_customer.BackgroundImage")));
            this.icon_customer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.icon_customer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icon_customer.Location = new System.Drawing.Point(176, 11);
            this.icon_customer.Name = "icon_customer";
            this.icon_customer.Size = new System.Drawing.Size(84, 69);
            this.icon_customer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.icon_customer.TabIndex = 17;
            this.icon_customer.TabStop = false;
            // 
            // label_customerInfo
            // 
            this.label_customerInfo.AutoSize = true;
            this.label_customerInfo.BackColor = System.Drawing.Color.Transparent;
            this.label_customerInfo.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_customerInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_customerInfo.Location = new System.Drawing.Point(266, 29);
            this.label_customerInfo.Name = "label_customerInfo";
            this.label_customerInfo.Size = new System.Drawing.Size(211, 28);
            this.label_customerInfo.TabIndex = 0;
            this.label_customerInfo.Text = "Sales Information";
            // 
            // textBox_cardNumber
            // 
            this.textBox_cardNumber.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_cardNumber.Location = new System.Drawing.Point(258, 284);
            this.textBox_cardNumber.Name = "textBox_cardNumber";
            this.textBox_cardNumber.Size = new System.Drawing.Size(265, 23);
            this.textBox_cardNumber.TabIndex = 70;
            // 
            // label_cardNumber
            // 
            this.label_cardNumber.AutoSize = true;
            this.label_cardNumber.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cardNumber.ForeColor = System.Drawing.Color.White;
            this.label_cardNumber.Location = new System.Drawing.Point(123, 287);
            this.label_cardNumber.Name = "label_cardNumber";
            this.label_cardNumber.Size = new System.Drawing.Size(97, 16);
            this.label_cardNumber.TabIndex = 69;
            this.label_cardNumber.Text = "Card Number";
            // 
            // AddNewSalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(35)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(702, 780);
            this.Controls.Add(this.textBox_cardNumber);
            this.Controls.Add(this.label_cardNumber);
            this.Controls.Add(this.panel1);
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
            this.Name = "AddNewSalesForm";
            this.Text = "aa";
            this.Load += new System.EventHandler(this.AddNewSalesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_productPurchased)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon_customer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox icon_customer;
        private System.Windows.Forms.Label label_customerInfo;
        private System.Windows.Forms.TextBox textBox_cardNumber;
        private System.Windows.Forms.Label label_cardNumber;
    }
}