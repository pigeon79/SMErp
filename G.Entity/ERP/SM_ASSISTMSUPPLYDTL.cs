using System;
using G.Data.Definition;
using G.Data.Model.Handler;

namespace G.Entity.ERP
{
    [DbView("SM_ASSISTMSUPPLYDTL_V1")]
    public class SM_ASSISTMSUPPLYDTL : DbObjectModel<SM_ASSISTMSUPPLYDTL, int>
    {
        public SM_ASSISTMSUPPLYDTL()
        {
            ASSISTMSCODE = "";
            LNNO = 0;
            ITEMCODE = "";
            ATTRIBUTEA = "";
            ATTRIBUTEB = "";
            ATTRIBUTEC = 0;
            ATTRIBUTED = "";
            NEEDING = "";
            PLANQTY = 0;
            FACTQTY = 0;
            WRHSCODE = "";
            LOCCODE = "";
            KGQTY = 0;
            RATE = 0;
            UNIT = "";
            BOMTEMPID = 0;
            REMARK = "";
            ENTRYQTY = 0;
        }
        [BelongsTo, DbColumn("ASSISTMSUPPLYID")]
        public SM_ASSISTMSUPPLY ASSISTMSUPPLY { get; set; }
        [AllowNull]
        [Length(50)]
        public string ASSISTMSCODE { get; set; }
        public int? LNNO { get; set; }
        [AllowNull]
        [Length(20)]
        public string ITEMCODE { get; set; }
        [AllowNull]
        [Length(50)]
        public string ATTRIBUTEA { get; set; }
        [AllowNull]
        [Length(50)]
        public string ATTRIBUTEB { get; set; }
        public System.Decimal? ATTRIBUTEC { get; set; }
        [AllowNull]
        [Length(20)]
        public string ATTRIBUTED { get; set; }
        [AllowNull]
        [Length(500)]
        public string NEEDING { get; set; }
        public System.Decimal? PLANQTY { get; set; }
        public System.Decimal? FACTQTY { get; set; }
        [AllowNull]
        [Length(50)]
        public string WRHSCODE { get; set; }
        [AllowNull]
        [Length(50)]
        public string LOCCODE { get; set; }
        public System.Decimal? KGQTY { get; set; }
        public System.Decimal? RATE { get; set; }
        [AllowNull]
        [Length(50)]
        public string UNIT { get; set; }
        public int? BOMTEMPID { get; set; }
        [AllowNull]
        [Length(500)]
        public string REMARK { get; set; }
        public decimal? ENTRYQTY { get; set; }

        [QueryRequired, AllowNull]
        public string ITEMNAME { get; set; }
        [QueryRequired, AllowNull]
        public string WRHSNAME { get; set; }
        [QueryRequired, AllowNull]
        public string LOCNAME { get; set; }
        [QueryRequired, AllowNull]
        public string ATTRIBUTEBNAME { get; set; }
        [QueryRequired]
        public bool ISATTRIBUTEA { get; set; }
        [QueryRequired]
        public bool ISATTRIBUTEB { get; set; }
        [QueryRequired]
        public bool ISATTRIBUTEC { get; set; }
        [QueryRequired]
        public System.Decimal? LEFTQTY { get; set; }
    }
}
