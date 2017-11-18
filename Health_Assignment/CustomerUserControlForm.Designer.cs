namespace Health_Assignment
{
    partial class CustomerUserControlForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerUserControlForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label_Sales = new System.Windows.Forms.Label();
            this.button_completeList = new System.Windows.Forms.Button();
            this.comboBox_searchOptions = new System.Windows.Forms.ComboBox();
            this.button_Search = new System.Windows.Forms.Button();
            this.richTextBox_searchBox = new System.Windows.Forms.RichTextBox();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.button_edit = new System.Windows.Forms.Button();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(35)))), ((int)(((byte)(63)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Raleway", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(35)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.customerTypeDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.DataSource = this.customerBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(35)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlLight;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(35)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(35)))), ((int)(((byte)(63)))));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label_Sales
            // 
            resources.ApplyResources(this.label_Sales, "label_Sales");
            this.label_Sales.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_Sales.Name = "label_Sales";
            // 
            // button_completeList
            // 
            this.button_completeList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(226)))), ((int)(((byte)(183)))));
            resources.ApplyResources(this.button_completeList, "button_completeList");
            this.button_completeList.Cursor = System.Windows.Forms.Cursors.Default;
            this.button_completeList.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_completeList.FlatAppearance.BorderSize = 0;
            this.button_completeList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.button_completeList.Name = "button_completeList";
            this.button_completeList.UseVisualStyleBackColor = false;
            this.button_completeList.Click += new System.EventHandler(this.button_completeList_Click);
            // 
            // comboBox_searchOptions
            // 
            this.comboBox_searchOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(226)))), ((int)(((byte)(183)))));
            resources.ApplyResources(this.comboBox_searchOptions, "comboBox_searchOptions");
            this.comboBox_searchOptions.FormattingEnabled = true;
            this.comboBox_searchOptions.Name = "comboBox_searchOptions";
            // 
            // button_Search
            // 
            this.button_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(226)))), ((int)(((byte)(183)))));
            this.button_Search.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.button_Search, "button_Search");
            this.button_Search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.button_Search.Name = "button_Search";
            this.button_Search.UseVisualStyleBackColor = false;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // richTextBox_searchBox
            // 
            this.richTextBox_searchBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(228)))), ((int)(((byte)(183)))));
            resources.ApplyResources(this.richTextBox_searchBox, "richTextBox_searchBox");
            this.richTextBox_searchBox.Name = "richTextBox_searchBox";
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(226)))), ((int)(((byte)(183)))));
            this.button_delete.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.button_delete, "button_delete");
            this.button_delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.button_delete.Name = "button_delete";
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(226)))), ((int)(((byte)(183)))));
            this.button_add.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.button_add, "button_add");
            this.button_add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.button_add.Name = "button_add";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_edit
            // 
            this.button_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(226)))), ((int)(((byte)(183)))));
            this.button_edit.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.button_edit, "button_edit");
            this.button_edit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.button_edit.Name = "button_edit";
            this.button_edit.UseVisualStyleBackColor = false;
            this.button_edit.Click += new System.EventHandler(this.button_editCustomer_Click);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            resources.ApplyResources(this.iDDataGridViewTextBoxColumn, "iDDataGridViewTextBoxColumn");
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            resources.ApplyResources(this.firstNameDataGridViewTextBoxColumn, "firstNameDataGridViewTextBoxColumn");
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            resources.ApplyResources(this.lastNameDataGridViewTextBoxColumn, "lastNameDataGridViewTextBoxColumn");
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            resources.ApplyResources(this.addressDataGridViewTextBoxColumn, "addressDataGridViewTextBoxColumn");
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerTypeDataGridViewTextBoxColumn
            // 
            this.customerTypeDataGridViewTextBoxColumn.DataPropertyName = "CustomerType";
            resources.ApplyResources(this.customerTypeDataGridViewTextBoxColumn, "customerTypeDataGridViewTextBoxColumn");
            this.customerTypeDataGridViewTextBoxColumn.Name = "customerTypeDataGridViewTextBoxColumn";
            this.customerTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            resources.ApplyResources(this.phoneNumberDataGridViewTextBoxColumn, "phoneNumberDataGridViewTextBoxColumn");
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(Health_Assignment.Customer);
            // 
            // CustomerUserControlForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(35)))), ((int)(((byte)(63)))));
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label_Sales);
            this.Controls.Add(this.button_completeList);
            this.Controls.Add(this.comboBox_searchOptions);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.richTextBox_searchBox);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.button_edit);
            this.Name = "CustomerUserControlForm";
            this.Load += new System.EventHandler(this.CustomerUserControlForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource customerBindingSource;
        private System.Windows.Forms.Label label_Sales;
        private System.Windows.Forms.Button button_completeList;
        private System.Windows.Forms.ComboBox comboBox_searchOptions;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.RichTextBox richTextBox_searchBox;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_edit;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
    }
}
