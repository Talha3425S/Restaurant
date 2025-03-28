namespace RestaurantSystem
{
    partial class customerForm
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
            this.Ad_to_order = new System.Windows.Forms.Button();
            this.Vie_order = new System.Windows.Forms.Button();
            this.Quantity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AvaiableItems = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.AvaiableItems)).BeginInit();
            this.SuspendLayout();
            // 
            // Ad_to_order
            // 
            this.Ad_to_order.Location = new System.Drawing.Point(286, 161);
            this.Ad_to_order.Name = "Ad_to_order";
            this.Ad_to_order.Size = new System.Drawing.Size(96, 34);
            this.Ad_to_order.TabIndex = 0;
            this.Ad_to_order.Text = "Add To Order";
            this.Ad_to_order.UseVisualStyleBackColor = true;
            this.Ad_to_order.Click += new System.EventHandler(this.Ad_to_order_Click);
            // 
            // Vie_order
            // 
            this.Vie_order.Location = new System.Drawing.Point(286, 65);
            this.Vie_order.Name = "Vie_order";
            this.Vie_order.Size = new System.Drawing.Size(96, 34);
            this.Vie_order.TabIndex = 1;
            this.Vie_order.Text = "View Order";
            this.Vie_order.UseVisualStyleBackColor = true;
            this.Vie_order.Click += new System.EventHandler(this.Vie_order_Click);
            // 
            // Quantity
            // 
            this.Quantity.Location = new System.Drawing.Point(91, 28);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(95, 20);
            this.Quantity.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Quantity:";
            // 
            // AvaiableItems
            // 
            this.AvaiableItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AvaiableItems.Location = new System.Drawing.Point(40, 65);
            this.AvaiableItems.Name = "AvaiableItems";
            this.AvaiableItems.Size = new System.Drawing.Size(240, 130);
            this.AvaiableItems.TabIndex = 5;
            this.AvaiableItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AvaiableItems_CellContentClick);
            // 
            // customerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(440, 261);
            this.Controls.Add(this.AvaiableItems);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.Vie_order);
            this.Controls.Add(this.Ad_to_order);
            this.Name = "customerForm";
            this.Text = "customerForm";
            this.Load += new System.EventHandler(this.customerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AvaiableItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Ad_to_order;
        private System.Windows.Forms.Button Vie_order;
        private System.Windows.Forms.TextBox Quantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView AvaiableItems;
    }
}