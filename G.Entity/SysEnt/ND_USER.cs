using System;
using G.Data.Definition;
using G.Data.Model.Handler;

namespace G.Entity.SysEnt
{
    public class ND_USER : DbObjectModel<ND_USER, int>
    {
        public ND_USER()
        {
            USERNAME = "";
            PASSWORD = "";
            ISMANAGER = false;
            ISDATAACCESS = false;
            ISGROUPACCESS = false;
            ISREPORTACCESS = false;
            PASS_PROMPT = "";
            PASS_SUBMIT = "";
            ORGID = 0;
            NOTINUSE = false;
            USERDM = "";
            SORTID = 0;
            MNEMONIC = "";
            EMAIL = "";
            MSN = "";
            TEL = "";
            USERTYPE = 0;
            LOGINOA = 0;
            OAUSERID = "";
            CERTTYPE = 0;
            MINPASSWORDLEN = 0;
            PASSWORDLEVEL = 0;
        }
        [AllowNull]
        [Length(50)]
        public string USERNAME { get; set; }
        [AllowNull]
        [Length(50)]
        public string PASSWORD { get; set; }
        public bool? ISMANAGER { get; set; }
        public bool? ISDATAACCESS { get; set; }
        public bool? ISGROUPACCESS { get; set; }
        public bool? ISREPORTACCESS { get; set; }
        [AllowNull]
        [Length(50)]
        public string PASS_PROMPT { get; set; }
        [AllowNull]
        [Length(50)]
        public string PASS_SUBMIT { get; set; }
        public int? ORGID { get; set; }
        public bool? NOTINUSE { get; set; }
        [AllowNull]
        [Length(50)]
        public string USERDM { get; set; }
        public int? SORTID { get; set; }
        [AllowNull]
        [Length(50)]
        public string MNEMONIC { get; set; }
        [AllowNull]
        [Length(50)]
        public string EMAIL { get; set; }
        [AllowNull]
        [Length(50)]
        public string MSN { get; set; }
        [AllowNull]
        [Length(50)]
        public string TEL { get; set; }
        public int? USERTYPE { get; set; }
        public int? LOGINOA { get; set; }
        [AllowNull]
        [Length(50)]
        public string OAUSERID { get; set; }
        public int? CERTTYPE { get; set; }
        public int? MINPASSWORDLEN { get; set; }
        public int? PASSWORDLEVEL { get; set; }
    }

}
