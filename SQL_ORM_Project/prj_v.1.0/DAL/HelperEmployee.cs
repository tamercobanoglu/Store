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
    class HelperEmployee
    {
        public static Employees GetEmployee(int employeeID) {
            using (StoreEntities s = new StoreEntities()) {
                return s.Employees.Where(x => x.employeeID == employeeID).FirstOrDefault();
            }
        }

		public static EmployeeModel GetEmployeeModel(int employeeID) {
			using (StoreEntities s = new StoreEntities()) {
				var dbEmp = s.Employees.Where(x => x.employeeID == employeeID).FirstOrDefault();

				return ConvertToModel(dbEmp);
			}
		}

		public static List<Employees> GetEmployeeList() {
			using (StoreEntities s = new StoreEntities()) {
				return s.Employees.ToList();
			}
		}

		public static List<EmployeeModel> GetEmployeeModelList() {
            using (StoreEntities s = new StoreEntities()) {
                var dbList = s.Employees.ToList();

                return ConvertToModelList(dbList);
            }
        }

		public static EmployeeModel ConvertToModel(Employees dbEmp)
		{
			EmployeeModel em = new EmployeeModel();
            em.employeeID = dbEmp.employeeID;
			em.eUserName = dbEmp.eUserName;
			em.eUserPassword = dbEmp.eUserPassword;
			em.eFirstName = dbEmp.eFirstName;
			em.eLastName = dbEmp.eLastName;
			em.email = dbEmp.email;
			em.officeCode = dbEmp.officeCode;
			em.jobTitle = dbEmp.jobTitle;

			em.Signin.signinID = dbEmp.Signin.signinID;
			em.Signin.userName = dbEmp.Signin.userName;
			em.Signin.userPassword = dbEmp.Signin.userPassword;
			em.Signin.userType = dbEmp.Signin.userType;

			return em;
		}

		public static List<EmployeeModel> ConvertToModelList(List<Employees> dbList) {
            List<EmployeeModel> emList = new List<EmployeeModel>();

            foreach (var item in dbList) emList.Add(ConvertToModel(item));
            return emList;
        }

		public static Employees Item(List<Employees> List, string username, string password)
		{
			Employees newItem = null;
			foreach (var item in List) {
				if (item.eUserName == username) {
					if (item.eUserPassword == password) {
						newItem = item;
						break;
					}
				}
			}
			return newItem;
		}

        public static bool CUD(Employees e, EntityState state) {
            using (StoreEntities s = new StoreEntities()) {
                s.Entry(e).State = state;
                if (s.SaveChanges() > 0) return true;
                return false;
            }
        }
    }
}
