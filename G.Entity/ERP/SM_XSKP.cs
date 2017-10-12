using System;
using System.Collections.Generic;
using G.Data.Definition;
using G.Data.Model.Handler;

namespace G.Entity.ERP
{
    [DbView("SM_XSKP_V1")]
    [Serializable]
    public class SM_XSKP : DbObjectModel<SM_XSKP, int>
    {
        public SM_XSKP()
        {
            NO = "";
            LBDM = "";
            STATUS = "N";
            AUDITOR = "";
            AUDITDATE = null;
            FPNO = "";
            OPERATOR = "";
            OPERDATE = DateTime.Now;
            CUSTID = 0;
            INVCUSTID = 0;
            SALEREP = "";
            SUMVAT = null;
            SUMTAX = null;
            SUMVOT = null;
            SUMQTY = null;
            WCJE = null;
            REMARK = "";
            SKDAYS = null;
            IDPZ_NO = 0;
            IDWB = 0;
            WBJE = null;
            WBHL = null;
            ISRED = false;
            ISREVERSE = false;
            ISINVALID = false;
        }
        [HasMany(OrderBy = "ID")]
        public IList<SM_XSKPDTL> XSKPDTL { get; private set; }

        [AllowNull]
        [Length(20)]
        public string NO { get; set; }
        [AllowNull]
        [Length(20)]
        public string LBDM { get; set; }
        [AllowNull]
        [Length(1)]
        public string STATUS { get; set; }
        [AllowNull]
        [Length(20)]
        public string AUDITOR { get; set; }
        public DateTime? AUDITDATE { get; set; }
        [AllowNull]
        [Length(100)]
        public string FPNO { get; set; }
        [AllowNull]
        [Length(20)]
        public string OPERATOR { get; set; }
        public DateTime? OPERDATE { get; set; }
        public int? CUSTID { get; set; }
        public int? INVCUSTID { get; set; }
        [AllowNull]
        [Length(20)]
        public string SALEREP { get; set; }
        public System.Decimal? SUMVAT { get; set; }
        public System.Decimal? SUMTAX { get; set; }
        public System.Decimal? SUMVOT { get; set; }
        public System.Decimal? SUMQTY { get; set; }
        public System.Decimal? WCJE { get; set; }
        [AllowNull]
        [Length(500)]
        public string REMARK { get; set; }
        public int? SKDAYS { get; set; }
        public int? IDPZ_NO { get; set; }
        public int? IDWB { get; set; }
        public System.Decimal? WBJE { get; set; }
        public System.Decimal? WBHL { get; set; }
        public bool? ISRED { get; set; }
        public bool? ISREVERSE { get; set; }
        public bool? ISINVALID { get; set; }

        [QueryRequired, AllowNull]
        public string AUDITORNAME { get; set; }
        [QueryRequired, AllowNull]
        public string OPERATORNAME { get; set; }
        [QueryRequired, AllowNull]
        public string STATUSNAME { get; set; }
        [QueryRequired, AllowNull]
        public string CUSTNAME { get; set; }
        [QueryRequired, AllowNull]
        public string INVCUSTNAME { get; set; }
        [QueryRequired, AllowNull]
        public string JBRLBNAME { get; set; }
    }
}
