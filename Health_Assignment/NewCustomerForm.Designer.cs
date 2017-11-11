namespace Health_Assignment
{
    partial class NewCustomerForm
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
            this.label_newCustomerText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_newPhoneNumber = new System.Windows.Forms.Label();
            this.textBox_newFirstName = new System.Windows.Forms.TextBox();
            this.textBox_newLastName = new System.Windows.Forms.TextBox();
            this.textBox_newAddress = new System.Windows.Forms.TextBox();
            this.comboBox_customerType = new System.Windows.Forms.ComboBox();
            this.textBox_newPhoneNumber = new System.Windows.Forms.TextBox();
            this.button_save = new System.Windows.Forms.Button();
            this.label_creditLimit = new System.Windows.Forms.Label();
            this.richTextBox_creditLimit = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label_newCustomerText
            // 
            this.label_newCustomerText.AutoSize = true;
            this.label_newCustomerText.Location = new System.Drawing.Point(128, 37);
            this.label_newCustomerText.Name = "label_newCustomerText";
            this.label_newCustomerText.Size = new System.Drawing.Size(111, 13);
            this.label_newCustomerText.TabIndex = 0;
            this.label_newCustomerText.Text = "New Customer Details";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Customer Type";
            // 
            // label_newPhoneNumber
            // 
            this.label_newPhoneNumber.AutoSize = true;
            this.label_newPhoneNumber.Location = new System.Drawing.Point(18, 239);
            this.label_newPhoneNumber.Name = "label_newPhoneNumber";
            this.label_newPhoneNumber.Size = new System.Drawing.Size(78, 13);
            this.label_newPhoneNumber.TabIndex = 5;
            this.label_newPhoneNumber.Text = "Phone Number";
            // 
            // textBox_newFirstName
            // 
            this.textBox_newFirstName.Location = new System.Drawing.Point(155, 81);
            this.textBox_newFirstName.Name = "textBox_newFirstName";
            this.textBox_newFirstName.Size = new System.Drawing.Size(100, 20);
            this.textBox_newFirstName.TabIndex = 6;
            // 
            // textBox_newLastName
            // 
            this.textBox_newLastName.Location = new System.Drawing.Point(155, 120);
            this.textBox_newLastName.Name = "textBox_newLastName";
            this.textBox_newLastName.Size = new System.Drawing.Size(100, 20);
            this.textBox_newLastName.TabIndex = 7;
            // 
            // textBox_newAddress
            // 
            this.textBox_newAddress.Location = new System.Drawing.Point(155, 162);
            this.textBox_newAddress.Name = "textBox_newAddress";
            this.textBox_newAddress.Size = new System.Drawing.Size(100, 20);
            this.textBox_newAddress.TabIndex = 8;
            // 
            // comboBox_customerType
            // 
            this.comboBox_customerType.FormattingEnabled = true;
            this.comboBox_customerType.Location = new System.Drawing.Point(155, 197);
            this.comboBox_customerType.Name = "comboBox_customerType";
            this.comboBox_customerType.Size = new System.Drawing.Size(121, 21);
            this.comboBox_customerType.TabIndex = 9;
            this.comboBox_customerType.SelectedIndexChanged += new System.EventHandler(this.comboBox_customerType_SelectedIndexChanged);
            // 
            // textBox_newPhoneNumber
            // 
            this.textBox_newPhoneNumber.Location = new System.Drawing.Point(155, 236);
            this.textBox_newPhoneNumber.Name = "textBox_newPhoneNumber";
            this.textBox_newPhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.textBox_newPhoneNumber.TabIndex = 10;
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(21, 295);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(75, 23);
            this.button_save.TabIndex = 11;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // label_creditLimit
            // 
            this.label_creditLimit.AutoSize = true;
            this.label_creditLimit.Location = new System.Drawing.Point(21, 276);
            this.label_creditLimit.Name = "label_creditLimit";
            this.label_creditLimit.Size = new System.Drawing.Size(58, 13);
            this.label_creditLimit.TabIndex = 12;
            this.label_creditLimit.Text = "Credit Limit";
            // 
            // richTextBox_creditLimit
            // 
            this.richTextBox_creditLimit.Location = new System.Drawing.Point(155, 276);
            this.richTextBox_creditLimit.Name = "richTextBox_creditLimit";
            this.richTextBox_creditLimit.Size = new System.Drawing.Size(100, 25);
            this.richTextBox_creditLimit.TabIndex = 13;
            this.richTextBox_creditLimit.Text = "";
            // 
            // NewCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 330);
            this.Controls.Add(this.richTextBox_creditLimit);
            this.Controls.Add(this.label_creditLimit);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.textBox_newPhoneNumber);
            this.Controls.Add(this.comboBox_customerType);
            this.Controls.Add(this.textBox_newAddress);
            this.Controls.Add(this.textBox_newLastName);
            this.Controls.Add(this.textBox_newFirstName);
            this.Controls.Add(this.label_newPhoneNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_newCustomerText);
            this.Name = "NewCustomerForm";
            this.Text = "NewCustomerForm";
            this.Load += new System.EventHandler(this.NewCustomerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_newCustomerText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_newPhoneNumber;
        private System.Windows.Forms.TextBox textBox_newFirstName;
        private System.Windows.Forms.TextBox textBox_newLastName;
        private System.Windows.Forms.TextBox textBox_newAddress;
        private System.Windows.Forms.ComboBox comboBox_customerType;
        private System.Windows.Forms.TextBox textBox_newPhoneNumber;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Label label_creditLimit;
        private System.Windows.Forms.RichTextBox richTextBox_creditLimit;
    }
}