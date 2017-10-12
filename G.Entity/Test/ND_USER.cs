using System;
using G.Data.Definition;
using G.Data.Model.Handler;

namespace G.Entity.Test
{
    [Cacheable]
    public class ND_USER : DbObjectModel<ND_USER,int>
    {
        //[DbColumn("USERID"), DbKey]
        //public int USERID { get; set; }

        [DbColumn("U_USERID")]
        public string U_USERID { get; set; }

        [DbColumn("USERNAME")]
        public string USERNAME { get; set; }

        [DbColumn("PASSWORD")]
        public string PASSWORD { get; set; }

        [DbColumn("ISMANAGER")]
        public bool ISMANAGER { get; set; }
    }
}
