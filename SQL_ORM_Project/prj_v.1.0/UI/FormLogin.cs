using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Windows.Forms;
using prj_v._1._0.DAL;
using prj_v._1._0.UI;
using prj_v._1._0.Model;
using prj_v._1._0.BLL;
using prj_v._1._0.Entity;

namespace prj_v._1._0
{
	public partial class FormLogin : Form
	{
		public FormLogin()
		{
			InitializeComponent();
		}

        private void FormLogin_Load(object sender, EventArgs e)
        {
            cBoxCity.Items.Clear();
            cBoxRegion.Items.Clear();
            cBoxCountry.SelectedItem = "Türkiye";

            cBoxCity.ValueMember = "cityID";
            cBoxCity.DisplayMember = "cityName";
            cBoxCity.DataSource = HelperCity.GetCityList();
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
            Application.ExitThread();
            //Environment.Exit();
        }

        private void BtLoginE_Click(object sender, EventArgs e)
        {
            var List = HelperEmployee.GetEmployeeList();
            Employees emp = HelperEmployee.Item(List, tbUserE.Text, tbPwE.Text);
			if (emp != null) {
				FormEmployee f2 = new FormEmployee(emp.employeeID);
				f2.Show();
				this.Hide();
			}
			else {
				tbUserE.Clear(); tbPwE.Clear();
				lblWrongE.Visible = true;
			}
        }

        private void LblWarningE_Click(object sender, EventArgs e)
        {
            lblHintE.Visible = true;
            lblHintE.Text = "İpucu: İlk evcil hayvanınızın adı";
        }

        private void BtLoginC_Click(object sender, EventArgs e)
        {
			var List = HelperCustomer.GetCustomerList();
			Customers cus = HelperCustomer.Item(List, tbUserC.Text, tbPwC.Text);
			if (cus != null) {
				FormCustomer f2 = new FormCustomer(cus.customerID);
				f2.Show();
				this.Hide();
			}
			else {
				tbUserC.Clear(); tbPwC.Clear();
				lblWrongC.Visible = true;
			} 
        }

        private void LblWarningC_Click(object sender, EventArgs e)
        {
            lblHintC.Visible = true;
            lblHintC.Text = "İpucu: En sevdiğiniz renk";
        }

        private void CbContract_CheckedChanged(object sender, EventArgs e)
        {
            if(cbContract.Checked == true) btRegister.Enabled = true;
            else btRegister.Enabled = false;
        }

        static bool I(string text) {
            return string.IsNullOrEmpty(text);
        }

		private void BtRegister_Click(object sender, EventArgs e)
		{
            bool result = I(tbUsername.Text) || I(tbPassword.Text) || I(tbName.Text) || I(tbSname.Text) || I(mtbPhone.Text) || I(tbCredit.Text) || I(tbAdress.Text);
            if (result) {
                MessageBox.Show("Tüm alanları doldurunuz!");
            }

            else {
                if(!Helper.isNumber(tbCredit.Text)) {
                    MessageBox.Show("Kredi miktarını sayı olarak giriniz!");
                }

                else {
                    var list = HelperSignin.GetUserNameList();
                    if (list.Contains(tbUsername.Text)) {
                        MessageBox.Show("Bu kullanıcı adı kullanılmaktadır!");
                    }

                    else
                    {
                        Signin user = new Signin {
                            userName = tbUsername.Text,
                            userPassword = tbPassword.Text,
                            userType = 2
                        };

                        var resultUser = HelperSignin.CUD(user, EntityState.Added);
                        if (resultUser) {
                            lblMessageR.Text = "Kayıt başarılı";
                            Helper.countUser++;
                        }
                        else {
                            lblMessageR.ForeColor = Color.Blue;
                            lblMessageR.Text = "Kayıt başarısız";
                        }

                        Customers cus = new Customers {
                            cUserName = tbUsername.Text,
                            cUserPassword = tbPassword.Text,
                            cFirstName = tbName.Text,
                            cLastName = tbSname.Text,
                            phone = mtbPhone.Text,
                            creditLimit = Convert.ToDouble(tbCredit.Text),
                            addressLine = tbAdress.Text,
                            region = cBoxRegion.Text,
                            city = cBoxCity.Text,
                            country = cBoxCountry.Text,
                            postalCode = HelperRegion.GetPostalCode(Convert.ToInt32(cBoxRegion.SelectedValue)),
                            signinID = Helper.countUser
                        };

                        var resultEmp = HelperCustomer.CUD(cus, EntityState.Added);
                        if (resultEmp) {
                            lblMessageR.Text = "Kayıt başarılı";
                            MessageBox.Show("Kayıt başarılı!");
                            Helper.countEmp++;
                        }
                        else {
                            lblMessageR.ForeColor = Color.Red;
                            lblMessageR.Text = "Kayıt başarısız";
                            MessageBox.Show("Kayıt başarısız!");
                        }
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
