using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prj_v._1._0.Entity;

namespace prj_v._1._0.DAL
{
    class HelperCate
    {
        public static Cate GetCate(int cateID) {
            using (StoreEntities s = new StoreEntities()) {
                return s.Cate.Where(x => x.cateID == cateID).FirstOrDefault();
            }
        }

        public static List<Cate> GetCateList() {
            using (StoreEntities s = new StoreEntities()) {
                return s.Cate.ToList();
            }
        }
    }
}
