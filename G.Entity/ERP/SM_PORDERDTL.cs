using System;
using G.Data.Definition;
using G.Data.Model.Handler;

namespace G.Entity.ERP
{
    [DbView("SM_PORDERDTL_V1")]
    public class SM_PORDERDTL : DbObjectModel<SM_PORDERDTL, int>
    {
        public SM_PORDERDTL()
        {
            POID = "";
            POLNNO = 0;
            PREPURORDID = "";
            ITEMCODE = "";
            SITEMCODE = "";
            INVUNIT = "";
            PREPURQTY = 0;
            PURPRICE = 0;
            PORTOTTAL = 0;
            PREPURQTYA = 0;
            DEMANDDATE = null;
            SHIPDATE = null;
            SHIPQTY = 0;
            SHIFTQTY = 0;
            DQQTY = 0;
            DEPCODE = "";
            CUSTOMER = "";
            DELADCODE = "";
            SHIPTYPE = "";
            LNSTATUS = "";
            REMARK = "";
            ORDERID = "";
            ATTRIBUTEA = "";
            ATTRIBUTEB = "";
            ATTRIBUTEC = 0;
            ATTRIBUTED = "";
            ATTRIBUTEE = "";
            KGRATE = 0;
            BOMTEMPID = 0;
        }
        [BelongsTo, DbColumn("PORDERID")]
        public SM_PORDER PORDER { get; set; }
        [Length(10)]
        public string POID { get; set; }
        public int POLNNO { get; set; }
        [AllowNull]
        [Length(10)]
        public string PREPURORDID { get; set; }
        [Length(18)]
        public string ITEMCODE { get; set; }
        [AllowNull]
        [Length(20)]
        public string SITEMCODE { get; set; }
        [Length(4)]
        public string INVUNIT { get; set; }
        public System.Decimal PREPURQTY { get; set; }
        public System.Decimal PURPRICE { get; set; }
        public System.Decimal PORTOTTAL { get; set; }
        public System.Decimal PREPURQTYA { get; set; }
        public DateTime? DEMANDDATE { get; set; }
        public DateTime? SHIPDATE { get; set; }
        public System.Decimal SHIPQTY { get; set; }
        public System.Decimal SHIFTQTY { get; set; }
        public System.Decimal DQQTY { get; set; }
        [AllowNull]
        [Length(4)]
        public string DEPCODE { get; set; }
        [AllowNull]
        [Length(8)]
        public string CUSTOMER { get; set; }
        [AllowNull]
        [Length(4)]
        public string DELADCODE { get; set; }
        [AllowNull]
        [Length(4)]
        public string SHIPTYPE { get; set; }
        [AllowNull]
        [Length(1)]
        public string LNSTATUS { get; set; }
        [AllowNull]
        [Length(200)]
        public string REMARK { get; set; }
        [AllowNull]
        [Length(11)]
        public string ORDERID { get; set; }
        [AllowNull]
        [Length(50)]
        public string ATTRIBUTEA { get; set; }
        [AllowNull]
        [Length(20)]
        public string ATTRIBUTEB { get; set; }
        public System.Decimal? ATTRIBUTEC { get; set; }
        [AllowNull]
        [Length(20)]
        public string ATTRIBUTED { get; set; }
        [AllowNull]
        [Length(50)]
        public string ATTRIBUTEE { get; set; }
        public System.Decimal? KGRATE { get; set; }

        [QueryRequired, AllowNull]
        public string ITEMNAME { get; set; }
        [QueryRequired, AllowNull]
        public string ATTRIBUTEBNAME { get; set; }
        [QueryRequired]
        public bool ISATTRIBUTEA { get; set; }
        [QueryRequired]
        public bool ISATTRIBUTEB { get; set; }
        [QueryRequired]
        public bool ISATTRIBUTEC { get; set; }
        public int? BOMTEMPID { get; set; }
    }
}
