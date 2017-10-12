using System;
using G.Data.Definition;
using G.Data.Model.Handler;

namespace G.Entity.SysEnt
{
    [Cacheable]
    public class ND_ORGINAZITION : DbObjectModel<ND_ORGINAZITION, int>
    {
        public ND_ORGINAZITION()
        {
            ORGNAME = "";
            MEMO = "";
            SORTID = 0;
            ISUNIT = 0;
            PARENTID = 0;
            MNEMONIC = "";
            ORGDM = "";
            ISDETAIL = 0;
            TREELEVEL = 0;
            USERCOUNT = 0;
        }
        [AllowNull]
        [Length(100)]
        public string ORGNAME { get; set; }
        [AllowNull]
        [Length(500)]
        public string MEMO { get; set; }
        public int? SORTID { get; set; }
        public int? ISUNIT { get; set; }
        public int? PARENTID { get; set; }
        [AllowNull]
        [Length(10)]
        public string MNEMONIC { get; set; }
        [AllowNull]
        [Length(10)]
        public string ORGDM { get; set; }
        public int? ISDETAIL { get; set; }
        public int? TREELEVEL { get; set; }
        public int? USERCOUNT { get; set; }
    }
}
