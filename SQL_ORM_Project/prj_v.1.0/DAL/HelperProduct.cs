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
    class HelperProduct
    {
        public static Products GetProduct(int productID) {
            using (StoreEntities s = new StoreEntities()) {
                return s.Products.Where(x => x.productID == productID).FirstOrDefault();
            }
        }

        public static int GetProIdByName(string proName) {
            using (StoreEntities s = new StoreEntities()) {
                var pro = s.Products.Where(x => x.proName == proName).FirstOrDefault();
                return pro.productID;
            }
        }

        public static ProductModel GetProductModel(int productID) {
            using (StoreEntities s = new StoreEntities()) {
                var dbPro = s.Products.Where(x => x.productID == productID).FirstOrDefault();

                return ConvertToModel(dbPro);
            }
        }

        public static List<Products> GetProductsList() {
            using (StoreEntities s = new StoreEntities()) {
                return s.Products.ToList();
            }
        }

        public static List<ProductModel> GetProductModelList() {
            using (StoreEntities s = new StoreEntities()) {
                var dbList = s.Products.ToList();

                return ConvertToModelList(dbList);
            }
        }

        public static List<ProductModel> GetProductbySubCateModelList(int subCateID) {
            using (StoreEntities s = new StoreEntities()) {
                var dbList = s.Products.Where(x => x.subCateID == subCateID).ToList();

                return ConvertToModelList(dbList);
            }
        }

        public static ProductModel ConvertToModel(Products dbPro) {
            ProductModel pm = new ProductModel();
            pm.productID = dbPro.productID;
            pm.proName = dbPro.proName;
            pm.proPrice = dbPro.proPrice;
            pm.quantity = dbPro.quantity;

            pm.SubCate.subCateID = dbPro.SubCate.subCateID;
            pm.SubCate.subCateName = dbPro.SubCate.subCateName;

            pm.Cate.cateID = dbPro.Cate.cateID;
            pm.Cate.cateName = dbPro.Cate.cateName;

            return pm;
        }

        public static List<ProductModel> ConvertToModelList(List<Products> dbList) {
            List<ProductModel> pmList = new List<ProductModel>();

            foreach (var item in dbList) pmList.Add(ConvertToModel(item));
            return pmList;
        }

        public static bool CUD(Products e, EntityState state) {
            using (StoreEntities s = new StoreEntities()) {
                s.Entry(e).State = state;
                if (s.SaveChanges() > 0) return true;
                return false;
            }
        }
    }
}
