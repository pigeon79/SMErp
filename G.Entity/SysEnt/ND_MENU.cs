using System;
using G.Data.Definition;
using G.Data.Model.Handler;

namespace G.Entity.SysEnt
{
    public class ND_MENU : DbObjectModel<ND_MENU, int>
    {
        public ND_MENU()
        {
            SYSTEMNAME = "";
            MENUDM = "";
            MENUCAPTION = "";
            ISDETAIL = false;
            DJLX = "";
            ISVISIBLE = true;
            PARENTID = 0;
            SORTID = 0;
            TREELEVEL = 0;
            MENUKEY = "";
            ACTIONTYPE = "";
            LINKFORM = "";
            ASSEMBLYNAME = "";
            ISSHOWDIALOG = false;
            SHELLAPP = "";
            MENUIMAGEPATH = "";
            NAVIGATEIMAGEPATH = "";
            MENUTYPE = "";
            TARGET = "";
            PROC_UID = "";
            OUTLOOKTAG = false;
        }
        [AllowNull]
        [Length(50)]
        public string SYSTEMNAME { get; set; }
        [AllowNull]
        [Length(50)]
        public string MENUDM { get; set; }
        [AllowNull]
        [Length(50)]
        public string MENUCAPTION { get; set; }
        public bool? ISDETAIL { get; set; }
        [AllowNull]
        [Length(50)]
        public string DJLX { get; set; }
        public bool? ISVISIBLE { get; set; }
        public int? PARENTID { get; set; }
        public int? SORTID { get; set; }
        public int? TREELEVEL { get; set; }
        [AllowNull]
        [Length(50)]
        public string MENUKEY { get; set; }
        [AllowNull]
        [Length(50)]
        public string ACTIONTYPE { get; set; }
        [AllowNull]
        [Length(500)]
        public string LINKFORM { get; set; }
        [AllowNull]
        [Length(500)]
        public string ASSEMBLYNAME { get; set; }
        public bool? ISSHOWDIALOG { get; set; }
        [AllowNull]
        [Length(500)]
        public string SHELLAPP { get; set; }
        [AllowNull]
        [Length(200)]
        public string MENUIMAGEPATH { get; set; }
        [AllowNull]
        [Length(200)]
        public string NAVIGATEIMAGEPATH { get; set; }
        [AllowNull]
        [Length(50)]
        public string MENUTYPE { get; set; }
        [AllowNull]
        [Length(50)]
        public string TARGET { get; set; }
        [AllowNull]
        [Length(500)]
        public string PROC_UID { get; set; }
        public bool? OUTLOOKTAG { get; set; }
    }

}
