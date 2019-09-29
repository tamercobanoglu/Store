using prj_v._1._0.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj_v._1._0.Model
{
    class EmployeeModel
    {
		public int employeeID { get; set; }
		public string eUserName { get; set; }
		public string eUserPassword { get; set; }
		public string eFirstName { get; set; }
		public string eLastName { get; set; }
		public string email { get; set; }
		public Nullable<int> officeCode { get; set; }
		public string jobTitle { get; set; }
		public Nullable<int> signinID { get; set; }

		public Signin Signin = new Signin();
	}
}
