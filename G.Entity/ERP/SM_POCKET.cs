using System;
using G.Data.Definition;
using G.Data.Model.Handler;
using System.Collections.Generic;

namespace G.Entity.ERP
{
    [DbView("SM_POCKET_V1")]
    public class SM_POCKET : DbObjectModel<SM_POCKET, int>
    {
        public SM_POCKET()
        {
            POCKID = "";
            ORDERID = "";
            POCKETER = "";
            POCKETDATE = DateTime.Now;
            STATUS = "N";
            AUDITOR = "";
            AUDITDATE = null;
            OPERATOR = "";
            OPERDATE = DateTime.Now;
            TOTALQTY = 0;
            REMARK = "";
            CUSTCODE = "";
            ISPRINT = false;
            RKID = "";
            RKDATE = null;
            RKER = "";
            CKID = "";
            CKDATE = null;
            CKER = "";
            BARCODE = "";
        }
        [AllowNull]
        [Length(20)]
        public string POCKID { get; set; }
        [AllowNull]
        [Length(20)]
        public string ORDERID { get; set; }
        [AllowNull]
        [Length(10)]
        public string POCKETER { get; set; }
        public DateTime? POCKETDATE { get; set; }
        [AllowNull]
        [Length(1)]
        public string STATUS { get; set; }
        [AllowNull]
        [Length(20)]
        public string AUDITOR { get; set; }
        public DateTime? AUDITDATE { get; set; }
        [AllowNull]
        [Length(20)]
        public string OPERATOR { get; set; }
        public DateTime? OPERDATE { get; set; }
        public System.Decimal? TOTALQTY { get; set; }
        [AllowNull]
        [Length(500)]
        public string REMARK { get; set; }
        [AllowNull]
        [Length(20)]
        public string CUSTCODE { get; set; }
        public bool? ISPRINT { get; set; }
        [AllowNull]
        [Length(20)]
        public string RKID { get; set; }
        public DateTime? RKDATE { get; set; }
        [AllowNull]
        [Length(10)]
        public string RKER { get; set; }
        [AllowNull]
        [Length(20)]
        public string CKID { get; set; }
        public DateTime? CKDATE { get; set; }
        [AllowNull]
        [Length(10)]
        public string CKER { get; set; }
        [AllowNull]
        [Length(50)]
        public string BARCODE { get; set; }

        [HasMany(OrderBy = "ID")]
        public IList<SM_POCKETDTL> POCKETDTL { get; private set; }

        [QueryRequired, AllowNull]
        public string POCKETERNAME { get; set; }
        [QueryRequired, AllowNull]
        public string AUDITORNAME { get; set; }
        [QueryRequired, AllowNull]
        public string OPERATORNAME { get; set; }
        [QueryRequired, AllowNull]
        public string STATUSNAME { get; set; }
        [QueryRequired, AllowNull]
        public string RKERNAME { get; set; }
        [QueryRequired, AllowNull]
        public string CKERNAME { get; set; }
    }

}
