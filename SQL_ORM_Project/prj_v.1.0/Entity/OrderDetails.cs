//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace prj_v._1._0.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrderDetails
    {
        public int orderDetailID { get; set; }
        public Nullable<int> productID { get; set; }
        public Nullable<double> priceEach { get; set; }
        public Nullable<int> quantityOrdered { get; set; }
        public Nullable<int> orderID { get; set; }
        public Nullable<int> employeeID { get; set; }
    
        public virtual Employees Employees { get; set; }
        public virtual Orders Orders { get; set; }
        public virtual Products Products { get; set; }
    }
}
