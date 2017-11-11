namespace Health_Assignment
{
    partial class UserAccountForm
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
            this.userAccountUserControl = new Health_Assignment.UserAccountUserControl();
            this.SuspendLayout();
            // 
            // userAccountUserControl
            // 
            this.userAccountUserControl.Location = new System.Drawing.Point(12, 12);
            this.userAccountUserControl.Name = "userAccountUserControl";
            this.userAccountUserControl.Size = new System.Drawing.Size(825, 417);
            this.userAccountUserControl.TabIndex = 0;
            this.userAccountUserControl.Load += new System.EventHandler(this.userAccountUserControl1_Load);
            // 
            // UserAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 441);
            this.Controls.Add(this.userAccountUserControl);
            this.Name = "UserAccountForm";
            this.Text = "UserAccountForm";
            this.ResumeLayout(false);

        }

        #endregion

        public UserAccountUserControl userAccountUserControl;
    }
}