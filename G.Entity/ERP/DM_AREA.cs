using System;
using G.Data.Definition;
using G.Data.Model.Handler;

namespace G.Entity.ERP
{
    public class DM_AREA : DbObjectModel<DM_AREA,int>
    {
        public DM_AREA()
        {
            IDDQLB = 0;
            DQDM = "";
            DQNAME = "";
            PY = "";
            PRIORLBDM = "";
            LBID = 0;
            TYBZ = 0;
        }
        public int? IDDQLB { get; set; }
        [AllowNull]
        [Length(50)]
        public string DQDM { get; set; }
        [AllowNull]
        [Length(100)]
        public string DQNAME { get; set; }
        [AllowNull]
        [Length(20)]
        public string PY { get; set; }
        [AllowNull]
        [Length(50)]
        public string PRIORLBDM { get; set; }
        public int? LBID { get; set; }
        public int? TYBZ { get; set; }
    }


}
