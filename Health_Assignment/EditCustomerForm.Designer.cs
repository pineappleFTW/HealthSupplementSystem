namespace Health_Assignment
{
    partial class EditCustomerForm
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
            this.label_customerInfo = new System.Windows.Forms.Label();
            this.label_firstNameHeader = new System.Windows.Forms.Label();
            this.label_lastNameHeader = new System.Windows.Forms.Label();
            this.textBox_firstName = new System.Windows.Forms.TextBox();
            this.textBox_lastName = new System.Windows.Forms.TextBox();
            this.button_save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_customerInfo
            // 
            this.label_customerInfo.AutoSize = true;
            this.label_customerInfo.Location = new System.Drawing.Point(87, 27);
            this.label_customerInfo.Name = "label_customerInfo";
            this.label_customerInfo.Size = new System.Drawing.Size(106, 13);
            this.label_customerInfo.TabIndex = 0;
            this.label_customerInfo.Text = "Customer Information";
            // 
            // label_firstNameHeader
            // 
            this.label_firstNameHeader.AutoSize = true;
            this.label_firstNameHeader.Location = new System.Drawing.Point(55, 87);
            this.label_firstNameHeader.Name = "label_firstNameHeader";
            this.label_firstNameHeader.Size = new System.Drawing.Size(57, 13);
            this.label_firstNameHeader.TabIndex = 1;
            this.label_firstNameHeader.Text = "First Name";
            // 
            // label_lastNameHeader
            // 
            this.label_lastNameHeader.AutoSize = true;
            this.label_lastNameHeader.Location = new System.Drawing.Point(55, 120);
            this.label_lastNameHeader.Name = "label_lastNameHeader";
            this.label_lastNameHeader.Size = new System.Drawing.Size(58, 13);
            this.label_lastNameHeader.TabIndex = 3;
            this.label_lastNameHeader.Text = "Last Name";
            // 
            // textBox_firstName
            // 
            this.textBox_firstName.Location = new System.Drawing.Point(160, 80);
            this.textBox_firstName.Name = "textBox_firstName";
            this.textBox_firstName.Size = new System.Drawing.Size(100, 20);
            this.textBox_firstName.TabIndex = 5;
            this.textBox_firstName.Text = "some name";
            this.textBox_firstName.TextChanged += new System.EventHandler(this.textBox_firstName_TextChanged);
            // 
            // textBox_lastName
            // 
            this.textBox_lastName.Location = new System.Drawing.Point(160, 120);
            this.textBox_lastName.Name = "textBox_lastName";
            this.textBox_lastName.Size = new System.Drawing.Size(100, 20);
            this.textBox_lastName.TabIndex = 6;
            this.textBox_lastName.Text = "some last name";
            this.textBox_lastName.TextChanged += new System.EventHandler(this.textBox_lastName_TextChanged);
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(58, 218);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(75, 23);
            this.button_save.TabIndex = 7;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.textBox_lastName);
            this.Controls.Add(this.textBox_firstName);
            this.Controls.Add(this.label_lastNameHeader);
            this.Controls.Add(this.label_firstNameHeader);
            this.Controls.Add(this.label_customerInfo);
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_customerInfo;
        private System.Windows.Forms.Label label_firstNameHeader;
        private System.Windows.Forms.Label label_lastNameHeader;
        private System.Windows.Forms.TextBox textBox_firstName;
        private System.Windows.Forms.TextBox textBox_lastName;
        private System.Windows.Forms.Button button_save;
    }
}