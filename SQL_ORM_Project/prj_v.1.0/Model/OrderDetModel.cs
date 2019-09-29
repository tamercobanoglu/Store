using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prj_v._1._0.Entity;

namespace prj_v._1._0.Model
{
    class OrderDetModel
    {
        public int orderDetailID { get; set; }
        public Nullable<int> productID { get; set; }
        public Nullable<double> priceEach { get; set; }
        public Nullable<int> quantityOrdered { get; set; }
        public Nullable<int> orderID { get; set; }
        public Nullable<int> employeeID { get; set; }

        public Employees Employees = new Employees();
        public Orders Orders = new Orders();
        public Products Products = new Products();
    }
}
