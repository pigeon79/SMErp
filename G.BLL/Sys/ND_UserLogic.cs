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
    public class ND_UserLogic : BaseBLL<ND_USER>, G.Interface.BLL.ISearch
    {
        public System.Data.DataTable SearchValue(Condition SearchCondition, string SearchText, string Fields, string ValueField)
        {
            int allcount = 0;
            Condition c = Condition.Empty;
            if (!String.IsNullOrEmpty(SearchText))
            {
                if (string.IsNullOrEmpty(ValueField))
                {
                    c = CK.K["USERDM"].LeftLike(SearchText);
                    c |= CK.K["USERNAME"].LeftLike(SearchText);
                }
                else
                {
                    c = CK.K[ValueField].Eq(SearchText);
                }
            }
            if (SearchCondition != null) { c &= SearchCondition; }

            return this.ExecuteSelect(c, OrderBy.Parse("USERDM"), 20, 0, ref allcount).ToDataTable();

        }
    }
}
