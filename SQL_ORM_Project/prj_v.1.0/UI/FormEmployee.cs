using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using prj_v._1._0.Model;
using System.Data.Entity;
using prj_v._1._0.BLL;
using prj_v._1._0.DAL;
using prj_v._1._0.Entity;

namespace prj_v._1._0.UI
{
	public partial class FormEmployee : Form
	{
        static int empID;
        static string name;
        static string sname;
        static string office;
        static string mail;
        static string title;

        public FormEmployee()
        {
            InitializeComponent();
        }

        public FormEmployee(int empID)
		{
            FormEmployee.empID = empID;
            name = HelperEmployee.GetEmployee(FormEmployee.empID).eFirstName;
            sname = HelperEmployee.GetEmployee(FormEmployee.empID).eLastName;
            office = HelperEmployee.GetEmployee(FormEmployee.empID).officeCode.ToString();
            mail = HelperEmployee.GetEmployee(FormEmployee.empID).email;
            title = HelperEmployee.GetEmployee(FormEmployee.empID).jobTitle;

			InitializeComponent();
		}

        private void FormEmployee_Load(object sender, EventArgs e)
		{
            lblName.Text = name;
            lblSname.Text = sname;
            lblOffice.Text = office;
            lblMail.Text = mail;
            lblTitle.Text = title;
		}

        private void FormEmployee_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
            //Application.ExitThread();
            //Environment.Exit();

            FormLogin f = new FormLogin();
            f.Show();
            this.Hide();
        }

        private void TSMI_UpdateE_Click(object sender, EventArgs e)
		{
			FormUpdateUserInfo f2 = new FormUpdateUserInfo(empID, 1);
			f2.Show();
		}

        private void BtUpdateInfoE_Click(object sender, EventArgs e)
        {
            FormUpdateEmp f = new FormUpdateEmp(empID);
            f.Show();
            this.Hide();
        }

        private void TSMI_ListProducts_Click(object sender, EventArgs e)
        {
            FormDisplayProducts f = new FormDisplayProducts();
            f.Show();
        }

        private void TSMI_SoldProducts_Click(object sender, EventArgs e)
        {
            FormDisplaySold f = new FormDisplaySold(empID);
            f.Show();
        }

        private void TSMI_CustomerInfo_Click(object sender, EventArgs e)
        {
            FormDisplayCus f = new FormDisplayCus();
            f.Show();
        }

        private void BtUpdProduct_Click(object sender, EventArgs e)
        {
            FormDisplayProducts f = new FormDisplayProducts("updProduct");
            f.Show();
        }

        private void BtDelProduct_Click(object sender, EventArgs e)
        {
            FormDisplayProducts f = new FormDisplayProducts("delProduct");
            f.Show();
        }

        private void BtDelCustomer_Click(object sender, EventArgs e)
        {
            //FormDisplayCus f = new FormDisplayCus("delCustomer");
            FormDisplayCus f = new FormDisplayCus("maintenance");
            f.Show();
        }
    }
}
