using System;
using G.Data.Definition;
using G.Data.Model.Handler;
using System.Collections.Generic;

namespace G.Entity.ERP
{
    public class DM_PRICEBILL : DbObjectModel<DM_PRICEBILL, int>
    {
        public DM_PRICEBILL()
        {
            PBILLNAME = "";
            REMARK = "";
            USETAG = false;
        }
        [AllowNull]
        [Length(50)]
        public string PBILLNAME { get; set; }
        [AllowNull]
        [Length(50)]
        public string REMARK { get; set; }
        public bool? USETAG { get; set; }
        [HasMany(OrderBy = "ID")]
        public IList<DM_PRICEBILLDTL> PRICEBILLDTL { get; private set; }
    }

}
