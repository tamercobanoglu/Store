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
    class HelperOrder
    {
        public static Orders GetOrder(int orderID) {
            using (StoreEntities s = new StoreEntities()) {
                return s.Orders.Where(x => x.orderID == orderID).FirstOrDefault();
            }
        }

        public static OrderModel GetOrderModel(int orderID) {
            using (StoreEntities s = new StoreEntities()) {
                var dbOrd = s.Orders.Where(x => x.orderID == orderID).FirstOrDefault();

                return ConvertToModel(dbOrd);
            }
        }

		public static string GetCusFullNameByOrderId(int orderID) {
			using (StoreEntities s = new StoreEntities()) {
				var dbOrd = s.Orders.Where(x => x.orderID == orderID).FirstOrDefault();

				return dbOrd.Customers.cFirstName + " " + dbOrd.Customers.cLastName;
			}
		}

		public static List<Orders> GetOrderList() {
            using (StoreEntities s = new StoreEntities()) {
                return s.Orders.ToList();
            }
        }

        public static List<int> ActiveCustomersList() {
            using (StoreEntities s = new StoreEntities()) {
                List<int> list = new List<int>();

                foreach (var item in GetOrderList()) list.Add(Convert.ToInt32(item.Customers.customerID));
                return list;
            }
        }

        public static List<OrderModel> GetOrderModelList(int cusID, string status) {
            using (StoreEntities s = new StoreEntities()) {
                var dbList = s.Orders.Where(x => x.orderStatus == status && x.Customers.customerID == cusID).ToList();

                return ConvertToModelList(dbList);
            }
        }

        public static OrderModel ConvertToModel(Orders dbOrd) {
            OrderModel om = new OrderModel();
            om.orderID = dbOrd.orderID;
            om.orderDate = dbOrd.orderDate;
            om.orderStatus = dbOrd.orderStatus;
            om.amount = dbOrd.amount;

            om.Customers.customerID = dbOrd.Customers.customerID;
            om.Customers.cFirstName = dbOrd.Customers.cFirstName;
            om.Customers.cLastName = dbOrd.Customers.cLastName;

            return om;
        }

        public static List<OrderModel> ConvertToModelList(List<Orders> dbList)
        {
            List<OrderModel> omList = new List<OrderModel>();

            foreach (var item in dbList) omList.Add(ConvertToModel(item));
            return omList;
        }

        public static bool CUD(Orders e, EntityState state) {
            using (StoreEntities s = new StoreEntities()) {
                s.Entry(e).State = state;
                if (s.SaveChanges() > 0) return true;
                return false;
            }
        }
    }
}
