namespace prj_v._1._0.UI
{
    partial class FormUpdateCus
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
            this.btUpdCusInfo = new System.Windows.Forms.Button();
            this.mtbPhone = new System.Windows.Forms.MaskedTextBox();
            this.cBoxCountry = new System.Windows.Forms.ComboBox();
            this.cBoxCity = new System.Windows.Forms.ComboBox();
            this.cBoxRegion = new System.Windows.Forms.ComboBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblRegion = new System.Windows.Forms.Label();
            this.tbAdress = new System.Windows.Forms.TextBox();
            this.lblAdress = new System.Windows.Forms.Label();
            this.tbCredit = new System.Windows.Forms.TextBox();
            this.lblCredit = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.tbSname = new System.Windows.Forms.TextBox();
            this.lblSname = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btUpdCusInfo
            // 
            this.btUpdCusInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUpdCusInfo.Location = new System.Drawing.Point(147, 357);
            this.btUpdCusInfo.Margin = new System.Windows.Forms.Padding(4);
            this.btUpdCusInfo.Name = "btUpdCusInfo";
            this.btUpdCusInfo.Size = new System.Drawing.Size(157, 30);
            this.btUpdCusInfo.TabIndex = 5;
            this.btUpdCusInfo.Text = "Bilgilerini Güncelle";
            this.btUpdCusInfo.UseVisualStyleBackColor = true;
            this.btUpdCusInfo.Click += new System.EventHandler(this.BtUpdCusInfo_Click);
            // 
            // mtbPhone
            // 
            this.mtbPhone.Location = new System.Drawing.Point(118, 89);
            this.mtbPhone.Mask = "(999) 000-0000";
            this.mtbPhone.Name = "mtbPhone";
            this.mtbPhone.Size = new System.Drawing.Size(186, 24);
            this.mtbPhone.TabIndex = 2;
            // 
            // cBoxCountry
            // 
            this.cBoxCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxCountry.FormattingEnabled = true;
            this.cBoxCountry.Items.AddRange(new object[] {
            "Türkiye"});
            this.cBoxCountry.Location = new System.Drawing.Point(118, 149);
            this.cBoxCountry.Name = "cBoxCountry";
            this.cBoxCountry.Size = new System.Drawing.Size(186, 26);
            this.cBoxCountry.TabIndex = 53;
            // 
            // cBoxCity
            // 
            this.cBoxCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxCity.FormattingEnabled = true;
            this.cBoxCity.Items.AddRange(new object[] {
            "İstanbul",
            "Ankara",
            "Trabzon",
            "Kocaeli",
            "İzmir",
            "Adapazarı",
            "Bursa"});
            this.cBoxCity.Location = new System.Drawing.Point(118, 181);
            this.cBoxCity.Name = "cBoxCity";
            this.cBoxCity.Size = new System.Drawing.Size(186, 26);
            this.cBoxCity.TabIndex = 52;
            this.cBoxCity.SelectedValueChanged += new System.EventHandler(this.CBoxCity_SelectedValueChanged);
            // 
            // cBoxRegion
            // 
            this.cBoxRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxRegion.FormattingEnabled = true;
            this.cBoxRegion.Location = new System.Drawing.Point(118, 213);
            this.cBoxRegion.Name = "cBoxRegion";
            this.cBoxRegion.Size = new System.Drawing.Size(186, 26);
            this.cBoxRegion.TabIndex = 51;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCountry.Location = new System.Drawing.Point(65, 157);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(42, 18);
            this.lblCountry.TabIndex = 48;
            this.lblCountry.Text = "Ülke:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCity.Location = new System.Drawing.Point(89, 189);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(18, 18);
            this.lblCity.TabIndex = 50;
            this.lblCity.Text = "İl:";
            // 
            // lblRegion
            // 
            this.lblRegion.AutoSize = true;
            this.lblRegion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRegion.Location = new System.Drawing.Point(73, 221);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(34, 18);
            this.lblRegion.TabIndex = 42;
            this.lblRegion.Text = "İlçe:";
            // 
            // tbAdress
            // 
            this.tbAdress.AcceptsReturn = true;
            this.tbAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbAdress.Location = new System.Drawing.Point(118, 245);
            this.tbAdress.Multiline = true;
            this.tbAdress.Name = "tbAdress";
            this.tbAdress.Size = new System.Drawing.Size(186, 90);
            this.tbAdress.TabIndex = 4;
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdress.Location = new System.Drawing.Point(57, 248);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(50, 18);
            this.lblAdress.TabIndex = 46;
            this.lblAdress.Text = "Adres:";
            // 
            // tbCredit
            // 
            this.tbCredit.AcceptsReturn = true;
            this.tbCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbCredit.Location = new System.Drawing.Point(118, 119);
            this.tbCredit.Name = "tbCredit";
            this.tbCredit.Size = new System.Drawing.Size(186, 24);
            this.tbCredit.TabIndex = 3;
            // 
            // lblCredit
            // 
            this.lblCredit.AutoSize = true;
            this.lblCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCredit.Location = new System.Drawing.Point(23, 125);
            this.lblCredit.Name = "lblCredit";
            this.lblCredit.Size = new System.Drawing.Size(84, 18);
            this.lblCredit.TabIndex = 45;
            this.lblCredit.Text = "Kredi Limiti:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPhone.Location = new System.Drawing.Point(60, 95);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(47, 18);
            this.lblPhone.TabIndex = 44;
            this.lblPhone.Text = "GSM:";
            // 
            // tbSname
            // 
            this.tbSname.AcceptsReturn = true;
            this.tbSname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbSname.Location = new System.Drawing.Point(118, 59);
            this.tbSname.Name = "tbSname";
            this.tbSname.Size = new System.Drawing.Size(186, 24);
            this.tbSname.TabIndex = 1;
            // 
            // lblSname
            // 
            this.lblSname.AutoSize = true;
            this.lblSname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSname.Location = new System.Drawing.Point(53, 65);
            this.lblSname.Name = "lblSname";
            this.lblSname.Size = new System.Drawing.Size(54, 18);
            this.lblSname.TabIndex = 43;
            this.lblSname.Text = "Soyad:";
            // 
            // tbName
            // 
            this.tbName.AcceptsReturn = true;
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbName.Location = new System.Drawing.Point(118, 29);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(186, 24);
            this.tbName.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblName.Location = new System.Drawing.Point(78, 35);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(29, 18);
            this.lblName.TabIndex = 47;
            this.lblName.Text = "Ad:";
            // 
            // FormUpdateCus
            // 
            this.AcceptButton = this.btUpdCusInfo;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 401);
            this.Controls.Add(this.mtbPhone);
            this.Controls.Add(this.cBoxCountry);
            this.Controls.Add(this.cBoxCity);
            this.Controls.Add(this.cBoxRegion);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblRegion);
            this.Controls.Add(this.tbAdress);
            this.Controls.Add(this.lblAdress);
            this.Controls.Add(this.tbCredit);
            this.Controls.Add(this.lblCredit);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.tbSname);
            this.Controls.Add(this.lblSname);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btUpdCusInfo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormUpdateCus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri Bilgilerini Güncelle";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormUpdateCus_FormClosing);
            this.Load += new System.EventHandler(this.FormUpdateCus_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btUpdCusInfo;
        private System.Windows.Forms.MaskedTextBox mtbPhone;
        private System.Windows.Forms.ComboBox cBoxCountry;
        private System.Windows.Forms.ComboBox cBoxCity;
        private System.Windows.Forms.ComboBox cBoxRegion;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblRegion;
        private System.Windows.Forms.TextBox tbAdress;
        private System.Windows.Forms.Label lblAdress;
        private System.Windows.Forms.TextBox tbCredit;
        private System.Windows.Forms.Label lblCredit;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox tbSname;
        private System.Windows.Forms.Label lblSname;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblName;
    }
}