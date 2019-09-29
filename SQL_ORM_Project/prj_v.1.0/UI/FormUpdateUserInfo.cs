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
using prj_v._1._0.DAL;

namespace prj_v._1._0.UI
{
    public partial class FormUpdateUserInfo : Form
    {
		static int userID, userType;
        public FormUpdateUserInfo()
        {
            InitializeComponent();
        }

		public FormUpdateUserInfo(int _userID, int _userType)
		{
			userID = _userID;
			userType = _userType;
			InitializeComponent();
		}

		private void FormUpdateUserInfo_FormClosing(object sender, FormClosingEventArgs e)
		{
			//Application.Exit();
			//Application.ExitThread();
			//Environment.Exit();
		}

        static bool I(string text) {
            return string.IsNullOrEmpty(text);
        }

        private void BtUpdUsername_Click(object sender, EventArgs e)
		{
            bool result = I(tbOldUsername.Text) || I(tbUsername.Text) || I(tbUsername1.Text);
            if (result) {
                MessageBox.Show("Tüm alanları doldurunuz!");
            }

            else {
                if (userType == 1) {
                    var list = HelperSignin.GetUserNameList();
                    if (list.Contains(tbUsername.Text)) {
                        MessageBox.Show("Bu kullanıcı adı kullanılmaktadır!");
                    }
                    else {
                        var user1 = HelperEmployee.GetEmployee(userID);
                        var user = HelperEmployee.GetEmployeeModel(userID);
                        var user2 = HelperSignin.GetUserEmp(user.Signin.signinID);
                        if (user1 != null && user2 != null) {
                            if (user1.eUserName == tbOldUsername.Text && tbUsername.Text == tbUsername1.Text) {
                                user1.eUserName = tbUsername.Text;
                                user2.userName = tbUsername.Text;
                                var result1 = HelperEmployee.CUD(user1, EntityState.Modified);
                                var result2 = HelperSignin.CUD(user2, EntityState.Modified);
                                if (result1 && result2) MessageBox.Show("Kayıt başarılı!");
                                else MessageBox.Show("Kayıt başarısız!");
                            }
                            //MessageBox.Show("Eski kullanıcı adınızı doğru giriniz!");
                        }
                        else MessageBox.Show("Kayıt başarısız!");
                    }
                }
                else if (userType == 2) {
                    var list = HelperSignin.GetUserNameList();
                    if (list.Contains(tbUsername.Text)) {
                        MessageBox.Show("Bu kullanıcı adı kullanılmaktadır!");
                    }
                    else {
                        var user1 = HelperCustomer.GetCustomer(userID);
                        var user = HelperCustomer.GetCustomerModel(userID);
                        var user2 = HelperSignin.GetUserCus(user.Signin.signinID);
                        if (user1 != null && user2 != null) {
                            if (user1.cUserName == tbOldUsername.Text && tbUsername.Text == tbUsername1.Text) {
                                user1.cUserName = tbUsername.Text;
                                user2.userName = tbUsername.Text;
                                var result1 = HelperCustomer.CUD(user1, EntityState.Modified);
                                var result2 = HelperSignin.CUD(user2, EntityState.Modified);
                                if (result1 && result2) MessageBox.Show("Kayıt başarılı!");
                                else MessageBox.Show("Kayıt başarısız!");
                            }
                            //MessageBox.Show("Eski kullanıcı adınızı doğru giriniz!");
                        }
                        else MessageBox.Show("Kayıt başarısız!");
                    }
                }
            }
		}

		private void BtUpdPassword_Click(object sender, EventArgs e)
		{
            bool result = I(tbOldPassWord.Text) || I(tbPassWord.Text) || I(tbPassWord1.Text);
            if (result) {
                MessageBox.Show("Tüm alanları doldurunuz!");
            }

            else {
                if (userType == 1) {
                    var user1 = HelperEmployee.GetEmployee(userID);
                    var user = HelperEmployee.GetEmployeeModel(userID);
                    var user2 = HelperSignin.GetUserEmp(user.Signin.signinID);
                    if (user != null) {
                        if (user1.eUserPassword == tbOldPassWord.Text && tbPassWord.Text == tbPassWord1.Text) {
                            user1.eUserPassword = tbPassWord.Text;
                            user2.userPassword = tbPassWord.Text;
                            var result1 = HelperEmployee.CUD(user1, EntityState.Modified);
                            var result2 = HelperSignin.CUD(user2, EntityState.Modified);
                            if (result1 && result2) MessageBox.Show("Kayıt başarılı!");
                            else MessageBox.Show("Kayıt başarısız!");
                        }
                        //MessageBox.Show("Eski şifrenizi doğru giriniz!");
                    }
                    else MessageBox.Show("Kayıt başarısız!");
                }
                else if (userType == 2) {
                    var user1 = HelperCustomer.GetCustomer(userID);
                    var user = HelperCustomer.GetCustomerModel(userID);
                    var user2 = HelperSignin.GetUserCus(user.Signin.signinID);
                    if (user != null) {
                        if (user1.cUserPassword == tbOldPassWord.Text && tbPassWord.Text == tbPassWord1.Text) {
                            user1.cUserPassword = tbPassWord.Text;
                            user2.userPassword = tbPassWord.Text;
                            var result1 = HelperCustomer.CUD(user1, EntityState.Modified);
                            var result2 = HelperSignin.CUD(user2, EntityState.Modified);
                            if (result1 && result2) MessageBox.Show("Kayıt başarılı!");
                            else MessageBox.Show("Kayıt başarısız!");
                        }
                        //MessageBox.Show("Eski şifrenizi doğru giriniz!");
                    }
                    else MessageBox.Show("Kayıt başarısız!");
                }
            }
		}
	}
}
