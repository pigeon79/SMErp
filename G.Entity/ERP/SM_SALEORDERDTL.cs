using System;
using G.Data.Definition;
using G.Data.Model.Handler;

namespace G.Entity.ERP
{
    [DbView("SM_SALEORDERDTL_V1")]
    public class SM_SALEORDERDTL : DbObjectModel<SM_SALEORDERDTL, int>
    {
        public SM_SALEORDERDTL()
        {
            //SALEORDERID = 0;
            ORDERID = "";
            ORDLNNO = 0;
            ITEMCODE = "";
            COLOR = "";
            TCOLORA = "";
            TCOLORANAME = "";
            TCOLORB = "";
            TCOLORANAME = "";
            SIZEA = 0;
            MOULDA = "";
            MOULDB = "";
            MOULDC = "";
            MOULDD = "";
            STYLENO = "";
            LNQTY = 0;
            BASICPRICE = 0;
            MOULDPRICE = 0;
            TCOLORPRICE = 0;
            OTHERPRICE = 0;
            PLANPRICE = 0;
            LNPRICE = 0;
            LNAMOUNT = 0;
            NEEDING = "";
            LNDISCOUNT = 0;
            SAMPLETAG = false;
            QCTAG = false;
        }
        [BelongsTo, DbColumn("SALEORDERID")]
        public SM_SALEORDER SALEORDER { get; set; }
        [Length(10), AllowNull]
        public string ORDERID { get; set; }
        public int ORDLNNO { get; set; }
        [Length(10), AllowNull]
        public string ITEMCODE { get; set; }
        [QueryRequired, AllowNull]
        public string ITEMNAME { get; set; }
        [AllowNull]
        [Length(10)]
        public string COLOR { get; set; }
        [AllowNull]
        [Length(10)]
        public string TCOLORA { get; set; }
        [Length(10), QueryRequired]
        public string TCOLORANAME { get; set; }
        [AllowNull]
        [Length(10)]
        public string TCOLORB { get; set; }
        [Length(10), QueryRequired,AllowNull]
        public string TCOLORBNAME { get; set; }
        public System.Decimal? SIZEA { get; set; }
        [AllowNull]
        [Length(10)]
        public string MOULDA { get; set; }
        [Length(10), QueryRequired,AllowNull]
        public string MOULDANAME { get; set; }
        [AllowNull]
        [Length(10)]
        public string MOULDB { get; set; }
        [Length(10), QueryRequired,AllowNull]
        public string MOULDBNAME { get; set; }
        [AllowNull]
        [Length(10)]
        public string MOULDC { get; set; }
        [Length(10), QueryRequired, AllowNull]
        public string MOULDCNAME { get; set; }
        [AllowNull]
        [Length(10)]
        public string MOULDD { get; set; }
        [Length(10), QueryRequired, AllowNull]
        public string MOULDDNAME { get; set; }
        [AllowNull]
        [Length(10)]
        public string STYLENO { get; set; }
        public System.Decimal? LNQTY { get; set; }
        public System.Decimal? BASICPRICE { get; set; }
        public System.Decimal? MOULDPRICE { get; set; }
        public System.Decimal? TCOLORPRICE { get; set; }
        public System.Decimal? OTHERPRICE { get; set; }
        public System.Decimal? ADDPRICE { get { return TCOLORPRICE.GetValueOrDefault(0) + OTHERPRICE.GetValueOrDefault(0); } }
        public System.Decimal? PLANPRICE { get; set; }
        public System.Decimal? LNPRICE { get; set; }
        public System.Decimal? LNAMOUNT { get; set; }
        [AllowNull]
        [Length(500)]
        public string NEEDING { get; set; }
        public System.Decimal? LNDISCOUNT { get; set; }
        public bool? SAMPLETAG { get; set; }
        public bool? QCTAG { get; set; }
    }

}