using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using prj_v._1._0.Entity;
using prj_v._1._0.DAL;
using prj_v._1._0.BLL;
using System.Data.Entity;

namespace prj_v._1._0.UI
{
    public partial class FormUpdatePro : Form
    {
        static Products pro = new Products();

        public FormUpdatePro(Products pro)
        {
            FormUpdatePro.pro = pro;
            InitializeComponent();
        }

        private void FormUpdatePro_Load(object sender, EventArgs e)
        {
            tbPrice.Text = pro.proPrice.ToString();
            tbStock.Text = pro.quantity.ToString();
        }

        private void FormUpdatePro_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormDisplayProducts f = new FormDisplayProducts();
            f.Show();
        }

        static bool I(string text) {
            return string.IsNullOrEmpty(text);
        }

        private void TbPrice_TextChanged(object sender, EventArgs e)
        {
            if(!I(tbPrice.Text) && !I(tbStock.Text)) btUpdProduct.Enabled = true;
            else btUpdProduct.Enabled = false;
        }

        private void TbStock_TextChanged(object sender, EventArgs e)
        {
            if (!I(tbPrice.Text) && !I(tbStock.Text)) btUpdProduct.Enabled = true;
            else btUpdProduct.Enabled = false;
        }

        private void BtUpdProduct_Click(object sender, EventArgs e)
        {
            if(!Helper.isNumber(tbPrice.Text) || !Helper.isNumber(tbStock.Text)) {
                MessageBox.Show("Fiyat ve stok bilgilerini sayı olarak giriniz!");
            }

            else {
                pro.proPrice = Convert.ToDouble(tbPrice.Text);
                pro.quantity = Convert.ToInt32(tbStock.Text);
                var result = HelperProduct.CUD(pro, EntityState.Modified);
                MessageBox.Show(result == true ? "Ürün başarıyla güncellendi!" : "HATA!");
            }
        }
    }
}
