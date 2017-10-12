using System;
using G.Data.Definition;
using G.Data.Model.Handler;

namespace G.Entity.SysEnt
{
    public class ND_LOG : DbObjectModel<ND_LOG, int>
    {
        public ND_LOG()
        {
            USERID = 0;
            ENTERTIME = DateTime.Now;
            EXITTIME = DateTime.Now;
            IP = "";
            COMPUTERNAME = "";
            STATEID = 0;
            WEBSERVICEIP = "";
            SYSTEMNAME = "";
            SESSIONID = "";
            USBKEY = "";
            DISKID = "";
        }
        public int? USERID { get; set; }
        public DateTime? ENTERTIME { get; set; }
        public DateTime? EXITTIME { get; set; }
        [AllowNull]
        [Length(50)]
        public string IP { get; set; }
        [AllowNull]
        [Length(200)]
        public string COMPUTERNAME { get; set; }
        public int? STATEID { get; set; }
        [AllowNull]
        [Length(50)]
        public string WEBSERVICEIP { get; set; }
        [AllowNull]
        [Length(50)]
        public string SYSTEMNAME { get; set; }
        [AllowNull]
        [Length(500)]
        public string SESSIONID { get; set; }
        [AllowNull]
        [Length(50)]
        public string USBKEY { get; set; }
        [AllowNull]
        [Length(50)]
        public string DISKID { get; set; }
    }
}
