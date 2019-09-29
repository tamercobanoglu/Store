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
    public partial class FormDisplayCus : Form
    {
        static string command;

        public FormDisplayCus()
        {
            InitializeComponent();
        }
        public FormDisplayCus(string command)
        {
            FormDisplayCus.command = command;
            InitializeComponent();
        }


        private void FormDisplayCus_Load(object sender, EventArgs e)
        {
            var list = HelperCustomer.GetCustomerModelList();

            foreach (var item in list) {
                dgvCustomers.Rows.Add(item.customerID, item.cFirstName, item.cLastName, item.creditLimit, item.phone, item.addressLine, item.region, item.city, item.postalCode);
            }
        }

        private void DgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (command == "delCustomer") {
                int cusID = 0;
                if (dgvCustomers.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null) {
                    dgvCustomers.CurrentRow.Selected = true;
                    cusID = Convert.ToInt32(dgvCustomers.Rows[e.RowIndex].Cells["customerID"].FormattedValue.ToString());
                }

                var cus = HelperCustomer.GetCustomer(cusID);
                var sign = HelperSignin.GetUserCus(cus.Signin.signinID);
                if (cus != null) {
                    if (HelperOrder.ActiveCustomersList().Contains(cusID)) {
                        MessageBox.Show("Bu müşteri daha önce satın alım yaptığı için sistemden çıkaramazsınız!");
                    }
                    else {
                        cus.Signin.signinID = 0;
                        HelperCustomer.CUD(cus, EntityState.Modified);
                        var result1 = HelperCustomer.CUD(cus, EntityState.Deleted);
                        var result2 = HelperSignin.CUD(sign, EntityState.Deleted);
                        MessageBox.Show(result1 == true && result2 == true ? "Müşteri başarıyla sistemden çıkarıldı!" : "HATA!");
                    }
                }
            }

            else if (command == "maintenance") {
                MessageBox.Show("Sistemin bakımda olması sebebiyle bu işlem geçici bir süreliğine askıya alınmıştır!");
            }
        }
    }
}
