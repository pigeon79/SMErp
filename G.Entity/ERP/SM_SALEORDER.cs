using System;
using G.Data.Definition;
using G.Data.Model.Handler;
using System.Collections.Generic;

namespace G.Entity.ERP
{
    [DbView("SM_SALEORDER_V1")]
    public class SM_SALEORDER : DbObjectModel<SM_SALEORDER, int>
    {
        public SM_SALEORDER()
        {
            ISSELECT = false;
            ORDERID = "";
            ORDERDATE = DateTime.Now;
            CUSTID = 0;
            INVCUSTID = 0;
            ORDERTYPE = "1";
            FTTAG = false;
            RECADDRESS = "";
            STATUS = "N";
            SALESMAN = "";
            SALESREP = "";
            INOFC = "";
            REMARK = "";
            INVTAG = false;
            ORDQTY = 0;
            ORDAMOUNT = 0;
            ORDDISCOUNT = 0;
            MAGTAG = false;
            CLOTHTYPE = "";
            THICK = 0;
            REQDATE = DateTime.Now;
            PROTAG = false;
            SUPPTAG = false;
            OPERATOR = "";
            OPERDATE = DateTime.Now;
            CUSTORDNB = "";
            AUDITOR = "";
            AUDITDATE = null;
            OTHAMOUNT = 0;
            ORDSTATUS = 0;
            SALEITEMTYPE = "";
        }
        [QueryRequired]
        public Boolean ISSELECT { get; set; }
        //[AllowNull]
        [Length(12)]
        public string ORDERID { get; set; }
        public DateTime? ORDERDATE { get; set; }
        public int? CUSTID { get; set; }
        public int? INVCUSTID { get; set; }
        [QueryRequired,AllowNull]
        public string CUSTNAME { get; set; }
        [QueryRequired, AllowNull]
        public string INVCUSTNAME { get; set; }
        [QueryRequired, AllowNull]
        public string CUSTLEV { get; set; }
        [QueryRequired, AllowNull]
        public string SALESMANNAME { get; set; }
        [QueryRequired, AllowNull]
        public string SALESREPNAME { get; set; }
        [QueryRequired,AllowNull]
        public string INOFCNAME { get; set; }
        [AllowNull]
        [Length(10)]
        public string ORDERTYPE { get; set; }
        public bool? FTTAG { get; set; }
        [AllowNull]
        [Length(200)]
        public string RECADDRESS { get; set; }
        [AllowNull]
        [Length(1)]
        public string STATUS { get; set; }
        [QueryRequired, AllowNull]
        public string STATUSNAME { get; set; }
        [AllowNull]
        [Length(10)]
        public string SALESMAN { get; set; }
        [AllowNull]
        [Length(10)]
        public string SALESREP { get; set; }
        [AllowNull]
        [Length(10)]
        public string INOFC { get; set; }
        [AllowNull]
        [Length(1000)]
        public string REMARK { get; set; }
        public bool? INVTAG { get; set; }
        public System.Decimal? ORDQTY { get; set; }
        public System.Decimal? ORDAMOUNT { get; set; }
        public System.Decimal? OTHAMOUNT { get; set; }
        public System.Decimal? ORDDISCOUNT { get; set; }
        public bool? MAGTAG { get; set; }
        [AllowNull]
        [Length(10)]
        public string CLOTHTYPE { get; set; }
        public int? THICK { get; set; }
        public DateTime? REQDATE { get; set; }
        public bool? PROTAG { get; set; }
        public bool? SUPPTAG { get; set; }
        [AllowNull]
        [Length(10)]
        public string SALEITEMTYPE { get; set; }

        [AllowNull]
        [Length(10)]
        public string OPERATOR { get; set; }
        public DateTime? OPERDATE { get; set; }
        [HasMany(OrderBy = "ID")]
        public IList<SM_SALEORDERDTL> SALEORDERDTL { get; private set; }
        [AllowNull]
        [Length(50)]
        public string CUSTORDNB { get; set; }
        [AllowNull]
        [Length(10)]
        public string AUDITOR { get; set; }
        public DateTime? AUDITDATE { get; set; }
        [QueryRequired]
        public bool? PRINTTAG { get; set; }
        [QueryRequired, AllowNull]
        public string ORDERTYPENAME { get; set; }
        [QueryRequired]
        public bool? POCKETTAG { get; set; }
        /// <summary>
        /// 0-新增 1-外协对库完成 2-车间生产下达 3-外协完全下达
        /// </summary>
        [QueryRequired]
        public int? ORDSTATUS { get; set; }
        public string ORDSTATUSNAME { get {
            string s = "";
            switch (ORDSTATUS) {
                case 0:
                    s = "未计划";
                    break;
                case 1:
                    s="对库完成";
                    break;
                case 2:
                    s="计划完成";
                    break;
                case 3:
                    s="外协完成";
                    break;
            }
            return s;
        } }
    }

}
