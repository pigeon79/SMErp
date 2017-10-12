using System;
using G.Data.Definition;
using G.Data.Model.Handler;

namespace G.Entity.CW
{
    
    public class CW_PZ : DbObjectModel<CW_PZ, int>
    {
        public CW_PZ() {
            this.ZY = "";
            this.JSPJH = "";
        }
        //[DbColumn("IDPZ_NO")]
        //public System.Int32 IDPZ_NO{get;set;}
        [BelongsTo, DbColumn("IDPZ_NO")]
        public CW_PZ_NO PZNO { get; set; }
        /// <summary>
        /// 科目ID
        /// </summary>
        [BelongsTo, DbColumn("IDDM"), Description("科目ID")]
        public CW_DM CWDM { get; set; }
        public String DETAILNAME { get { return CWDM != null ? CWDM.DETAILNAME : ""; } }
        /// <summary>
        /// 摘要
        /// </summary>
        [DbColumn("ZY")]
        public System.String ZY { get; set; }
        /// <summary>
        /// 外币金额
        /// </summary>
        [DbColumn("WBJE")]
        public System.Decimal WBJE { get; set; }
        /// <summary>
        /// 汇率
        /// </summary>
        [DbColumn("WBHL")]
        public System.Decimal WBHL { get; set; }
        /// <summary>
        /// 数量
        /// </summary>
        [DbColumn("SL")]
        public System.Decimal SL { get; set; }
        /// <summary>
        /// 单价
        /// </summary>
        [DbColumn("DJ")]
        public System.Decimal DJ { get; set; }
        /// <summary>
        /// 借方金额
        /// </summary>
        [DbColumn("JFJE")]
        public System.Decimal JFJE { get; set; }
        /// <summary>
        /// 贷方金额
        /// </summary>
        [DbColumn("DFJE")]
        public System.Decimal DFJE { get; set; }

        [DbColumn("IDGZ")]
        public System.Int32 IDGZ { get; set; }
        /// <summary>
        /// 部门
        /// </summary>
        [DbColumn("IDBM")]
        public System.Int32 IDBM { get; set; }
        /// <summary>
        /// 项目ID
        /// </summary>
        [DbColumn("IDXM")]
        public System.Int32 IDXM { get; set; }
        /// <summary>
        /// 供应商
        /// </summary>
        [DbColumn("IDGYS")]
        public System.Int32 IDGYS { get; set; }
        /// <summary>
        /// 客户
        /// </summary>
        [DbColumn("IDYH")]
        public System.Int32 IDYH { get; set; }

        [DbColumn("IDJSFS")]
        public System.Int32 IDJSFS { get; set; }

        [DbColumn("JSRQ")]
        public System.DateTime? JSRQ { get; set; }

        [DbColumn("JSPJH")]
        public System.String JSPJH { get; set; }

        [DbColumn("SFDZ")]
        public System.Boolean? SFDZ { get; set; }
        /// <summary>
        /// 序号
        /// </summary>
        [DbColumn("LNNO")]
        public System.Int32 LNNO { get; set; }
        /// <summary>
        /// 固定资产标志
        /// </summary>
        [DbColumn("GZBZ")]
        public System.Int32 GZBZ { get; set; }

        [DbColumn("IDJBR")]
        public System.Int32 IDJBR { get; set; }
        /// <summary>
        /// 外币ID
        /// </summary>
        [DbColumn("IDWB")]
        public System.Int32 IDWB { get; set; }

    }

}
