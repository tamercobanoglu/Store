namespace prj_v._1._0.UI
{
    partial class FormUpdatePro
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
            this.tbStock = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.btUpdProduct = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbStock
            // 
            this.tbStock.AcceptsReturn = true;
            this.tbStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbStock.Location = new System.Drawing.Point(175, 84);
            this.tbStock.Name = "tbStock";
            this.tbStock.Size = new System.Drawing.Size(186, 24);
            this.tbStock.TabIndex = 3;
            this.tbStock.TextChanged += new System.EventHandler(this.TbStock_TextChanged);
            // 
            // tbPrice
            // 
            this.tbPrice.AcceptsReturn = true;
            this.tbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbPrice.Location = new System.Drawing.Point(175, 41);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(186, 24);
            this.tbPrice.TabIndex = 2;
            this.tbPrice.TextChanged += new System.EventHandler(this.TbPrice_TextChanged);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPrice.Location = new System.Drawing.Point(45, 47);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(94, 18);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Güncel Fiyat:";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStock.Location = new System.Drawing.Point(47, 90);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(92, 18);
            this.lblStock.TabIndex = 5;
            this.lblStock.Text = "Güncel Adet:";
            // 
            // btUpdProduct
            // 
            this.btUpdProduct.Enabled = false;
            this.btUpdProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUpdProduct.Location = new System.Drawing.Point(213, 138);
            this.btUpdProduct.Margin = new System.Windows.Forms.Padding(4);
            this.btUpdProduct.Name = "btUpdProduct";
            this.btUpdProduct.Size = new System.Drawing.Size(148, 31);
            this.btUpdProduct.TabIndex = 6;
            this.btUpdProduct.Text = "Ürünü Güncelle";
            this.btUpdProduct.UseVisualStyleBackColor = true;
            this.btUpdProduct.Click += new System.EventHandler(this.BtUpdProduct_Click);
            // 
            // FormUpdatePro
            // 
            this.AcceptButton = this.btUpdProduct;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 195);
            this.Controls.Add(this.btUpdProduct);
            this.Controls.Add(this.tbStock);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblStock);
            this.Name = "FormUpdatePro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "STORE V.1.0 Special Edition   |   Ürünü Güncelle";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormUpdatePro_FormClosing);
            this.Load += new System.EventHandler(this.FormUpdatePro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbStock;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Button btUpdProduct;
    }
}