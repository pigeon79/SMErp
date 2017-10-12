using System;
using G.Data.Definition;
using G.Data.Model.Handler;

namespace G.Entity.ERP
{
    public class SM_LOCSTORAGE : DbObjectModel<SM_LOCSTORAGE, int>
    {
        public SM_LOCSTORAGE()
        {
            WRHSCODE = "";
            LOCCODE = "";
            ITEMCODE = "";
            ONHANDQTY = 0;
            ALLOSHOP = 0;
            ALLOORDER = 0;
            AVAILQTY = 0;
            OPNBALANE = 0;
            ISSUEQTY = 0;
            RECIVQTY = 0;
            ADJUSTQTY = 0;
            COUNTTYP = "";
            LSTCOUDTE = DateTime.Now;
            LSTOUTDTE = DateTime.Now;
            OPERATOR = "";
            OPERDATE = DateTime.Now;
            ATTRIBUTEA = "";
            ATTRIBUTEB = "";
            ATTRIBUTEC = 0;
            ATTRIBUTED = "";
            ATTRIBUTEE = "";
        }
        [Length(5)]
        public string WRHSCODE { get; set; }
        [Length(5)]
        public string LOCCODE { get; set; }
        [Length(50)]
        public string ITEMCODE { get; set; }
        public System.Decimal? ONHANDQTY { get; set; }
        public System.Decimal? ALLOSHOP { get; set; }
        public System.Decimal? ALLOORDER { get; set; }
        public System.Decimal? AVAILQTY { get; set; }
        public System.Decimal? OPNBALANE { get; set; }
        public System.Decimal? ISSUEQTY { get; set; }
        public System.Decimal? RECIVQTY { get; set; }
        public System.Decimal? ADJUSTQTY { get; set; }
        [AllowNull]
        [Length(5)]
        public string COUNTTYP { get; set; }
        public DateTime? LSTCOUDTE { get; set; }
        public DateTime? LSTOUTDTE { get; set; }
        [Length(50)]
        public string OPERATOR { get; set; }
        public DateTime? OPERDATE { get; set; }
        [AllowNull]
        [Length(50),Description("色号")]
        public string ATTRIBUTEA { get; set; }
        [AllowNull]
        [Length(50), Description("花模代码")]
        public string ATTRIBUTEB { get; set; }
        [Description("尺寸")]
        public System.Decimal? ATTRIBUTEC { get; set; }
        [AllowNull]
        [Length(50)]
        public string ATTRIBUTED { get; set; }
        [AllowNull]
        [Length(50)]
        public string ATTRIBUTEE { get; set; }
    }

}
