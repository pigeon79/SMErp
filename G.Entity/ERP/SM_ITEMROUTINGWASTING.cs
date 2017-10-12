using System;
using G.Data.Definition;
using G.Data.Model.Handler;

namespace G.Entity.ERP
{
    [DbView("SM_ITEMROUTINGWASTING_V1")]
    public class SM_ITEMROUTINGWASTING : DbObjectModel<SM_ITEMROUTINGWASTING, int>
    {
        public SM_ITEMROUTINGWASTING()
        {
            ITEMROUTINGID = 0;
            FQTY = 0;
            TQTY = 0;
            WASTING = 0;
        }
        public int? ITEMROUTINGID { get; set; }
        public int? FQTY { get; set; }
        public int? TQTY { get; set; }
        public System.Decimal? WASTING { get; set; }

        [AllowNull]
        [QueryRequired]
        public string GXNAME { get; set; }
        [AllowNull]
        [QueryRequired]
        public string ITEMTYPENAME { get; set; }
    }
}
