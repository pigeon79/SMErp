using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using G.Entity.ERP;
using G.Data.Model.QuerySyntax;
using G.Data;
using G.BLL.Base;
using G.Data.Model.Linq;

namespace G.BLL.ERP.BaseData
{
    public class DM_WHBLBLogic : BaseBLL<DM_WHBLB>
    {
        public bool MoveTo(DM_WHBLB menu, int parentid)
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
        public bool MoveFirst(DM_WHBLB curmenu, DM_WHBLB tagmenu)
        {
            bool ok = false;
            try
            {
                int tcount = 0;
                List<DM_WHBLB> list = this.ExecuteSelect(ExpressionParser<DM_WHBLB>.Parse(m => m.PARENTID == curmenu.PARENTID), OrderBy.Parse("SORTID"), 0, 0, ref tcount);
                int index = 1;
                foreach (DM_WHBLB m in list)
                {
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
        public bool MovePrv(DM_WHBLB curmenu, DM_WHBLB tagmenu)
        {
            bool ok = false;
            try
            {
                int tcount = 0;
                List<DM_WHBLB> list = this.ExecuteSelect(ExpressionParser<DM_WHBLB>.Parse(m => m.PARENTID == curmenu.PARENTID), OrderBy.Parse("SORTID"), 0, 0, ref tcount);
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
        public bool MoveNext(DM_WHBLB curmenu, DM_WHBLB tagmenu)
        {
            bool ok = false;
            try
            {
                int tcount = 0;
                List<DM_WHBLB> list = this.ExecuteSelect(ExpressionParser<DM_WHBLB>.Parse(m => m.PARENTID == curmenu.PARENTID), OrderBy.Parse("SORTID"), 0, 0, ref tcount);
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
        public bool MoveLast(DM_WHBLB curmenu, DM_WHBLB tagmenu)
        {
            bool ok = false;
            try
            {
                int tcount = 0;
                List<DM_WHBLB> list = this.ExecuteSelect(ExpressionParser<DM_WHBLB>.Parse(m => m.PARENTID == curmenu.PARENTID), OrderBy.Parse("SORTID"), 0, 0, ref tcount);
                int index = 0;
                foreach (DM_WHBLB m in list)
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
        public void DeleteChild(DM_WHBLB parentmenu)
        {
            int tcount = 0;
            List<DM_WHBLB> list = this.ExecuteSelect(ExpressionParser<DM_WHBLB>.Parse(m => m.PARENTID == parentmenu.Id), OrderBy.Parse("parentid"), 0, 0, ref tcount);
            foreach (DM_WHBLB m in list)
            {
                DeleteChild(m);
                this.ExecuteDelete(m);
            }
            this.ExecuteDelete(parentmenu);
        }
    }
}
