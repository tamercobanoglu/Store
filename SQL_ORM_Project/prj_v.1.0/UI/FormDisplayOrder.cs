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

namespace prj_v._1._0.UI
{
	public partial class FormDisplayOrder : Form
	{
        static int cusID;
        static string status;

		public FormDisplayOrder()
		{
			InitializeComponent();
		}

        public FormDisplayOrder(int cusID, string status)
        {
            FormDisplayOrder.cusID = cusID;
            FormDisplayOrder.status = status;
            InitializeComponent();
        }

        private void FormDisplayOrder_Load(object sender, EventArgs e)
        {
            var list = HelperOrder.GetOrderModelList(cusID, status);

            foreach (var item in list) {
                dgvOrder.Rows.Add(item.orderID, Convert.ToDateTime(item.orderDate).ToShortDateString(), item.orderStatus, item.amount);
            }
        }

        private void DgvOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvOrderDet.Rows.Clear();
            //int orderID = Convert.ToInt32(dgvOrder.CurrentCell.Value.ToString());
            int orderID = 0;
            if (dgvOrder.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null) {
                dgvOrder.CurrentRow.Selected = true;
                orderID = Convert.ToInt32(dgvOrder.Rows[e.RowIndex].Cells["orderID"].FormattedValue.ToString());
            }

            var list = HelperOrderDet.GetOrderDetModelList(orderID);

            foreach (var item in list) {
                dgvOrderDet.Rows.Add(item.Products.productID, item.Products.proName, item.priceEach, item.quantityOrdered, item.Employees.eFirstName + " " + item.Employees.eLastName);
            }
        }
    }
}
