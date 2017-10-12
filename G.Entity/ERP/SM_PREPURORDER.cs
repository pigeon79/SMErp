using System;
using G.Data.Definition;
using G.Data.Model.Handler;

namespace G.Entity.ERP
{
    [DbView("SM_PREPURORDER_V1")]
    public class SM_PREPURORDER : DbObjectModel<SM_PREPURORDER, int>
    {
        public SM_PREPURORDER()
        {
            ISSELECT = false;
            PREPURORDID = "";
            SUPCODE = "";
            ITEMCODE = "";
            PREPURQTY = 0;
            INVUNIT = "";
            PREPURQTYA = 0;
            DEPCODE = "";
            DEMANDDATE = DateTime.Now;
            CUSTOMER = "";
            APPLYUSER = "";
            APPLYDATE = DateTime.Now;
            AUDITOR = "";
            AUDITDATE = null;
            STATUS = "N";
            POID = "";
            PONO = 0;
            PURQTY = 0;
            LOCKTAG = false;
            REMARK = "";
            OPERATOR = "";
            OPERDATE = DateTime.Now;
            SHOPORDERID = "";
            ORDERID = "";
            ORDLNNO = 0;
            BATCHNUMBER = 0;
            SHIPQTY = 0;
            WORKDAY = 0;
            PURSUPCODE = "";
            ATTRIBUTEA = "";
            ATTRIBUTEB = "";
            ATTRIBUTEC = 0;
            ATTRIBUTED = "";
            ATTRIBUTEE = "";
            PURTYPE = "";
            PURUSER = "";
            FROMSOURCE = "";
            DEMANDDATEBAK = DateTime.Now;
            BOMTEMPID = 0;
        }
        [QueryRequired]
        public Boolean ISSELECT { get; set; }
        [Length(10)]
        public string PREPURORDID { get; set; }
        [AllowNull]
        [Length(8)]
        public string SUPCODE { get; set; }
        [QueryRequired,AllowNull]
        public string SUPPNAME { get; set; }
        [Length(18)]
        public string ITEMCODE { get; set; }
        [QueryRequired,AllowNull]
        public string ITEMNAME { get; set; }
        public System.Decimal PREPURQTY { get; set; }
        [AllowNull]
        [Length(4)]
        public string INVUNIT { get; set; }
        public System.Decimal PREPURQTYA { get; set; }
        [AllowNull]
        [Length(4)]
        public string DEPCODE { get; set; }
        [QueryRequired,AllowNull]
        public string DEPNAME { get; set; }
        public DateTime? DEMANDDATE { get; set; }
        [AllowNull]
        [Length(8)]
        public string CUSTOMER { get; set; }
        [Length(10)]
        public string APPLYUSER { get; set; }
        [QueryRequired,AllowNull]
        public string APPLYUSERNAME { get; set; }
        public DateTime APPLYDATE { get; set; }
        [AllowNull]
        [Length(10)]
        public string AUDITOR { get; set; }
        [QueryRequired,AllowNull]
        public string AUDITORNAME { get; set; }
        public DateTime? AUDITDATE { get; set; }
        [AllowNull]
        [Length(1)]
        public string STATUS { get; set; }
        [QueryRequired,AllowNull]
        public string STATUSNAME { get; set; }
        [AllowNull]
        [Length(10)]
        public string POID { get; set; }
        public short? PONO { get; set; }
        public System.Decimal PURQTY { get; set; }
        public bool LOCKTAG { get; set; }
        [AllowNull]
        [Length(500)]
        public string REMARK { get; set; }
        [Length(10)]
        public string OPERATOR { get; set; }
        [QueryRequired,AllowNull]
        public string OPERATORNAME { get; set; }
        public DateTime? OPERDATE { get; set; }
        [AllowNull]
        [Length(11)]
        public string SHOPORDERID { get; set; }
        [AllowNull]
        [Length(12)]
        public string ORDERID { get; set; }
        public int? ORDLNNO { get; set; }
        public short? BATCHNUMBER { get; set; }
        public System.Decimal? SHIPQTY { get; set; }
        public int? WORKDAY { get; set; }
        [AllowNull]
        [Length(8)]
        public string PURSUPCODE { get; set; }
        [AllowNull]
        [Length(40)]
        public string ATTRIBUTEA { get; set; }
        [AllowNull]
        [Length(20)]
        public string ATTRIBUTEB { get; set; }
        [QueryRequired,AllowNull]
        public string ATTRIBUTEBNAME { get; set; }
        public System.Decimal? ATTRIBUTEC { get; set; }
        [AllowNull]
        [Length(20)]
        public string ATTRIBUTED { get; set; }
        [AllowNull]
        [Length(100)]
        public string ATTRIBUTEE { get; set; }
        [AllowNull]
        [Length(10)]
        public string PURTYPE { get; set; }
        [AllowNull]
        [Length(10)]
        public string PURUSER { get; set; }
        [QueryRequired,AllowNull]
        public string PURUSERNAME { get; set; }
        [AllowNull]
        [Length(50)]
        public string FROMSOURCE { get; set; }
        public DateTime? DEMANDDATEBAK { get; set; }
        [QueryRequired, AllowNull]
        public string PURTYPENAME { get; set; }
        [QueryRequired]
        public bool ISATTRIBUTEA { get; set; }
        [QueryRequired]
        public bool ISATTRIBUTEB { get; set; }
        [QueryRequired]
        public bool ISATTRIBUTEC { get; set; }
        public int? BOMTEMPID { get; set; }
        [QueryRequired]
        public decimal? SUPPRICE { get; set; }
    }

}
