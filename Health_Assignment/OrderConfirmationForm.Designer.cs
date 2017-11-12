namespace Health_Assignment
{
    partial class OrderConfirmationForm
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
            this.label_orderTitle = new System.Windows.Forms.Label();
            this.label_salesID = new System.Windows.Forms.Label();
            this.label_dear = new System.Windows.Forms.Label();
            this.label_customerName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_thankYouMessage = new System.Windows.Forms.Label();
            this.dataGridView_productPurchased = new System.Windows.Forms.DataGridView();
            this.label_totalAmounTitle = new System.Windows.Forms.Label();
            this.label_totalAmount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_productPurchased)).BeginInit();
            this.SuspendLayout();
            // 
            // label_orderTitle
            // 
            this.label_orderTitle.AutoSize = true;
            this.label_orderTitle.Location = new System.Drawing.Point(222, 58);
            this.label_orderTitle.Name = "label_orderTitle";
            this.label_orderTitle.Size = new System.Drawing.Size(43, 13);
            this.label_orderTitle.TabIndex = 0;
            this.label_orderTitle.Text = "Order #";
            // 
            // label_salesID
            // 
            this.label_salesID.AutoSize = true;
            this.label_salesID.Location = new System.Drawing.Point(288, 58);
            this.label_salesID.Name = "label_salesID";
            this.label_salesID.Size = new System.Drawing.Size(52, 13);
            this.label_salesID.TabIndex = 1;
            this.label_salesID.Text = "SOME ID";
            // 
            // label_dear
            // 
            this.label_dear.AutoSize = true;
            this.label_dear.Location = new System.Drawing.Point(222, 99);
            this.label_dear.Name = "label_dear";
            this.label_dear.Size = new System.Drawing.Size(30, 13);
            this.label_dear.TabIndex = 2;
            this.label_dear.Text = "Dear";
            // 
            // label_customerName
            // 
            this.label_customerName.AutoSize = true;
            this.label_customerName.Location = new System.Drawing.Point(258, 99);
            this.label_customerName.Name = "label_customerName";
            this.label_customerName.Size = new System.Drawing.Size(82, 13);
            this.label_customerName.TabIndex = 3;
            this.label_customerName.Text = "Customer Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(346, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = ",";
            // 
            // label_thankYouMessage
            // 
            this.label_thankYouMessage.AutoSize = true;
            this.label_thankYouMessage.Location = new System.Drawing.Point(190, 154);
            this.label_thankYouMessage.Name = "label_thankYouMessage";
            this.label_thankYouMessage.Size = new System.Drawing.Size(386, 13);
            this.label_thankYouMessage.TabIndex = 5;
            this.label_thankYouMessage.Text = "Thanks for purchasing! We hope to see you again. Below is your order summary:";
            // 
            // dataGridView_productPurchased
            // 
            this.dataGridView_productPurchased.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_productPurchased.Location = new System.Drawing.Point(193, 222);
            this.dataGridView_productPurchased.Name = "dataGridView_productPurchased";
            this.dataGridView_productPurchased.Size = new System.Drawing.Size(383, 150);
            this.dataGridView_productPurchased.TabIndex = 6;
            // 
            // label_totalAmounTitle
            // 
            this.label_totalAmounTitle.AutoSize = true;
            this.label_totalAmounTitle.Location = new System.Drawing.Point(383, 390);
            this.label_totalAmounTitle.Name = "label_totalAmounTitle";
            this.label_totalAmounTitle.Size = new System.Drawing.Size(70, 13);
            this.label_totalAmounTitle.TabIndex = 7;
            this.label_totalAmounTitle.Text = "Total Amount";
            // 
            // label_totalAmount
            // 
            this.label_totalAmount.AutoSize = true;
            this.label_totalAmount.Location = new System.Drawing.Point(500, 390);
            this.label_totalAmount.Name = "label_totalAmount";
            this.label_totalAmount.Size = new System.Drawing.Size(70, 13);
            this.label_totalAmount.TabIndex = 8;
            this.label_totalAmount.Text = "some amount";
            // 
            // OrderConfirmationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 572);
            this.Controls.Add(this.label_totalAmount);
            this.Controls.Add(this.label_totalAmounTitle);
            this.Controls.Add(this.dataGridView_productPurchased);
            this.Controls.Add(this.label_thankYouMessage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_customerName);
            this.Controls.Add(this.label_dear);
            this.Controls.Add(this.label_salesID);
            this.Controls.Add(this.label_orderTitle);
            this.Name = "OrderConfirmationForm";
            this.Text = "OrderConfirmationForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_productPurchased)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_orderTitle;
        private System.Windows.Forms.Label label_salesID;
        private System.Windows.Forms.Label label_dear;
        private System.Windows.Forms.Label label_customerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_thankYouMessage;
        private System.Windows.Forms.DataGridView dataGridView_productPurchased;
        private System.Windows.Forms.Label label_totalAmounTitle;
        private System.Windows.Forms.Label label_totalAmount;
    }
}