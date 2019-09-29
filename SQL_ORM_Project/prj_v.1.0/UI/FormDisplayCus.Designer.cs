namespace prj_v._1._0.UI
{
    partial class FormDisplayCus
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
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.customerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creditLimit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adressLine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.region = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.city = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postalCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerID,
            this.cFirstName,
            this.cLastName,
            this.creditLimit,
            this.phone,
            this.adressLine,
            this.region,
            this.city,
            this.postalCode});
            this.dgvCustomers.Location = new System.Drawing.Point(12, 12);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.Size = new System.Drawing.Size(952, 482);
            this.dgvCustomers.TabIndex = 0;
            this.dgvCustomers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCustomers_CellClick);
            // 
            // customerID
            // 
            this.customerID.HeaderText = "Müşteri ID";
            this.customerID.Name = "customerID";
            this.customerID.Width = 50;
            // 
            // cFirstName
            // 
            this.cFirstName.HeaderText = "Ad";
            this.cFirstName.Name = "cFirstName";
            // 
            // cLastName
            // 
            this.cLastName.HeaderText = "Soyad";
            this.cLastName.Name = "cLastName";
            this.cLastName.Width = 120;
            // 
            // creditLimit
            // 
            this.creditLimit.HeaderText = "Kredi Limiti";
            this.creditLimit.Name = "creditLimit";
            this.creditLimit.Width = 70;
            // 
            // phone
            // 
            this.phone.HeaderText = "GSM";
            this.phone.Name = "phone";
            this.phone.Width = 120;
            // 
            // adressLine
            // 
            this.adressLine.HeaderText = "Adres";
            this.adressLine.Name = "adressLine";
            this.adressLine.Width = 150;
            // 
            // region
            // 
            this.region.HeaderText = "İlçe";
            this.region.Name = "region";
            // 
            // city
            // 
            this.city.HeaderText = "Şehir";
            this.city.Name = "city";
            // 
            // postalCode
            // 
            this.postalCode.HeaderText = "Posta Kodu";
            this.postalCode.Name = "postalCode";
            // 
            // FormDisplayCus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 506);
            this.Controls.Add(this.dgvCustomers);
            this.Name = "FormDisplayCus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "STORE V.1.0 Special Edition   |   Müşteri Bilgileri";
            this.Load += new System.EventHandler(this.FormDisplayCus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditLimit;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn adressLine;
        private System.Windows.Forms.DataGridViewTextBoxColumn region;
        private System.Windows.Forms.DataGridViewTextBoxColumn city;
        private System.Windows.Forms.DataGridViewTextBoxColumn postalCode;
    }
}