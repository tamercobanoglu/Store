namespace prj_v._1._0.UI
{
	partial class FormDisplayOrder
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
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.orderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvOrderDet = new System.Windows.Forms.DataGridView();
            this.orderDetailID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceEach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityOrdered = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOrder
            // 
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderID,
            this.orderDate,
            this.orderStatus,
            this.amount});
            this.dgvOrder.Location = new System.Drawing.Point(12, 45);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.ReadOnly = true;
            this.dgvOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvOrder.Size = new System.Drawing.Size(765, 256);
            this.dgvOrder.TabIndex = 0;
            this.dgvOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvOrder_CellClick);
            // 
            // orderID
            // 
            this.orderID.HeaderText = "Sipariş No";
            this.orderID.Name = "orderID";
            this.orderID.ReadOnly = true;
            this.orderID.Width = 50;
            // 
            // orderDate
            // 
            this.orderDate.HeaderText = "Sipariş Tarihi";
            this.orderDate.Name = "orderDate";
            this.orderDate.ReadOnly = true;
            this.orderDate.Width = 170;
            // 
            // orderStatus
            // 
            this.orderStatus.HeaderText = "Sipariş Durumu";
            this.orderStatus.Name = "orderStatus";
            this.orderStatus.ReadOnly = true;
            this.orderStatus.Width = 225;
            // 
            // amount
            // 
            this.amount.HeaderText = "Toplam Tutar";
            this.amount.Name = "amount";
            this.amount.ReadOnly = true;
            this.amount.Width = 275;
            // 
            // dgvOrderDet
            // 
            this.dgvOrderDet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderDet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderDetailID,
            this.productID,
            this.priceEach,
            this.quantityOrdered,
            this.employeeID});
            this.dgvOrderDet.Location = new System.Drawing.Point(12, 359);
            this.dgvOrderDet.Name = "dgvOrderDet";
            this.dgvOrderDet.ReadOnly = true;
            this.dgvOrderDet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvOrderDet.Size = new System.Drawing.Size(765, 256);
            this.dgvOrderDet.TabIndex = 0;
            // 
            // orderDetailID
            // 
            this.orderDetailID.HeaderText = "Ürün No";
            this.orderDetailID.Name = "orderDetailID";
            this.orderDetailID.ReadOnly = true;
            this.orderDetailID.Width = 50;
            // 
            // productID
            // 
            this.productID.HeaderText = "Ürün Açıklaması";
            this.productID.Name = "productID";
            this.productID.ReadOnly = true;
            this.productID.Width = 310;
            // 
            // priceEach
            // 
            this.priceEach.HeaderText = "Fiyat";
            this.priceEach.Name = "priceEach";
            this.priceEach.ReadOnly = true;
            // 
            // quantityOrdered
            // 
            this.quantityOrdered.HeaderText = "Adet";
            this.quantityOrdered.Name = "quantityOrdered";
            this.quantityOrdered.ReadOnly = true;
            this.quantityOrdered.Width = 60;
            // 
            // employeeID
            // 
            this.employeeID.HeaderText = "Satıcı";
            this.employeeID.Name = "employeeID";
            this.employeeID.ReadOnly = true;
            this.employeeID.Width = 200;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl1.Location = new System.Drawing.Point(12, 24);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(434, 18);
            this.lbl1.TabIndex = 16;
            this.lbl1.Text = "İçeriğini görmek istediğiniz siparişinizin bulunduğu satıra tıklayınız.";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl2.Location = new System.Drawing.Point(12, 338);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(102, 18);
            this.lbl2.TabIndex = 17;
            this.lbl2.Text = "Sipariş Detayı:";
            // 
            // FormDisplayOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 627);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.dgvOrderDet);
            this.Controls.Add(this.dgvOrder);
            this.Name = "FormDisplayOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "STORE V.1.0 Special Edition   |   Sipariş Tablosu";
            this.Load += new System.EventHandler(this.FormDisplayOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvOrder;
		private System.Windows.Forms.DataGridView dgvOrderDet;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDetailID;
        private System.Windows.Forms.DataGridViewTextBoxColumn productID;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceEach;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityOrdered;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
    }
}