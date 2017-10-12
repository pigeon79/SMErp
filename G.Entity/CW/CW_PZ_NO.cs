using System;
using G.Data.Definition;
using G.Data.Model.Handler;
using System.Collections.Generic;

namespace G.Entity.CW
{
	public class CW_PZ_NO : DbObjectModel<CW_PZ_NO, int>
	{
        public CW_PZ_NO() {
            this.RQ = DateTime.Now;
            this.YWRQ = DateTime.Now;
            this.CZYNAME = "";
            this.DJLX = "";
            this.DJLX_DJ = "";
            this.FHYNAME = "";
            this.JZRNAME = "";
            this.IDDJ = "";
            this.JZRNAME = "";
            this.LBDM = "";
            this.ZT = "";
            this.MEMO = "";
        }
        /// <summary>
        /// 年份
        /// </summary>
        [DbColumn("NF"), Description("年份")]
		public System.Int32 NF{get;set;}
        /// <summary>
        /// 会计期间
        /// </summary>
        [DbColumn("KJQJ"), Description("会计期间")]
		public System.Int32 KJQJDM{get;set;}
        /// <summary>
        /// 单据类型
        /// </summary>
        [DbColumn("DJLX")]
		public System.String DJLX{get;set;}
        /// <summary>
        /// 类别代码
        /// </summary>
        [DbColumn("LBDM")]
        public System.String LBDM { get; set; }
        /// <summary>
        /// 凭证类别
        /// </summary>
        [DbColumn("IDPZLB")]
		public System.Int32 IDPZLB{get;set;}
        /// <summary>
        /// 凭证编号
        /// </summary>
        [DbColumn("NO")]
		public System.Int32 NO{get;set;}
        /// <summary>
        /// 单据日期
        /// </summary>
        [DbColumn("RQ")]
		public System.DateTime? RQ{get;set;}
        /// <summary>
        /// 附件张数
        /// </summary>
        [DbColumn("FJZS")]
		public System.Int32 FJZS{get;set;}
        /// <summary>
        /// 合计借方
        /// </summary>
        [DbColumn("JFJEHJ")]
		public System.Decimal JFJEHJ{get;set;}
        /// <summary>
        /// 合计贷方
        /// </summary>
        [DbColumn("DFJEHJ")]
		public System.Decimal DFJEHJ{get;set;}
        /// <summary>
        /// 制单员
        /// </summary>
        [DbColumn("CZYNAME")]
        public System.String CZYNAME { get; set; }
        /// <summary>
        /// 审核员
        /// </summary>
        [DbColumn("FHYNAME")]
        public System.String FHYNAME { get; set; }
        /// <summary>
        /// 审核日期
        /// </summary>
        [DbColumn("FHRQ")]
		public System.DateTime? FHRQ{get;set;}
        /// <summary>
        /// 
        /// </summary>
        [DbColumn("ZT")]
        public System.String ZT { get; set; }
        /// <summary>
        /// 记账标志
        /// </summary>
        [DbColumn("JZBZ")]
		public System.Boolean JZBZ{get;set;}
        /// <summary>
        /// 审核标志
        /// </summary>
        [DbColumn("SHBZ")]
		public System.Boolean SHBZ{get;set;}
        /// <summary>
        /// 作废标志
        /// </summary>
        [DbColumn("ZFBZ")]
		public System.Boolean ZFBZ{get;set;}
        /// <summary>
        /// 记账人员
        /// </summary>
        [DbColumn("JZRNAME")]
        public System.String JZRNAME { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DbColumn("DJLX_DJ")]
        public System.String DJLX_DJ { get; set; }
        /// <summary>
        /// 关联单据ID
        /// </summary>
        [DbColumn("IDDJ")]
        public System.String IDDJ { get; set; }
        /// <summary>
        /// 现金分配标志
        /// </summary>
        [DbColumn("XJFPF")]
		public System.Boolean XJFPF{get;set;}
        /// <summary>
        /// 自动生成标志
        /// </summary>
        [DbColumn("BERP")]
		public System.Boolean BERP{get;set;}
        /// <summary>
        /// 
        /// </summary>
        [DbColumn("ISSEND")]
		public System.Int32 ISSEND{get;set;}
        /// <summary>
        /// 
        /// </summary>
        [DbColumn("FVOUCHERID")]
		public System.Int32 FVOUCHERID{get;set;}
        /// <summary>
        /// 
        /// </summary>
        [DbColumn("VOUCHERNO")]
		public System.Int32 VOUCHERNO{get;set;}
        /// <summary>
        /// 摘要
        /// </summary>
        [DbColumn("MEMO")]
        public System.String MEMO { get; set; }
        /// <summary>
        /// 业务日期
        /// </summary>
        [DbColumn("YWRQ")]
        public System.DateTime? YWRQ { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [HasMany(OrderBy = "ID")]
        public IList<CW_PZ> PZ { get; private set; }
      }
                                             
}
