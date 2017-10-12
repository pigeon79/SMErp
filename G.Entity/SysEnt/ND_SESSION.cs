using System;
using System.Collections.Generic;
using G.Data.Definition;
using G.Data.Model.Handler;

namespace G.Entity.SysEnt
{
    public class ND_SESSION : IDbObject
    {
        [DbKey(IsDbGenerate = false)]
        [Length(500)]
        public string SESSIONID;
        [AllowNull]
        [Length(500)]
        public string ACCOUNTNAME;
        public int? USERID;
        [AllowNull]
        [Length(500)]
        public string USERNAME;
        [AllowNull]
        [Length(500)]
        public string IP;
        [AllowNull]
        [Length(500)]
        public string COMPUTERNAME;
        public DateTime? NEWDATE;
        [AllowNull]
        [Length(500)]
        public string CONNECTSTRING;
        [AllowNull]
        [Length(500)]
        public string SYSTEMNAME;
        public int? LOGID;
        public int? ISMANAGER;
        [AllowNull]
        [Length(500)]
        public string U_USERID;
    }


}
