using System;
using G.Data.Definition;
using G.Data.Model.Handler;

namespace G.Entity.ERP
{
    public class DM_WHBLB : DbObjectModel<DM_WHBLB, int>
    {
        public DM_WHBLB()
        {
            WHLBDM = "";
            WHLBNAME = "";
            PRIORCLASSDM = "";
            PY = "";
            SYSTEM = 0;
            ZTNAME = "";
            PARENTID = 0;
            ISDETAIL = 0;
            SORTID = 0;
            TREELEVEL = 0;
        }
        [AllowNull]
        [Length(50)]
        public string WHLBDM { get; set; }
        [AllowNull]
        [Length(100)]
        public string WHLBNAME { get; set; }
        [AllowNull]
        [Length(30)]
        public string PRIORCLASSDM { get; set; }
        [AllowNull]
        [Length(20)]
        public string PY { get; set; }
        public int? SYSTEM { get; set; }
        [AllowNull]
        [Length(50)]
        public string ZTNAME { get; set; }
        public int? PARENTID { get; set; }
        public int? ISDETAIL { get; set; }
        public int? SORTID { get; set; }
        public int? TREELEVEL { get; set; }
    }
}
