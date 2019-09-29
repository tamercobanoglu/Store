namespace prj_v._1._0.UI
{
    partial class FormCustomer
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItem_Security = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_UpdateC = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Display = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Orders = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_CurrentOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_CompOrders = new System.Windows.Forms.ToolStripMenuItem();
            this.lblSname1 = new System.Windows.Forms.Label();
            this.lblCredit1 = new System.Windows.Forms.Label();
            this.lblSname = new System.Windows.Forms.Label();
            this.lblName1 = new System.Windows.Forms.Label();
            this.lblCredit = new System.Windows.Forms.Label();
            this.lblRegion = new System.Windows.Forms.Label();
            this.lblRegion1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblCity1 = new System.Windows.Forms.Label();
            this.lblPhone1 = new System.Windows.Forms.Label();
            this.lblCountry1 = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblAdress1 = new System.Windows.Forms.Label();
            this.lblPostalCode1 = new System.Windows.Forms.Label();
            this.lblAdress = new System.Windows.Forms.Label();
            this.lblPostalCode = new System.Windows.Forms.Label();
            this.gbCustomer = new System.Windows.Forms.GroupBox();
            this.lblCate = new System.Windows.Forms.Label();
            this.lblSubCate = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.cBoxCate = new System.Windows.Forms.ComboBox();
            this.cBoxSubCate = new System.Windows.Forms.ComboBox();
            this.cBoxProduct = new System.Windows.Forms.ComboBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbOrder = new System.Windows.Forms.GroupBox();
            this.cBoxEmployee = new System.Windows.Forms.ComboBox();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.btUpdateInfoC = new System.Windows.Forms.Button();
            this.btAddToBasket = new System.Windows.Forms.Button();
            this.btFinishOrder = new System.Windows.Forms.Button();
            this.TSMI_Payment = new System.Windows.Forms.ToolStripMenuItem();
            this.pbCustomer = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.gbCustomer.SuspendLayout();
            this.gbOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Security,
            this.ToolStripMenuItem_Display});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItem_Security
            // 
            this.ToolStripMenuItem_Security.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_UpdateC});
            this.ToolStripMenuItem_Security.Name = "ToolStripMenuItem_Security";
            this.ToolStripMenuItem_Security.Size = new System.Drawing.Size(118, 20);
            this.ToolStripMenuItem_Security.Text = "Güvenlik Bilgilerim";
            // 
            // TSMI_UpdateC
            // 
            this.TSMI_UpdateC.Name = "TSMI_UpdateC";
            this.TSMI_UpdateC.Size = new System.Drawing.Size(211, 22);
            this.TSMI_UpdateC.Text = "Kullanıcı Adı/Şifre Değiştir";
            this.TSMI_UpdateC.Click += new System.EventHandler(this.TSMI_UpdateC_Click);
            // 
            // ToolStripMenuItem_Display
            // 
            this.ToolStripMenuItem_Display.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_Orders,
            this.TSMI_Payment});
            this.ToolStripMenuItem_Display.Name = "ToolStripMenuItem_Display";
            this.ToolStripMenuItem_Display.Size = new System.Drawing.Size(72, 20);
            this.ToolStripMenuItem_Display.Text = "Görüntüle";
            // 
            // TSMI_Orders
            // 
            this.TSMI_Orders.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_CurrentOrder,
            this.TSMI_CompOrders});
            this.TSMI_Orders.Name = "TSMI_Orders";
            this.TSMI_Orders.Size = new System.Drawing.Size(180, 22);
            this.TSMI_Orders.Text = "Siparişlerim";
            // 
            // TSMI_CurrentOrder
            // 
            this.TSMI_CurrentOrder.Name = "TSMI_CurrentOrder";
            this.TSMI_CurrentOrder.Size = new System.Drawing.Size(212, 22);
            this.TSMI_CurrentOrder.Text = "Güncel Siparişim";
            this.TSMI_CurrentOrder.Click += new System.EventHandler(this.TSMI_CurrentOrder_Click);
            // 
            // TSMI_CompOrders
            // 
            this.TSMI_CompOrders.Name = "TSMI_CompOrders";
            this.TSMI_CompOrders.Size = new System.Drawing.Size(212, 22);
            this.TSMI_CompOrders.Text = "Tamamlanmış Siparişlerim";
            this.TSMI_CompOrders.Click += new System.EventHandler(this.TSMI_CompOrders_Click);
            // 
            // lblSname1
            // 
            this.lblSname1.AutoSize = true;
            this.lblSname1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSname1.Location = new System.Drawing.Point(392, 32);
            this.lblSname1.Name = "lblSname1";
            this.lblSname1.Size = new System.Drawing.Size(54, 18);
            this.lblSname1.TabIndex = 16;
            this.lblSname1.Text = "Soyad:";
            // 
            // lblCredit1
            // 
            this.lblCredit1.AutoSize = true;
            this.lblCredit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCredit1.Location = new System.Drawing.Point(362, 59);
            this.lblCredit1.Name = "lblCredit1";
            this.lblCredit1.Size = new System.Drawing.Size(84, 18);
            this.lblCredit1.TabIndex = 15;
            this.lblCredit1.Text = "Kredi Limiti:";
            // 
            // lblSname
            // 
            this.lblSname.AutoSize = true;
            this.lblSname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSname.Location = new System.Drawing.Point(461, 32);
            this.lblSname.Name = "lblSname";
            this.lblSname.Size = new System.Drawing.Size(69, 18);
            this.lblSname.TabIndex = 16;
            this.lblSname.Text = "lblSname";
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
            // lblCredit
            // 
            this.lblCredit.AutoSize = true;
            this.lblCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCredit.Location = new System.Drawing.Point(461, 59);
            this.lblCredit.Name = "lblCredit";
            this.lblCredit.Size = new System.Drawing.Size(61, 18);
            this.lblCredit.TabIndex = 15;
            this.lblCredit.Text = "lblCredit";
            // 
            // lblRegion
            // 
            this.lblRegion.AutoSize = true;
            this.lblRegion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRegion.Location = new System.Drawing.Point(131, 113);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(69, 18);
            this.lblRegion.TabIndex = 13;
            this.lblRegion.Text = "lblRegion";
            // 
            // lblRegion1
            // 
            this.lblRegion1.AutoSize = true;
            this.lblRegion1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRegion1.Location = new System.Drawing.Point(82, 113);
            this.lblRegion1.Name = "lblRegion1";
            this.lblRegion1.Size = new System.Drawing.Size(34, 18);
            this.lblRegion1.TabIndex = 13;
            this.lblRegion1.Text = "İlçe:";
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
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCity.Location = new System.Drawing.Point(461, 113);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(47, 18);
            this.lblCity.TabIndex = 13;
            this.lblCity.Text = "lblCity";
            // 
            // lblCity1
            // 
            this.lblCity1.AutoSize = true;
            this.lblCity1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCity1.Location = new System.Drawing.Point(428, 113);
            this.lblCity1.Name = "lblCity1";
            this.lblCity1.Size = new System.Drawing.Size(18, 18);
            this.lblCity1.TabIndex = 13;
            this.lblCity1.Text = "İl:";
            // 
            // lblPhone1
            // 
            this.lblPhone1.AutoSize = true;
            this.lblPhone1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPhone1.Location = new System.Drawing.Point(69, 59);
            this.lblPhone1.Name = "lblPhone1";
            this.lblPhone1.Size = new System.Drawing.Size(47, 18);
            this.lblPhone1.TabIndex = 14;
            this.lblPhone1.Text = "GSM:";
            // 
            // lblCountry1
            // 
            this.lblCountry1.AutoSize = true;
            this.lblCountry1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCountry1.Location = new System.Drawing.Point(74, 141);
            this.lblCountry1.Name = "lblCountry1";
            this.lblCountry1.Size = new System.Drawing.Size(42, 18);
            this.lblCountry1.TabIndex = 13;
            this.lblCountry1.Text = "Ülke:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPhone.Location = new System.Drawing.Point(131, 59);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(65, 18);
            this.lblPhone.TabIndex = 14;
            this.lblPhone.Text = "lblPhone";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCountry.Location = new System.Drawing.Point(131, 141);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(74, 18);
            this.lblCountry.TabIndex = 13;
            this.lblCountry.Text = "lblCountry";
            // 
            // lblAdress1
            // 
            this.lblAdress1.AutoSize = true;
            this.lblAdress1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdress1.Location = new System.Drawing.Point(66, 86);
            this.lblAdress1.Name = "lblAdress1";
            this.lblAdress1.Size = new System.Drawing.Size(50, 18);
            this.lblAdress1.TabIndex = 13;
            this.lblAdress1.Text = "Adres:";
            // 
            // lblPostalCode1
            // 
            this.lblPostalCode1.AutoSize = true;
            this.lblPostalCode1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPostalCode1.Location = new System.Drawing.Point(356, 141);
            this.lblPostalCode1.Name = "lblPostalCode1";
            this.lblPostalCode1.Size = new System.Drawing.Size(90, 18);
            this.lblPostalCode1.TabIndex = 13;
            this.lblPostalCode1.Text = "Posta Kodu:";
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdress.Location = new System.Drawing.Point(131, 86);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(68, 18);
            this.lblAdress.TabIndex = 13;
            this.lblAdress.Text = "lblAdress";
            // 
            // lblPostalCode
            // 
            this.lblPostalCode.AutoSize = true;
            this.lblPostalCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPostalCode.Location = new System.Drawing.Point(461, 141);
            this.lblPostalCode.Name = "lblPostalCode";
            this.lblPostalCode.Size = new System.Drawing.Size(100, 18);
            this.lblPostalCode.TabIndex = 13;
            this.lblPostalCode.Text = "lblPostalCode";
            // 
            // gbCustomer
            // 
            this.gbCustomer.Controls.Add(this.lblPostalCode);
            this.gbCustomer.Controls.Add(this.lblAdress);
            this.gbCustomer.Controls.Add(this.lblPostalCode1);
            this.gbCustomer.Controls.Add(this.lblAdress1);
            this.gbCustomer.Controls.Add(this.lblCountry);
            this.gbCustomer.Controls.Add(this.lblPhone);
            this.gbCustomer.Controls.Add(this.lblCountry1);
            this.gbCustomer.Controls.Add(this.lblPhone1);
            this.gbCustomer.Controls.Add(this.lblCity1);
            this.gbCustomer.Controls.Add(this.lblCity);
            this.gbCustomer.Controls.Add(this.lblName);
            this.gbCustomer.Controls.Add(this.pbCustomer);
            this.gbCustomer.Controls.Add(this.lblRegion1);
            this.gbCustomer.Controls.Add(this.lblRegion);
            this.gbCustomer.Controls.Add(this.lblCredit);
            this.gbCustomer.Controls.Add(this.lblName1);
            this.gbCustomer.Controls.Add(this.lblSname);
            this.gbCustomer.Controls.Add(this.lblCredit1);
            this.gbCustomer.Controls.Add(this.lblSname1);
            this.gbCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCustomer.Location = new System.Drawing.Point(12, 36);
            this.gbCustomer.Name = "gbCustomer";
            this.gbCustomer.Size = new System.Drawing.Size(776, 167);
            this.gbCustomer.TabIndex = 4;
            this.gbCustomer.TabStop = false;
            this.gbCustomer.Text = "Bilgilerim";
            // 
            // lblCate
            // 
            this.lblCate.AutoSize = true;
            this.lblCate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCate.Location = new System.Drawing.Point(49, 31);
            this.lblCate.Name = "lblCate";
            this.lblCate.Size = new System.Drawing.Size(67, 18);
            this.lblCate.TabIndex = 19;
            this.lblCate.Text = "Kategori:";
            // 
            // lblSubCate
            // 
            this.lblSubCate.AutoSize = true;
            this.lblSubCate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSubCate.Location = new System.Drawing.Point(29, 63);
            this.lblSubCate.Name = "lblSubCate";
            this.lblSubCate.Size = new System.Drawing.Size(87, 18);
            this.lblSubCate.TabIndex = 18;
            this.lblSubCate.Text = "Alt Kategori:";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProductName.Location = new System.Drawing.Point(72, 95);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(44, 18);
            this.lblProductName.TabIndex = 17;
            this.lblProductName.Text = "Ürün:";
            // 
            // cBoxCate
            // 
            this.cBoxCate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxCate.FormattingEnabled = true;
            this.cBoxCate.Location = new System.Drawing.Point(134, 23);
            this.cBoxCate.Name = "cBoxCate";
            this.cBoxCate.Size = new System.Drawing.Size(259, 26);
            this.cBoxCate.TabIndex = 22;
            this.cBoxCate.SelectedValueChanged += new System.EventHandler(this.CBoxCate_SelectedValueChanged);
            // 
            // cBoxSubCate
            // 
            this.cBoxSubCate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxSubCate.FormattingEnabled = true;
            this.cBoxSubCate.Location = new System.Drawing.Point(134, 55);
            this.cBoxSubCate.Name = "cBoxSubCate";
            this.cBoxSubCate.Size = new System.Drawing.Size(259, 26);
            this.cBoxSubCate.TabIndex = 21;
            this.cBoxSubCate.SelectedValueChanged += new System.EventHandler(this.CBoxSubCate_SelectedValueChanged);
            // 
            // cBoxProduct
            // 
            this.cBoxProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxProduct.FormattingEnabled = true;
            this.cBoxProduct.Location = new System.Drawing.Point(134, 87);
            this.cBoxProduct.Name = "cBoxProduct";
            this.cBoxProduct.Size = new System.Drawing.Size(427, 26);
            this.cBoxProduct.TabIndex = 20;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblQuantity.Location = new System.Drawing.Point(579, 63);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(41, 18);
            this.lblQuantity.TabIndex = 23;
            this.lblQuantity.Text = "Adet:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(613, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 31);
            this.button1.TabIndex = 18;
            this.button1.Text = "Sepete Ekle";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tbQuantity
            // 
            this.tbQuantity.Location = new System.Drawing.Point(630, 57);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(121, 24);
            this.tbQuantity.TabIndex = 24;
            this.tbQuantity.TextChanged += new System.EventHandler(this.TbQuantity_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(441, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 18);
            this.label1.TabIndex = 20;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // gbOrder
            // 
            this.gbOrder.Controls.Add(this.label1);
            this.gbOrder.Controls.Add(this.tbQuantity);
            this.gbOrder.Controls.Add(this.button1);
            this.gbOrder.Controls.Add(this.lblQuantity);
            this.gbOrder.Controls.Add(this.cBoxEmployee);
            this.gbOrder.Controls.Add(this.lblEmployee);
            this.gbOrder.Controls.Add(this.cBoxProduct);
            this.gbOrder.Controls.Add(this.cBoxSubCate);
            this.gbOrder.Controls.Add(this.cBoxCate);
            this.gbOrder.Controls.Add(this.lblProductName);
            this.gbOrder.Controls.Add(this.lblSubCate);
            this.gbOrder.Controls.Add(this.lblCate);
            this.gbOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOrder.Location = new System.Drawing.Point(12, 246);
            this.gbOrder.Name = "gbOrder";
            this.gbOrder.Size = new System.Drawing.Size(776, 121);
            this.gbOrder.TabIndex = 4;
            this.gbOrder.TabStop = false;
            this.gbOrder.Text = "Sepete Ekle";
            // 
            // cBoxEmployee
            // 
            this.cBoxEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxEmployee.FormattingEnabled = true;
            this.cBoxEmployee.Location = new System.Drawing.Point(492, 23);
            this.cBoxEmployee.Name = "cBoxEmployee";
            this.cBoxEmployee.Size = new System.Drawing.Size(259, 26);
            this.cBoxEmployee.TabIndex = 22;
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEmployee.Location = new System.Drawing.Point(434, 31);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(48, 18);
            this.lblEmployee.TabIndex = 19;
            this.lblEmployee.Text = "Satıcı:";
            // 
            // btUpdateInfoC
            // 
            this.btUpdateInfoC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUpdateInfoC.Location = new System.Drawing.Point(619, 200);
            this.btUpdateInfoC.Name = "btUpdateInfoC";
            this.btUpdateInfoC.Size = new System.Drawing.Size(169, 31);
            this.btUpdateInfoC.TabIndex = 3;
            this.btUpdateInfoC.Text = "Bilgilerimi Güncelle";
            this.btUpdateInfoC.UseVisualStyleBackColor = true;
            this.btUpdateInfoC.Click += new System.EventHandler(this.BtUpdateInfoC_Click);
            // 
            // btAddToBasket
            // 
            this.btAddToBasket.Enabled = false;
            this.btAddToBasket.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAddToBasket.Location = new System.Drawing.Point(619, 364);
            this.btAddToBasket.Name = "btAddToBasket";
            this.btAddToBasket.Size = new System.Drawing.Size(169, 31);
            this.btAddToBasket.TabIndex = 3;
            this.btAddToBasket.Text = "Sepete Ekle";
            this.btAddToBasket.UseVisualStyleBackColor = true;
            this.btAddToBasket.Click += new System.EventHandler(this.BtAddToBasket_Click);
            // 
            // btFinishOrder
            // 
            this.btFinishOrder.Enabled = false;
            this.btFinishOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFinishOrder.Location = new System.Drawing.Point(279, 410);
            this.btFinishOrder.Name = "btFinishOrder";
            this.btFinishOrder.Size = new System.Drawing.Size(241, 47);
            this.btFinishOrder.TabIndex = 3;
            this.btFinishOrder.Text = "Siparişi Tamamla";
            this.btFinishOrder.UseVisualStyleBackColor = true;
            this.btFinishOrder.Click += new System.EventHandler(this.BtFinishOrder_Click);
            // 
            // TSMI_Payment
            // 
            this.TSMI_Payment.Name = "TSMI_Payment";
            this.TSMI_Payment.Size = new System.Drawing.Size(180, 22);
            this.TSMI_Payment.Text = "Ödemelerim";
            this.TSMI_Payment.Click += new System.EventHandler(this.TSMI_Payment_Click);
            // 
            // pbCustomer
            // 
            this.pbCustomer.Image = global::prj_v._1._0.Properties.Resources.login2;
            this.pbCustomer.Location = new System.Drawing.Point(675, 14);
            this.pbCustomer.Name = "pbCustomer";
            this.pbCustomer.Size = new System.Drawing.Size(95, 90);
            this.pbCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCustomer.TabIndex = 1;
            this.pbCustomer.TabStop = false;
            // 
            // FormCustomer
            // 
            this.AcceptButton = this.btAddToBasket;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 466);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btFinishOrder);
            this.Controls.Add(this.btAddToBasket);
            this.Controls.Add(this.btUpdateInfoC);
            this.Controls.Add(this.gbOrder);
            this.Controls.Add(this.gbCustomer);
            this.Name = "FormCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "STORE V.1.0 Special Edition   |   Müşteri";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCustomer_FormClosing);
            this.Load += new System.EventHandler(this.FormCustomer_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbCustomer.ResumeLayout(false);
            this.gbCustomer.PerformLayout();
            this.gbOrder.ResumeLayout(false);
            this.gbOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Security;
        private System.Windows.Forms.ToolStripMenuItem TSMI_UpdateC;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Display;
        private System.Windows.Forms.Label lblSname1;
        private System.Windows.Forms.Label lblCredit1;
        private System.Windows.Forms.Label lblSname;
        private System.Windows.Forms.Label lblName1;
        private System.Windows.Forms.Label lblCredit;
        private System.Windows.Forms.Label lblRegion;
        private System.Windows.Forms.Label lblRegion1;
        private System.Windows.Forms.PictureBox pbCustomer;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblCity1;
        private System.Windows.Forms.Label lblPhone1;
        private System.Windows.Forms.Label lblCountry1;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblAdress1;
        private System.Windows.Forms.Label lblPostalCode1;
        private System.Windows.Forms.Label lblAdress;
        private System.Windows.Forms.Label lblPostalCode;
        private System.Windows.Forms.GroupBox gbCustomer;
        private System.Windows.Forms.Label lblCate;
        private System.Windows.Forms.Label lblSubCate;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.ComboBox cBoxCate;
        private System.Windows.Forms.ComboBox cBoxSubCate;
        private System.Windows.Forms.ComboBox cBoxProduct;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbQuantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbOrder;
        private System.Windows.Forms.Button btUpdateInfoC;
        private System.Windows.Forms.Button btAddToBasket;
        private System.Windows.Forms.ComboBox cBoxEmployee;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.Button btFinishOrder;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Orders;
        private System.Windows.Forms.ToolStripMenuItem TSMI_CurrentOrder;
        private System.Windows.Forms.ToolStripMenuItem TSMI_CompOrders;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Payment;
    }
}