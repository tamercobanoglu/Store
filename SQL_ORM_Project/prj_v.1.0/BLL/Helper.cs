using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prj_v._1._0.DAL;

namespace prj_v._1._0.BLL
{
	static class Helper
	{
		public static int countUser = HelperSignin.GetUserEmpList().Count + HelperSignin.GetUserCusList().Count;
		public static int countEmp = HelperSignin.GetUserEmpList().Count;
		public static int countCus = HelperSignin.GetUserCusList().Count;

        public static bool isNumber(string text) {
            foreach (char chr in text) {
                if (!Char.IsNumber(chr)) return false;
            }
            return true;
        }
    }
}
