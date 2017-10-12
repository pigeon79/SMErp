using System;
using G.Data.Definition;
using G.Data.Model.Handler;

namespace G.Entity.ERP
{
    [DbView("SM_POCKETDTL_V1")]
    public class SM_POCKETDTL : DbObjectModel<SM_POCKETDTL, int>
    {
        public SM_POCKETDTL()
        {
            POCKID = "";
            POCKLNNO = 0;
            ORDERID = "";
            ORDLNNO = 0;
            ITEMCODE = "";
            UNIT = "";
            ORDQTY = 0;
            POCKETQTY = 0;
            ATTRIBUTEA = "";
            ATTRIBUTEB = "";
            ATTRIBUTEC = 0;
            ATTRIBUTED = "";
            ATTRIBUTEE = "";
            STYLENO = "";
            GIFTQTY = 0;
            BOMTEMPID = 0;
        }
        [BelongsTo, DbColumn("POCKETID")]
        public SM_POCKET POCKET { get; set; }
        [AllowNull]
        [Length(20)]
        public string POCKID { get; set; }
        public int? POCKLNNO { get; set; }
        [AllowNull]
        [Length(20)]
        public string ORDERID { get; set; }
        public int? ORDLNNO { get; set; }
        [AllowNull]
        [Length(20)]
        public string ITEMCODE { get; set; }
        [AllowNull]
        [Length(5)]
        public string UNIT { get; set; }
        public System.Decimal? ORDQTY { get; set; }
        public System.Decimal? POCKETQTY { get; set; }
        [AllowNull]
        [Length(40)]
        public string ATTRIBUTEA { get; set; }
        [AllowNull]
        [Length(40)]
        public string ATTRIBUTEB { get; set; }
        public System.Decimal? ATTRIBUTEC { get; set; }
        [AllowNull]
        [Length(40)]
        public string ATTRIBUTED { get; set; }
        [AllowNull]
        [Length(40)]
        public string ATTRIBUTEE { get; set; }
        [AllowNull]
        [Length(10)]
        public string STYLENO { get; set; }
        public System.Decimal? GIFTQTY { get; set; }
        public int? BOMTEMPID { get; set; }

        [QueryRequired, AllowNull]
        public string ITEMNAME { get; set; }
        [QueryRequired, AllowNull]
        public string ATTRIBUTEBNAME { get; set; }
        [QueryRequired]
        public System.Decimal? UNFINISHQTY { get; set; }
    }
}
