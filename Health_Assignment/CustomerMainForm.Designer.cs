namespace Health_Assignment
{
    partial class CustomerMainForm
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
            this.customerUserControlForm1 = new Health_Assignment.CustomerUserControlForm();
            this.SuspendLayout();
            // 
            // customerUserControlForm1
            // 
            this.customerUserControlForm1.Location = new System.Drawing.Point(27, 26);
            this.customerUserControlForm1.Name = "customerUserControlForm1";
            this.customerUserControlForm1.Size = new System.Drawing.Size(891, 490);
            this.customerUserControlForm1.TabIndex = 0;
            this.customerUserControlForm1.Load += new System.EventHandler(this.customerUserControlForm1_Load);
            // 
            // CustomerMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 528);
            this.Controls.Add(this.customerUserControlForm1);
            this.Name = "CustomerMainForm";
            this.Text = "CustomerMainForm";
            this.Load += new System.EventHandler(this.CustomerMainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public CustomerUserControlForm customerUserControlForm1;
    }
}