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
    public class DM_COLORLogic : BaseBLL<DM_COLOR>, G.Interface.BLL.ISearch
    {
        public System.Data.DataTable SearchValue(Condition SearchCondition, string SearchText, string Fields, string ValueField)
        {
            int allcount = 0;
            Condition c = null;
            if (!String.IsNullOrEmpty(SearchText))
            {
                if (string.IsNullOrEmpty(ValueField))
                {
                    c = CK.K["CCODE"].LeftLike(SearchText);
                    c |= CK.K["CNAME"].Like(SearchText);
                }
                else
                {
                    c = CK.K[ValueField].Eq(SearchText);
                }
            }
            if (c != null && SearchCondition!=null) { c &= SearchCondition; }
            if (c == null)
                c = SearchCondition;

            return this.ExecuteSelect(c, OrderBy.Parse("CCODE"), 100, 0, ref allcount).ToDataTable();
        }
    }
}
