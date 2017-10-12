using System;
using System.Collections.Generic;
using G.Data.Definition;
using G.Data.Model.Handler;

namespace G.Entity.ERP
{
    [DbView("SM_ASSISTMSUPPLY_V1")]
    public class SM_ASSISTMSUPPLY : DbObjectModel<SM_ASSISTMSUPPLY, int>
    {
        public SM_ASSISTMSUPPLY()
        {
            ASSISTMSCODE = "";
            ASSISTMSDATE = DateTime.Now;
            CONSPER = "";
            CHECKEDPER = "";
            STATUS = "N";
            OPERATOR = "";
            OPERDATE = DateTime.Now;
            LOCK = false;
            MEMO = "";
            ORDERID = "";
            ASUPCODE = "";
            ADELIVERYDATE = DateTime.Now;
            ISPRINT = false;
            AFFIRMDATE = null;
            AFFIRMER = "";
            PURUSER = "";
            HBOrderID = "";
            CKID = "";
            ISFINISH = false;
            COSTMONEY = 0;
            ACUSTID = 0;
            ISCANCEL = 0;
            REASON = "";
            FINISHDATE = DateTime.Now;
            ISCOLOR = 0;
        }
        [AllowNull]
        [Length(50)]
        public string ASSISTMSCODE { get; set; }
        public DateTime? ASSISTMSDATE { get; set; }
        [AllowNull]
        [Length(50)]
        public string CONSPER { get; set; }
        [AllowNull]
        [Length(50)]
        public string CHECKEDPER { get; set; }
        [AllowNull]
        [Length(1)]
        public string STATUS { get; set; }
        [AllowNull]
        [Length(50)]
        public string OPERATOR { get; set; }
        public DateTime? OPERDATE { get; set; }
        public bool? LOCK { get; set; }
        [AllowNull]
        [Length(200)]
        public string MEMO { get; set; }
        [AllowNull]
        [Length(20)]
        public string ORDERID { get; set; }
        [AllowNull]
        [Length(50)]
        public string ASUPCODE { get; set; }
        public DateTime? ADELIVERYDATE { get; set; }
        public bool? ISPRINT { get; set; }
        public DateTime? AFFIRMDATE { get; set; }
        [AllowNull]
        [Length(50)]
        public string AFFIRMER { get; set; }
        [AllowNull]
        [Length(50)]
        public string PURUSER { get; set; }
        [AllowNull]
        [Length(50)]
        public string HBOrderID { get; set; }
        [AllowNull]
        [Length(50)]
        public string CKID { get; set; }
        public bool? ISFINISH { get; set; }
        public System.Decimal? COSTMONEY { get; set; }
        public int? ACUSTID { get; set; }
        public int? ISCANCEL { get; set; }
        [AllowNull]
        [Length(3000)]
        public string REASON { get; set; }
        public DateTime? FINISHDATE { get; set; }
        public int? ISCOLOR { get; set; }
        
        [HasMany(OrderBy = "ID")]
        public IList<SM_ASSISTMSUPPLYDTL> ASSISTMSUPPLYDTL { get; private set; }

        [QueryRequired, AllowNull]
        public string OPERATORNAME { get; set; }
        [QueryRequired, AllowNull]
        public string AFFIRMERNAME { get; set; }
        [QueryRequired, AllowNull]
        public string STATUSNAME { get; set; }
        [QueryRequired, AllowNull]
        public string PURUSERNAME { get; set; }
        [QueryRequired, AllowNull]
        public string SUPPNAME { get; set; }
        [QueryRequired, AllowNull]
        public string CUSTNAME { get; set; }
        [QueryRequired, AllowNull]
        public string SALESMANNAME { get; set; }
        [QueryRequired, AllowNull]
        public string SALESREPNAME { get; set; }
    }
}
