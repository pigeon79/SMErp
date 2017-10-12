using System;
using G.Data.Definition;
using G.Data.Model.Handler;
using System.Collections.Generic;

namespace G.Entity.ERP
{
    public class DM_WAREHOUSE : DbObjectModel<DM_WAREHOUSE, int>
    {
        [Length(50)]
        public string WRHSCODE { get; set; }
        [AllowNull]
        [Length(100)]
        public string WRHSNAME { get; set; }
        [AllowNull]
        [Length(20)]
        public string PY { get; set; }
        [AllowNull]
        [Length(100)]
        public string ADDRESS { get; set; }
        [AllowNull]
        [Length(50)]
        public string TEL { get; set; }
        public int? LBID { get; set; }
        public bool? USETAG { get; set; }
        [AllowNull]
        [Length(50)]
        public string MANAGER { get; set; }
        public int? ISMRP { get; set; }
        public int? ISALLOC { get; set; }
        //[HasOne(OrderBy = "ID")]
        //public DM_LOCATION LOCATION { get; set; }
    }


}
