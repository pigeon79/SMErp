using System;
using G.Data.Definition;
using G.Data.Model.Handler;

namespace G.Entity.ERP
{
    [DbView("SM_XSKPDTL_V1")]
    [Serializable]
    public class SM_XSKPDTL : DbObjectModel<SM_XSKPDTL, int>
    {
        public SM_XSKPDTL()
        {
            ITEMCODE = "";
            JLDW = "";
            QTY = 0;
            ATPRICE = 0;
            ATMONEY = 0;
            OTPRICE = 0;
            OTMONEY = 0;
            TAXRATE = 17;
            TAXMONEY = 0;
            SERIALNO = 0;
            REMARK = "";
            ORDERID = "";
            SALEORDERDTLID = 0;
        }
        [BelongsTo, DbColumn("XSKPID")]
        public SM_XSKP XSKP { get; set; }

        [AllowNull]
        [Length(50)]
        public string ITEMCODE { get; set; }
        [AllowNull]
        [Length(10)]
        public string JLDW { get; set; }
        /// <summary>
        /// 数量
        /// </summary>
        public System.Decimal? QTY { get; set; }
        /// <summary>
        /// 含税单价
        /// </summary>
        public System.Decimal? ATPRICE { get; set; }
        /// <summary>
        /// 含税金额
        /// </summary>
        public System.Decimal? ATMONEY { get; set; }
        /// <summary>
        /// 不含税单价
        /// </summary>
        public System.Decimal? OTPRICE { get; set; }
        /// <summary>
        /// 不含税金额
        /// </summary>
        public System.Decimal? OTMONEY { get; set; }
        /// <summary>
        /// 税率
        /// </summary>
        public System.Decimal? TAXRATE { get; set; }
        /// <summary>
        /// 税金
        /// </summary>
        public System.Decimal? TAXMONEY { get; set; }
        public int? SERIALNO { get; set; }
        [AllowNull]
        [Length(500)]
        public string REMARK { get; set; }
        [AllowNull]
        [Length(50)]
        public string ORDERID { get; set; }
        public int? SALEORDERDTLID { get; set; }

        [QueryRequired, AllowNull]
        public string ITEMNAME { get; set; }
    }
}
