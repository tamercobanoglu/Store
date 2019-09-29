using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using prj_v._1._0.Model;
using prj_v._1._0.Entity;

namespace prj_v._1._0.DAL
{
    class HelperCustomer
    {
		static ResultSet r = new ResultSet();

        public static Customers GetCustomer(int customerID) {
            using (StoreEntities s = new StoreEntities()) {
                return s.Customers.Where(x => x.customerID == customerID).FirstOrDefault();
            }
        }

        public static string GetCustomerFullName(int customerID) {
            using (StoreEntities s = new StoreEntities()) {
                var cus = s.Customers.Where(x => x.customerID == customerID).FirstOrDefault();

                return cus.cFirstName + " " + cus.cLastName;
            }
        }

		public static CustomerModel GetCustomerModel(int customerID)
		{
			using (StoreEntities s = new StoreEntities()) {
				var dbCus = s.Customers.Where(x => x.customerID == customerID).FirstOrDefault();

				return ConvertToModel(dbCus);
			}
		}

		public static List<Customers> GetCustomerList()
		{
			using (StoreEntities s = new StoreEntities()) {
				return s.Customers.ToList();
			}
		}

		public static List<CustomerModel> GetCustomerModelList() {
            using (StoreEntities s = new StoreEntities()) {
                var dbList = s.Customers.ToList();

                return ConvertToModelList(dbList);
            }
        }

		public static CustomerModel ConvertToModel(Customers dbCus)
		{
			CustomerModel cm = new CustomerModel();
            cm.customerID = dbCus.customerID;
			cm.cUserName = dbCus.cUserName;
			cm.cUserPassword = dbCus.cUserPassword;
			cm.cFirstName = dbCus.cFirstName;
			cm.cLastName = dbCus.cLastName;
			cm.phone = dbCus.phone;
			cm.creditLimit = dbCus.creditLimit;
			cm.addressLine = dbCus.addressLine;
			cm.region = dbCus.region;
			cm.city = dbCus.city;
			cm.country = dbCus.country;
			cm.postalCode = dbCus.postalCode;

			cm.Signin.signinID = dbCus.Signin.signinID;
			cm.Signin.userName = dbCus.Signin.userName;
			cm.Signin.userPassword = dbCus.Signin.userPassword;
			cm.Signin.userType = dbCus.Signin.userType;

			return cm;
		}

		public static List<CustomerModel> ConvertToModelList(List<Customers> dbList) {
            List<CustomerModel> cmList = new List<CustomerModel>();

            foreach (var item in dbList) cmList.Add(ConvertToModel(item));
            return cmList;
        }

		public static Customers Item(List<Customers> List, string username, string password)
		{
			Customers newItem = null;
			foreach (var item in List) {
				if (item.cUserName == username) {
					if (item.cUserPassword == password) {
						newItem = item;
						break;
					}
				}
			}
			return newItem;
		}

        public static bool CUD(Customers c, EntityState state) {
            using (StoreEntities s = new StoreEntities()) {
                s.Entry(c).State = state;
                if (s.SaveChanges() > 0) return true;
                return false;
            }
        }

		public static ResultSet ResultCUD(Customers cus, EntityState state)
		{
			using (StoreEntities s = new StoreEntities()) {
				s.Entry(cus).State = state;

				if (s.SaveChanges() > 0) {
					r.isSuccess = true;
					r.Message = "Kayıt eklendi.";
					r.Customer = cus;
					r.iconType = IconType.ok;
				}
				else {
					r.isSuccess = false;
					r.Message = "Hata!!";
					r.Customer = cus;
					r.iconType = IconType.warning;
				}
				return r;
			}
		}
	}
}
