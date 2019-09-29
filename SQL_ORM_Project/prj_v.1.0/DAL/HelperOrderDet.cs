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
    class HelperOrderDet
    {
        public static OrderDetails GetOrderDet(int orderDetID) {
            using (StoreEntities s = new StoreEntities()) {
                return s.OrderDetails.Where(x => x.orderDetailID == orderDetID).FirstOrDefault();
            }
        }

        public static List<int> SoldProductsList() {
            using (StoreEntities s = new StoreEntities()) {
                List<int> soldProIDs = new List<int>();

                foreach (var item in GetOrderDetList()) soldProIDs.Add(Convert.ToInt32(item.productID));
                return soldProIDs;
            }
        }

        public static OrderDetModel GetOrderDetModel(int orderDetID) {
            using (StoreEntities s = new StoreEntities()) {
                var dbOrdDet = s.OrderDetails.Where(x => x.orderDetailID == orderDetID).FirstOrDefault();

                return ConvertToModel(dbOrdDet);
            }
        }

        public static List<OrderDetails> GetOrderDetList() {
            using (StoreEntities s = new StoreEntities()) {
                return s.OrderDetails.ToList();
            }
        }

        public static List<OrderDetModel> GetOrderDetModelList(int ordID) {
            using (StoreEntities s = new StoreEntities()) {
                var dbList = s.OrderDetails.Where(x => x.orderID == ordID).ToList();

                return ConvertToModelList(dbList);
            }
        }

        public static List<OrderDetModel> GetOrderDetbyEmpModelList(int empID) {
            using (StoreEntities s = new StoreEntities()) {
                var dbList = s.OrderDetails.Where(x => x.Employees.employeeID == empID).ToList();

                return ConvertToModelList(dbList);
            }
        }

        public static OrderDetModel ConvertToModel(OrderDetails dbOrdDet) {
            OrderDetModel odm = new OrderDetModel();
            odm.orderDetailID = dbOrdDet.orderDetailID;

            odm.Products.productID = dbOrdDet.Products.productID;
            odm.Products.proName = dbOrdDet.Products.proName;
            odm.Products.proPrice = dbOrdDet.Products.proPrice;

            odm.priceEach = dbOrdDet.priceEach;
            odm.quantityOrdered = dbOrdDet.quantityOrdered;
            
            odm.Orders.orderID = dbOrdDet.Orders.orderID;

            odm.Employees.employeeID = dbOrdDet.Employees.employeeID;
            odm.Employees.eFirstName = dbOrdDet.Employees.eFirstName;
            odm.Employees.eLastName = dbOrdDet.Employees.eLastName;

            return odm;
        }

        public static List<OrderDetModel> ConvertToModelList(List<OrderDetails> dbList) {
            List<OrderDetModel> odmList = new List<OrderDetModel>();

            foreach (var item in dbList) odmList.Add(ConvertToModel(item));
            return odmList;
        }

        public static bool CUD(OrderDetails e, EntityState state) {
            using (StoreEntities s = new StoreEntities()) {
                s.Entry(e).State = state;
                if (s.SaveChanges() > 0) return true;
                return false;
            }
        }
    }
}
