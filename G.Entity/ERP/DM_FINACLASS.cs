using System;
using G.Data.Definition;
using G.Data.Model.Handler;

namespace G.Entity.ERP
{
    public class DM_FINACLASS : DbObjectModel<DM_FINACLASS>
    {
        [Length(3)]
        public string FINACLASS { get; set; }
        [Length(50)]
        public string FINADESC { get; set; }
        [AllowNull]
        [Length(20)]
        public string SALINCSUB { get; set; }
        [AllowNull]
        [Length(20)]
        public string SALCOSTSU { get; set; }
        [AllowNull]
        [Length(20)]
        public string SALDISCSU { get; set; }
        [AllowNull]
        [Length(20)]
        public string PURCHSUB { get; set; }
        [AllowNull]
        [Length(20)]
        public string ONWAYSUB { get; set; }
        [AllowNull]
        [Length(20)]
        public string INVSUB { get; set; }
        [AllowNull]
        [Length(20)]
        public string CSTDIFSUB { get; set; }
        [AllowNull]
        [Length(20)]
        public string ISSUESUB { get; set; }
        [AllowNull]
        [Length(10)]
        public string OPERATOR { get; set; }
        public DateTime? OPERDATE { get; set; }
        [AllowNull]
        [Length(13)]
        public string CKID { get; set; }
        [AllowNull]
        [Length(13)]
        public string RKID { get; set; }
        [AllowNull]
        [Length(50)]
        public string SALINCSUB_W { get; set; }
    }

}
