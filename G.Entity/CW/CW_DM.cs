using System;
using G.Data.Definition;
using G.Data.Model.Handler;

namespace G.Entity.CW
{
    public class CW_DM : DbObjectModel<CW_DM, int>
    {
        [Length(50)]
        public string DM { get; set; }
        [Length(100)]
        public string NAME { get; set; }
        [AllowNull]
        [Length(5000)]
        public string DETAILNAME { get; set; }
        public int? KMFL { get; set; }
        [Length(20)]
        public string YEFX { get; set; }
        [AllowNull]
        [Length(20)]
        public string PY { get; set; }
        [AllowNull]
        [Length(6)]
        public string JLDWNAME { get; set; }
        public int? IDWB { get; set; }
        public int? LEVELNUM { get; set; }
        public int? ISDETIAL { get; set; }
        [AllowNull]
        [Length(8)]
        [Index(UNIQUE = true)]
        public byte[] FTIMESTAMP { get; set; }
        public int? PARENTID { get; set; }
        public int? SORTID { get; set; }
        public int? HSYHF { get; set; }
        public int? HSGYSF { get; set; }
        [HasOne(OrderBy = "ID")]
        public CW_PZ PZ { get; set; }
    }

}
