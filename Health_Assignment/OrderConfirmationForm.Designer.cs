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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label_orderTitle = new System.Windows.Forms.Label();
            this.label_salesID = new System.Windows.Forms.Label();
            this.label_dear = new System.Windows.Forms.Label();
            this.label_customerName = new System.Windows.Forms.Label();
            this.label_thankYouMessage = new System.Windows.Forms.Label();
            this.dataGridView_productPurchased = new System.Windows.Forms.DataGridView();
            this.label_totalAmounTitle = new System.Windows.Forms.Label();
            this.label_totalAmount = new System.Windows.Forms.Label();
            this.button_print = new System.Windows.Forms.Button();
            this.button_send = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_productPurchased)).BeginInit();
            this.SuspendLayout();
            // 
            // label_orderTitle
            // 
            this.label_orderTitle.AutoSize = true;
            this.label_orderTitle.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_orderTitle.ForeColor = System.Drawing.Color.White;
            this.label_orderTitle.Location = new System.Drawing.Point(74, 28);
            this.label_orderTitle.Name = "label_orderTitle";
            this.label_orderTitle.Size = new System.Drawing.Size(120, 36);
            this.label_orderTitle.TabIndex = 0;
            this.label_orderTitle.Text = "Order #";
            // 
            // label_salesID
            // 
            this.label_salesID.AutoSize = true;
            this.label_salesID.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_salesID.ForeColor = System.Drawing.Color.White;
            this.label_salesID.Location = new System.Drawing.Point(200, 28);
            this.label_salesID.Name = "label_salesID";
            this.label_salesID.Size = new System.Drawing.Size(131, 36);
            this.label_salesID.TabIndex = 1;
            this.label_salesID.Text = "SOME ID";
            // 
            // label_dear
            // 
            this.label_dear.AutoSize = true;
            this.label_dear.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_dear.ForeColor = System.Drawing.Color.White;
            this.label_dear.Location = new System.Drawing.Point(75, 87);
            this.label_dear.Name = "label_dear";
            this.label_dear.Size = new System.Drawing.Size(61, 25);
            this.label_dear.TabIndex = 2;
            this.label_dear.Text = "Dear";
            // 
            // label_customerName
            // 
            this.label_customerName.AutoSize = true;
            this.label_customerName.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_customerName.ForeColor = System.Drawing.Color.White;
            this.label_customerName.Location = new System.Drawing.Point(133, 87);
            this.label_customerName.Name = "label_customerName";
            this.label_customerName.Size = new System.Drawing.Size(178, 25);
            this.label_customerName.TabIndex = 3;
            this.label_customerName.Text = "Customer Name";
            // 
            // label_thankYouMessage
            // 
            this.label_thankYouMessage.AutoSize = true;
            this.label_thankYouMessage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_thankYouMessage.ForeColor = System.Drawing.Color.White;
            this.label_thankYouMessage.Location = new System.Drawing.Point(76, 121);
            this.label_thankYouMessage.Name = "label_thankYouMessage";
            this.label_thankYouMessage.Size = new System.Drawing.Size(566, 21);
            this.label_thankYouMessage.TabIndex = 5;
            this.label_thankYouMessage.Text = "Thanks for purchasing! We hope to see you again. Below is your order summary:";
            // 
            // dataGridView_productPurchased
            // 
            this.dataGridView_productPurchased.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_productPurchased.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView_productPurchased.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Raleway", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(35)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_productPurchased.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_productPurchased.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(35)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_productPurchased.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_productPurchased.Location = new System.Drawing.Point(80, 161);
            this.dataGridView_productPurchased.Name = "dataGridView_productPurchased";
            this.dataGridView_productPurchased.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView_productPurchased.Size = new System.Drawing.Size(850, 220);
            this.dataGridView_productPurchased.TabIndex = 6;
            // 
            // label_totalAmounTitle
            // 
            this.label_totalAmounTitle.AutoSize = true;
            this.label_totalAmounTitle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_totalAmounTitle.ForeColor = System.Drawing.Color.White;
            this.label_totalAmounTitle.Location = new System.Drawing.Point(744, 384);
            this.label_totalAmounTitle.Name = "label_totalAmounTitle";
            this.label_totalAmounTitle.Size = new System.Drawing.Size(111, 19);
            this.label_totalAmounTitle.TabIndex = 7;
            this.label_totalAmounTitle.Text = "Total Amount";
            // 
            // label_totalAmount
            // 
            this.label_totalAmount.AutoSize = true;
            this.label_totalAmount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_totalAmount.ForeColor = System.Drawing.Color.White;
            this.label_totalAmount.Location = new System.Drawing.Point(872, 384);
            this.label_totalAmount.Name = "label_totalAmount";
            this.label_totalAmount.Size = new System.Drawing.Size(58, 19);
            this.label_totalAmount.TabIndex = 8;
            this.label_totalAmount.Text = "200.00";
            // 
            // button_print
            // 
            this.button_print.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(226)))), ((int)(((byte)(183)))));
            this.button_print.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_print.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.button_print.Location = new System.Drawing.Point(363, 503);
            this.button_print.Name = "button_print";
            this.button_print.Size = new System.Drawing.Size(79, 26);
            this.button_print.TabIndex = 9;
            this.button_print.Text = "Print";
            this.button_print.UseVisualStyleBackColor = false;
            // 
            // button_send
            // 
            this.button_send.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(226)))), ((int)(((byte)(183)))));
            this.button_send.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_send.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.button_send.Location = new System.Drawing.Point(587, 503);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(79, 26);
            this.button_send.TabIndex = 10;
            this.button_send.Text = "Send";
            this.button_send.UseVisualStyleBackColor = false;
            // 
            // OrderConfirmationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(35)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(988, 578);
            this.Controls.Add(this.button_send);
            this.Controls.Add(this.button_print);
            this.Controls.Add(this.label_totalAmount);
            this.Controls.Add(this.label_totalAmounTitle);
            this.Controls.Add(this.dataGridView_productPurchased);
            this.Controls.Add(this.label_thankYouMessage);
            this.Controls.Add(this.label_customerName);
            this.Controls.Add(this.label_dear);
            this.Controls.Add(this.label_salesID);
            this.Controls.Add(this.label_orderTitle);
            this.Name = "OrderConfirmationForm";
            this.Text = "OrderConfirmationForm";
            this.Load += new System.EventHandler(this.OrderConfirmationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_productPurchased)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_orderTitle;
        private System.Windows.Forms.Label label_salesID;
        private System.Windows.Forms.Label label_dear;
        private System.Windows.Forms.Label label_customerName;
        private System.Windows.Forms.Label label_thankYouMessage;
        private System.Windows.Forms.DataGridView dataGridView_productPurchased;
        private System.Windows.Forms.Label label_totalAmounTitle;
        private System.Windows.Forms.Label label_totalAmount;
        private System.Windows.Forms.Button button_print;
        private System.Windows.Forms.Button button_send;
    }
}