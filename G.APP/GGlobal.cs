using System;
using System.Collections.Generic;
using System.Text;
using G.Entity.SysEnt;

namespace G.AppInfo
{
    
    public static class GGlobal
    {
        public static ND_USER User = new ND_USER();
        public static C1.Win.C1Ribbon.RibbonLabel infolab = null;
        public static void SetInfo(string info){
            if (infolab != null) { infolab.Text = info; }
        }
    }
    public  struct SysInfo {
        public static string company = "";
        public static string sysname = "";
        public static string version = "";
        public static string logname = "";
    }
    
}
