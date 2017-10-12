using System;
using G.Data.Definition;
using G.Data.Model.Handler;

namespace G.Entity.ERP
{
    [DbView("SM_SHIPVOUCHERDTL_V1")]
    public class SM_SHIPVOUCHERDTL : DbObjectModel<SM_SHIPVOUCHERDTL, int>
    {
        public SM_SHIPVOUCHERDTL()
        {
            SHIPVID = "";
            SHIPVLNNO = 0;
            POLNNO = 0;
            ITEMCODE = "";
            INVUNIT = "";
            SHIPTYPE = "";
            CURRCODE = "";
            EXCHRATE = 0;
            SHIPAMOUNTO = 0;
            SHIPAMOUNT = 0;
            PRICE = 0;
            QUQTY = 0;
            CHECKEDQTY = 0;
            SHFINQTY = 0;
            ELSEQTY = 0;
            CHECKFLAG = false;
            INVOICEQTY = 0;
            ISREP = false;
            LOT = "";
            SLOT = "";
            POINVOICEID = "";
            WRHSCODE = "";
            LOCCODE = "";
            UDFITEM = "";
            ISINOUT = false;
            PURPRICE = 0;
            ATTRIBUTEA = "";
            ATTRIBUTEB = "";
            ATTRIBUTEC = 0;
            ATTRIBUTED = "";
            ATTRIBUTEE = "";
            SHWEIGHT = 0;
            CAUSE = "";
            PREPURQTY = 0;
            KGRATE = 0;
            REMARKS = "";
            BOMTEMPID = 0;
        }
        [BelongsTo, DbColumn("SHIPVOUCHERID")]
        public SM_SHIPVOUCHER SHIPVOUCHER { get; set; }

        [Length(11)]
        public string SHIPVID { get; set; }
        public int SHIPVLNNO { get; set; }
        public int? POLNNO { get; set; }
        [AllowNull]
        [Length(18)]
        public string ITEMCODE { get; set; }
        [AllowNull]
        [Length(4)]
        public string INVUNIT { get; set; }
        [AllowNull]
        [Length(4)]
        public string SHIPTYPE { get; set; }
        [AllowNull]
        [Length(4)]
        public string CURRCODE { get; set; }
        public System.Decimal? EXCHRATE { get; set; }
        public System.Decimal? SHIPAMOUNTO { get; set; }
        public System.Decimal? SHIPAMOUNT { get; set; }
        public System.Decimal? PRICE { get; set; }
        public System.Decimal? QUQTY { get; set; }
        public System.Decimal? CHECKEDQTY { get; set; }
        public System.Decimal? SHFINQTY { get; set; }
        public System.Decimal? ELSEQTY { get; set; }
        public bool CHECKFLAG { get; set; }
        public System.Decimal? INVOICEQTY { get; set; }
        public bool? ISREP { get; set; }
        [AllowNull]
        [Length(15)]
        public string LOT { get; set; }
        [AllowNull]
        [Length(15)]
        public string SLOT { get; set; }
        [AllowNull]
        [Length(10)]
        public string POINVOICEID { get; set; }
        [AllowNull]
        [Length(2)]
        public string WRHSCODE { get; set; }
        [AllowNull]
        [Length(5)]
        public string LOCCODE { get; set; }
        [AllowNull]
        [Length(15)]
        public string UDFITEM { get; set; }
        public bool? ISINOUT { get; set; }
        public System.Decimal? PURPRICE { get; set; }
        [AllowNull]
        [Length(40)]
        public string ATTRIBUTEA { get; set; }
        [AllowNull]
        [Length(40)]
        public string ATTRIBUTEB { get; set; }
        public System.Decimal? ATTRIBUTEC { get; set; }
        [AllowNull]
        [Length(20)]
        public string ATTRIBUTED { get; set; }
        [AllowNull]
        [Length(20)]
        public string ATTRIBUTEE { get; set; }
        public System.Decimal? SHWEIGHT { get; set; }
        [AllowNull]
        [Length(100)]
        public string CAUSE { get; set; }
        public System.Decimal? PREPURQTY { get; set; }
        public System.Decimal? KGRATE { get; set; }
        [AllowNull]
        [Length(500)]
        public string REMARKS { get; set; }

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
        public int? BOMTEMPID { get; set; }
        [QueryRequired]
        public System.Decimal? UNFINISHQTY { get; set; }
    }

}
