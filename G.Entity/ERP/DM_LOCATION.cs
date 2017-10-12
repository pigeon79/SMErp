using System;
using G.Data.Definition;
using G.Data.Model.Handler;

namespace G.Entity.ERP
{
    [DbView("DM_LOCATION_V1")]
    public class DM_LOCATION : DbObjectModel<DM_LOCATION,int>
    {
        public DM_LOCATION(){
            this.WRHSCODE = "";
            this.WRHSNAME = "";
            this.LOCCODE = "";
            this.LOCNAME = "";
            this.Operator = "";
            this.Operdate = DateTime.Now;
            this.Remarks = "";
        }
        //仓库
        //[BelongsTo, DbColumn("WRHSCODE")]
        //public DM_WAREHOUSE WRHS { get; set; }
        //public string WRHSNAME { get { return WRHS != null ? WRHS.WRHSNAME : ""; } }

        public string WRHSCODE { get; set; }
        [QueryRequired]
        public string WRHSNAME { get; set; }
        //库位
        [Length(5)]
        public string LOCCODE { get; set; }
        [AllowNull]
        [Length(10)]
        public string LOCDESC { get; set; }
        [Length(50)]
        public string LOCNAME { get; set; }
        public bool? MultiItem { get; set; }
        public short? CountCyl { get; set; }
        public DateTime? LstCouDte { get; set; }
        [AllowNull]
        [Length(10)]
        public string Operator { get; set; }
        public DateTime? Operdate { get; set; }
        [AllowNull]
        [Length(50)]
        public string Remarks { get; set; }
        public bool? IsAllc { get; set; }
        public int? USERID { get; set; }

        
        public const string ViewName = "DM_LOCATION_V1";
        private const string SqlName = "";
        public static string QuerySql() {
            string csql = "";
            if (!ViewName.IsNullOrEmpty()) { csql = string.Format("select * from {0}",ViewName); }
            else { csql = SqlName; }
            return csql;
        }
    }

}
