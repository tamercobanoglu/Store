using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prj_v._1._0.Model;
using prj_v._1._0.Entity;

namespace prj_v._1._0.DAL
{
    class HelperRegion
    {
        public static Region GetRegion(int regionID) {
            using (StoreEntities s = new StoreEntities()) {
                return s.Region.Where(x => x.regionID == regionID).FirstOrDefault();
            }
        }

        public static string GetPostalCode(int regionID) {
            using (StoreEntities s = new StoreEntities()) {
                return s.Region.Where(x => x.regionID == regionID).FirstOrDefault().postalCode;
            }
        }

        public static RegionModel GetRegionModel(int regionID) {
            using (StoreEntities s = new StoreEntities()) {
                var dbReg = s.Region.Where(x => x.regionID == regionID).FirstOrDefault();

                return ConvertToModel(dbReg);
            }
        }

        public static List<Region> GetRegionList() {
            using (StoreEntities s = new StoreEntities()) {
                return s.Region.ToList();
            }
        }

        public static List<RegionModel> GetRegionModelList(int cityID) {
            using (StoreEntities s = new StoreEntities()) {
                var dbList = s.Region.Where(x => x.cityID == cityID).ToList();

                return ConvertToModelList(dbList);
            }
        }

        public static RegionModel ConvertToModel(Region dbReg) {
            RegionModel rm = new RegionModel();
            rm.regionID = dbReg.regionID;
            rm.regionName = dbReg.regionName;
            rm.postalCode = dbReg.postalCode;

            rm.City.cityID = dbReg.City.cityID;
            rm.City.cityName = dbReg.City.cityName;

            return rm;
        }

        public static List<RegionModel> ConvertToModelList(List<Region> dbList) {
            List<RegionModel> rmList = new List<RegionModel>();

            foreach (var item in dbList) rmList.Add(ConvertToModel(item));
            return rmList;
        }
    }
}
