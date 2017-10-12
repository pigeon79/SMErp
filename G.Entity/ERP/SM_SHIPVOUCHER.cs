using System;
using G.Data.Definition;
using G.Data.Model.Handler;
using System.Collections.Generic;

namespace G.Entity.ERP
{
    [DbView("SM_SHIPVOUCHER_V1")]
    public class SM_SHIPVOUCHER : DbObjectModel<SM_SHIPVOUCHER, int>
    {
        public SM_SHIPVOUCHER()
        {
            SHIPVID = "";
            SHIPDATE = DateTime.Now;
            STATUS = "N";
            SUPCODE = "";
            POID = "";
            OPERATOR = "";
            OPERDATE = null;
            SHIPUSER = "";
            LOCKTAG = false;
            INVTRNCDE = "";
            IFCHECKOUT = false;
            DELIVERCODE = "";
            ISPRINT = false;
            ISDEBT = false;
            CHECKMAN = "";
            ISREQ = false;
            POINVOICEID = "";
            RKID = "";
            ISPRICEDIFF = false;
            TAXRATE = 17;
            AUDITDATE = null;
            AUDITOR = "";
            PORDERID = 0;
            ISVALUATION = 0;
            CLOSED = 0;
        }
        [Length(11)]
        public string SHIPVID { get; set; }
        public DateTime SHIPDATE { get; set; }
        [AllowNull]
        [Length(1)]
        public string STATUS { get; set; }
        [AllowNull]
        [Length(8)]
        public string SUPCODE { get; set; }
        [AllowNull]
        [Length(11)]
        public string POID { get; set; }
        [AllowNull]
        [Length(10)]
        public string OPERATOR { get; set; }
        public DateTime? OPERDATE { get; set; }
        [AllowNull]
        [Length(10)]
        public string SHIPUSER { get; set; }
        public bool LOCKTAG { get; set; }
        [AllowNull]
        [Length(2)]
        public string INVTRNCDE { get; set; }
        public bool? IFCHECKOUT { get; set; }
        [AllowNull]
        [Length(20)]
        public string DELIVERCODE { get; set; }
        public bool? ISPRINT { get; set; }
        public bool? ISDEBT { get; set; }
        [AllowNull]
        [Length(10)]
        public string CHECKMAN { get; set; }
        public bool? ISREQ { get; set; }
        [AllowNull]
        [Length(10)]
        public string POINVOICEID { get; set; }
        [AllowNull]
        [Length(13)]
        public string RKID { get; set; }
        public bool? ISPRICEDIFF { get; set; }
        public System.Decimal? TAXRATE { get; set; }
        public DateTime? AUDITDATE { get; set; }
        [AllowNull]
        [Length(10)]
        public string AUDITOR { get; set; }
        public int? PORDERID { get; set; }
        public int? ISVALUATION { get; set; }
        public int? CLOSED { get; set; }

        [HasMany(OrderBy = "ID")]
        public IList<SM_SHIPVOUCHERDTL> SHIPVOUCHERDTL { get; private set; }

        [QueryRequired, AllowNull]
        public string SUPPNAME { get; set; }
        [QueryRequired, AllowNull]
        public string AUDITORNAME { get; set; }
        [QueryRequired, AllowNull]
        public string SHIPUSERNAME { get; set; }
        [QueryRequired, AllowNull]
        public string OPERATORNAME { get; set; }
        [QueryRequired, AllowNull]
        public string STATUSNAME { get; set; }
    }


}
