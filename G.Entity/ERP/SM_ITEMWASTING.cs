using System;
using G.Data.Definition;
using G.Data.Model.Handler;

namespace G.Entity.ERP
{
    [DbView("SM_ITEMWASTING_V1")]
    public class SM_ITEMWASTING : DbObjectModel<SM_ITEMWASTING, int>
    {
        public SM_ITEMWASTING()
        {
            ITEMTYPEID = 0;
            FQTY = 0;
            TQTY = 0;
            WASTING = 0;
        }
        public int? ITEMTYPEID { get; set; }
        public int? FQTY { get; set; }
        public int? TQTY { get; set; }
        public System.Decimal? WASTING { get; set; }

        [QueryRequired, AllowNull]
        public string ITEMTYPENAME { get; set; }
    }
}
