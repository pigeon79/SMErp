using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using G.Entity.SysEnt;
using G.Data.Model.QuerySyntax;
using G.Data;
using G.BLL.Base;
using G.Data.Model.Linq;
using G.Interface.BLL;

namespace G.BLL.Sys
{
    public class ND_ORGINAZITIONLogic : BaseBLL<ND_ORGINAZITION>, ISearch
    {
        public bool MoveTo(ND_ORGINAZITION menu, int parentid)
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
        public bool MoveFirst(ND_ORGINAZITION curmenu, ND_ORGINAZITION tagmenu)
        {
            bool ok = false;
            try
            {
                int tcount = 0;
                List<ND_ORGINAZITION> list = this.ExecuteSelect(ExpressionParser<ND_ORGINAZITION>.Parse(m => m.PARENTID == curmenu.PARENTID), OrderBy.Parse("SORTID"), 0, 0, ref tcount);
                int index = 1;
                foreach (ND_ORGINAZITION m in list)
                {
                    if (m.Id == curmenu.Id) { m.SORTID = 0; }
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
        public bool MovePrv(ND_ORGINAZITION curmenu, ND_ORGINAZITION tagmenu)
        {
            bool ok = false;
            try
            {
                int tcount = 0;
                List<ND_ORGINAZITION> list = this.ExecuteSelect(ExpressionParser<ND_ORGINAZITION>.Parse(m => m.PARENTID == curmenu.PARENTID), OrderBy.Parse("SORTID"), 0, 0, ref tcount);
                int index = 0;
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].Id == curmenu.Id && i > 0)
                    {
                        list[i].SORTID = list[i - 1].SORTID;
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
        public bool MoveNext(ND_ORGINAZITION curmenu, ND_ORGINAZITION tagmenu)
        {
            bool ok = false;
            try
            {
                int tcount = 0;
                List<ND_ORGINAZITION> list = this.ExecuteSelect(ExpressionParser<ND_ORGINAZITION>.Parse(m => m.PARENTID == curmenu.PARENTID), OrderBy.Parse("SORTID"), 0, 0, ref tcount);
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
                        else
                        {
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
        public bool MoveLast(ND_ORGINAZITION curmenu, ND_ORGINAZITION tagmenu)
        {
            bool ok = false;
            try
            {
                int tcount = 0;
                List<ND_ORGINAZITION> list = this.ExecuteSelect(ExpressionParser<ND_ORGINAZITION>.Parse(m => m.PARENTID == curmenu.PARENTID), OrderBy.Parse("SORTID"), 0, 0, ref tcount);
                int index = 0;
                foreach (ND_ORGINAZITION m in list)
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

        public System.Data.DataTable SearchValue(Condition SearchCondition, string SearchText, string Fields, string ValueField)
        {
            int allcount = 0;
            Condition c = Condition.Empty;
            if (!String.IsNullOrEmpty(SearchText))
            {
                if (string.IsNullOrEmpty(ValueField))
                {
                    c = CK.K["ORGNAME"].LeftLike(SearchText);
                    c |= CK.K["ORGDM"].LeftLike(SearchText);
                    c |= CK.K["ID"].Eq(SearchText);
                }
                else
                {
                    c = CK.K[ValueField].Eq(SearchText);
                }
            }
            if (SearchCondition != null) { c &= SearchCondition; }

            return this.ExecuteSelect(c, OrderBy.Parse("ORGNAME"), 20, 0, ref allcount).ToDataTable();
        }
        public void DeleteChild(ND_ORGINAZITION parent)
        {
            int tcount = 0;
            List<ND_ORGINAZITION> list = this.ExecuteSelect(ExpressionParser<ND_ORGINAZITION>.Parse(m => m.PARENTID == parent.Id), OrderBy.Parse("parentid"), 0, 0, ref tcount);
            foreach (ND_ORGINAZITION m in list)
            {
                DeleteChild(m);
                this.ExecuteDelete(m);
            }
            this.ExecuteDelete(parent);
        }
    }
}
