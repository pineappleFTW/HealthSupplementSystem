﻿namespace Health_Assignment
{
    partial class AddNewPurchaseOrderForm
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
            this.label_newPurchaseOrder = new System.Windows.Forms.Label();
            this.label_product = new System.Windows.Forms.Label();
            this.comboBox_searchProduct = new System.Windows.Forms.ComboBox();
            this.button_search = new System.Windows.Forms.Button();
            this.label_orderDate = new System.Windows.Forms.Label();
            this.dateTimePicker_orderDate = new System.Windows.Forms.DateTimePicker();
            this.label_quantity = new System.Windows.Forms.Label();
            this.textBox_quantity = new System.Windows.Forms.TextBox();
            this.button_save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_newPurchaseOrder
            // 
            this.label_newPurchaseOrder.AutoSize = true;
            this.label_newPurchaseOrder.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_newPurchaseOrder.ForeColor = System.Drawing.Color.White;
            this.label_newPurchaseOrder.Location = new System.Drawing.Point(175, 31);
            this.label_newPurchaseOrder.Name = "label_newPurchaseOrder";
            this.label_newPurchaseOrder.Size = new System.Drawing.Size(167, 19);
            this.label_newPurchaseOrder.TabIndex = 0;
            this.label_newPurchaseOrder.Text = "New Purchase Order";
            // 
            // label_product
            // 
            this.label_product.AutoSize = true;
            this.label_product.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_product.ForeColor = System.Drawing.Color.White;
            this.label_product.Location = new System.Drawing.Point(58, 81);
            this.label_product.Name = "label_product";
            this.label_product.Size = new System.Drawing.Size(57, 16);
            this.label_product.TabIndex = 1;
            this.label_product.Text = "Product";
            // 
            // comboBox_searchProduct
            // 
            this.comboBox_searchProduct.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_searchProduct.FormattingEnabled = true;
            this.comboBox_searchProduct.Location = new System.Drawing.Point(61, 109);
            this.comboBox_searchProduct.Name = "comboBox_searchProduct";
            this.comboBox_searchProduct.Size = new System.Drawing.Size(281, 25);
            this.comboBox_searchProduct.TabIndex = 2;
            this.comboBox_searchProduct.SelectedIndexChanged += new System.EventHandler(this.comboBox_searchProduct_SelectedIndexChanged);
            // 
            // button_search
            // 
            this.button_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(226)))), ((int)(((byte)(183)))));
            this.button_search.FlatAppearance.BorderSize = 0;
            this.button_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_search.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.button_search.Location = new System.Drawing.Point(365, 109);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(75, 23);
            this.button_search.TabIndex = 3;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = false;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // label_orderDate
            // 
            this.label_orderDate.AutoSize = true;
            this.label_orderDate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_orderDate.ForeColor = System.Drawing.Color.White;
            this.label_orderDate.Location = new System.Drawing.Point(58, 160);
            this.label_orderDate.Name = "label_orderDate";
            this.label_orderDate.Size = new System.Drawing.Size(80, 16);
            this.label_orderDate.TabIndex = 4;
            this.label_orderDate.Text = "Order Date";
            // 
            // dateTimePicker_orderDate
            // 
            this.dateTimePicker_orderDate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_orderDate.Location = new System.Drawing.Point(61, 192);
            this.dateTimePicker_orderDate.Name = "dateTimePicker_orderDate";
            this.dateTimePicker_orderDate.Size = new System.Drawing.Size(281, 23);
            this.dateTimePicker_orderDate.TabIndex = 5;
            // 
            // label_quantity
            // 
            this.label_quantity.AutoSize = true;
            this.label_quantity.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_quantity.ForeColor = System.Drawing.Color.White;
            this.label_quantity.Location = new System.Drawing.Point(58, 240);
            this.label_quantity.Name = "label_quantity";
            this.label_quantity.Size = new System.Drawing.Size(64, 16);
            this.label_quantity.TabIndex = 6;
            this.label_quantity.Text = "Quantity";
            // 
            // textBox_quantity
            // 
            this.textBox_quantity.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_quantity.Location = new System.Drawing.Point(61, 272);
            this.textBox_quantity.Name = "textBox_quantity";
            this.textBox_quantity.Size = new System.Drawing.Size(281, 23);
            this.textBox_quantity.TabIndex = 7;
            // 
            // button_save
            // 
            this.button_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(226)))), ((int)(((byte)(183)))));
            this.button_save.FlatAppearance.BorderSize = 0;
            this.button_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_save.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.button_save.Location = new System.Drawing.Point(239, 335);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(75, 23);
            this.button_save.TabIndex = 8;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = false;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // AddNewPurchaseOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(35)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(529, 394);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.textBox_quantity);
            this.Controls.Add(this.label_quantity);
            this.Controls.Add(this.dateTimePicker_orderDate);
            this.Controls.Add(this.label_orderDate);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.comboBox_searchProduct);
            this.Controls.Add(this.label_product);
            this.Controls.Add(this.label_newPurchaseOrder);
            this.Name = "AddNewPurchaseOrderForm";
            this.Text = "AddNewPurchaseOrderForm";
            this.Load += new System.EventHandler(this.AddNewPurchaseOrderForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_newPurchaseOrder;
        private System.Windows.Forms.Label label_product;
        private System.Windows.Forms.ComboBox comboBox_searchProduct;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Label label_orderDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker_orderDate;
        private System.Windows.Forms.Label label_quantity;
        private System.Windows.Forms.TextBox textBox_quantity;
        private System.Windows.Forms.Button button_save;
    }
}