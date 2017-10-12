using System;
using G.Data.Definition;
using G.Data.Model.Handler;

namespace G.Entity.ERP
{
    [DbView("SM_ASSISTMENTRYDTL_V1")]
    public class SM_ASSISTMENTRYDTL : DbObjectModel<SM_ASSISTMENTRYDTL, int>
    {
        public SM_ASSISTMENTRYDTL()
        {
            ASSISTMECODE = "";
            LNNO = 0;
            ASSISTMSLNNO = 0;
            ITEMCODE = "";
            ATTRIBUTEA = "";
            ATTRIBUTEB = "";
            ATTRIBUTEC = 0;
            ATTRIBUTED = "";
            NEEDING = "";
            FACTQTY = 0;
            CHECKQTY = 0;
            WRHSCODE = "";
            LOCCODE = "";
            KGQTY = 0;
            RATE = 0;
            UNIT = "";
            REMARK = "";
        }
        [BelongsTo, DbColumn("ASSISTMENTRYID")]
        public SM_ASSISTMENTRY ASSISTMENTRY { get; set; }
        [AllowNull]
        [Length(50)]
        public string ASSISTMECODE { get; set; }
        public int? LNNO { get; set; }
        public int? ASSISTMSLNNO { get; set; }
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
        public System.Decimal? FACTQTY { get; set; }
        public System.Decimal? CHECKQTY { get; set; }
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
        [AllowNull]
        [Length(500)]
        public string REMARK { get; set; }

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
    }
}
