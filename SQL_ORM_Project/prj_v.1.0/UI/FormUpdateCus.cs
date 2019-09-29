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
using prj_v._1._0.BLL;
using System.Data.Entity;

namespace prj_v._1._0.UI
{
    public partial class FormUpdateCus : Form
    {
		static int cusID;

		public FormUpdateCus()
		{
			InitializeComponent();
		}
		public FormUpdateCus(int cusID)
        {
			FormUpdateCus.cusID = cusID;
            InitializeComponent();
        }

        private void FormUpdateCus_Load(object sender, EventArgs e)
        {
            cBoxCity.ValueMember = "cityID";
            cBoxCity.DisplayMember = "cityName";
            cBoxCity.DataSource = HelperCity.GetCityList();

            tbName.Text = HelperCustomer.GetCustomer(cusID).cFirstName;
            tbSname.Text = HelperCustomer.GetCustomer(cusID).cLastName;
            mtbPhone.Text = HelperCustomer.GetCustomer(cusID).phone;
            tbCredit.Text = HelperCustomer.GetCustomer(cusID).creditLimit.ToString();
            cBoxCountry.Text = HelperCustomer.GetCustomer(cusID).country;
            cBoxCity.Text = HelperCustomer.GetCustomer(cusID).city;
            cBoxRegion.Text = HelperCustomer.GetCustomer(cusID).region;
            tbAdress.Text = HelperCustomer.GetCustomer(cusID).addressLine;
        }

        private void FormUpdateCus_FormClosing(object sender, FormClosingEventArgs e)
		{
			//Application.Exit();
			//Application.ExitThread();
			//Environment.Exit();
			FormCustomer f1 = new FormCustomer(cusID);
			f1.Show();
		}

        static bool I(string text) {
            return string.IsNullOrEmpty(text);
        }

        private void BtUpdCusInfo_Click(object sender, EventArgs e)
		{
            bool result = I(tbName.Text) || I(tbSname.Text) || I(mtbPhone.Text) || I(tbCredit.Text) || I(tbAdress.Text);
            if (result) {
                MessageBox.Show("Tüm alanları doldurunuz!");
            }

            else {
                if (!Helper.isNumber(tbCredit.Text)) {
                    MessageBox.Show("Kredi miktarını sayı olarak giriniz!");
                }

                else {
                    var c = HelperCustomer.GetCustomer(cusID);
                    if (c != null) {
                        c.cFirstName = tbName.Text;
                        c.cLastName = tbSname.Text;
                        c.phone = mtbPhone.Text;
                        c.creditLimit = Convert.ToDouble(tbCredit.Text);
                        c.addressLine = tbAdress.Text;
                        c.region = cBoxRegion.Text;
                        c.city = cBoxCity.Text;
                        c.country = cBoxCountry.Text;
                        c.postalCode = HelperRegion.GetPostalCode(Convert.ToInt32(cBoxRegion.SelectedValue));
                        var result2 = HelperCustomer.CUD(c, EntityState.Modified);
                        MessageBox.Show(result2 == true ? "Müşteri bilgileri güncellendi!" : "HATA!");
                    }
                }
            }
        }

        private void CBoxCity_SelectedValueChanged(object sender, EventArgs e)
        {
            int cityID = Convert.ToInt32(cBoxCity.SelectedValue);
            cBoxRegion.ValueMember = "regionID";
            cBoxRegion.DisplayMember = "regionName";
            cBoxRegion.DataSource = HelperRegion.GetRegionModelList(cityID);
        }
    }
}
