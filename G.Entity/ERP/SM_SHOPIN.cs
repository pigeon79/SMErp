using System;
using G.Data.Definition;
using G.Data.Model.Handler;

namespace G.Entity.ERP
{
    [DbView("SM_SHOPIN_V1")]
    public class SM_SHOPIN : DbObjectModel<SM_SHOPIN, int>
    {
        public SM_SHOPIN()
        {
            SHOPINID = "";
            STATUS = "N";
            ITEMCODE = "";
            INQTY = 0;
            WTINQTY = 0;
            INVUNIT = "";
            WORKSHOP = "";
            FINISHDATE = DateTime.Now;
            WRHSCODE = "";
            LOCCODE = "";
            RATE = 0;
            WEIGHT = 0;
            AUDITOR = "";
            AUDITDATE = null;
            REMARK = "";
            OPERATOR = "";
            OPERDATE = DateTime.Now;
            SHOPORDERID = "";
            ORDERID = "";
            ORDLNNO = 0;
            ATTRIBUTEA = "";
            ATTRIBUTEB = "";
            ATTRIBUTEC = 0;
            ATTRIBUTED = "";
            ATTRIBUTEE = "";
        }
        [AllowNull]
        [Length(20)]
        public string SHOPINID { get; set; }
        [AllowNull]
        [Length(1)]
        public string STATUS { get; set; }
        [AllowNull]
        [Length(50)]
        public string ITEMCODE { get; set; }
        public System.Decimal? INQTY { get; set; }
        public System.Decimal? WTINQTY { get; set; }
        [AllowNull]
        [Length(4)]
        public string INVUNIT { get; set; }
        [AllowNull]
        [Length(10)]
        public string WORKSHOP { get; set; }
        public DateTime? FINISHDATE { get; set; }
        [AllowNull]
        [Length(5)]
        public string WRHSCODE { get; set; }
        [AllowNull]
        [Length(5)]
        public string LOCCODE { get; set; }
        public System.Decimal? RATE { get; set; }
        public System.Decimal? WEIGHT { get; set; }
        [AllowNull]
        [Length(10)]
        public string AUDITOR { get; set; }
        public DateTime? AUDITDATE { get; set; }
        [AllowNull]
        [Length(500)]
        public string REMARK { get; set; }
        [AllowNull]
        [Length(10)]
        public string OPERATOR { get; set; }
        public DateTime? OPERDATE { get; set; }
        [AllowNull]
        [Length(20)]
        public string SHOPORDERID { get; set; }
        [AllowNull]
        [Length(20)]
        public string ORDERID { get; set; }
        public int? ORDLNNO { get; set; }
        [AllowNull]
        [Length(50)]
        public string ATTRIBUTEA { get; set; }
        [AllowNull]
        [Length(50)]
        public string ATTRIBUTEB { get; set; }
        public System.Decimal? ATTRIBUTEC { get; set; }
        [AllowNull]
        [Length(50)]
        public string ATTRIBUTED { get; set; }
        [AllowNull]
        [Length(50)]
        public string ATTRIBUTEE { get; set; }

        [QueryRequired, AllowNull]
        public string AUDITORNAME { get; set; }
        [QueryRequired, AllowNull]
        public string OPERATORNAME { get; set; }
        [QueryRequired, AllowNull]
        public string STATUSNAME { get; set; }
        [QueryRequired, AllowNull]
        public string ITEMNAME { get; set; }
        [QueryRequired, AllowNull]
        public string WRHSNAME { get; set; }
        [QueryRequired, AllowNull]
        public string LOCNAME { get; set; }
        [QueryRequired, AllowNull]
        public string ATTRIBUTEBNAME { get; set; }
        [QueryRequired, AllowNull]
        public string WORKSHOPNAME { get; set; }
        [QueryRequired]
        public bool ISATTRIBUTEA { get; set; }
        [QueryRequired]
        public bool ISATTRIBUTEB { get; set; }
        [QueryRequired]
        public bool ISATTRIBUTEC { get; set; }
    }
}
