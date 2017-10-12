using System;
using G.Data.Definition;
using G.Data.Model.Handler;
using System.Collections.Generic;

namespace G.Entity.ERP
{
    public class DM_WHB : DbObjectModel<DM_WHB, int>
    {
        public DM_WHB()
        {
            FZDM = "";
            FZNAME = "";
            WHBLBID = 0;
            PY = "";
        }
        [AllowNull]
        [Length(50)]
        public string FZDM { get; set; }
        [AllowNull]
        [Length(500)]
        public string FZNAME { get; set; }
        public int? WHBLBID { get; set; }
        [AllowNull]
        [Length(20)]
        public string PY { get; set; }
    }
}
