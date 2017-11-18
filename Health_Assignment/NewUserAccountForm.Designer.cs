namespace Health_Assignment
{
    partial class NewUserAccountForm
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
            this.label_newUserAccount = new System.Windows.Forms.Label();
            this.label_userName = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.richTextBox_userName = new System.Windows.Forms.RichTextBox();
            this.richTextBox_password = new System.Windows.Forms.RichTextBox();
            this.button_save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_newUserAccount
            // 
            this.label_newUserAccount.AutoSize = true;
            this.label_newUserAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(35)))), ((int)(((byte)(63)))));
            this.label_newUserAccount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_newUserAccount.ForeColor = System.Drawing.Color.White;
            this.label_newUserAccount.Location = new System.Drawing.Point(116, 25);
            this.label_newUserAccount.Name = "label_newUserAccount";
            this.label_newUserAccount.Size = new System.Drawing.Size(149, 19);
            this.label_newUserAccount.TabIndex = 0;
            this.label_newUserAccount.Text = "New User Account";
            // 
            // label_userName
            // 
            this.label_userName.AutoSize = true;
            this.label_userName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_userName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_userName.ForeColor = System.Drawing.Color.White;
            this.label_userName.Location = new System.Drawing.Point(80, 79);
            this.label_userName.Name = "label_userName";
            this.label_userName.Size = new System.Drawing.Size(78, 16);
            this.label_userName.TabIndex = 1;
            this.label_userName.Text = "User Name";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_password.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_password.ForeColor = System.Drawing.Color.White;
            this.label_password.Location = new System.Drawing.Point(80, 134);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(68, 16);
            this.label_password.TabIndex = 2;
            this.label_password.Text = "Password";
            // 
            // richTextBox_userName
            // 
            this.richTextBox_userName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_userName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_userName.Location = new System.Drawing.Point(182, 79);
            this.richTextBox_userName.Name = "richTextBox_userName";
            this.richTextBox_userName.Size = new System.Drawing.Size(106, 28);
            this.richTextBox_userName.TabIndex = 3;
            this.richTextBox_userName.Text = "";
            // 
            // richTextBox_password
            // 
            this.richTextBox_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_password.Location = new System.Drawing.Point(182, 136);
            this.richTextBox_password.Name = "richTextBox_password";
            this.richTextBox_password.Size = new System.Drawing.Size(106, 25);
            this.richTextBox_password.TabIndex = 4;
            this.richTextBox_password.Text = "";
            // 
            // button_save
            // 
            this.button_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(226)))), ((int)(((byte)(183)))));
            this.button_save.FlatAppearance.BorderSize = 0;
            this.button_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_save.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.button_save.Location = new System.Drawing.Point(150, 202);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(75, 23);
            this.button_save.TabIndex = 5;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = false;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // NewUserAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(35)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(378, 276);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.richTextBox_password);
            this.Controls.Add(this.richTextBox_userName);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_userName);
            this.Controls.Add(this.label_newUserAccount);
            this.Name = "NewUserAccountForm";
            this.Text = "NewUserAccountForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_newUserAccount;
        private System.Windows.Forms.Label label_userName;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.RichTextBox richTextBox_userName;
        private System.Windows.Forms.RichTextBox richTextBox_password;
        private System.Windows.Forms.Button button_save;
    }
}