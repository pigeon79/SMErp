using System;
using G.Data.Definition;
using G.Data.Model.Handler;

namespace G.Entity.ERP
{
    [DbView("SM_ITEMROUTING_V1")]
    public class SM_ITEMROUTING : DbObjectModel<SM_ITEMROUTING, int>
    {
        public SM_ITEMROUTING()
        {
            SORTID = 0;
            GXID = 0;
            ISASSIST = false;
            ITEMTYPEID = 0;
        }
        public int? SORTID { get; set; }
        public int? GXID { get; set; }
        public bool? ISASSIST { get; set; }
        public int? ITEMTYPEID { get; set; }

        [QueryRequired, AllowNull]
        public string ITEMTYPENAME { get; set; }
        [QueryRequired, AllowNull]
        public string GXNAME { get; set; }
    }
}
