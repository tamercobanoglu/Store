using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prj_v._1._0.Model;
using prj_v._1._0.Entity;

namespace prj_v._1._0.DAL
{
    class HelperSubCate
    {
        public static SubCate GetSubCate(int subCateID) {
            using (StoreEntities s = new StoreEntities()) {
                return s.SubCate.Where(x => x.subCateID == subCateID).FirstOrDefault();
            }
        }

        public static SubCateModel GetSubCateModel(int subCateID) {
            using (StoreEntities s = new StoreEntities()) {
                var dbSub = s.SubCate.Where(x => x.subCateID == subCateID).FirstOrDefault();

                return ConvertToModel(dbSub);
            }
        }

        public static List<SubCate> GetSubCateList() {
            using (StoreEntities s = new StoreEntities()) {
                return s.SubCate.ToList();
            }
        }

        public static List<SubCateModel> GetSubCateModelList(int cateID) {
            using (StoreEntities s = new StoreEntities()) {
                var dbList = s.SubCate.Where(x => x.cateID == cateID).ToList();

                return ConvertToModelList(dbList);
            }
        }

        public static SubCateModel ConvertToModel(SubCate dbSub)
        {
            SubCateModel scm = new SubCateModel();
            scm.subCateID = dbSub.subCateID;
            scm.subCateName = dbSub.subCateName;

            scm.Cate.cateID = dbSub.Cate.cateID;
            scm.Cate.cateName = dbSub.Cate.cateName;

            return scm;
        }

        public static List<SubCateModel> ConvertToModelList(List<SubCate> dbList) {
            List<SubCateModel> scmList = new List<SubCateModel>();

            foreach (var item in dbList) scmList.Add(ConvertToModel(item));
            return scmList;
        }
    }
}
