namespace Health_Assignment
{
    partial class PurchaseOrderUseControl
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
            this.label_purchaseStock = new System.Windows.Forms.Label();
            this.dataGridView_purchaseOrders = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentProductDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isObtainedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button_newPurchase = new System.Windows.Forms.Button();
            this.button_deletePurchase = new System.Windows.Forms.Button();
            this.comboBox_searchOption = new System.Windows.Forms.ComboBox();
            this.textBox_searchQuery = new System.Windows.Forms.TextBox();
            this.button_search = new System.Windows.Forms.Button();
            this.button_completeList = new System.Windows.Forms.Button();
            this.button_completed = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_purchaseOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label_purchaseStock
            // 
            this.label_purchaseStock.AutoSize = true;
            this.label_purchaseStock.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_purchaseStock.ForeColor = System.Drawing.Color.White;
            this.label_purchaseStock.Location = new System.Drawing.Point(400, 28);
            this.label_purchaseStock.Name = "label_purchaseStock";
            this.label_purchaseStock.Size = new System.Drawing.Size(275, 41);
            this.label_purchaseStock.TabIndex = 0;
            this.label_purchaseStock.Text = "Purchase Stock";
            // 
            // dataGridView_purchaseOrders
            // 
            this.dataGridView_purchaseOrders.AutoGenerateColumns = false;
            this.dataGridView_purchaseOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_purchaseOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.currentProductDataGridViewTextBoxColumn,
            this.isObtainedDataGridViewCheckBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn});
            this.dataGridView_purchaseOrders.DataSource = this.purchaseOrderBindingSource;
            this.dataGridView_purchaseOrders.Location = new System.Drawing.Point(191, 152);
            this.dataGridView_purchaseOrders.Name = "dataGridView_purchaseOrders";
            this.dataGridView_purchaseOrders.ReadOnly = true;
            this.dataGridView_purchaseOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_purchaseOrders.Size = new System.Drawing.Size(757, 259);
            this.dataGridView_purchaseOrders.TabIndex = 1;
            this.dataGridView_purchaseOrders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // currentProductDataGridViewTextBoxColumn
            // 
            this.currentProductDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.currentProductDataGridViewTextBoxColumn.DataPropertyName = "CurrentProduct";
            this.currentProductDataGridViewTextBoxColumn.HeaderText = "CurrentProduct";
            this.currentProductDataGridViewTextBoxColumn.Name = "currentProductDataGridViewTextBoxColumn";
            this.currentProductDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isObtainedDataGridViewCheckBoxColumn
            // 
            this.isObtainedDataGridViewCheckBoxColumn.DataPropertyName = "IsObtained";
            this.isObtainedDataGridViewCheckBoxColumn.HeaderText = "IsObtained";
            this.isObtainedDataGridViewCheckBoxColumn.Name = "isObtainedDataGridViewCheckBoxColumn";
            this.isObtainedDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // purchaseOrderBindingSource
            // 
            this.purchaseOrderBindingSource.DataSource = typeof(Health_Assignment.PurchaseOrder);
            // 
            // button_newPurchase
            // 
            this.button_newPurchase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(228)))), ((int)(((byte)(183)))));
            this.button_newPurchase.DialogResult = System.Windows.Forms.DialogResult.No;
            this.button_newPurchase.FlatAppearance.BorderSize = 0;
            this.button_newPurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_newPurchase.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_newPurchase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.button_newPurchase.Location = new System.Drawing.Point(191, 433);
            this.button_newPurchase.Name = "button_newPurchase";
            this.button_newPurchase.Size = new System.Drawing.Size(130, 33);
            this.button_newPurchase.TabIndex = 2;
            this.button_newPurchase.Text = "New Purchase";
            this.button_newPurchase.UseVisualStyleBackColor = false;
            this.button_newPurchase.Click += new System.EventHandler(this.button_newPurchase_Click);
            // 
            // button_deletePurchase
            // 
            this.button_deletePurchase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(228)))), ((int)(((byte)(183)))));
            this.button_deletePurchase.FlatAppearance.BorderSize = 0;
            this.button_deletePurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_deletePurchase.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_deletePurchase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.button_deletePurchase.Location = new System.Drawing.Point(343, 433);
            this.button_deletePurchase.Name = "button_deletePurchase";
            this.button_deletePurchase.Size = new System.Drawing.Size(140, 33);
            this.button_deletePurchase.TabIndex = 3;
            this.button_deletePurchase.Text = "Delete Purchase";
            this.button_deletePurchase.UseVisualStyleBackColor = false;
            this.button_deletePurchase.Click += new System.EventHandler(this.button_deletePurchase_Click);
            // 
            // comboBox_searchOption
            // 
            this.comboBox_searchOption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(226)))), ((int)(((byte)(183)))));
            this.comboBox_searchOption.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_searchOption.FormattingEnabled = true;
            this.comboBox_searchOption.Location = new System.Drawing.Point(825, 88);
            this.comboBox_searchOption.Name = "comboBox_searchOption";
            this.comboBox_searchOption.Size = new System.Drawing.Size(121, 25);
            this.comboBox_searchOption.TabIndex = 4;
            // 
            // textBox_searchQuery
            // 
            this.textBox_searchQuery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(226)))), ((int)(((byte)(183)))));
            this.textBox_searchQuery.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_searchQuery.Location = new System.Drawing.Point(665, 88);
            this.textBox_searchQuery.Name = "textBox_searchQuery";
            this.textBox_searchQuery.Size = new System.Drawing.Size(154, 23);
            this.textBox_searchQuery.TabIndex = 5;
            // 
            // button_search
            // 
            this.button_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(226)))), ((int)(((byte)(183)))));
            this.button_search.FlatAppearance.BorderSize = 0;
            this.button_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_search.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.button_search.Location = new System.Drawing.Point(665, 117);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(75, 23);
            this.button_search.TabIndex = 7;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = false;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // button_completeList
            // 
            this.button_completeList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(226)))), ((int)(((byte)(183)))));
            this.button_completeList.FlatAppearance.BorderSize = 0;
            this.button_completeList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_completeList.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_completeList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.button_completeList.Location = new System.Drawing.Point(191, 89);
            this.button_completeList.Name = "button_completeList";
            this.button_completeList.Size = new System.Drawing.Size(114, 23);
            this.button_completeList.TabIndex = 8;
            this.button_completeList.Text = "Complete List";
            this.button_completeList.UseVisualStyleBackColor = false;
            this.button_completeList.Click += new System.EventHandler(this.button_completeList_Click);
            // 
            // button_completed
            // 
            this.button_completed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(226)))), ((int)(((byte)(183)))));
            this.button_completed.FlatAppearance.BorderSize = 0;
            this.button_completed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_completed.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_completed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.button_completed.Location = new System.Drawing.Point(788, 433);
            this.button_completed.Name = "button_completed";
            this.button_completed.Size = new System.Drawing.Size(146, 33);
            this.button_completed.TabIndex = 9;
            this.button_completed.Text = "Mark Complete";
            this.button_completed.UseVisualStyleBackColor = false;
            this.button_completed.Click += new System.EventHandler(this.button_completed_Click);
            // 
            // PurchaseOrderUseControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(35)))), ((int)(((byte)(63)))));
            this.Controls.Add(this.button_completed);
            this.Controls.Add(this.button_completeList);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.textBox_searchQuery);
            this.Controls.Add(this.comboBox_searchOption);
            this.Controls.Add(this.button_deletePurchase);
            this.Controls.Add(this.button_newPurchase);
            this.Controls.Add(this.dataGridView_purchaseOrders);
            this.Controls.Add(this.label_purchaseStock);
            this.Name = "PurchaseOrderUseControl";
            this.Size = new System.Drawing.Size(1099, 557);
            this.Load += new System.EventHandler(this.PurchaseOrderUseControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_purchaseOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrderBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_purchaseStock;
        private System.Windows.Forms.DataGridView dataGridView_purchaseOrders;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentProductDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isObtainedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource purchaseOrderBindingSource;
        private System.Windows.Forms.Button button_newPurchase;
        private System.Windows.Forms.Button button_deletePurchase;
        private System.Windows.Forms.ComboBox comboBox_searchOption;
        private System.Windows.Forms.TextBox textBox_searchQuery;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Button button_completeList;
        private System.Windows.Forms.Button button_completed;
    }
}
