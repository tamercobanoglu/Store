namespace prj_v._1._0.UI
{
    partial class FormEmployee
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
            this.btUpdateInfoE = new System.Windows.Forms.Button();
            this.gbEmployee = new System.Windows.Forms.GroupBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTitle1 = new System.Windows.Forms.Label();
            this.lblOffice = new System.Windows.Forms.Label();
            this.lblOffice1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.pbEmployee = new System.Windows.Forms.PictureBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblName1 = new System.Windows.Forms.Label();
            this.lblSname = new System.Windows.Forms.Label();
            this.lblMail1 = new System.Windows.Forms.Label();
            this.lblSname1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItem_Security = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_UpdateE = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Display = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_ListProducts = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_SoldProducts = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_CustomerInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.gbUpdProduct = new System.Windows.Forms.GroupBox();
            this.btUpdProduct = new System.Windows.Forms.Button();
            this.gbDelProduct = new System.Windows.Forms.GroupBox();
            this.btDelProduct = new System.Windows.Forms.Button();
            this.gbDelCustomer = new System.Windows.Forms.GroupBox();
            this.btDelCustomer = new System.Windows.Forms.Button();
            this.gbEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmployee)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.gbUpdProduct.SuspendLayout();
            this.gbDelProduct.SuspendLayout();
            this.gbDelCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // btUpdateInfoE
            // 
            this.btUpdateInfoE.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUpdateInfoE.Location = new System.Drawing.Point(619, 149);
            this.btUpdateInfoE.Name = "btUpdateInfoE";
            this.btUpdateInfoE.Size = new System.Drawing.Size(169, 31);
            this.btUpdateInfoE.TabIndex = 0;
            this.btUpdateInfoE.Text = "Bilgilerimi Güncelle";
            this.btUpdateInfoE.UseVisualStyleBackColor = true;
            this.btUpdateInfoE.Click += new System.EventHandler(this.BtUpdateInfoE_Click);
            // 
            // gbEmployee
            // 
            this.gbEmployee.Controls.Add(this.lblTitle);
            this.gbEmployee.Controls.Add(this.lblTitle1);
            this.gbEmployee.Controls.Add(this.lblOffice);
            this.gbEmployee.Controls.Add(this.lblOffice1);
            this.gbEmployee.Controls.Add(this.lblName);
            this.gbEmployee.Controls.Add(this.pbEmployee);
            this.gbEmployee.Controls.Add(this.lblMail);
            this.gbEmployee.Controls.Add(this.lblName1);
            this.gbEmployee.Controls.Add(this.lblSname);
            this.gbEmployee.Controls.Add(this.lblMail1);
            this.gbEmployee.Controls.Add(this.lblSname1);
            this.gbEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEmployee.Location = new System.Drawing.Point(12, 39);
            this.gbEmployee.Name = "gbEmployee";
            this.gbEmployee.Size = new System.Drawing.Size(776, 113);
            this.gbEmployee.TabIndex = 2;
            this.gbEmployee.TabStop = false;
            this.gbEmployee.Text = "Bilgilerim";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTitle.Location = new System.Drawing.Point(131, 86);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(49, 18);
            this.lblTitle.TabIndex = 13;
            this.lblTitle.Text = "lblTitle";
            // 
            // lblTitle1
            // 
            this.lblTitle1.AutoSize = true;
            this.lblTitle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTitle1.Location = new System.Drawing.Point(42, 86);
            this.lblTitle1.Name = "lblTitle1";
            this.lblTitle1.Size = new System.Drawing.Size(74, 18);
            this.lblTitle1.TabIndex = 13;
            this.lblTitle1.Text = "Pozisyon:";
            // 
            // lblOffice
            // 
            this.lblOffice.AutoSize = true;
            this.lblOffice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOffice.Location = new System.Drawing.Point(131, 59);
            this.lblOffice.Name = "lblOffice";
            this.lblOffice.Size = new System.Drawing.Size(61, 18);
            this.lblOffice.TabIndex = 14;
            this.lblOffice.Text = "lblOffice";
            // 
            // lblOffice1
            // 
            this.lblOffice1.AutoSize = true;
            this.lblOffice1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOffice1.Location = new System.Drawing.Point(38, 59);
            this.lblOffice1.Name = "lblOffice1";
            this.lblOffice1.Size = new System.Drawing.Size(78, 18);
            this.lblOffice1.TabIndex = 14;
            this.lblOffice1.Text = "Ofis Kodu:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblName.Location = new System.Drawing.Point(131, 32);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(62, 18);
            this.lblName.TabIndex = 17;
            this.lblName.Text = "lblName";
            // 
            // pbEmployee
            // 
            this.pbEmployee.Location = new System.Drawing.Point(675, 14);
            this.pbEmployee.Name = "pbEmployee";
            this.pbEmployee.Size = new System.Drawing.Size(95, 90);
            this.pbEmployee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEmployee.TabIndex = 1;
            this.pbEmployee.TabStop = false;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMail.Location = new System.Drawing.Point(408, 59);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(49, 18);
            this.lblMail.TabIndex = 15;
            this.lblMail.Text = "lblMail";
            // 
            // lblName1
            // 
            this.lblName1.AutoSize = true;
            this.lblName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblName1.Location = new System.Drawing.Point(87, 32);
            this.lblName1.Name = "lblName1";
            this.lblName1.Size = new System.Drawing.Size(29, 18);
            this.lblName1.TabIndex = 17;
            this.lblName1.Text = "Ad:";
            // 
            // lblSname
            // 
            this.lblSname.AutoSize = true;
            this.lblSname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSname.Location = new System.Drawing.Point(410, 32);
            this.lblSname.Name = "lblSname";
            this.lblSname.Size = new System.Drawing.Size(69, 18);
            this.lblSname.TabIndex = 16;
            this.lblSname.Text = "lblSname";
            // 
            // lblMail1
            // 
            this.lblMail1.AutoSize = true;
            this.lblMail1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMail1.Location = new System.Drawing.Point(341, 59);
            this.lblMail1.Name = "lblMail1";
            this.lblMail1.Size = new System.Drawing.Size(52, 18);
            this.lblMail1.TabIndex = 15;
            this.lblMail1.Text = "e-Mail:";
            // 
            // lblSname1
            // 
            this.lblSname1.AutoSize = true;
            this.lblSname1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSname1.Location = new System.Drawing.Point(339, 32);
            this.lblSname1.Name = "lblSname1";
            this.lblSname1.Size = new System.Drawing.Size(54, 18);
            this.lblSname1.TabIndex = 16;
            this.lblSname1.Text = "Soyad:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Security,
            this.ToolStripMenuItem_Display});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItem_Security
            // 
            this.ToolStripMenuItem_Security.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_UpdateE});
            this.ToolStripMenuItem_Security.Name = "ToolStripMenuItem_Security";
            this.ToolStripMenuItem_Security.Size = new System.Drawing.Size(118, 20);
            this.ToolStripMenuItem_Security.Text = "Güvenlik Bilgilerim";
            // 
            // TSMI_UpdateE
            // 
            this.TSMI_UpdateE.Name = "TSMI_UpdateE";
            this.TSMI_UpdateE.Size = new System.Drawing.Size(211, 22);
            this.TSMI_UpdateE.Text = "Kullanıcı Adı/Şifre Değiştir";
            this.TSMI_UpdateE.Click += new System.EventHandler(this.TSMI_UpdateE_Click);
            // 
            // ToolStripMenuItem_Display
            // 
            this.ToolStripMenuItem_Display.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_ListProducts,
            this.TSMI_SoldProducts,
            this.TSMI_CustomerInfo});
            this.ToolStripMenuItem_Display.Name = "ToolStripMenuItem_Display";
            this.ToolStripMenuItem_Display.Size = new System.Drawing.Size(72, 20);
            this.ToolStripMenuItem_Display.Text = "Görüntüle";
            // 
            // TSMI_ListProducts
            // 
            this.TSMI_ListProducts.Name = "TSMI_ListProducts";
            this.TSMI_ListProducts.Size = new System.Drawing.Size(180, 22);
            this.TSMI_ListProducts.Text = "Tüm Ürünleri Listele";
            this.TSMI_ListProducts.Click += new System.EventHandler(this.TSMI_ListProducts_Click);
            // 
            // TSMI_SoldProducts
            // 
            this.TSMI_SoldProducts.Name = "TSMI_SoldProducts";
            this.TSMI_SoldProducts.Size = new System.Drawing.Size(180, 22);
            this.TSMI_SoldProducts.Text = "Sattığım Ürünler";
            this.TSMI_SoldProducts.Click += new System.EventHandler(this.TSMI_SoldProducts_Click);
            // 
            // TSMI_CustomerInfo
            // 
            this.TSMI_CustomerInfo.Name = "TSMI_CustomerInfo";
            this.TSMI_CustomerInfo.Size = new System.Drawing.Size(180, 22);
            this.TSMI_CustomerInfo.Text = "Müşteri Bilgileri";
            this.TSMI_CustomerInfo.Click += new System.EventHandler(this.TSMI_CustomerInfo_Click);
            // 
            // gbUpdProduct
            // 
            this.gbUpdProduct.Controls.Add(this.btUpdProduct);
            this.gbUpdProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbUpdProduct.Location = new System.Drawing.Point(12, 216);
            this.gbUpdProduct.Name = "gbUpdProduct";
            this.gbUpdProduct.Size = new System.Drawing.Size(341, 63);
            this.gbUpdProduct.TabIndex = 2;
            this.gbUpdProduct.TabStop = false;
            this.gbUpdProduct.Text = "Ürün Güncelle";
            // 
            // btUpdProduct
            // 
            this.btUpdProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUpdProduct.Location = new System.Drawing.Point(114, 23);
            this.btUpdProduct.Name = "btUpdProduct";
            this.btUpdProduct.Size = new System.Drawing.Size(211, 31);
            this.btUpdProduct.TabIndex = 0;
            this.btUpdProduct.Text = "Güncellenecek Ürünü Seç";
            this.btUpdProduct.UseVisualStyleBackColor = true;
            this.btUpdProduct.Click += new System.EventHandler(this.BtUpdProduct_Click);
            // 
            // gbDelProduct
            // 
            this.gbDelProduct.Controls.Add(this.btDelProduct);
            this.gbDelProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDelProduct.Location = new System.Drawing.Point(441, 216);
            this.gbDelProduct.Name = "gbDelProduct";
            this.gbDelProduct.Size = new System.Drawing.Size(341, 63);
            this.gbDelProduct.TabIndex = 2;
            this.gbDelProduct.TabStop = false;
            this.gbDelProduct.Text = "Ürün Sil";
            // 
            // btDelProduct
            // 
            this.btDelProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDelProduct.Location = new System.Drawing.Point(114, 23);
            this.btDelProduct.Name = "btDelProduct";
            this.btDelProduct.Size = new System.Drawing.Size(211, 31);
            this.btDelProduct.TabIndex = 0;
            this.btDelProduct.Text = "Silinecek Ürünü Seç";
            this.btDelProduct.UseVisualStyleBackColor = true;
            this.btDelProduct.Click += new System.EventHandler(this.BtDelProduct_Click);
            // 
            // gbDelCustomer
            // 
            this.gbDelCustomer.Controls.Add(this.btDelCustomer);
            this.gbDelCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDelCustomer.Location = new System.Drawing.Point(197, 299);
            this.gbDelCustomer.Name = "gbDelCustomer";
            this.gbDelCustomer.Size = new System.Drawing.Size(341, 63);
            this.gbDelCustomer.TabIndex = 2;
            this.gbDelCustomer.TabStop = false;
            this.gbDelCustomer.Text = "Müşteriyi Sistemden Çıkar";
            // 
            // btDelCustomer
            // 
            this.btDelCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDelCustomer.Location = new System.Drawing.Point(114, 23);
            this.btDelCustomer.Name = "btDelCustomer";
            this.btDelCustomer.Size = new System.Drawing.Size(211, 31);
            this.btDelCustomer.TabIndex = 0;
            this.btDelCustomer.Text = "Çıkarılacak Müşteriyi Seç";
            this.btDelCustomer.UseVisualStyleBackColor = true;
            this.btDelCustomer.Click += new System.EventHandler(this.BtDelCustomer_Click);
            // 
            // FormEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 382);
            this.Controls.Add(this.btUpdateInfoE);
            this.Controls.Add(this.gbDelCustomer);
            this.Controls.Add(this.gbDelProduct);
            this.Controls.Add(this.gbUpdProduct);
            this.Controls.Add(this.gbEmployee);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "STORE V.1.0 Special Edition   |   Personel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormEmployee_FormClosing);
            this.Load += new System.EventHandler(this.FormEmployee_Load);
            this.gbEmployee.ResumeLayout(false);
            this.gbEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmployee)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbUpdProduct.ResumeLayout(false);
            this.gbDelProduct.ResumeLayout(false);
            this.gbDelCustomer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbEmployee;
        private System.Windows.Forms.GroupBox gbEmployee;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTitle1;
        private System.Windows.Forms.Label lblOffice;
        private System.Windows.Forms.Label lblOffice1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblName1;
        private System.Windows.Forms.Label lblSname;
        private System.Windows.Forms.Label lblMail1;
        private System.Windows.Forms.Label lblSname1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Security;
        private System.Windows.Forms.ToolStripMenuItem TSMI_UpdateE;
        private System.Windows.Forms.GroupBox gbUpdProduct;
        private System.Windows.Forms.Button btUpdProduct;
        private System.Windows.Forms.GroupBox gbDelProduct;
        private System.Windows.Forms.Button btDelProduct;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Display;
        private System.Windows.Forms.ToolStripMenuItem TSMI_SoldProducts;
        private System.Windows.Forms.ToolStripMenuItem TSMI_ListProducts;
		private System.Windows.Forms.Button btUpdateInfoE;
        private System.Windows.Forms.ToolStripMenuItem TSMI_CustomerInfo;
        private System.Windows.Forms.GroupBox gbDelCustomer;
        private System.Windows.Forms.Button btDelCustomer;
    }
}