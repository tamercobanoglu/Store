using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prj_v._1._0.Entity;

namespace prj_v._1._0.Model
{
    class SubCateModel
    {
        public int subCateID { get; set; }
        public string subCateName { get; set; }
        public Nullable<int> cateID { get; set; }

        public Cate Cate = new Cate();
    }
}
