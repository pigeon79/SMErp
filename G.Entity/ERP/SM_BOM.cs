using System;
using G.Data.Definition;
using G.Data.Model.Handler;

namespace G.Entity.ERP
{
    [DbView("SM_BOM_V1")]
    public class SM_BOM : DbObjectModel<SM_BOM, int>
    {
        public SM_BOM()
        {
            FITEM = "";
            CITEM = "";
            FITEMNAME = "";
            CITEMNAME = "";
            CQTY = 1;
        }
        [Length(50)]
        public string FITEM { get; set; }
        [Length(50)]
        public string CITEM { get; set; }
        public System.Decimal CQTY { get; set; }
        [QueryRequired]
        public string FITEMNAME { get; set; }
        [QueryRequired]
        public string CITEMNAME { get; set; }
    }

}
