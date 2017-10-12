using System;
using G.Data.Definition;
using G.Data.Model.Handler;
using System.Collections.Generic;

namespace G.Entity.ERP
{
    [DbView("SM_SHOPORDER_V1")]
    public class SM_SHOPORDER : DbObjectModel<SM_SHOPORDER, int>
    {
        public SM_SHOPORDER()
        {
            SHOPORDID = "";
            ITEMCODE = "";
            REQQTY = 0;
            ACTRDATE = DateTime.Now;
            ACTDUEDATE = DateTime.Now;
            RDATE = DateTime.Now;
            DUEDATE = DateTime.Now;
            SHPORDTYPE = "";
            FINQTY = 0;
            ORDERID = "";
            STATUS = "N";
            OPERATOR = "";
            OPERDATE = DateTime.Now;
            ODOCID = "";
            WASTERQTY = 0;
            ALLOCFLAG = false;
            INVQTY = 0;
            BATCHNUMBER = 0;
            ROUTINEID = "";
            CURWORKSTEP = "";
            CURWRKCENTER = "";
            WORKSHOP = "";
            ATTRIBUTEA = "";
            ATTRIBUTEB = "";
            ATTRIBUTEC = 0;
            ATTRIBUTED = "";
            ATTRIBUTEE = "";
            HUMANCAP = 0;
            IFWORKAGAIN = false;
            BATCHQTY = 0;
            ISQUASH = false;
            MEMO = "";
            QTYKG = 0;
            BREAKPER = 0;
            ISPRINT = false;
            LOCKTAG = 0;
            BOMTEMPID = 0;
            ITEMNAME = "";
            ATTRIBUTEBNAME = "";

        }
        [AllowNull]
        [Length(11)]
        public string SHOPORDID { get; set; }
        [AllowNull]
        [Length(18)]
        public string ITEMCODE { get; set; }
        public System.Decimal? REQQTY { get; set; }
        public DateTime? ACTRDATE { get; set; }
        public DateTime? ACTDUEDATE { get; set; }
        public DateTime? RDATE { get; set; }
        public DateTime? DUEDATE { get; set; }
        [AllowNull]
        [Length(50)]
        public string SHPORDTYPE { get; set; }//1-成品类型
        public System.Decimal? FINQTY { get; set; }
        [AllowNull]
        [Length(20)]
        public string ORDERID { get; set; }
        [AllowNull]
        [Length(1)]
        public string STATUS { get; set; }
        [AllowNull]
        [Length(10)]
        public string OPERATOR { get; set; }
        public DateTime? OPERDATE { get; set; }
        [AllowNull]
        [Length(10)]
        public string ODOCID { get; set; }
        public System.Decimal? WASTERQTY { get; set; }
        public bool? ALLOCFLAG { get; set; }
        public System.Decimal? INVQTY { get; set; }
        public short? BATCHNUMBER { get; set; }
        [AllowNull]
        [Length(4)]
        public string ROUTINEID { get; set; }
        [AllowNull]
        [Length(5)]
        public string CURWORKSTEP { get; set; }
        [AllowNull]
        [Length(4)]
        public string CURWRKCENTER { get; set; }
        [AllowNull]
        [Length(6)]
        public string WORKSHOP { get; set; }
        [AllowNull]
        [Length(50)]
        public string ATTRIBUTEA { get; set; }
        [AllowNull]
        [Length(50)]
        public string ATTRIBUTEB { get; set; }
        public System.Decimal? ATTRIBUTEC { get; set; }
        [AllowNull]
        [Length(40)]
        public string ATTRIBUTED { get; set; }
        [AllowNull]
        [Length(40)]
        public string ATTRIBUTEE { get; set; }
        public int? HUMANCAP { get; set; }
        public bool? IFWORKAGAIN { get; set; }
        public System.Decimal? BATCHQTY { get; set; }
        public bool? ISQUASH { get; set; }
        [AllowNull]
        [Length(200)]
        public string MEMO { get; set; }
        public System.Decimal? QTYKG { get; set; }
        public System.Decimal? BREAKPER { get; set; }
        public bool? ISPRINT { get; set; }
        public int? LOCKTAG { get; set; }
        public int? BOMTEMPID { get; set; }
        [QueryRequired, AllowNull]
        public string ITEMNAME { get; set; }
        [QueryRequired, AllowNull]
        public string ATTRIBUTEBNAME { get; set; }
        [QueryRequired]
        public decimal? UNFINQTY { get; set; }
    }
}

