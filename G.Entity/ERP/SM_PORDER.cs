using System;
using G.Data.Definition;
using G.Data.Model.Handler;
using System.Collections.Generic;

namespace G.Entity.ERP
{
    [DbView("SM_PORDER_V1")]
    public class SM_PORDER : DbObjectModel<SM_PORDER, int>
    {
        public SM_PORDER()
        {
            POID = "";
            SUPCODE = "";
            CURRCODE = "";
            EXCHRATE = 0;
            PERIODPAY = 0;
            SHIPTYPE = "";
            CDISCCODE = "";
            STATUS = "N";
            AUDITOR = "";
            AUDITDATE = null;
            CLOSEDATE = null;
            SHIPWRHS = "";
            PURSCODE = "";
            SETTLECODE = "";
            DELADCODE = "";
            LASTDATE = null;
            TOTALAMTO = 0;
            TOTALAMT = 0;
            LOCKTAG = false;
            OPERATOR = "";
            OPERDATE = null;
            POTYPE = "";
            INPUTFROM = "";
            PODESCCODE = "";
            CUSTORDNB = "";
            BANKMESCODE = "";
            INVOICECODE = "";
            INVOICEMONEY = 0;
            INVOICEDATE = null;
            PROJECTCOD = "";
            NEWADDRESS = "";
            SENDDATE = null;
            DEPCODE = "";
            PREPAYMENT = 0;
            PAYREASON = "";
            STOCKTYPE = "";
            TAXRATE = 17;
            ISPRINT = false;
            REMARK = "";
        }
        [Length(10)]
        public string POID { get; set; }
        [Length(8)]
        public string SUPCODE { get; set; }
        [Length(4)]
        public string CURRCODE { get; set; }
        public System.Decimal EXCHRATE { get; set; }
        public short PERIODPAY { get; set; }
        [AllowNull]
        [Length(4)]
        public string SHIPTYPE { get; set; }
        [AllowNull]
        [Length(2)]
        public string CDISCCODE { get; set; }
        [AllowNull]
        [Length(1)]
        public string STATUS { get; set; }
        [AllowNull]
        [Length(10)]
        public string AUDITOR { get; set; }
        public DateTime? AUDITDATE { get; set; }
        public DateTime? CLOSEDATE { get; set; }
        [AllowNull]
        [Length(2)]
        public string SHIPWRHS { get; set; }
        [AllowNull]
        [Length(4)]
        public string PURSCODE { get; set; }
        [AllowNull]
        [Length(2)]
        public string SETTLECODE { get; set; }
        [AllowNull]
        [Length(4)]
        public string DELADCODE { get; set; }
        public DateTime? LASTDATE { get; set; }
        public System.Decimal TOTALAMTO { get; set; }
        public System.Decimal TOTALAMT { get; set; }
        public bool LOCKTAG { get; set; }
        [Length(10)]
        public string OPERATOR { get; set; }
        public DateTime? OPERDATE { get; set; }
        [AllowNull]
        [Length(3)]
        public string POTYPE { get; set; }
        [AllowNull]
        [Length(1)]
        public string INPUTFROM { get; set; }
        [AllowNull]
        [Length(4)]
        public string PODESCCODE { get; set; }
        [AllowNull]
        [Length(20)]
        public string CUSTORDNB { get; set; }
        [AllowNull]
        [Length(30)]
        public string BANKMESCODE { get; set; }
        [AllowNull]
        [Length(30)]
        public string INVOICECODE { get; set; }
        public System.Decimal? INVOICEMONEY { get; set; }
        public DateTime? INVOICEDATE { get; set; }
        [AllowNull]
        [Length(15)]
        public string PROJECTCOD { get; set; }
        [AllowNull]
        [Length(300)]
        public string NEWADDRESS { get; set; }
        public DateTime? SENDDATE { get; set; }
        [AllowNull]
        [Length(4)]
        public string DEPCODE { get; set; }
        public System.Decimal? PREPAYMENT { get; set; }
        [AllowNull]
        [Length(50)]
        public string PAYREASON { get; set; }
        [AllowNull]
        [Length(10)]
        public string STOCKTYPE { get; set; }
        public System.Decimal? TAXRATE { get; set; }
        public bool? ISPRINT { get; set; }
        [AllowNull]
        [Length(4000)]
        public string REMARK { get; set; }

        [HasMany(OrderBy = "ID")]
        public IList<SM_PORDERDTL> PORDERDTL { get; private set; }

        [QueryRequired, AllowNull]
        public string SUPPNAME { get; set; }
        [QueryRequired, AllowNull]
        public string AUDITORNAME { get; set; }
        [QueryRequired, AllowNull]
        public string OPERATORNAME { get; set; }
        [QueryRequired, AllowNull]
        public string STATUSNAME { get; set; }
        [QueryRequired, AllowNull]
        public string POTYPENAME { get; set; }
    }

}
