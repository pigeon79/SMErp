using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using G.Entity.CW;
using G.Data.Model.QuerySyntax;
using G.Data;
using G.BLL.Base;
using G.Data.Model.Linq;
using G.Interface.BLL;
using G.Data.Definition;
using System.Data;

namespace G.BLL.CW
{
    public class DMLogic : DbEntryDataSource<CW_DM>,ISearch
    {
        public bool MoveTo(CW_DM dm, int parentid)
        {
            bool ok = false;
            try
            {
                dm.PARENTID = parentid;
                this.ExecuteUpdate(dm);
                ok = true;
            }
            catch (Exception e) { throw e; }
            return ok;
        }

        public DataTable SearchValue(Condition SearchCondition, string SearchText, string Fields, string ValueField)
        {
            int allcount = 0;
            Condition c = null;
            if (!String.IsNullOrEmpty(SearchText))
                c &= CK.K["DM"].LeftLike(SearchText);
            if (c != null && SearchCondition != null) { c &= SearchCondition; }
            if (c == null)
                c = Condition.Empty;

            return this.ExecuteSelect(c, OrderBy.Parse("DM"), 20, 1, ref allcount).ToDataTable();
        }


        public DataRow SearchValue(string value, string Field)
        {
            throw new NotImplementedException();
        }
    }
}
