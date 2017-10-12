using System;
using System.Collections.Generic;
using G.Data.Definition;
using G.Data.Model.Handler;

namespace G.Entity.ERP
{
    [DbView("SM_ASSISTMENTRY_V1")]
    public class SM_ASSISTMENTRY : DbObjectModel<SM_ASSISTMENTRY, int>
    {
        public SM_ASSISTMENTRY()
        {
            ASSISTMECODE = "";
            ASSISTMSCODE = "";
            ASSISTMEDATE = DateTime.Now;
            CHECKEDPER = "";
            STATUS = "N";
            OPERATOR = "";
            OPERDATE = DateTime.Now;
            LOCK = false;
            MEMO = "";
            AFFIRMER = "";
            AFFIRMDATE = null;
            RKID = "";
            
        }
        [HasMany(OrderBy = "ID")]
        public IList<SM_ASSISTMENTRYDTL> ASSISTMENTRYDTL { get; private set; }

        [AllowNull]
        [Length(50)]
        public string ASSISTMECODE { get; set; }
        [AllowNull]
        [Length(50)]
        public string ASSISTMSCODE { get; set; }
        public DateTime? ASSISTMEDATE { get; set; }
        [AllowNull]
        [Length(50)]
        public string CHECKEDPER { get; set; }
        [AllowNull]
        [Length(50)]
        public string STATUS { get; set; }
        [AllowNull]
        [Length(50)]
        public string OPERATOR { get; set; }
        public DateTime? OPERDATE { get; set; }
        public bool? LOCK { get; set; }
        [AllowNull]
        [Length(200)]
        public string MEMO { get; set; }
        [AllowNull]
        [Length(50)]
        public string AFFIRMER { get; set; }
        public DateTime? AFFIRMDATE { get; set; }
        [AllowNull]
        [Length(50)]
        public string RKID { get; set; }
        
        [QueryRequired, AllowNull]
        public string OPERATORNAME { get; set; }
        [QueryRequired, AllowNull]
        public string AFFIRMERNAME { get; set; }
        [QueryRequired, AllowNull]
        public string STATUSNAME { get; set; }
        [QueryRequired, AllowNull]
        public string CHECKEDPERNAME { get; set; }
        [QueryRequired, AllowNull]
        public string SUPPNAME { get; set; }
    }
}
