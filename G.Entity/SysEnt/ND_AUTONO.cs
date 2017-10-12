using System;
using G.Data.Definition;
using G.Data.Model.Handler;

namespace G.Entity.SysEnt
{
    public class ND_AUTONO : DbObjectModel<ND_AUTONO,int>
    {
        [AllowNull]
        [Length(50)]
        public string DJLX { get; set; }
        [AllowNull]
        [Length(50)]
        public string PREFIX { get; set; }
        public int? MAXNO { get; set; }
        public int? AUTONOLENGTH { get; set; }
        [AllowNull]
        [Length(50)]
        public string AUTOTYPE { get; set; }
        [AllowNull]
        [Length(50)]
        public string TABLENAME { get; set; }
        [AllowNull]
        [Length(50)]
        public string FIELDNAME_NO { get; set; }
        public DateTime? MODIFYDATE { get; set; }
        [AllowNull]
        [Length(50)]
        public string MEMO { get; set; }
    }
}
