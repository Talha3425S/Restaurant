namespace RestaurantSystem
{
    partial class Form1
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
            this.M_Admin = new System.Windows.Forms.Button();
            this.C_Customer = new System.Windows.Forms.Button();
            this.O_Order = new System.Windows.Forms.Button();
            this.P_Payment = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // M_Admin
            // 
            this.M_Admin.BackColor = System.Drawing.Color.LightPink;
            this.M_Admin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.M_Admin.Location = new System.Drawing.Point(172, 37);
            this.M_Admin.Name = "M_Admin";
            this.M_Admin.Size = new System.Drawing.Size(75, 43);
            this.M_Admin.TabIndex = 0;
            this.M_Admin.Text = "Admin";
            this.M_Admin.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.M_Admin.UseVisualStyleBackColor = false;
            this.M_Admin.Click += new System.EventHandler(this.M_Admin_Click);
            // 
            // C_Customer
            // 
            this.C_Customer.BackColor = System.Drawing.Color.LightPink;
            this.C_Customer.Location = new System.Drawing.Point(172, 86);
            this.C_Customer.Name = "C_Customer";
            this.C_Customer.Size = new System.Drawing.Size(75, 41);
            this.C_Customer.TabIndex = 1;
            this.C_Customer.Text = "Customer";
            this.C_Customer.UseVisualStyleBackColor = false;
            this.C_Customer.Click += new System.EventHandler(this.C_Customer_Click);
            // 
            // O_Order
            // 
            this.O_Order.BackColor = System.Drawing.Color.LightPink;
            this.O_Order.Location = new System.Drawing.Point(172, 133);
            this.O_Order.Name = "O_Order";
            this.O_Order.Size = new System.Drawing.Size(75, 42);
            this.O_Order.TabIndex = 2;
            this.O_Order.Text = "Order";
            this.O_Order.UseVisualStyleBackColor = false;
            this.O_Order.Click += new System.EventHandler(this.O_Order_Click);
            // 
            // P_Payment
            // 
            this.P_Payment.BackColor = System.Drawing.Color.Pink;
            this.P_Payment.Location = new System.Drawing.Point(172, 181);
            this.P_Payment.Name = "P_Payment";
            this.P_Payment.Size = new System.Drawing.Size(75, 45);
            this.P_Payment.TabIndex = 3;
            this.P_Payment.Text = "Payment";
            this.P_Payment.UseVisualStyleBackColor = false;
            this.P_Payment.Click += new System.EventHandler(this.P_Payment_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Lavender;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.Location = new System.Drawing.Point(40, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Restaurant";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(269, 246);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.P_Payment);
            this.Controls.Add(this.O_Order);
            this.Controls.Add(this.C_Customer);
            this.Controls.Add(this.M_Admin);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button M_Admin;
        private System.Windows.Forms.Button C_Customer;
        private System.Windows.Forms.Button O_Order;
        private System.Windows.Forms.Button P_Payment;
        private System.Windows.Forms.Label label1;
    }
}

