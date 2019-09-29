namespace prj_v._1._0.UI
{
    partial class FormPayment
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.orderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPayment = new System.Windows.Forms.DataGridView();
            this.paymenID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymenDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountPayed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl3 = new System.Windows.Forms.Label();
            this.btPay = new System.Windows.Forms.Button();
            this.tbPay = new System.Windows.Forms.TextBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lblDebt = new System.Windows.Forms.Label();
            this.lblCredit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayment)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl1.Location = new System.Drawing.Point(12, 25);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(503, 18);
            this.lbl1.TabIndex = 17;
            this.lbl1.Text = "Ödeme yapmak istediğiniz istediğiniz siparişinizin bulunduğu satıra tıklayınız.";
            // 
            // dgvOrder
            // 
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderID,
            this.orderDate,
            this.orderStatus,
            this.amount});
            this.dgvOrder.Location = new System.Drawing.Point(12, 46);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.ReadOnly = true;
            this.dgvOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvOrder.Size = new System.Drawing.Size(765, 192);
            this.dgvOrder.TabIndex = 18;
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
            // dgvPayment
            // 
            this.dgvPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.paymenID,
            this.paymenDate,
            this.amountPayed});
            this.dgvPayment.Location = new System.Drawing.Point(12, 338);
            this.dgvPayment.Name = "dgvPayment";
            this.dgvPayment.ReadOnly = true;
            this.dgvPayment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvPayment.Size = new System.Drawing.Size(765, 193);
            this.dgvPayment.TabIndex = 19;
            // 
            // paymenID
            // 
            this.paymenID.HeaderText = "Fatura No";
            this.paymenID.Name = "paymenID";
            this.paymenID.ReadOnly = true;
            this.paymenID.Width = 50;
            // 
            // paymenDate
            // 
            this.paymenDate.HeaderText = "Ödeme Tarihi";
            this.paymenDate.Name = "paymenDate";
            this.paymenDate.ReadOnly = true;
            this.paymenDate.Width = 295;
            // 
            // amountPayed
            // 
            this.amountPayed.HeaderText = "Ödenen Miktar";
            this.amountPayed.Name = "amountPayed";
            this.amountPayed.ReadOnly = true;
            this.amountPayed.Width = 375;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl3.Location = new System.Drawing.Point(12, 317);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(106, 18);
            this.lbl3.TabIndex = 20;
            this.lbl3.Text = "Ödeme Detayı:";
            // 
            // btPay
            // 
            this.btPay.Enabled = false;
            this.btPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPay.Location = new System.Drawing.Point(200, 274);
            this.btPay.Name = "btPay";
            this.btPay.Size = new System.Drawing.Size(163, 31);
            this.btPay.TabIndex = 21;
            this.btPay.Text = "Güvenli Öde";
            this.btPay.UseVisualStyleBackColor = true;
            this.btPay.Click += new System.EventHandler(this.BtPay_Click);
            // 
            // tbPay
            // 
            this.tbPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPay.Location = new System.Drawing.Point(200, 244);
            this.tbPay.Name = "tbPay";
            this.tbPay.Size = new System.Drawing.Size(163, 24);
            this.tbPay.TabIndex = 25;
            this.tbPay.TextChanged += new System.EventHandler(this.TbPay_TextChanged);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl2.Location = new System.Drawing.Point(12, 250);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(182, 18);
            this.lbl2.TabIndex = 26;
            this.lbl2.Text = "Ödemek istediğiniz miktar:";
            // 
            // lblDebt
            // 
            this.lblDebt.AutoSize = true;
            this.lblDebt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDebt.Location = new System.Drawing.Point(521, 250);
            this.lblDebt.Name = "lblDebt";
            this.lblDebt.Size = new System.Drawing.Size(53, 18);
            this.lblDebt.TabIndex = 27;
            this.lblDebt.Text = "lblDebt";
            this.lblDebt.Visible = false;
            // 
            // lblCredit
            // 
            this.lblCredit.AutoSize = true;
            this.lblCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCredit.Location = new System.Drawing.Point(521, 280);
            this.lblCredit.Name = "lblCredit";
            this.lblCredit.Size = new System.Drawing.Size(61, 18);
            this.lblCredit.TabIndex = 27;
            this.lblCredit.Text = "lblCredit";
            this.lblCredit.Visible = false;
            // 
            // FormPayment
            // 
            this.AcceptButton = this.btPay;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 545);
            this.Controls.Add(this.lblCredit);
            this.Controls.Add(this.lblDebt);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.tbPay);
            this.Controls.Add(this.btPay);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.dgvPayment);
            this.Controls.Add(this.dgvOrder);
            this.Controls.Add(this.lbl1);
            this.Name = "FormPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "STORE V.1.0 Special Edition   |   Ödemelerim";
            this.Load += new System.EventHandler(this.FormPayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridView dgvPayment;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Button btPay;
        private System.Windows.Forms.TextBox tbPay;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lblDebt;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymenID;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymenDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountPayed;
        private System.Windows.Forms.Label lblCredit;
    }
}