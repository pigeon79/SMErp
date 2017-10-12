using System;
using G.Data.Definition;
using G.Data.Model.Handler;

namespace G.Entity.ERP
{
    public class DM_GX : DbObjectModel<DM_GX, int>
    {
        public DM_GX()
        {
            GXDM = "";
            GXNAME = "";
            PY = "";
            GZXS = 0;
            CL = 0;
            STOPTAG = false;
        }
        [AllowNull]
        [Length(50)]
        public string GXDM { get; set; }
        [Length(100)]
        public string GXNAME { get; set; }
        [AllowNull]
        [Length(50)]
        public string PY { get; set; }
        public System.Decimal? GZXS { get; set; }
        public System.Decimal? CL { get; set; }
        public bool? STOPTAG { get; set; }
    }
}
