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
    public partial class FormUpdateEmp : Form
    {
        static int empID;
        public FormUpdateEmp()
        {
            InitializeComponent();
        }

        public FormUpdateEmp(int empID)
        {
            FormUpdateEmp.empID = empID;
            InitializeComponent();
        }

        private void FormUpdateEmp_Load(object sender, EventArgs e)
        {
            tbName.Text = HelperEmployee.GetEmployee(empID).eFirstName;
            tbSname.Text = HelperEmployee.GetEmployee(empID).eLastName;
            tbMail.Text = HelperEmployee.GetEmployee(empID).email;
            tbOfficeCode.Text = HelperEmployee.GetEmployee(empID).officeCode.ToString();
            tbJobTitle.Text = HelperEmployee.GetEmployee(empID).jobTitle;
        }

        private void FormUpdateEmp_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
            //Application.ExitThread();
            //Environment.Exit();
            FormEmployee f1 = new FormEmployee(empID);
            f1.Show();
        }

        static bool I(string text) {
            return string.IsNullOrEmpty(text);
        }

        private void BtUpdEmpInfo_Click(object sender, EventArgs e)
        {
            bool result = I(tbName.Text) || I(tbSname.Text) || I(tbMail.Text) || I(tbOfficeCode.Text) || I(tbJobTitle.Text);
            if (result) {
                MessageBox.Show("Tüm alanları doldurunuz!");
            }

            else {
                if(!Helper.isNumber(tbOfficeCode.Text)) {
                    MessageBox.Show("Ofis kodu bilgisini sayı olarak giriniz!");
                }

                else {
                    var emp = HelperEmployee.GetEmployee(empID);
                    if (emp != null) {
                        emp.eFirstName = tbName.Text;
                        emp.eLastName = tbSname.Text;
                        emp.email = tbMail.Text;
                        emp.officeCode = Convert.ToInt32(tbOfficeCode.Text);
                        emp.jobTitle = tbJobTitle.Text;

                        var result2 = HelperEmployee.CUD(emp, EntityState.Modified);
                        MessageBox.Show(result2 == true ? "Satıcı bilgileri güncellendi!" : "HATA!");
                    }
                }
            }
        }
    }
}
