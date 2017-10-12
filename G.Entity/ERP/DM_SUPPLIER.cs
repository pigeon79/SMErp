using System;
using G.Data.Definition;
using G.Data.Model.Handler;

namespace G.Entity.ERP
{
    public class DM_SUPPLIER : DbObjectModel<DM_SUPPLIER, int>
    {
        public DM_SUPPLIER()
        {
            SUPPCODE = "";
            SUPPNAME = "";
            SUPPLEV = "";
            PRDTYPE = "";
            FOUNDDATE = DateTime.Now;
            PY = "";
            SUPPTYPE = "";
            SUPPOR = "";
            SUPPDESC = "";
            BOSS = "";
            TEL = "";
            CONTACTS = "";
            CONTEL = "";
            ADDRESS = "";
            FAX = "";
            SUPPTEL = "";
            PRDCOUNT = 0;
            QS = "";
            SERVER = "";
            PAYTYPE = "";
            AREA = "";
            BANK = "";
            BANKACCOUNT = "";
            REMARK = "";
            OPERATOR = "";
            OPERDATE = DateTime.Now;
            INVTAG = true;
            PAYTIME= "";
        }
        [Length(50)]
        public string SUPPCODE { get; set; }
        [Length(50)]
        public string SUPPNAME { get; set; }
        [AllowNull]
        [Length(50)]
        public string SUPPLEV { get; set; }
        [AllowNull]
        [Length(50)]
        public string PRDTYPE { get; set; }
        public DateTime? FOUNDDATE { get; set; }
        [AllowNull]
        [Length(50)]
        public string PY { get; set; }
        [AllowNull]
        [Length(50)]
        public string SUPPTYPE { get; set; }
        [AllowNull]
        [Length(10)]
        public string SUPPOR { get; set; }
        [AllowNull]
        [Length(50)]
        public string SUPPDESC { get; set; }
        [AllowNull]
        [Length(10)]
        public string BOSS { get; set; }
        [AllowNull]
        [Length(50)]
        public string TEL { get; set; }
        [AllowNull]
        [Length(50)]
        public string CONTACTS { get; set; }
        [AllowNull]
        [Length(50)]
        public string CONTEL { get; set; }
        [AllowNull]
        [Length(100)]
        public string ADDRESS { get; set; }
        [AllowNull]
        [Length(50)]
        public string FAX { get; set; }
        [AllowNull]
        [Length(50)]
        public string SUPPTEL { get; set; }
        public int? PRDCOUNT { get; set; }
        [AllowNull]
        [Length(50)]
        public string QS { get; set; }
        [AllowNull]
        [Length(50)]
        public string SERVER { get; set; }
        [AllowNull]
        [Length(50)]
        public string PAYTYPE { get; set; }
        [AllowNull]
        [Length(50)]
        public string AREA { get; set; }
        [AllowNull]
        [Length(50)]
        public string BANK { get; set; }
        [AllowNull]
        [Length(50)]
        public string BANKACCOUNT { get; set; }
        [AllowNull]
        [Length(800)]
        public string REMARK { get; set; }
        [AllowNull]
        [Length(10)]
        public string OPERATOR { get; set; }
        public DateTime? OPERDATE { get; set; }
        public bool? INVTAG { get; set; }
        [AllowNull]
        [Length(50)]
        public string PAYTIME { get; set; }
    }

}
