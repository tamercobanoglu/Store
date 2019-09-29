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
using System.Data.Entity;

namespace prj_v._1._0.UI
{
    public partial class FormDisplayProducts : Form
    {
        static string command;

        public FormDisplayProducts()
        {
            InitializeComponent();
        }

        public FormDisplayProducts(string command)
        {
            FormDisplayProducts.command = command;
            InitializeComponent();
        }

        private void FormDisplayProducts_Load(object sender, EventArgs e)
        {
            var list = HelperProduct.GetProductModelList();

            foreach (var item in list) {
                dgvProducts.Rows.Add(item.productID, item.proName, item.SubCate.subCateName, item.Cate.cateName, item.proPrice, item.quantity);
            }
        }

        private void DgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (command == "updProduct") {
                int proID = 0;
                if (dgvProducts.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null) {
                    dgvProducts.CurrentRow.Selected = true;
                    proID = Convert.ToInt32(dgvProducts.Rows[e.RowIndex].Cells["productID"].FormattedValue.ToString());
                }

                var pro = HelperProduct.GetProduct(proID);
                if (pro != null) {
                    FormUpdatePro f = new FormUpdatePro(pro);
                    f.Show();
                    this.Hide();
                }
            }

            else if (command == "delProduct") {
                int proID = 0;
                if (dgvProducts.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null) {
                    dgvProducts.CurrentRow.Selected = true;
                    proID = Convert.ToInt32(dgvProducts.Rows[e.RowIndex].Cells["productID"].FormattedValue.ToString());
                }

                var pro = HelperProduct.GetProduct(proID);
                if (pro != null) {
                    if (HelperOrderDet.SoldProductsList().Contains(proID)) {
                        MessageBox.Show("Bu ürün daha önce satıldığı için listeden çıkaramazsınız!");
                    }
                    else {
                        var result = HelperProduct.CUD(pro, EntityState.Deleted);
                        MessageBox.Show(result == true ? "Ürün başarıyla silindi!" : "HATA!");
                    }
                }
            }
        }
    }
}
