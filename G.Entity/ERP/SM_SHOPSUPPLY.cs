using System;
using G.Data.Definition;
using G.Data.Model.Handler;
using System.Collections.Generic;

namespace G.Entity.ERP
{
    [DbView("SM_SHOPSUPPLY_V1")]
    public class SM_SHOPSUPPLY : DbObjectModel<SM_SHOPSUPPLY, int>
    {
        public SM_SHOPSUPPLY()
        {
            SUPPLYID = "";
            SHOPORDID = "";
            APPLYER = "";
            APPLYDATE = DateTime.Now;
            STATUS = "N";
            AUDITOR = "";
            AUDITDATE = null;
            LOCKTAG = "";
            OPERATOR = "";
            OPERDATE = DateTime.Now;
            INVTRNCDE = "";
            REMARK = "";
            SUPPLYTYPE = "";
            WORKSHOP = "";
            ISPRINT = false;
            RCKID = "";
            CKDM = "";
        }
        [Length(11)]
        public string SUPPLYID { get; set; }
        [AllowNull]
        [Length(11)]
        public string SHOPORDID { get; set; }
        [AllowNull]
        [Length(10)]
        public string APPLYER { get; set; }
        public DateTime? APPLYDATE { get; set; }
        [AllowNull]
        [Length(1)]
        public string STATUS { get; set; }
        [AllowNull]
        [Length(10)]
        public string AUDITOR { get; set; }
        public DateTime? AUDITDATE { get; set; }
        [AllowNull]
        [Length(2)]
        public string LOCKTAG { get; set; }
        [AllowNull]
        [Length(10)]
        public string OPERATOR { get; set; }
        public DateTime? OPERDATE { get; set; }
        [AllowNull]
        [Length(2)]
        public string INVTRNCDE { get; set; }
        [AllowNull]
        [Length(500)]
        public string REMARK { get; set; }
        [AllowNull]
        [Length(1)]
        public string SUPPLYTYPE { get; set; }
        [AllowNull]
        [Length(2)]
        public string WORKSHOP { get; set; }
        public bool? ISPRINT { get; set; }
        [AllowNull]
        [Length(15)]
        public string RCKID { get; set; }
        [AllowNull]
        [Length(15)]
        public string CKDM { get; set; }

        [HasMany(OrderBy = "ID")]
        public IList<SM_SHOPSUPPLYDTL> SHOPSUPPLYDTL { get; private set; }

        [QueryRequired, AllowNull]
        public string APPLYERNAME { get; set; }
        [QueryRequired, AllowNull]
        public string AUDITORNAME { get; set; }
        [QueryRequired, AllowNull]
        public string OPERATORNAME { get; set; }
        [QueryRequired, AllowNull]
        public string STATUSNAME { get; set; }
        [QueryRequired, AllowNull]
        public string ORGNAME { get; set; }
    }
}
