using System;
using G.Data.Definition;
using G.Data.Model.Handler;

namespace G.Entity.SysEnt
{
    [Cacheable]
    public class ND_ROLE : DbObjectModel<ND_ROLE, int>
    {
        public ND_ROLE()
	{
		ROLENAME = "";
		ROLETYPE = 0;
		MNEMONIC = "";
		MEMO = "";
	}
        [Length(50)]
        public string ROLENAME { get; set; }
        public int? ROLETYPE { get; set; }
        [AllowNull]
        [Length(8)]
        [Index(UNIQUE = true)]
        public byte[] FTIMESTAMP { get; set; }
        [AllowNull]
        [Length(50)]
        public string MNEMONIC { get; set; }
        [AllowNull]
        [Length(50)]
        public string MEMO { get; set; }
    }


}
