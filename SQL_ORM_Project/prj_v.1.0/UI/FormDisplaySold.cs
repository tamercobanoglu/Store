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
    public partial class FormDisplaySold : Form
    {
        static int empID;

        public FormDisplaySold()
        {
            InitializeComponent();
        }

        public FormDisplaySold(int empID)
        {
            FormDisplaySold.empID = empID;
            InitializeComponent();
        }

        private void FormDisplaySold_Load(object sender, EventArgs e)
        {
            var list = HelperOrderDet.GetOrderDetbyEmpModelList(empID);

			foreach (var item in list) {
                dgvSoldProducts.Rows.Add(item.Products.productID, item.Products.proName, item.priceEach, item.quantityOrdered, HelperOrder.GetCusFullNameByOrderId(item.Orders.orderID));
            }
        }
    }
}
