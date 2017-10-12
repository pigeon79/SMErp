using System;
using G.Data.Definition;
using G.Data.Model.Handler;

namespace G.Entity.ERP
{
    [DbView("SM_BOMTEMP_V1")]
    public class SM_BOMTEMP : DbObjectModel<SM_BOMTEMP, int>
    {
        public SM_BOMTEMP()
        {
            ISSELECT = false;
            FATHERITEM = "";
            ITEMCODE = "";
            REQUIREQTY = 0;
            SAFESTOCK = 0;
            ADVICEQTY = 0;
            BOMQTY = 0;
            ITEMLEVEL = 0;
            ORDERID = "";
            ORDLNNO = 0;
            ATTRIBUTEA = "";
            ATTRIBUTEB = "";
            ATTRIBUTEC = 0;
            ATTRIBUTED = "";
            ATTRIBUTEE = "";
            SBEGINDATE = null;
            SENDDATE = null;
            STATUS = "";
            SHOPORDERID = "";
            TYPEID = "";
            BATCHNUMBER = 0;
            MEMO = "";
            OPERDATE = DateTime.Now;
            OPERATOR = "";
            PURDATE = DateTime.Now;
            PRODATE = null;
            ASSISTDATE = DateTime.Now;
            ASSISTQTY = 0;
            ASSISTSTATUS = 0;
            UNASSISTQTY = 0;
            UNPLANQTY = 0;
            SUPPRICE = 0;
            SUPCODE = "";
            PURQTY = 0;
        }
        [QueryRequired]
        public Boolean ISSELECT { get; set; }
        [AllowNull]
        [Length(20)]
        public string FATHERITEM { get; set; }
        [AllowNull]
        [Length(20)]
        public string ITEMCODE { get; set; }
        public System.Decimal? REQUIREQTY { get; set; }//需求数包括损耗数
        public System.Decimal? SAFESTOCK { get; set; }
        public System.Decimal? ADVICEQTY { get; set; }//需生产数量
        public System.Decimal? BOMQTY { get; set; }//销售订单分解成品后订单数
        public int? ITEMLEVEL { get; set; }
        [AllowNull]
        [Length(50)]
        public string ORDERID { get; set; }
        public short? ORDLNNO { get; set; }
        [AllowNull]
        [Length(50)]
        public string ATTRIBUTEA { get; set; }//色号
        [AllowNull]
        [Length(50)]
        public string ATTRIBUTEB { get; set; }//花模
        public System.Decimal? ATTRIBUTEC { get; set; }//尺寸
        [AllowNull]
        [Length(20)]
        public string ATTRIBUTED { get; set; }
        [AllowNull]
        [Length(20)]
        public string ATTRIBUTEE { get; set; }
        public DateTime? SBEGINDATE { get; set; }
        public DateTime? SENDDATE { get; set; }
        [AllowNull]
        [Length(1)]
        public string STATUS { get; set; }
        [AllowNull]
        [Length(11)]
        public string SHOPORDERID { get; set; }
        [AllowNull]
        [Length(1)]//类别 1-分解后成品
        public string TYPEID { get; set; }
        public int? BATCHNUMBER { get; set; }
        [AllowNull]
        [Length(500)]
        public string MEMO { get; set; }
        public DateTime? OPERDATE { get; set; }
        [AllowNull]
        [Length(10)]
        public string OPERATOR { get; set; }

        [QueryRequired, AllowNull]
        public string ITEMNAME { get; set; }
        [QueryRequired, AllowNull]
        public string ATTRIBUTEBNAME { get; set; }
        [QueryRequired]
        public decimal? UNASSISTQTY { get; set; }//未外协数
        [QueryRequired, AllowNull]
        public string INVUNIT { get; set; }
        public DateTime? PURDATE { get; set; }//采购交期
        public DateTime? PRODATE { get; set; }//生产交期
        public DateTime? ASSISTDATE { get; set; }//外协交期
        public System.Decimal? ASSISTQTY { get; set; }//外协数量
        public int? ASSISTSTATUS { get; set; }//仓库外协状态
        public System.Decimal? PLANQTY { get; set; }//计划生产数量
        [QueryRequired]
        public System.Decimal? UNPLANQTY { get; set; }//未计划生产数量
        public decimal? PURQTY { get; set; }//采购数量
        public decimal? STOCKQTY { get; set; }//库存数量
        [QueryRequired]
        public decimal? SUPPRICE { get; set; }
        [QueryRequired, AllowNull]
        public string SUPCODE { get; set; }
        [QueryRequired]
        public decimal? ONHANDQTY { get; set; }
        [QueryRequired]
        public decimal? ONHANDQTY1 { get; set; }
        [QueryRequired]
        public DateTime? RDATE { get; set; }
        [QueryRequired, AllowNull]
        public string FATHERITEMNAME { get; set; }//父物品名称
        [QueryRequired]
        public decimal? FATHERISIZE { get; set; }//父物品规格
        [QueryRequired]
        public int? DUEQTY { get; set; }//下达数
        [QueryRequired]
        public int? LEFTQTY { get; set; }//剩余数
    }

}
