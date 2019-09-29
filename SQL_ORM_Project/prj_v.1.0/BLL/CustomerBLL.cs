using prj_v._1._0.DAL;
using prj_v._1._0.Entity;
using prj_v._1._0.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj_v._1._0.BLL
{
	class CustomerBLL
	{
		public static ResultSet ResultCUD(Customers cus, EntityState state)
		{
			ResultSet r = new ResultSet();
			try {
				r = HelperCustomer.ResultCUD(cus, state);
				if (r.iconType == IconType.ok) {

				}
				return r;
			}
			catch (Exception e) {
				r.Message = e.Message;
			}
			return r;
		}
	}
}
