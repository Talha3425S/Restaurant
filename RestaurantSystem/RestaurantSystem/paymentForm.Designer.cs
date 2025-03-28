namespace RestaurantSystem
{
    partial class paymentForm
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
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelOrder = new System.Windows.Forms.Label();
            this.PaymentMethod = new System.Windows.Forms.ComboBox();
            this.M_payment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(69, 38);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(43, 13);
            this.labelTotal.TabIndex = 0;
            this.labelTotal.Text = "Amount";
            this.labelTotal.Click += new System.EventHandler(this.labelTotal_Click);
            // 
            // labelOrder
            // 
            this.labelOrder.AutoSize = true;
            this.labelOrder.Location = new System.Drawing.Point(12, 38);
            this.labelOrder.Name = "labelOrder";
            this.labelOrder.Size = new System.Drawing.Size(42, 13);
            this.labelOrder.TabIndex = 1;
            this.labelOrder.Text = "OrderId";
            this.labelOrder.Click += new System.EventHandler(this.labelOrder_Click);
            // 
            // PaymentMethod
            // 
            this.PaymentMethod.FormattingEnabled = true;
            this.PaymentMethod.Location = new System.Drawing.Point(62, 68);
            this.PaymentMethod.Name = "PaymentMethod";
            this.PaymentMethod.Size = new System.Drawing.Size(121, 21);
            this.PaymentMethod.TabIndex = 2;
            this.PaymentMethod.SelectedIndexChanged += new System.EventHandler(this.PaymentMethod_SelectedIndexChanged);
            // 
            // M_payment
            // 
            this.M_payment.Location = new System.Drawing.Point(72, 117);
            this.M_payment.Name = "M_payment";
            this.M_payment.Size = new System.Drawing.Size(75, 23);
            this.M_payment.TabIndex = 3;
            this.M_payment.Text = "Make Payment";
            this.M_payment.UseVisualStyleBackColor = true;
            this.M_payment.Click += new System.EventHandler(this.M_payment_Click);
            // 
            // paymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.M_payment);
            this.Controls.Add(this.PaymentMethod);
            this.Controls.Add(this.labelOrder);
            this.Controls.Add(this.labelTotal);
            this.Name = "paymentForm";
            this.Text = "paymentForm";
            this.Load += new System.EventHandler(this.paymentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelOrder;
        private System.Windows.Forms.ComboBox PaymentMethod;
        private System.Windows.Forms.Button M_payment;
    }
}