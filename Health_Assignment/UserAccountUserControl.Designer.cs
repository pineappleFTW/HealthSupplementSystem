namespace Health_Assignment
{
    partial class UserAccountUserControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_userAccount = new System.Windows.Forms.DataGridView();
            this.button_newUserAccount = new System.Windows.Forms.Button();
            this.button_editUserAccount = new System.Windows.Forms.Button();
            this.button_deleteUserAccount = new System.Windows.Forms.Button();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userAccountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_userAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userAccountBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(456, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Account";
            // 
            // dataGridView_userAccount
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(35)))), ((int)(((byte)(63)))));
            this.dataGridView_userAccount.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_userAccount.AutoGenerateColumns = false;
            this.dataGridView_userAccount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_userAccount.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Raleway", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(35)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_userAccount.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_userAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_userAccount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userNameDataGridViewTextBoxColumn});
            this.dataGridView_userAccount.DataSource = this.userAccountBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(35)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_userAccount.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_userAccount.Location = new System.Drawing.Point(271, 94);
            this.dataGridView_userAccount.Name = "dataGridView_userAccount";
            this.dataGridView_userAccount.ReadOnly = true;
            this.dataGridView_userAccount.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(35)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_userAccount.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(35)))), ((int)(((byte)(63)))));
            this.dataGridView_userAccount.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView_userAccount.Size = new System.Drawing.Size(606, 244);
            this.dataGridView_userAccount.TabIndex = 1;
            this.dataGridView_userAccount.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_userAccount_CellContentClick);
            // 
            // button_newUserAccount
            // 
            this.button_newUserAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(226)))), ((int)(((byte)(183)))));
            this.button_newUserAccount.FlatAppearance.BorderSize = 0;
            this.button_newUserAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_newUserAccount.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_newUserAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.button_newUserAccount.Location = new System.Drawing.Point(271, 372);
            this.button_newUserAccount.Name = "button_newUserAccount";
            this.button_newUserAccount.Size = new System.Drawing.Size(172, 33);
            this.button_newUserAccount.TabIndex = 2;
            this.button_newUserAccount.Text = "New User Account";
            this.button_newUserAccount.UseVisualStyleBackColor = false;
            this.button_newUserAccount.Click += new System.EventHandler(this.button_newUserAccount_Click);
            // 
            // button_editUserAccount
            // 
            this.button_editUserAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(226)))), ((int)(((byte)(183)))));
            this.button_editUserAccount.FlatAppearance.BorderSize = 0;
            this.button_editUserAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_editUserAccount.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_editUserAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.button_editUserAccount.Location = new System.Drawing.Point(501, 372);
            this.button_editUserAccount.Name = "button_editUserAccount";
            this.button_editUserAccount.Size = new System.Drawing.Size(155, 33);
            this.button_editUserAccount.TabIndex = 3;
            this.button_editUserAccount.Text = "Edit User Account";
            this.button_editUserAccount.UseVisualStyleBackColor = false;
            this.button_editUserAccount.Click += new System.EventHandler(this.button_editUserAccount_Click);
            // 
            // button_deleteUserAccount
            // 
            this.button_deleteUserAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(226)))), ((int)(((byte)(183)))));
            this.button_deleteUserAccount.FlatAppearance.BorderSize = 0;
            this.button_deleteUserAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_deleteUserAccount.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_deleteUserAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.button_deleteUserAccount.Location = new System.Drawing.Point(712, 372);
            this.button_deleteUserAccount.Name = "button_deleteUserAccount";
            this.button_deleteUserAccount.Size = new System.Drawing.Size(165, 33);
            this.button_deleteUserAccount.TabIndex = 4;
            this.button_deleteUserAccount.Text = "Delete User Account";
            this.button_deleteUserAccount.UseVisualStyleBackColor = false;
            this.button_deleteUserAccount.Click += new System.EventHandler(this.button_deleteUserAccount_Click);
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "User Name";
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            this.userNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userAccountBindingSource
            // 
            this.userAccountBindingSource.DataSource = typeof(Health_Assignment.UserAccount);
            // 
            // UserAccountUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(35)))), ((int)(((byte)(63)))));
            this.Controls.Add(this.button_deleteUserAccount);
            this.Controls.Add(this.button_editUserAccount);
            this.Controls.Add(this.button_newUserAccount);
            this.Controls.Add(this.dataGridView_userAccount);
            this.Controls.Add(this.label1);
            this.Name = "UserAccountUserControl";
            this.Size = new System.Drawing.Size(1078, 483);
            this.Load += new System.EventHandler(this.UserAccountUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_userAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userAccountBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource userAccountBindingSource;
        private System.Windows.Forms.Button button_newUserAccount;
        private System.Windows.Forms.Button button_editUserAccount;
        private System.Windows.Forms.Button button_deleteUserAccount;
        public System.Windows.Forms.DataGridView dataGridView_userAccount;
    }
}
