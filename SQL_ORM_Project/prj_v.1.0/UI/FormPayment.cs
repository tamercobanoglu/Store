using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using prj_v._1._0.DAL;
using prj_v._1._0.Entity;
using prj_v._1._0.BLL;
using System.Data.Entity;

namespace prj_v._1._0.UI
{
    public partial class FormPayment : Form
    {
        static int cusID;
        static int ordID;
        static string status;

        public FormPayment()
        {
            InitializeComponent();
        }

        public FormPayment(int cusID, string status)
        {
            FormPayment.cusID = cusID;
            FormPayment.status = status;
            InitializeComponent();
        }

        private void FormPayment_Load(object sender, EventArgs e)
        {
            var list = HelperOrder.GetOrderModelList(cusID, status);

            foreach (var item in list) {
                dgvOrder.Rows.Add(item.orderID, Convert.ToDateTime(item.orderDate).ToShortDateString(), item.orderStatus, item.amount);
            }
        }

        private void DgvOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvPayment.Rows.Clear();

            if (dgvOrder.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null) {
                dgvOrder.CurrentRow.Selected = true;
                ordID = Convert.ToInt32(dgvOrder.Rows[e.RowIndex].Cells["orderID"].FormattedValue.ToString());
            }

            var list = HelperPayment.GetPaymentList(ordID);
            foreach (var p in list) {
                dgvPayment.Rows.Add(p.paymentID, Convert.ToDateTime(p.paymentDate).ToShortDateString(), p.amountPayed);
            }

            var debt = HelperOrder.GetOrder(ordID).amount - HelperPayment.GetAmountPayed(ordID);
            lblDebt.Visible = true;
            lblDebt.Text = $"Bu siparişe ait kalan borç: {debt}";
        }

        private void TbPay_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbPay.Text) && Helper.isNumber(tbPay.Text)) btPay.Enabled = true;
            else btPay.Enabled = false;
        }

        private void BtPay_Click(object sender, EventArgs e)
        {
            var control1 = HelperOrder.GetOrder(ordID).amount - HelperPayment.GetAmountPayed(ordID) - Convert.ToDouble(tbPay.Text);
            var control2 = HelperCustomer.GetCustomer(cusID).creditLimit - Convert.ToDouble(tbPay.Text);

            if (control1 < 0 || control2 < 0) {
				if (control1 < 0) {
					MessageBox.Show("Lütfen borcunuza eşit veya daha düşük bir miktar giriniz!");
				}
				else MessageBox.Show("Bakiyeniz bu işlem için yetersizdir!");
			}

            else {
                Payment p = new Payment {
                    paymentDate = DateTime.Now.Date,
                    amountPayed = Convert.ToInt32(tbPay.Text),
                    customerID = cusID,
                    orderID = ordID
                };
                HelperPayment.CUD(p, EntityState.Added);

                var cus = HelperCustomer.GetCustomer(cusID);
                if (cus != null) {
                    cus.creditLimit -= p.amountPayed;
                    HelperCustomer.CUD(cus, EntityState.Modified);
                }
                
                var debt = HelperOrder.GetOrder(ordID).amount - HelperPayment.GetAmountPayed(ordID);
                dgvPayment.Rows.Add(p.paymentID, Convert.ToDateTime(p.paymentDate).ToShortDateString(), p.amountPayed);
                lblDebt.Text = $"Bu siparişe ait kalan borç: {debt}";
                lblCredit.Visible = true;
                lblCredit.Text = $"Kalan bakiyeniz: {cus.creditLimit}";
                if (debt == 0) {
                    MessageBox.Show("Bu siparişe ait borcunuzun tamamını ödediniz!");
                }
            }
        }
    }
}
