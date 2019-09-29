using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prj_v._1._0.Entity;

namespace prj_v._1._0.Model
{
    class PaymentModel
    {
        public int paymentID { get; set; }
        public Nullable<System.DateTime> paymentDate { get; set; }
        public Nullable<double> amountPayed { get; set; }
        public Nullable<int> customerID { get; set; }
        public Nullable<int> orderID { get; set; }

        public Customers Customers = new Customers();
        public Orders Orders = new Orders();
    }
}
