namespace prj_v._1._0.UI
{
    partial class FormDisplayProducts
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
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.productID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subCateName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cateName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProducts
            // 
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productID,
            this.proName,
            this.subCateName,
            this.cateName,
            this.proPrice,
            this.quantity});
            this.dgvProducts.Location = new System.Drawing.Point(12, 12);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.Size = new System.Drawing.Size(980, 495);
            this.dgvProducts.TabIndex = 0;
            this.dgvProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProducts_CellClick);
            // 
            // productID
            // 
            this.productID.HeaderText = "Ürün No";
            this.productID.Name = "productID";
            this.productID.ReadOnly = true;
            this.productID.Width = 40;
            // 
            // proName
            // 
            this.proName.HeaderText = "Ürün Açıklaması";
            this.proName.Name = "proName";
            this.proName.ReadOnly = true;
            this.proName.Width = 400;
            // 
            // subCateName
            // 
            this.subCateName.HeaderText = "Alt Kategori";
            this.subCateName.Name = "subCateName";
            this.subCateName.ReadOnly = true;
            this.subCateName.Width = 185;
            // 
            // cateName
            // 
            this.cateName.HeaderText = "Kategori";
            this.cateName.Name = "cateName";
            this.cateName.ReadOnly = true;
            this.cateName.Width = 185;
            // 
            // proPrice
            // 
            this.proPrice.HeaderText = "Fiyat";
            this.proPrice.Name = "proPrice";
            this.proPrice.ReadOnly = true;
            this.proPrice.Width = 75;
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Stok";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            this.quantity.Width = 50;
            // 
            // FormDisplayProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 519);
            this.Controls.Add(this.dgvProducts);
            this.Name = "FormDisplayProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "STORE V.1.0 Special Edition   |   Ürün Tablosu";
            this.Load += new System.EventHandler(this.FormDisplayProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn productID;
        private System.Windows.Forms.DataGridViewTextBoxColumn proName;
        private System.Windows.Forms.DataGridViewTextBoxColumn subCateName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cateName;
        private System.Windows.Forms.DataGridViewTextBoxColumn proPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
    }
}