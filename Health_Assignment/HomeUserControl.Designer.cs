namespace Health_Assignment
{
    partial class HomeUserControl
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
            this.label_Welcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_Welcome
            // 
            this.label_Welcome.AutoSize = true;
            this.label_Welcome.Cursor = System.Windows.Forms.Cursors.Default;
            this.label_Welcome.Font = new System.Drawing.Font("Raleway", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Welcome.ForeColor = System.Drawing.Color.White;
            this.label_Welcome.Location = new System.Drawing.Point(281, 183);
            this.label_Welcome.Name = "label_Welcome";
            this.label_Welcome.Size = new System.Drawing.Size(518, 112);
            this.label_Welcome.TabIndex = 0;
            this.label_Welcome.Text = "Welcome!";
            this.label_Welcome.Click += new System.EventHandler(this.label_Welcome_Click);
            // 
            // HomeUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(35)))), ((int)(((byte)(63)))));
            this.Controls.Add(this.label_Welcome);
            this.Name = "HomeUserControl";
            this.Size = new System.Drawing.Size(1100, 561);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Welcome;
    }
}
