using System;
using System.Collections.Generic;
using G.Data.Definition;
using G.Data.Model.Handler;

namespace G.Entity.SysEnt
{
    public class ND_BILL : DbObjectModel<ND_BILL,int>
    {
        [AllowNull]
        [Length(50)]
        public string ZTNAME { get; set; }
        [Length(50)]
        public string DJLX { get; set; }
        public int? ISINUSE { get; set; }
        [AllowNull]
        [Length(50)]
        public string BILLCAPTION { get; set; }
        [AllowNull]
        [Length(50)]
        public string LBDM { get; set; }
        [AllowNull]
        [Length(500)]
        public string DELVALIDTABLE { get; set; }
        [AllowNull]
        [Length(50)]
        public string KM1 { get; set; }
        [AllowNull]
        [Length(50)]
        public string KM1_V { get; set; }
        [AllowNull]
        [Length(50)]
        public string KM2 { get; set; }
        [AllowNull]
        [Length(50)]
        public string KM2_V { get; set; }
        [AllowNull]
        [Length(50)]
        public string KM_V { get; set; }
        [AllowNull]
        [Length(50)]
        public string BILLTYPE { get; set; }
        [AllowNull]
        [Length(50)]
        public string MEMO { get; set; }
        [AllowNull]
        [Length(50)]
        public string FOREIGNKEYNAME { get; set; }
        public bool? ISSYSTEM { get; set; }
        public bool? ISAUTONO { get; set; }
        [AllowNull]
        [Length(50)]
        public string PREFIXNO { get; set; }
        public int? NOLENGTH { get; set; }
        public int? MAXNO { get; set; }
        [AllowNull]
        [Length(8000)]
        public string SELECTSQL { get; set; }
        public bool? ISUSEAUDIT { get; set; }
        public bool? ISPERIODLOCKED { get; set; }
        [AllowNull]
        [Length(50)]
        public string ORDERBYFIELD { get; set; }
        [AllowNull]
        [Length(500)]
        public string BILLDLLNAME { get; set; }
        [AllowNull]
        [Length(500)]
        public string FACADENAME { get; set; }
        [AllowNull]
        public string FORMXML { get; set; }
        [AllowNull]
        [Length(8000)]
        public string PRINTSETXML { get; set; }
        [AllowNull]
        public string REPORTXML { get; set; }
        [AllowNull]
        [Length(50)]
        public string ENTITYNAME { get; set; }
        public int? ISEFFECTAFTERAUDIT { get; set; }
        [AllowNull]
        [Length(500)]
        public string REPORTACTION { get; set; }
        [AllowNull]
        [Length(50)]
        public string REPORTTYPE { get; set; }
        [AllowNull]
        [Length(50)]
        public string LISTMODE { get; set; }
        [AllowNull]
        [Length(200)]
        public string RPTNAME_PRINT { get; set; }
        [AllowNull]
        [Length(8000)]
        public string EXTENDXML { get; set; }
        public int? ACCESSTYPE { get; set; }
        [AllowNull]
        [Length(50)]
        public string PRD_UID { get; set; }
        public int? AUTOMESSAGE { get; set; }
    }
}
