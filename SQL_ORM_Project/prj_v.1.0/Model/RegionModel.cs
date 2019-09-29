using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prj_v._1._0.Entity;

namespace prj_v._1._0.Model
{
    class RegionModel
    {
        public int regionID { get; set; }
        public string regionName { get; set; }
        public string postalCode { get; set; }
        public Nullable<int> cityID { get; set; }

        public City City = new City();
    }
}
