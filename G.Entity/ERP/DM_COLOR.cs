using System;
using G.Data.Definition;
using G.Data.Model.Handler;

namespace G.Entity.ERP
{
    [DbView("DM_COLOR_V1")]
    public class DM_COLOR : DbObjectModel<DM_COLOR, int>
    {
        public DM_COLOR()
        {
            CCODE = "";
            CNAME = "";
            TECHNAME = "";
            TCNAME = "";
            HELPMARKER = "";
            ISWX = false;
            ISPX = false;
            COST = 0;
            ADDPRICE = 0;
            STOPTAG = false;
            OPERTOR = "";
            OPERDATE = DateTime.Now;
        }
        [AllowNull]
        [Length(20)]
        public string CCODE { get; set; }
        [AllowNull]
        [Length(20)]
        public string CNAME { get; set; }
        [Length(50),QueryRequired]
        public string COLORNAME { get; set; }
        [AllowNull]
        [Length(20)]
        public string TECHNAME { get; set; }
        [AllowNull]
        [Length(20)]
        public string TCNAME { get; set; }
        [AllowNull]
        [Length(20)]
        public string HELPMARKER { get; set; }
        public bool? ISWX { get; set; }
        public bool? ISPX { get; set; }
        public System.Decimal? COST { get; set; }
        public System.Decimal? ADDPRICE { get; set; }
        public bool? STOPTAG { get; set; }
        [AllowNull]
        [Length(10)]
        public string OPERTOR { get; set; }
        public DateTime? OPERDATE { get; set; }

        
    }

}
