using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using G.Entity.SysEnt;
using G.Data.Model.QuerySyntax;
using G.Data;
using G.BLL.Base;
using G.Data.Model.Linq;

namespace G.BLL.Sys
{
    public class ND_USER_MENUACCESSLogic : BaseBLL<ND_USER_MENUACCESS>
    {
        public void SaveAccess( int userid,List<ND_USER_MENUACCESS> list) {
            DbEntry.UsingTransaction(delegate {
                string csql = string.Format("delete from ND_USER_MENUACCESS  where userid={0} ", userid);
                DbEntry.Provider.ExecuteNonQuery(csql);
                DbEntry.Save(list.ToArray());
                //foreach (ND_USER_MENUACCESS a in list) {
                //    a.Save();
                //}
            });
        }
        public List<ND_USER_MENUACCESS> GetMenusAccess(int userid) {
            int totalc = 0;
            Condition c = CK.K["USERID"].Eq(userid);
           return  this.ExecuteSelect(c, OrderBy.Parse("MENUID"), 0, 0, ref totalc);
        }
    }
}
