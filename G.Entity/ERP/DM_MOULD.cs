using System;
using G.Data.Definition;
using G.Data.Model.Handler;

namespace G.Entity.ERP
{
    public class DM_MOULD : DbObjectModel<DM_MOULD, int>
    {
        public DM_MOULD()
        {
            MDCODE = "";
            MDNAME = "";
            MDTYPE = "";
            PRDTYPE = "";
            CUSTID = 0;
            SUPPID = 0;
            BASICPRICE = 0;
            ADDPRICE = 0;
            MDSIZE = 0;
            MDCOUNT = 0;
            PICPATH = "";
            MDDATE = DateTime.Now;
            REMARK = "";
            OPERATOR = "";
            OPERDATE = DateTime.Now;
            WEIGHT = 0;
            WASTING1 = 0;
            WASTING2 = 0;
            WASTING3 = 0;
            BASICCODE = "";
            ISIZE = 0;
            MCOUNT = 0;
        }
        [AllowNull]
        [Length(20)]
        public string MDCODE { get; set; }
        [AllowNull]
        [Length(20)]
        public string MDNAME { get; set; }
        [AllowNull]
        [Length(20)]
        public string MDTYPE { get; set; }
        [AllowNull]
        [Length(20)]
        public string PRDTYPE { get; set; }
        public int? CUSTID { get; set; }
        public int? SUPPID { get; set; }
        public System.Decimal? MDPRICE { get { return BASICPRICE+ADDPRICE;}  }
        public System.Decimal? BASICPRICE { get; set; }
        public System.Decimal? ADDPRICE { get; set; }
        public System.Decimal? MDSIZE { get; set; }
        public int? MDCOUNT { get; set; }
        [AllowNull]
        [Length(100)]
        public string PICPATH { get; set; }
        public DateTime? MDDATE { get; set; }
        [AllowNull]
        [Length(800)]
        public string REMARK { get; set; }
        [AllowNull]
        [Length(10)]
        public string OPERATOR { get; set; }
        public DateTime? OPERDATE { get; set; }
        public System.Decimal? WEIGHT { get; set; }
        public System.Decimal? WASTING1 { get; set; }
        public System.Decimal? WASTING2 { get; set; }
        public System.Decimal? WASTING3 { get; set; }
        [AllowNull]
        [Length(15), Description("基础模代码")]
        public string BASICCODE { get; set; }
        [Description("规格")]
        public Decimal? ISIZE { get; set; }
        [Description("模数")]
        public int? MCOUNT { get; set; }
    }
}
