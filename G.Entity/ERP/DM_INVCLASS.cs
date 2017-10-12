using System;
using G.Data.Definition;
using G.Data.Model.Handler;

namespace G.Entity.ERP
{
    public class DM_INVCLASS : DbObjectModel<DM_INVCLASS, int>
    {
        public DM_INVCLASS() {
            InvClass = "";
            InvDesc = "";
            Operator = "";
            Operdate = DateTime.Now;
            Remark = "";
        }
        [Length(3)]
        public string InvClass { get; set; }
        [Length(15)]
        public string InvDesc { get; set; }
        [AllowNull]
        [Length(50)]
        public string Operator { get; set; }
        public DateTime? Operdate { get; set; }
        [AllowNull]
        [Length(15)]
        public string Remark { get; set; }
    }
}
