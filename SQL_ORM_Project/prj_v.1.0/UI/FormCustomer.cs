using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Windows.Forms;
using prj_v._1._0.Model;
using prj_v._1._0.BLL;
using prj_v._1._0.DAL;
using prj_v._1._0.Entity;

namespace prj_v._1._0.UI
{
    public partial class FormCustomer : Form
    {
		static int cusID;
        static string name;
        static string sname;
        static string phone;
        static string credit;
        static string adress, region, city, country;
        static string postalCode;

        static bool openOrder;

        public FormCustomer()
        {
            InitializeComponent();
        }

		public FormCustomer(int cusID)
		{
            FormCustomer.cusID = cusID;
            name = HelperCustomer.GetCustomer(FormCustomer.cusID).cFirstName;
            sname = HelperCustomer.GetCustomer(FormCustomer.cusID).cLastName;
            phone = HelperCustomer.GetCustomer(FormCustomer.cusID).phone;
            credit = HelperCustomer.GetCustomer(FormCustomer.cusID).creditLimit.ToString();
            adress = HelperCustomer.GetCustomer(FormCustomer.cusID).addressLine;
            region = HelperCustomer.GetCustomer(FormCustomer.cusID).region;
            city = HelperCustomer.GetCustomer(FormCustomer.cusID).city;
            country = HelperCustomer.GetCustomer(FormCustomer.cusID).country;
            postalCode = HelperCustomer.GetCustomer(FormCustomer.cusID).postalCode;

            InitializeComponent();
		}

        private void FormCustomer_Load(object sender, EventArgs e)
        {
            lblName.Text = name;
            lblSname.Text = sname;
            lblPhone.Text = phone;
            lblCredit.Text = credit;
            lblAdress.Text = adress;
            lblRegion.Text = region;
            lblCity.Text = city;
            lblCountry.Text = country;
            lblPostalCode.Text = postalCode;

            cBoxCate.Items.Clear();
            cBoxSubCate.Items.Clear();
            cBoxProduct.Items.Clear();

            cBoxCate.ValueMember = "cateID";
            cBoxCate.DisplayMember = "cateName";
            cBoxCate.DataSource = HelperCate.GetCateList();

            cBoxEmployee.ValueMember = "employeeID";
            cBoxEmployee.DisplayMember = "eLastName";
            cBoxEmployee.DataSource = HelperEmployee.GetEmployeeList();
        }

        private void FormCustomer_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
            //Application.ExitThread();
            //Environment.Exit();

            FinishOrder();
            FormLogin f = new FormLogin();
            f.Show();
            this.Hide();
        }

        private void TSMI_UpdateC_Click(object sender, EventArgs e)
		{
			FormUpdateUserInfo f2 = new FormUpdateUserInfo(cusID, 2);
			f2.Show();
		}

        private void BtUpdateInfoC_Click(object sender, EventArgs e)
		{
			FormUpdateCus f = new FormUpdateCus(cusID);
			f.Show();
			this.Hide();
		}

        private void CBoxCate_SelectedValueChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(cBoxCate.SelectedValue);
            cBoxSubCate.ValueMember = "subCateID";
            cBoxSubCate.DisplayMember = "subCateName";
            cBoxSubCate.DataSource = HelperSubCate.GetSubCateModelList(id);
        }

        private void CBoxSubCate_SelectedValueChanged(object sender, EventArgs e)
        {
            int subCateID = Convert.ToInt32(cBoxSubCate.SelectedValue);
            cBoxProduct.ValueMember = "productID";
            cBoxProduct.DisplayMember = "proName";
            cBoxProduct.DataSource = HelperProduct.GetProductbySubCateModelList(subCateID);
        }

        private void TbQuantity_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbQuantity.Text)) btAddToBasket.Enabled = false;
            else btAddToBasket.Enabled = true;
        }

        private void BtAddToBasket_Click(object sender, EventArgs e)
        {
            int empID = Convert.ToInt32(cBoxEmployee.SelectedValue);
            int proID = Convert.ToInt32(cBoxProduct.SelectedValue);
            var pro = HelperProduct.GetProduct(proID);

            if (pro != null) {
                if (!Helper.isNumber(tbQuantity.Text) || Convert.ToInt32(tbQuantity.Text) <= 0) {
                    btAddToBasket.Enabled = false;
                    MessageBox.Show("Hatalı giriş yaptınız!");
                }

                else if (pro.quantity < Convert.ToInt32(tbQuantity.Text)) {
                    if(pro.quantity == 0) MessageBox.Show("Bu ürün tükenmiştir!");
                    else MessageBox.Show($"Bu üründen stokta {pro.quantity} adet kaldı!");
                }

                else {
                    if (!openOrder) {
                        Orders ord = new Orders {
                            orderDate = DateTime.Now.Date,
                            orderStatus = "Açık",
                            amount = 0,
                            customerID = cusID
                        };

                        var result1 = HelperOrder.CUD(ord, EntityState.Added);
                        if (result1) {
                            openOrder = true;
                            OrderDetails ordDet = new OrderDetails {
                                productID = proID,
                                priceEach = HelperProduct.GetProduct(proID).proPrice,
                                quantityOrdered = Convert.ToInt32(tbQuantity.Text),
                                orderID = ord.orderID,
                                employeeID = empID
                            };

                            var result2 = HelperOrderDet.CUD(ordDet, EntityState.Added);
                            if (result2) {
                                btFinishOrder.Enabled = true;
                                MessageBox.Show("Ürün sepete eklendi!");
                                ord.amount += ordDet.priceEach * ordDet.quantityOrdered;
                                HelperOrder.CUD(ord, EntityState.Modified);
                            }
                            else MessageBox.Show("HATA!");
                        }
                    }

                    else {
                        OrderDetails ordDet = new OrderDetails {
                            productID = proID,
                            priceEach = pro.proPrice,
                            quantityOrdered = Convert.ToInt32(tbQuantity.Text),
                            orderID = HelperOrder.GetOrderList().Count,
                            employeeID = empID
                        };

                        var ord = HelperOrder.GetOrder(Convert.ToInt32(ordDet.orderID));
                        var result = HelperOrderDet.CUD(ordDet, EntityState.Added);
                        if (result) {
                            btFinishOrder.Enabled = true;
                            MessageBox.Show("Ürün sepete eklendi!");
                            ord.amount += ordDet.priceEach * ordDet.quantityOrdered;
                            HelperOrder.CUD(ord, EntityState.Modified);
                        }
                        else MessageBox.Show("HATA!");
                    }

                    pro.quantity -= Convert.ToInt32(tbQuantity.Text);
                    HelperProduct.CUD(pro, EntityState.Modified);
                }
            }
        }

		private void BtFinishOrder_Click(object sender, EventArgs e)
        {
            MessageBox.Show(FinishOrder() == true ? "Sipariş tamamlandı!" : "HATA!");
            btFinishOrder.Enabled = false;
        }

        private bool FinishOrder() {
            var ord = HelperOrder.GetOrder(HelperOrder.GetOrderList().Count);
            if (ord != null) {
                ord.orderStatus = "Tamamlanmış";
                var result = HelperOrder.CUD(ord, EntityState.Modified);
                if (result) {
                    openOrder = false;
                    return true;
                }
                return false;
            }
            return false;
        }

		private void TSMI_CurrentOrder_Click(object sender, EventArgs e)
		{
            FormDisplayOrder f = new FormDisplayOrder(cusID, "Açık");
            f.Show();
        }

        private void TSMI_CompOrders_Click(object sender, EventArgs e)
		{
            FormDisplayOrder f = new FormDisplayOrder(cusID, "Tamamlanmış");
            f.Show();
		}

        private void TSMI_Payment_Click(object sender, EventArgs e)
        {
            FormPayment f = new FormPayment(cusID, "Tamamlanmış");
            f.Show();
        }
    }
}
