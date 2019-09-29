namespace prj_v._1._0.UI
{
    partial class FormDisplaySold
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
            this.dgvSoldProducts = new System.Windows.Forms.DataGridView();
            this.productID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceEach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityOrdered = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoldProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSoldProducts
            // 
            this.dgvSoldProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSoldProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productID,
            this.proName,
            this.priceEach,
            this.quantityOrdered,
            this.orderID});
            this.dgvSoldProducts.Location = new System.Drawing.Point(12, 12);
            this.dgvSoldProducts.Name = "dgvSoldProducts";
            this.dgvSoldProducts.Size = new System.Drawing.Size(833, 472);
            this.dgvSoldProducts.TabIndex = 0;
            // 
            // productID
            // 
            this.productID.HeaderText = "Ürün No";
            this.productID.Name = "productID";
            this.productID.Width = 40;
            // 
            // proName
            // 
            this.proName.HeaderText = "Ürün Açıklaması";
            this.proName.Name = "proName";
            this.proName.Width = 390;
            // 
            // priceEach
            // 
            this.priceEach.HeaderText = "Fiyat";
            this.priceEach.Name = "priceEach";
            // 
            // quantityOrdered
            // 
            this.quantityOrdered.HeaderText = "Adet";
            this.quantityOrdered.Name = "quantityOrdered";
            this.quantityOrdered.Width = 40;
            // 
            // orderID
            // 
            this.orderID.HeaderText = "Müşteri";
            this.orderID.Name = "orderID";
            this.orderID.Width = 220;
            // 
            // FormDisplaySold
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 496);
            this.Controls.Add(this.dgvSoldProducts);
            this.Name = "FormDisplaySold";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "STORE V.1.0 Special Edition   |   Sattığım Ürünler";
            this.Load += new System.EventHandler(this.FormDisplaySold_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoldProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSoldProducts;
		private System.Windows.Forms.DataGridViewTextBoxColumn productID;
		private System.Windows.Forms.DataGridViewTextBoxColumn proName;
		private System.Windows.Forms.DataGridViewTextBoxColumn priceEach;
		private System.Windows.Forms.DataGridViewTextBoxColumn quantityOrdered;
		private System.Windows.Forms.DataGridViewTextBoxColumn orderID;
	}
}