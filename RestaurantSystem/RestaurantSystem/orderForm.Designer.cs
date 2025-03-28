namespace RestaurantSystem
{
    partial class orderForm
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
            this.R_Order = new System.Windows.Forms.Button();
            this.C_Order = new System.Windows.Forms.Button();
            this.U_Order = new System.Windows.Forms.Button();
            this.DisplaySelectedOrder = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DisplaySelectedOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // R_Order
            // 
            this.R_Order.Location = new System.Drawing.Point(268, 75);
            this.R_Order.Name = "R_Order";
            this.R_Order.Size = new System.Drawing.Size(92, 44);
            this.R_Order.TabIndex = 0;
            this.R_Order.Text = "Remove Order";
            this.R_Order.UseVisualStyleBackColor = true;
            this.R_Order.Click += new System.EventHandler(this.R_Order_Click);
            // 
            // C_Order
            // 
            this.C_Order.Location = new System.Drawing.Point(268, 125);
            this.C_Order.Name = "C_Order";
            this.C_Order.Size = new System.Drawing.Size(92, 44);
            this.C_Order.TabIndex = 1;
            this.C_Order.Text = "Confirm Order";
            this.C_Order.UseVisualStyleBackColor = true;
            this.C_Order.Click += new System.EventHandler(this.C_Order_Click);
            // 
            // U_Order
            // 
            this.U_Order.Location = new System.Drawing.Point(268, 175);
            this.U_Order.Name = "U_Order";
            this.U_Order.Size = new System.Drawing.Size(92, 50);
            this.U_Order.TabIndex = 2;
            this.U_Order.Text = "Update Order";
            this.U_Order.UseVisualStyleBackColor = true;
            this.U_Order.Click += new System.EventHandler(this.U_Order_Click);
            // 
            // DisplaySelectedOrder
            // 
            this.DisplaySelectedOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DisplaySelectedOrder.Location = new System.Drawing.Point(12, 75);
            this.DisplaySelectedOrder.Name = "DisplaySelectedOrder";
            this.DisplaySelectedOrder.Size = new System.Drawing.Size(240, 150);
            this.DisplaySelectedOrder.TabIndex = 4;
            this.DisplaySelectedOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DisplaySelectedOrder_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(265, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Total Amount";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // orderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(386, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DisplaySelectedOrder);
            this.Controls.Add(this.U_Order);
            this.Controls.Add(this.C_Order);
            this.Controls.Add(this.R_Order);
            this.Name = "orderForm";
            this.Text = "orderForm";
            this.Load += new System.EventHandler(this.orderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DisplaySelectedOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button R_Order;
        private System.Windows.Forms.Button C_Order;
        private System.Windows.Forms.Button U_Order;
        private System.Windows.Forms.DataGridView DisplaySelectedOrder;
        private System.Windows.Forms.Label label1;
    }
}