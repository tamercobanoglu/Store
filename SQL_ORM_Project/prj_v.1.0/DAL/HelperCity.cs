using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prj_v._1._0.Entity;

namespace prj_v._1._0.DAL
{
    class HelperCity
    {
        public static City GetCity(int cityID) {
            using (StoreEntities s = new StoreEntities()) {
                return s.City.Where(x => x.cityID == cityID).FirstOrDefault();
            }
        }

        public static List<City> GetCityList() {
            using (StoreEntities s = new StoreEntities()) {
                return s.City.ToList();
            }
        }
    }
}
