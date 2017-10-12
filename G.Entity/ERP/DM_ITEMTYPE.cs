using System;
using G.Data.Definition;
using G.Data.Model.Handler;

namespace G.Entity.ERP
{
    public class DM_ITEMTYPE : DbObjectModel<DM_ITEMTYPE,int>
    {
        [AllowNull]
        [Length(10)]
        public string TYPECODE { get; set; }
        [AllowNull]
        [Length(50)]
        public string TYPEDESC { get; set; }
        [AllowNull]
        [Length(200)]
        public string MEMO { get; set; }
        public int? PARENTID { get; set; }
        public DateTime? OperDate { get; set; }
        [AllowNull]
        [Length(10)]
        public string Operator { get; set; }
    }
}
