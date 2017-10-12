using System;
using G.Data.Definition;
using G.Data.Model.Handler;

namespace G.Entity.SysEnt
{
    public class ND_BILLENTRY : DbObjectModel<ND_BILLENTRY,int>
    {
        [AllowNull]
        [Length(50)]
        public string DJLX { get; set; }
        [AllowNull]
        [Length(50)]
        public string FIELDNAME { get; set; }
        [AllowNull]
        [Length(600)]
        public string FIELDCAPTION { get; set; }
        [AllowNull]
        [Length(500)]
        public string FIELDCAPTIONTWO { get; set; }
        [AllowNull]
        [Length(50)]
        public string KJBM { get; set; }
        [AllowNull]
        [Length(50)]
        public string SOURCETABLE { get; set; }
        [AllowNull]
        [Length(50)]
        public string SOURCEKEYNAME { get; set; }
        [AllowNull]
        [Length(50)]
        public string SOURCECODE { get; set; }
        [AllowNull]
        [Length(50)]
        public string SOURCENAME { get; set; }
        [AllowNull]
        [Length(500)]
        public string SOURCECONDITION { get; set; }
        public int EDITINDEX { get; set; }
        public int? LISTINDEX { get; set; }
        [AllowNull]
        [Length(50)]
        public string ATTACHFIELD { get; set; }
        public bool? ISINUSE { get; set; }
        public bool? ISDESIGNABLE { get; set; }
        public bool? ISVISIBLE_EDIT { get; set; }
        public bool? ISVISIBLE_LIST { get; set; }
        public bool? ISUPDATE { get; set; }
        public bool? ISREADONLY { get; set; }
        public bool? ISAUTOCOPY { get; set; }
        public bool? ISMUST { get; set; }
        [AllowNull]
        [Length(50)]
        public string SFPX { get; set; }
        [AllowNull]
        [Length(50)]
        public string FIELDTYPE { get; set; }
        public int? FIELDLEN { get; set; }
        public int? POINTLEN { get; set; }
        [AllowNull]
        [Length(50)]
        public string DISPFORMAT { get; set; }
        [AllowNull]
        [Length(5000)]
        public string EXPRESSION { get; set; }
        [AllowNull]
        [Length(40)]
        public string ERRORMESSAGE { get; set; }
        public bool? ISVALID { get; set; }
        [AllowNull]
        [Length(500)]
        public string VALIDTYPE { get; set; }
        [AllowNull]
        [Length(500)]
        public string DEFAULTVALUE { get; set; }
        public System.Decimal? WIDTH { get; set; }
        public int? CON_LEFT { get; set; }
        public int? CON_TOP { get; set; }
        public int? CON_WIDTH { get; set; }
        public int? CON_HEIGHT { get; set; }
        public bool? DJTXT_LABELFX { get; set; }
        public int? DJTXT_STYLETYPE { get; set; }
        public int? DJTXT_DATATYPE { get; set; }
        [AllowNull]
        [Length(50)]
        public string CON_TYPE { get; set; }
        public int? CON_ALIGNMENT { get; set; }
        [AllowNull]
        [Length(50)]
        public string CON_FORECOLOR { get; set; }
        [AllowNull]
        [Length(50)]
        public string CON_BACKCOLOR { get; set; }
        [AllowNull]
        [Length(50)]
        public string CON_FONT { get; set; }
        public int? CON_TABINDEX { get; set; }
        [AllowNull]
        [Length(50)]
        public string CON_CONTAINER { get; set; }
        public int? ZDXSLX { get; set; }
        [AllowNull]
        [Length(1)]
        public string FCLASS { get; set; }
        [AllowNull]
        [Length(50)]
        public string BORDERLINECOLOR { get; set; }
        public System.Decimal? BORDERLINEWIDTH { get; set; }
        public bool? BORDERLINESLANT { get; set; }
        public bool? ALLOWMULTISELECT { get; set; }
        public bool? MULTILINE { get; set; }
        public bool? AUTONEW { get; set; }
        [AllowNull]
        [Length(50)]
        public string ATTACHFIELDTWO { get; set; }
        [AllowNull]
        [Length(8000)]
        public string EXTENDXML { get; set; }
    }


}
