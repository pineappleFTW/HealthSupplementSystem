namespace Health_Assignment
{
    partial class PaymentReceiptForm
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
            this.label_order = new System.Windows.Forms.Label();
            this.label_salesID = new System.Windows.Forms.Label();
            this.label_dear = new System.Windows.Forms.Label();
            this.label_customerName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_paymentModeText = new System.Windows.Forms.Label();
            this.label_paymentMode = new System.Windows.Forms.Label();
            this.dataGridView_productPurchased = new System.Windows.Forms.DataGridView();
            this.label_totalAmountText = new System.Windows.Forms.Label();
            this.label_totalAmount = new System.Windows.Forms.Label();
            this.button_send = new System.Windows.Forms.Button();
            this.button_print = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_productPurchased)).BeginInit();
            this.SuspendLayout();
            // 
            // label_order
            // 
            this.label_order.AutoSize = true;
            this.label_order.Location = new System.Drawing.Point(189, 82);
            this.label_order.Name = "label_order";
            this.label_order.Size = new System.Drawing.Size(43, 13);
            this.label_order.TabIndex = 0;
            this.label_order.Text = "Order #";
            // 
            // label_salesID
            // 
            this.label_salesID.AutoSize = true;
            this.label_salesID.Location = new System.Drawing.Point(294, 82);
            this.label_salesID.Name = "label_salesID";
            this.label_salesID.Size = new System.Drawing.Size(43, 13);
            this.label_salesID.TabIndex = 1;
            this.label_salesID.Text = "some id";
            // 
            // label_dear
            // 
            this.label_dear.AutoSize = true;
            this.label_dear.Location = new System.Drawing.Point(189, 129);
            this.label_dear.Name = "label_dear";
            this.label_dear.Size = new System.Drawing.Size(30, 13);
            this.label_dear.TabIndex = 2;
            this.label_dear.Text = "Dear";
            // 
            // label_customerName
            // 
            this.label_customerName.AutoSize = true;
            this.label_customerName.Location = new System.Drawing.Point(294, 129);
            this.label_customerName.Name = "label_customerName";
            this.label_customerName.Size = new System.Drawing.Size(107, 13);
            this.label_customerName.TabIndex = 3;
            this.label_customerName.Text = "some customer name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(510, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Thank you for your payment! We hope to see you again and we will inform you when " +
    "the shipment is made.";
            // 
            // label_paymentModeText
            // 
            this.label_paymentModeText.AutoSize = true;
            this.label_paymentModeText.Location = new System.Drawing.Point(189, 105);
            this.label_paymentModeText.Name = "label_paymentModeText";
            this.label_paymentModeText.Size = new System.Drawing.Size(78, 13);
            this.label_paymentModeText.TabIndex = 5;
            this.label_paymentModeText.Text = "Payment Mode";
            // 
            // label_paymentMode
            // 
            this.label_paymentMode.AutoSize = true;
            this.label_paymentMode.Location = new System.Drawing.Point(297, 105);
            this.label_paymentMode.Name = "label_paymentMode";
            this.label_paymentMode.Size = new System.Drawing.Size(61, 13);
            this.label_paymentMode.TabIndex = 6;
            this.label_paymentMode.Text = "some mode";
            // 
            // dataGridView_productPurchased
            // 
            this.dataGridView_productPurchased.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_productPurchased.Location = new System.Drawing.Point(78, 203);
            this.dataGridView_productPurchased.Name = "dataGridView_productPurchased";
            this.dataGridView_productPurchased.Size = new System.Drawing.Size(507, 150);
            this.dataGridView_productPurchased.TabIndex = 7;
            // 
            // label_totalAmountText
            // 
            this.label_totalAmountText.AutoSize = true;
            this.label_totalAmountText.Location = new System.Drawing.Point(416, 369);
            this.label_totalAmountText.Name = "label_totalAmountText";
            this.label_totalAmountText.Size = new System.Drawing.Size(70, 13);
            this.label_totalAmountText.TabIndex = 8;
            this.label_totalAmountText.Text = "Total Amount";
            // 
            // label_totalAmount
            // 
            this.label_totalAmount.AutoSize = true;
            this.label_totalAmount.Location = new System.Drawing.Point(523, 369);
            this.label_totalAmount.Name = "label_totalAmount";
            this.label_totalAmount.Size = new System.Drawing.Size(62, 13);
            this.label_totalAmount.TabIndex = 9;
            this.label_totalAmount.Text = "RM amount";
            // 
            // button_send
            // 
            this.button_send.Location = new System.Drawing.Point(337, 440);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(75, 23);
            this.button_send.TabIndex = 10;
            this.button_send.Text = "Send";
            this.button_send.UseVisualStyleBackColor = true;
            // 
            // button_print
            // 
            this.button_print.Location = new System.Drawing.Point(166, 440);
            this.button_print.Name = "button_print";
            this.button_print.Size = new System.Drawing.Size(75, 23);
            this.button_print.TabIndex = 11;
            this.button_print.Text = "Print";
            this.button_print.UseVisualStyleBackColor = true;
            // 
            // PaymentReceiptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 536);
            this.Controls.Add(this.button_print);
            this.Controls.Add(this.button_send);
            this.Controls.Add(this.label_totalAmount);
            this.Controls.Add(this.label_totalAmountText);
            this.Controls.Add(this.dataGridView_productPurchased);
            this.Controls.Add(this.label_paymentMode);
            this.Controls.Add(this.label_paymentModeText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_customerName);
            this.Controls.Add(this.label_dear);
            this.Controls.Add(this.label_salesID);
            this.Controls.Add(this.label_order);
            this.Name = "PaymentReceiptForm";
            this.Text = "PaymentReceiptForm";
            this.Load += new System.EventHandler(this.PaymentReceiptForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_productPurchased)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_order;
        private System.Windows.Forms.Label label_salesID;
        private System.Windows.Forms.Label label_dear;
        private System.Windows.Forms.Label label_customerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_paymentModeText;
        private System.Windows.Forms.Label label_paymentMode;
        private System.Windows.Forms.DataGridView dataGridView_productPurchased;
        private System.Windows.Forms.Label label_totalAmountText;
        private System.Windows.Forms.Label label_totalAmount;
        private System.Windows.Forms.Button button_send;
        private System.Windows.Forms.Button button_print;
    }
}