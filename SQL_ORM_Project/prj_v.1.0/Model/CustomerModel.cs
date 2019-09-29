using prj_v._1._0.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj_v._1._0.Model
{
    class CustomerModel
    {
		public int customerID { get; set; }
		public string cUserName { get; set; }
		public string cUserPassword { get; set; }
		public string cFirstName { get; set; }
		public string cLastName { get; set; }
		public string phone { get; set; }
		public Nullable<double> creditLimit { get; set; }
		public string addressLine { get; set; }
		public string region { get; set; }
		public string city { get; set; }
		public string country { get; set; }
		public string postalCode { get; set; }
		public Nullable<int> signinID { get; set; }

		public Signin Signin = new Signin();
	}
}
