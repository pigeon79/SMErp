using System;
using G.Data.Definition;
using G.Data.Model.Handler;

namespace G.Entity.SysEnt
{
    [Cacheable]
    public class ND_USER_ROLE : DbObjectModel<ND_USER_ROLE,int>
    {
        public int? USERID { get; set; }
        public int? ROLEID { get; set; }
    }
}
