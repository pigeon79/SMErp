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
    public class ND_MenuLogic : BaseBLL<ND_MENU>
    {
        public bool MoveTo(ND_MENU menu, int parentid)
        {
            bool ok = false;
            try
            {
                menu.PARENTID = parentid;
                this.ExecuteUpdate(menu);
                ok = true;
            }
            catch (Exception e) { throw e; }
            return ok;
        }
        public bool MoveFirst(ND_MENU curmenu, ND_MENU tagmenu)
        {
            bool ok = false;
            try
            {
                int tcount = 0;
                List<ND_MENU> list = this.ExecuteSelect(ExpressionParser<ND_MENU>.Parse(m => m.PARENTID == curmenu.PARENTID), OrderBy.Parse("SORTID"), 0, 0, ref tcount);
                int index = 1;
                foreach (ND_MENU m in list) {
                    if (m.Id == curmenu.Id) { m.SORTID = 0; }
                    else {
                        m.SORTID = index;
                        index++;
                    }
                }
                this.ExecuteUpdate(list);
                ok = true;
            }
            catch (Exception e) { throw e; }
            return ok;
        }
        public bool MovePrv(ND_MENU curmenu, ND_MENU tagmenu)
        {
            bool ok = false;
            try
            {
                int tcount = 0;
                List<ND_MENU> list = this.ExecuteSelect(ExpressionParser<ND_MENU>.Parse(m => m.PARENTID == curmenu.PARENTID), OrderBy.Parse("SORTID"), 0, 0, ref tcount);
                int index = 0;
                for (int i = 0; i < list.Count;i++ )
                {
                    if (list[i].Id == curmenu.Id && i > 0) { 
                        list[i].SORTID = list[i-1].SORTID;
                        list[i - 1].SORTID = index;
                        index++;
                    }
                    else
                    {
                        list[i].SORTID = index;
                        index++;
                    }
                }
                this.ExecuteUpdate(list);
                ok = true;
            }
            catch (Exception e) { throw e; }
            return ok;
        }
        public bool MoveNext(ND_MENU curmenu, ND_MENU tagmenu)
        {
            bool ok = false;
            try
            {
                int tcount = 0;
                List<ND_MENU> list = this.ExecuteSelect(ExpressionParser<ND_MENU>.Parse(m => m.PARENTID == curmenu.PARENTID), OrderBy.Parse("SORTID"), 0, 0, ref tcount);
                int index = 0;
                for (int i = 0; i < list.Count; i++)
                {
                    if (i > 0)
                    {
                        if (list[i - 1].Id == curmenu.Id)
                        {
                            list[i].SORTID = list[i - 1].SORTID;
                            list[i - 1].SORTID = index;
                            index++;
                        }
                        else {
                            list[i].SORTID = index;
                            index++;
                        }
                    }
                    else
                    {
                        list[i].SORTID = index;
                        index++;
                    }
                }
                this.ExecuteUpdate(list);
                ok = true;
            }
            catch (Exception e) { throw e; }
            return ok;
        }
        public bool MoveLast(ND_MENU curmenu, ND_MENU tagmenu)
        {
            bool ok = false;
            try
            {
                int tcount = 0;
                List<ND_MENU> list = this.ExecuteSelect(ExpressionParser<ND_MENU>.Parse(m => m.PARENTID == curmenu.PARENTID), OrderBy.Parse("SORTID"), 0, 0, ref tcount);
                int index = 0;
                foreach (ND_MENU m in list)
                {
                    if (m.Id == curmenu.Id) { m.SORTID = list.Count; }
                    else
                    {
                        m.SORTID = index;
                        index++;
                    }
                }
                this.ExecuteUpdate(list);
                ok = true;
            }
            catch (Exception e) { throw e; }
            return ok;
        }
        public void DeleteChild(ND_MENU parentmenu)
        {
            int tcount = 0;
            List<ND_MENU> list = this.ExecuteSelect(ExpressionParser<ND_MENU>.Parse(m => m.PARENTID == parentmenu.Id), OrderBy.Parse("parentid"), 0, 0, ref tcount);
            foreach (ND_MENU m in list)
            {
                DeleteChild(m);
                this.ExecuteDelete(m);
            }
            this.ExecuteDelete(parentmenu);
        }
        public List<ND_MENU> GetMenusByAuthority(ND_USER user)
        {
            int totalRowCount = 0;
            List<ND_MENU> mlist = this.ExecuteSelect(ExpressionParser<ND_MENU>.Parse(m => m.SYSTEMNAME == "ERP" && m.ISVISIBLE == true), OrderBy.Parse("sortid"), 0, 1, ref totalRowCount);

            if (user.ISMANAGER == true) { return mlist; }
            else
            {
                ND_USER_MENUACCESSLogic acclogic = new ND_USER_MENUACCESSLogic();
                List<ND_USER_MENUACCESS> alist = acclogic.GetMenusAccess(user.Id);
                return mlist.FindAll(m => { return alist.Exists(n => n.MENUID == m.Id); });
            }

        }
    }
}
