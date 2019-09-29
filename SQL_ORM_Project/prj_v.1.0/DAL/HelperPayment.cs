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
    class HelperPayment
    {
        public static Payment GetPayment(int paymentID) {
            using (StoreEntities s = new StoreEntities()) {
                return s.Payment.Where(x => x.paymentID == paymentID).FirstOrDefault();
            }
        }

        public static double GetAmountPayed(int orderID) {
            using (StoreEntities s = new StoreEntities()) {
                double payed = 0;
                var list = s.Payment.Where(x => x.orderID == orderID).ToList();
                foreach (var item in list) payed += Convert.ToDouble(item.amountPayed);
                return payed;
            }
        }

        public static Payment GetPaymentByOrderID(int orderID) {
            using (StoreEntities s = new StoreEntities()) {
                return s.Payment.Where(x => x.orderID == orderID).FirstOrDefault();
            }
        }

        public static PaymentModel GetPaymentModel(int paymentID) {
            using (StoreEntities s = new StoreEntities()) {
                var dbPay = s.Payment.Where(x => x.paymentID == paymentID).FirstOrDefault();

                return ConvertToModel(dbPay);
            }
        }

        public static List<Payment> GetPaymentList(int orderID) {
            using (StoreEntities s = new StoreEntities()) {
                return s.Payment.Where(x => x.orderID == orderID).ToList();
            }
        }

        public static List<PaymentModel> GetPaymentModelList() {
            using (StoreEntities s = new StoreEntities()) {
                var dbList = s.Payment.ToList();

                return ConvertToModelList(dbList);
            }
        }

        public static PaymentModel ConvertToModel(Payment dbPay) {
            PaymentModel pym = new PaymentModel();
            pym.paymentID = dbPay.paymentID;
            pym.paymentDate = dbPay.paymentDate;
            pym.amountPayed = dbPay.amountPayed;

            pym.Customers.customerID = dbPay.Customers.customerID;
            pym.Customers.cFirstName = dbPay.Customers.cFirstName;
            pym.Customers.cLastName = dbPay.Customers.cLastName;

            pym.Orders.orderID = dbPay.Orders.orderID;
            pym.Orders.orderDate = dbPay.Orders.orderDate;
            pym.Orders.orderStatus = dbPay.Orders.orderStatus;
            pym.Orders.customerID = dbPay.Orders.customerID;

            return pym;
        }

        public static List<PaymentModel> ConvertToModelList(List<Payment> dbList) {
            List<PaymentModel> pymList = new List<PaymentModel>();

            foreach (var item in dbList) pymList.Add(ConvertToModel(item));
            return pymList;
        }

        public static bool CUD(Payment e, EntityState state) {
            using (StoreEntities s = new StoreEntities()) {
                s.Entry(e).State = state;
                if (s.SaveChanges() > 0) return true;
                return false;
            }
        }
    }
}
