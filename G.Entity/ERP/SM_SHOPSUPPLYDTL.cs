using System;
using G.Data.Definition;
using G.Data.Model.Handler;

namespace G.Entity.ERP
{
    [DbView("SM_SHOPSUPPLYDTL_V1")]
    public class SM_SHOPSUPPLYDTL : DbObjectModel<SM_SHOPSUPPLYDTL, int>
    {
        public SM_SHOPSUPPLYDTL()
        {
            SUPPLYID = "";
            SUPLNNO = 0;
            ITEMCODE = "";
            UNIT = "";
            REQQTY = 0;
            ACTQTY = 0;
            WRHSCODE = "";
            LOCCODE = "";
            LOTNUMBER = "";
            WORKSTEPID = "";
            ATTRIBUTEA = "";
            ATTRIBUTEB = "";
            ATTRIBUTEC = 0;
            ATTRIBUTED = "";
            ATTRIBUTEE = "";
            KGQTY = 0;
            RATE = 0;
            BOMTEMPID = 0;
            MEMO = "";
        }
        [BelongsTo, DbColumn("SHOPSUPPLYID")]
        public SM_SHOPSUPPLY SHOPSUPPLY { get; set; }
        [AllowNull]
        [Length(11)]
        public string SUPPLYID { get; set; }
        public int? SUPLNNO { get; set; }
        [AllowNull]
        [Length(50)]
        public string ITEMCODE { get; set; }
        [AllowNull]
        [Length(4)]
        public string UNIT { get; set; }
        public System.Decimal? REQQTY { get; set; }
        public System.Decimal? ACTQTY { get; set; }
        [AllowNull]
        [Length(5)]
        public string WRHSCODE { get; set; }
        [AllowNull]
        [Length(50)]
        public string LOCCODE { get; set; }
        [AllowNull]
        [Length(50)]
        public string LOTNUMBER { get; set; }
        [AllowNull]
        [Length(10)]
        public string WORKSTEPID { get; set; }
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
        public System.Decimal? KGQTY { get; set; }
        public System.Decimal? RATE { get; set; }
        public int? BOMTEMPID { get; set; }
        [AllowNull]
        [Length(200)]
        public string MEMO { get; set; }

        [QueryRequired, AllowNull]
        public string ITEMNAME { get; set; }
        [QueryRequired, AllowNull]
        public string WRHSNAME { get; set; }
        [QueryRequired, AllowNull]
        public string LOCNAME { get; set; }
        [QueryRequired, AllowNull]
        public string ATTRIBUTEBNAME { get; set; }
        [QueryRequired]
        public bool ISATTRIBUTEA { get; set; }
        [QueryRequired]
        public bool ISATTRIBUTEB { get; set; }
        [QueryRequired]
        public bool ISATTRIBUTEC { get; set; }
    }

}
