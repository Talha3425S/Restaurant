namespace RestaurantSystem
{
    partial class adminForm
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
            this.Ad_Item = new System.Windows.Forms.Button();
            this.Re_Item = new System.Windows.Forms.Button();
            this.Upd_Item = new System.Windows.Forms.Button();
            this.itemName = new System.Windows.Forms.TextBox();
            this.itemPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DisplayItems = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayItems)).BeginInit();
            this.SuspendLayout();
            // 
            // Ad_Item
            // 
            this.Ad_Item.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ad_Item.Location = new System.Drawing.Point(167, 158);
            this.Ad_Item.Name = "Ad_Item";
            this.Ad_Item.Size = new System.Drawing.Size(100, 46);
            this.Ad_Item.TabIndex = 0;
            this.Ad_Item.Text = "Add Item";
            this.Ad_Item.UseVisualStyleBackColor = true;
            this.Ad_Item.Click += new System.EventHandler(this.Ad_Item_Click);
            // 
            // Re_Item
            // 
            this.Re_Item.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Re_Item.Location = new System.Drawing.Point(273, 158);
            this.Re_Item.Name = "Re_Item";
            this.Re_Item.Size = new System.Drawing.Size(100, 46);
            this.Re_Item.TabIndex = 1;
            this.Re_Item.Text = "Remove Item";
            this.Re_Item.UseVisualStyleBackColor = true;
            this.Re_Item.Click += new System.EventHandler(this.Re_Item_Click);
            // 
            // Upd_Item
            // 
            this.Upd_Item.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Upd_Item.Location = new System.Drawing.Point(379, 158);
            this.Upd_Item.Name = "Upd_Item";
            this.Upd_Item.Size = new System.Drawing.Size(100, 46);
            this.Upd_Item.TabIndex = 2;
            this.Upd_Item.Text = "Update Item";
            this.Upd_Item.UseVisualStyleBackColor = true;
            this.Upd_Item.Click += new System.EventHandler(this.Upd_Item_Click);
            // 
            // itemName
            // 
            this.itemName.Location = new System.Drawing.Point(69, 40);
            this.itemName.Name = "itemName";
            this.itemName.Size = new System.Drawing.Size(92, 20);
            this.itemName.TabIndex = 3;
            // 
            // itemPrice
            // 
            this.itemPrice.Location = new System.Drawing.Point(69, 79);
            this.itemPrice.Name = "itemPrice";
            this.itemPrice.Size = new System.Drawing.Size(59, 20);
            this.itemPrice.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Price";
            // 
            // DisplayItems
            // 
            this.DisplayItems.BackgroundColor = System.Drawing.Color.MintCream;
            this.DisplayItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DisplayItems.Location = new System.Drawing.Point(167, 40);
            this.DisplayItems.Name = "DisplayItems";
            this.DisplayItems.Size = new System.Drawing.Size(312, 112);
            this.DisplayItems.TabIndex = 7;
            this.DisplayItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DisplayItems_CellContentClick);
            // 
            // adminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(557, 261);
            this.Controls.Add(this.DisplayItems);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.itemPrice);
            this.Controls.Add(this.itemName);
            this.Controls.Add(this.Upd_Item);
            this.Controls.Add(this.Re_Item);
            this.Controls.Add(this.Ad_Item);
            this.Name = "adminForm";
            this.Text = "adminForm";
            this.Load += new System.EventHandler(this.adminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DisplayItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Ad_Item;
        private System.Windows.Forms.Button Re_Item;
        private System.Windows.Forms.Button Upd_Item;
        private System.Windows.Forms.TextBox itemName;
        private System.Windows.Forms.TextBox itemPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DisplayItems;
    }
}