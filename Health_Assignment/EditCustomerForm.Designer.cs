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
            this.button_save = new System.Windows.Forms.Button();
            this.label_address = new System.Windows.Forms.Label();
            this.richTextBox_address = new System.Windows.Forms.RichTextBox();
            this.richTextBox_firstName = new System.Windows.Forms.RichTextBox();
            this.richTextBox_lastName = new System.Windows.Forms.RichTextBox();
            this.label_customerType = new System.Windows.Forms.Label();
            this.label_phoneNumber = new System.Windows.Forms.Label();
            this.comboBox_customerType = new System.Windows.Forms.ComboBox();
            this.richTextBox_phoneNumber = new System.Windows.Forms.RichTextBox();
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
            this.label_firstNameHeader.Location = new System.Drawing.Point(26, 60);
            this.label_firstNameHeader.Name = "label_firstNameHeader";
            this.label_firstNameHeader.Size = new System.Drawing.Size(57, 13);
            this.label_firstNameHeader.TabIndex = 1;
            this.label_firstNameHeader.Text = "First Name";
            // 
            // label_lastNameHeader
            // 
            this.label_lastNameHeader.AutoSize = true;
            this.label_lastNameHeader.Location = new System.Drawing.Point(26, 99);
            this.label_lastNameHeader.Name = "label_lastNameHeader";
            this.label_lastNameHeader.Size = new System.Drawing.Size(58, 13);
            this.label_lastNameHeader.TabIndex = 3;
            this.label_lastNameHeader.Text = "Last Name";
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(90, 288);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(75, 23);
            this.button_save.TabIndex = 7;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // label_address
            // 
            this.label_address.AutoSize = true;
            this.label_address.Location = new System.Drawing.Point(26, 136);
            this.label_address.Name = "label_address";
            this.label_address.Size = new System.Drawing.Size(45, 13);
            this.label_address.TabIndex = 8;
            this.label_address.Text = "Address";
            // 
            // richTextBox_address
            // 
            this.richTextBox_address.Location = new System.Drawing.Point(104, 133);
            this.richTextBox_address.Name = "richTextBox_address";
            this.richTextBox_address.Size = new System.Drawing.Size(121, 33);
            this.richTextBox_address.TabIndex = 9;
            this.richTextBox_address.Text = "Some address";
            // 
            // richTextBox_firstName
            // 
            this.richTextBox_firstName.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox_firstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox_firstName.Location = new System.Drawing.Point(104, 50);
            this.richTextBox_firstName.MaxLength = 30;
            this.richTextBox_firstName.Name = "richTextBox_firstName";
            this.richTextBox_firstName.Size = new System.Drawing.Size(121, 23);
            this.richTextBox_firstName.TabIndex = 10;
            this.richTextBox_firstName.Text = "";
            // 
            // richTextBox_lastName
            // 
            this.richTextBox_lastName.Location = new System.Drawing.Point(104, 91);
            this.richTextBox_lastName.Name = "richTextBox_lastName";
            this.richTextBox_lastName.Size = new System.Drawing.Size(121, 21);
            this.richTextBox_lastName.TabIndex = 11;
            this.richTextBox_lastName.Text = "Some last name";
            // 
            // label_customerType
            // 
            this.label_customerType.AutoSize = true;
            this.label_customerType.Location = new System.Drawing.Point(12, 191);
            this.label_customerType.Name = "label_customerType";
            this.label_customerType.Size = new System.Drawing.Size(78, 13);
            this.label_customerType.TabIndex = 12;
            this.label_customerType.Text = "Customer Type";
            // 
            // label_phoneNumber
            // 
            this.label_phoneNumber.AutoSize = true;
            this.label_phoneNumber.Location = new System.Drawing.Point(12, 230);
            this.label_phoneNumber.Name = "label_phoneNumber";
            this.label_phoneNumber.Size = new System.Drawing.Size(78, 13);
            this.label_phoneNumber.TabIndex = 13;
            this.label_phoneNumber.Text = "Phone Number";
            // 
            // comboBox_customerType
            // 
            this.comboBox_customerType.FormattingEnabled = true;
            this.comboBox_customerType.Location = new System.Drawing.Point(104, 188);
            this.comboBox_customerType.Name = "comboBox_customerType";
            this.comboBox_customerType.Size = new System.Drawing.Size(121, 21);
            this.comboBox_customerType.TabIndex = 14;
            // 
            // richTextBox_phoneNumber
            // 
            this.richTextBox_phoneNumber.Location = new System.Drawing.Point(104, 230);
            this.richTextBox_phoneNumber.Name = "richTextBox_phoneNumber";
            this.richTextBox_phoneNumber.Size = new System.Drawing.Size(121, 22);
            this.richTextBox_phoneNumber.TabIndex = 15;
            this.richTextBox_phoneNumber.Text = "";
            // 
            // EditCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 345);
            this.Controls.Add(this.richTextBox_phoneNumber);
            this.Controls.Add(this.comboBox_customerType);
            this.Controls.Add(this.label_phoneNumber);
            this.Controls.Add(this.label_customerType);
            this.Controls.Add(this.richTextBox_lastName);
            this.Controls.Add(this.richTextBox_firstName);
            this.Controls.Add(this.richTextBox_address);
            this.Controls.Add(this.label_address);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.label_lastNameHeader);
            this.Controls.Add(this.label_firstNameHeader);
            this.Controls.Add(this.label_customerInfo);
            this.Name = "EditCustomerForm";
            this.Text = "CustomerForm";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_customerInfo;
        private System.Windows.Forms.Label label_firstNameHeader;
        private System.Windows.Forms.Label label_lastNameHeader;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Label label_address;
        private System.Windows.Forms.RichTextBox richTextBox_address;
        private System.Windows.Forms.RichTextBox richTextBox_firstName;
        private System.Windows.Forms.RichTextBox richTextBox_lastName;
        private System.Windows.Forms.Label label_customerType;
        private System.Windows.Forms.Label label_phoneNumber;
        private System.Windows.Forms.ComboBox comboBox_customerType;
        private System.Windows.Forms.RichTextBox richTextBox_phoneNumber;
    }
}