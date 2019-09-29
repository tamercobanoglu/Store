using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using prj_v._1._0.Entity;

namespace prj_v._1._0.DAL
{
    class HelperSignin
    {
		public static Signin GetUser(int signinID) {
			using (StoreEntities s = new StoreEntities()) {
				return s.Signin.Where(x => x.signinID == signinID).FirstOrDefault();
			}
		}

		public static Signin GetUserEmp(int signinID) {
            using (StoreEntities s = new StoreEntities()) {
                return s.Signin.Where(x => x.signinID == signinID && x.userType == 1).FirstOrDefault();
            }
        }

        public static Signin GetUserCus(int signinID) {
            using (StoreEntities s = new StoreEntities()) {
                return s.Signin.Where(x => x.signinID == signinID && x.userType == 2).FirstOrDefault();
            }
        }

        public static List<string> GetUserNameList() {
            List<string> list = new List<string>();
            using (StoreEntities s = new StoreEntities()) {
                foreach (var item in s.Signin.ToList()) {
                    list.Add(item.userName);
                }
            }
            return list;
        }

        public static List<Signin> GetUserEmpList() {
            List<Signin> List = new List<Signin>();
            using (StoreEntities s = new StoreEntities()) {
                foreach (var item in s.Signin.ToList()) {
                    if (item.userType == 1) List.Add(item);
                }
                return List;
            }
        }

        public static List<Signin> GetUserCusList() {
            List<Signin> List = new List<Signin>();
            using (StoreEntities s = new StoreEntities()) {
                foreach (var item in s.Signin.ToList()) {
                    if (item.userType == 2) List.Add(item);
                }
                return List;
            }
        }

        public static bool CUD(Signin u, EntityState state) {
            using (StoreEntities s = new StoreEntities()) {
                s.Entry(u).State = state;
                if (s.SaveChanges() > 0) return true;
                return false;
            }
        }
    }
}
