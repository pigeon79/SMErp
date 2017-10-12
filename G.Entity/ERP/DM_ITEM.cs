using System;
using G.Data.Definition;
using G.Data.Model.Handler;

namespace G.Entity.ERP
{
    [DbView("DM_ITEM_V1")]
    public class DM_ITEM : DbObjectModel<DM_ITEM, int>
    {
        public DM_ITEM()
        {
            ItemCode = "";
            ItemDesc = "";
            ItemName = "";
            Size = "";
            InvUnit = "";
            ABC = "";
            InvClassID = 0;
            FinaClassID = 0;
            TaxCode = "";
            ItemType = "";
            WrhsCode = "";
            LocCode = "";
            LockTag = false;
            OrgDm = "";
            OperDate = DateTime.Now;
            Operator = "";
            Remark = "";
            BreakPer = 0;
            SafeStock = 0;
            MaxStock = 0;
            StandCost = 0;
            ActCost = 0;
            IsAttributeA = false;
            IsAttributeB = false;
            IsAttributeC = false;
            IsAttributeD = false;
            IsAttributeE = false;
            ItemTypeID = 0;
            Py = "";
            PicPath = "";
            SUPCODE = "";
            SUPPNAME = "";
            SUPPRICE = 0;
            CertQty = 0;
            WorkOrdQty = 0;
            MaxCap = 0;
            METNAME = "";
            WEIGHT = 0;
            ISIZE = 0;
            SCRAPRATE = 0;
            ISPUR = 0;
        }
        [Length(50), Description("物品代码")]
        public string ItemCode { get; set; }
        [Length(100), Description("物品描述")]
        public string ItemDesc { get; set; }
        [AllowNull]
        [Length(100), Description("物品名称")]
        public string ItemName { get; set; }
        [AllowNull]
        [Length(50), Description("规格")]
        public string Size { get; set; }
        [AllowNull]
        [Length(4), Description("计量单位")]
        public string InvUnit { get; set; }
        [AllowNull]
        [Length(1), Description("ABC分类")]
        public string ABC { get; set; }
        [Description("库存类别")]
        public int InvClassID { get; set; }
        [Description("财务类别")]
        public int FinaClassID { get; set; }
        [AllowNull]
        [Length(4)]
        public string TaxCode { get; set; }
        [AllowNull]
        [Length(2), Description("物品分类限制")]
        public string ItemType { get; set; }
        public System.Decimal? SafeStock { get; set; }
        public System.Decimal? MaxStock { get; set; }
        public System.Decimal? StandCost { get; set; }
        public System.Decimal? ActCost { get; set; }
        [AllowNull]
        [Length(2), Description("仓库")]
        public string WrhsCode { get; set; }
        [AllowNull]
        [Length(5), Description("库位")]
        public string LocCode { get; set; }
        public bool? UseLot { get; set; }
        [Description("停用标志")]
        public bool? LockTag { get; set; }
        [AllowNull]
        [Length(10)]
        public string Operator { get; set; }
        public DateTime? OperDate { get; set; }
        [AllowNull]
        [Length(6), Description("部门")]
        public string OrgDm { get; set; }
        public short? PeriodDays { get; set; }
        public int? Multiple { get; set; }
        public bool? QltFlag { get; set; }
        [AllowNull]
        [Length(200)]
        public string Remark { get; set; }
        public System.Decimal? BreakPer { get; set; }
        /// <summary>
        /// 是否色号
        /// </summary>
        public bool? IsAttributeA { get; set; }
        /// <summary>
        /// 是否花模
        /// </summary>
        public bool? IsAttributeB { get; set; }
        /// <summary>
        /// 是否规格尺寸
        /// </summary>
        public bool? IsAttributeC { get; set; }
        public bool? IsAttributeD { get; set; }
        public bool? IsAttributeE { get; set; }
        public System.Decimal? FixFeedPer { get; set; }
        public int? MaxCap { get; set; }
        [Description("物品大类分类")]
        public int? ItemTypeID { get; set; }
        public bool? IfLimited { get; set; }
        [AllowNull]
        [Length(20), Description("辅助码")]
        public string Py { get; set; }
        [AllowNull]
        [Length(100)]
        public string ItemEnglish { get; set; }
        [AllowNull]
        [Length(500)]
        public string PicPath { get; set; }
        [AllowNull]
        [Length(50)]
        public string SUPCODE { get; set; }
        public decimal? SUPPRICE { get; set; }
        [Description("合格证批量数量")]
        public int? CertQty { get; set; }
        [Description("派工单批量数量")]
        public int? WorkOrdQty { get; set; }
        [AllowNull]
        [Length(50), Description("材料名称")]
        public string METNAME { get; set; }
        [Description("克重")]
        public Decimal? WEIGHT { get; set; }
        [Description("规格")]
        public Decimal? ISIZE { get; set; }
        [Description("废料比列")]
        public Decimal? SCRAPRATE { get; set; }
        [Description("是否采购")]
        public int? ISPUR { get; set; }

        [QueryRequired, AllowNull]
        public string WRHSNAME { get; set; }
        [QueryRequired, AllowNull]
        public string LOCNAME { get; set; }
        [QueryRequired, AllowNull]
        public string INVNAME { get; set; }
        [QueryRequired, AllowNull]
        public string FINANAME { get; set; }
        [QueryRequired, AllowNull]
        public string ITEMTYPENAME { get; set; }
        [QueryRequired, AllowNull]
        public string ORGNAME { get; set; }
        [QueryRequired, AllowNull]
        public string SUPPNAME { get; set; }
    }
}
