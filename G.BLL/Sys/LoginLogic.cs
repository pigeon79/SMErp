using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using G.Data;
using G.Data.Model.Linq;
using G.Entity.SysEnt;
namespace G.BLL.Sys
{
    public class LoginLogic
    {
        public ND_USER CheckLogin(string logname, string pwd)
        {
            ND_USER user = null;
            List<ND_USER> list= G.Data.DbEntry.From<ND_USER>().Where(ExpressionParser<ND_USER>.Parse(u => u.USERDM == logname && u.PASSWORD == pwd)).Select();
            if (list.Count == 1) { 
                user = list[0];
                ND_LOG log = new ND_LOG();
                log.ENTERTIME = DateTime.Now;
                log.COMPUTERNAME = G.Core.Common.Usually.GetMachineName();
                log.IP = G.Core.Common.Usually.GetIp();
                log.Save();
            }
            return user;
        }
    }
}
