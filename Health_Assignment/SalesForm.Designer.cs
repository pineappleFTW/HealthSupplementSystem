namespace Health_Assignment
{
    partial class SalesForm
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
            this.salesFormUserControl1 = new Health_Assignment.SalesFormUserControl();
            this.SuspendLayout();
            // 
            // salesFormUserControl1
            // 
            this.salesFormUserControl1.Location = new System.Drawing.Point(0, 0);
            this.salesFormUserControl1.Name = "salesFormUserControl1";
            this.salesFormUserControl1.Size = new System.Drawing.Size(1030, 500);
            this.salesFormUserControl1.TabIndex = 0;
            // 
            // SalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 496);
            this.Controls.Add(this.salesFormUserControl1);
            this.Name = "SalesForm";
            this.Text = "SalesForm";
            this.ResumeLayout(false);

        }

        #endregion

        private SalesFormUserControl salesFormUserControl1;
    }
}