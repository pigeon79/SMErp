using System;
using G.Data.Definition;
using G.Data.Model.Handler;

namespace G.Entity.ERP
{
    [DbView("DM_PRICEBILLDTL_V1")]
    public class DM_PRICEBILLDTL : DbObjectModel<DM_PRICEBILLDTL, int>
    {
        
        public DM_PRICEBILLDTL()
        {
            ITEMCODE = "";
            ITEMNAME = "";
            BASICSIZE = 0;
            BASICPRICE = 0;
            ADDPRICE = 0;
            SUBPRICE = 0;
        }
        [Length(50)]
        public string ITEMCODE { get; set; }
        [QueryRequired]
        public string ITEMNAME { get; set; }
        public System.Decimal BASICSIZE { get; set; }
        public System.Decimal BASICPRICE { get; set; }
        public System.Decimal ADDPRICE { get; set; }
        public System.Decimal SUBPRICE { get; set; }
        [BelongsTo, DbColumn("PBILLID")]
        public DM_PRICEBILL PRICEBILL { get; set; }
    }

}
