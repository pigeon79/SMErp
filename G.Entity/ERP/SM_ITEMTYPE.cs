using System;
using G.Data.Definition;
using G.Data.Model.Handler;

namespace G.Entity.ERP
{
    public class SM_ITEMTYPE : DbObjectModel<SM_ITEMTYPE, int>
    {
        public SM_ITEMTYPE()
        {
            ITEMTYPENAME = "";
        }
        [AllowNull]
        [Length(50)]
        public string ITEMTYPENAME { get; set; }
    }
}
