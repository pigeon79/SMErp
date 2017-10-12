using System;
using G.Data.Definition;
using G.Data.Model.Handler;

namespace G.Entity.ERP
{
    [DbView("DM_ITEMSPLIT_V1")]
    public class DM_ITEMSPLIT : DbObjectModel<DM_ITEMSPLIT,int>
    {
        [Length(50)]
        public string ItemCode { get; set; }
        [QueryRequired]
        public string ItemDesc { get; set; }
        [Length(50)]
        public string ItemCodeA { get; set; }
        [QueryRequired]
        public string ItemDescA { get; set; }
        [AllowNull]
        [Length(50)]
        public string ItemCodeB { get; set; }
        [QueryRequired]
        public string ItemDescB { get; set; }
        [AllowNull]
        [Length(50)]
        public string ItemCodeC { get; set; }
        [QueryRequired]
        public string ItemDescC { get; set; }
        [AllowNull]
        [Length(50)]
        public string ItemCodeD { get; set; }
        [QueryRequired]
        public string ItemDescD { get; set; }
        //[QueryRequired]
        //public bool? IsAttributeB { get; set; }
    }

}
