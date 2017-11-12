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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditCustomerForm));
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
            this.label_creditLimit = new System.Windows.Forms.Label();
            this.richTextBox_creditLimit = new System.Windows.Forms.RichTextBox();
            this.icon_customer = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.icon_customer)).BeginInit();
            this.SuspendLayout();
            // 
            // label_customerInfo
            // 
            this.label_customerInfo.AutoSize = true;
            this.label_customerInfo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_customerInfo.ForeColor = System.Drawing.Color.White;
            this.label_customerInfo.Location = new System.Drawing.Point(128, 30);
            this.label_customerInfo.Name = "label_customerInfo";
            this.label_customerInfo.Size = new System.Drawing.Size(174, 19);
            this.label_customerInfo.TabIndex = 0;
            this.label_customerInfo.Text = "Customer Information";
            // 
            // label_firstNameHeader
            // 
            this.label_firstNameHeader.AutoSize = true;
            this.label_firstNameHeader.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_firstNameHeader.ForeColor = System.Drawing.Color.White;
            this.label_firstNameHeader.Location = new System.Drawing.Point(34, 89);
            this.label_firstNameHeader.Name = "label_firstNameHeader";
            this.label_firstNameHeader.Size = new System.Drawing.Size(76, 16);
            this.label_firstNameHeader.TabIndex = 1;
            this.label_firstNameHeader.Text = "First Name";
            // 
            // label_lastNameHeader
            // 
            this.label_lastNameHeader.AutoSize = true;
            this.label_lastNameHeader.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_lastNameHeader.ForeColor = System.Drawing.Color.White;
            this.label_lastNameHeader.Location = new System.Drawing.Point(34, 126);
            this.label_lastNameHeader.Name = "label_lastNameHeader";
            this.label_lastNameHeader.Size = new System.Drawing.Size(76, 16);
            this.label_lastNameHeader.TabIndex = 3;
            this.label_lastNameHeader.Text = "Last Name";
            // 
            // button_save
            // 
            this.button_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(226)))), ((int)(((byte)(183)))));
            this.button_save.FlatAppearance.BorderSize = 0;
            this.button_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_save.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_save.Location = new System.Drawing.Point(132, 351);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(84, 35);
            this.button_save.TabIndex = 7;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = false;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // label_address
            // 
            this.label_address.AutoSize = true;
            this.label_address.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_address.ForeColor = System.Drawing.Color.White;
            this.label_address.Location = new System.Drawing.Point(34, 165);
            this.label_address.Name = "label_address";
            this.label_address.Size = new System.Drawing.Size(61, 16);
            this.label_address.TabIndex = 8;
            this.label_address.Text = "Address";
            // 
            // richTextBox_address
            // 
            this.richTextBox_address.Location = new System.Drawing.Point(157, 164);
            this.richTextBox_address.Name = "richTextBox_address";
            this.richTextBox_address.Size = new System.Drawing.Size(163, 33);
            this.richTextBox_address.TabIndex = 9;
            this.richTextBox_address.Text = "Some address";
            // 
            // richTextBox_firstName
            // 
            this.richTextBox_firstName.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox_firstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox_firstName.Location = new System.Drawing.Point(157, 82);
            this.richTextBox_firstName.MaxLength = 30;
            this.richTextBox_firstName.Name = "richTextBox_firstName";
            this.richTextBox_firstName.Size = new System.Drawing.Size(163, 23);
            this.richTextBox_firstName.TabIndex = 10;
            this.richTextBox_firstName.Text = "";
            // 
            // richTextBox_lastName
            // 
            this.richTextBox_lastName.Location = new System.Drawing.Point(157, 121);
            this.richTextBox_lastName.Name = "richTextBox_lastName";
            this.richTextBox_lastName.Size = new System.Drawing.Size(163, 21);
            this.richTextBox_lastName.TabIndex = 11;
            this.richTextBox_lastName.Text = "Some last name";
            // 
            // label_customerType
            // 
            this.label_customerType.AutoSize = true;
            this.label_customerType.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_customerType.ForeColor = System.Drawing.Color.White;
            this.label_customerType.Location = new System.Drawing.Point(34, 212);
            this.label_customerType.Name = "label_customerType";
            this.label_customerType.Size = new System.Drawing.Size(104, 16);
            this.label_customerType.TabIndex = 12;
            this.label_customerType.Text = "Customer Type";
            // 
            // label_phoneNumber
            // 
            this.label_phoneNumber.AutoSize = true;
            this.label_phoneNumber.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_phoneNumber.ForeColor = System.Drawing.Color.White;
            this.label_phoneNumber.Location = new System.Drawing.Point(34, 262);
            this.label_phoneNumber.Name = "label_phoneNumber";
            this.label_phoneNumber.Size = new System.Drawing.Size(103, 16);
            this.label_phoneNumber.TabIndex = 13;
            this.label_phoneNumber.Text = "Phone Number";
            // 
            // comboBox_customerType
            // 
            this.comboBox_customerType.FormattingEnabled = true;
            this.comboBox_customerType.Location = new System.Drawing.Point(157, 211);
            this.comboBox_customerType.Name = "comboBox_customerType";
            this.comboBox_customerType.Size = new System.Drawing.Size(163, 21);
            this.comboBox_customerType.TabIndex = 14;
            this.comboBox_customerType.SelectedIndexChanged += new System.EventHandler(this.comboBox_customerType_SelectedIndexChanged);
            // 
            // richTextBox_phoneNumber
            // 
            this.richTextBox_phoneNumber.Location = new System.Drawing.Point(157, 253);
            this.richTextBox_phoneNumber.Name = "richTextBox_phoneNumber";
            this.richTextBox_phoneNumber.Size = new System.Drawing.Size(163, 22);
            this.richTextBox_phoneNumber.TabIndex = 15;
            this.richTextBox_phoneNumber.Text = "";
            // 
            // label_creditLimit
            // 
            this.label_creditLimit.AutoSize = true;
            this.label_creditLimit.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_creditLimit.ForeColor = System.Drawing.Color.White;
            this.label_creditLimit.Location = new System.Drawing.Point(34, 301);
            this.label_creditLimit.Name = "label_creditLimit";
            this.label_creditLimit.Size = new System.Drawing.Size(82, 16);
            this.label_creditLimit.TabIndex = 16;
            this.label_creditLimit.Text = "Credit Limit";
            // 
            // richTextBox_creditLimit
            // 
            this.richTextBox_creditLimit.Location = new System.Drawing.Point(157, 301);
            this.richTextBox_creditLimit.Name = "richTextBox_creditLimit";
            this.richTextBox_creditLimit.Size = new System.Drawing.Size(163, 18);
            this.richTextBox_creditLimit.TabIndex = 17;
            this.richTextBox_creditLimit.Text = "";
            // 
            // icon_customer
            // 
            this.icon_customer.BackColor = System.Drawing.Color.Transparent;
            this.icon_customer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("icon_customer.BackgroundImage")));
            this.icon_customer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.icon_customer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icon_customer.Location = new System.Drawing.Point(43, 6);
            this.icon_customer.Name = "icon_customer";
            this.icon_customer.Size = new System.Drawing.Size(55, 67);
            this.icon_customer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.icon_customer.TabIndex = 18;
            this.icon_customer.TabStop = false;
            // 
            // EditCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(35)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(379, 407);
            this.Controls.Add(this.icon_customer);
            this.Controls.Add(this.richTextBox_creditLimit);
            this.Controls.Add(this.label_creditLimit);
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
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.Name = "EditCustomerForm";
            this.Text = "CustomerForm";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.icon_customer)).EndInit();
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
        private System.Windows.Forms.Label label_creditLimit;
        private System.Windows.Forms.RichTextBox richTextBox_creditLimit;
        private System.Windows.Forms.PictureBox icon_customer;
    }
}