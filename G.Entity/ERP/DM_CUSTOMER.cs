using System;
using G.Data.Definition;
using G.Data.Model.Handler;

namespace G.Entity.ERP
{
    [DbView("DM_CUSTOMER_V1")]
    public class DM_CUSTOMER : DbObjectModel<DM_CUSTOMER, int>
    {
        public DM_CUSTOMER()
        {
            CUSTCODE = "";
            CUSTNAME = "";
            CUSTLEV = "";
            FOUNDDATE = DateTime.Now;
            SALESMAN = "";
            SALESREP = "";
            INOFC = "";
            PY = "";
            CUSTTYPE = "";
            BOSS = "";
            TEL = "";
            CONTACTS = "";
            CONTEL = "";
            ADDRESS = "";
            FAX = "";
            BUYER = "";
            BUYTEL = "";
            INVCUSTCODE = "";
            JSFS = "";
            PAYTYPE = "";
            DISCOUNT = 1;
            AREA = "";
            BANK = "";
            BANKACCOUNT = "";
            TRADE = "";
            REMARK = "";
            ORDERINFO = "";
            OPERATOR = "";
            OPERDATE = DateTime.Now;
        }
        [AllowNull]
        [Length(20)]
        public string CUSTCODE { get; set; }
        [AllowNull]
        [Length(100)]
        public string CUSTNAME { get; set; }
        [AllowNull]
        [Length(2)]
        public string CUSTLEV { get; set; }
        public DateTime? FOUNDDATE { get; set; }
        [AllowNull]
        [Length(20)]
        public string SALESMAN { get; set; }
        [AllowNull]
        [Length(20)]
        public string SALESREP { get; set; }
        [AllowNull]
        [Length(20)]
        public string INOFC { get; set; }
        [AllowNull]
        [Length(20)]
        public string PY { get; set; }
        [AllowNull]
        [Length(20)]
        public string CUSTTYPE { get; set; }
        [AllowNull]
        [Length(20)]
        public string BOSS { get; set; }
        [AllowNull]
        [Length(20)]
        public string TEL { get; set; }
        [AllowNull]
        [Length(20)]
        public string CONTACTS { get; set; }
        [AllowNull]
        [Length(50)]
        public string CONTEL { get; set; }
        [AllowNull]
        [Length(100)]
        public string ADDRESS { get; set; }
        [AllowNull]
        [Length(20)]
        public string FAX { get; set; }
        [AllowNull]
        [Length(20)]
        public string BUYER { get; set; }
        [AllowNull]
        [Length(20)]
        public string BUYTEL { get; set; }
        [AllowNull]
        [Length(20)]
        public string INVCUSTCODE { get; set; }
        [AllowNull]
        [Length(20)]
        public string JSFS { get; set; }
        [AllowNull]
        [Length(20)]
        public string PAYTYPE { get; set; }
        public System.Decimal? DISCOUNT { get; set; }
        [AllowNull]
        [Length(200)]
        public string AREA { get; set; }
        [AllowNull]
        [Length(50)]
        public string BANK { get; set; }
        [AllowNull]
        [Length(50)]
        public string BANKACCOUNT { get; set; }
        [AllowNull]
        [Length(20)]
        public string TRADE { get; set; }
        [AllowNull]
        [Length(800)]
        public string REMARK { get; set; }
        [AllowNull]
        [Length(800)]
        public string ORDERINFO { get; set; }
        [AllowNull]
        [Length(10)]
        public string OPERATOR { get; set; }
        public DateTime? OPERDATE { get; set; }
        [QueryRequired, AllowNull]
        public string SALESMANNAME { get; set; }
        [QueryRequired, AllowNull]
        public string SALESREPNAME { get; set; }
        [QueryRequired, AllowNull]
        public string INOFCNAME { get; set; }
        [QueryRequired, AllowNull]
        public string BUYERNAME { get; set; }
        [QueryRequired, AllowNull]
        public string OPERATORNAME { get; set; }
        [QueryRequired, AllowNull]
        public string INVCUSTNAME { get; set; }
    }
}
