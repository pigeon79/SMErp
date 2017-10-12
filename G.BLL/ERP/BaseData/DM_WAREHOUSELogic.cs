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
    public class DM_WAREHOUSELogic : BaseBLL<DM_WAREHOUSE>, G.Interface.BLL.ISearch
    {

        public System.Data.DataTable SearchValue(Condition SearchCondition, string SearchText, string Fields, string ValueField)
        {
            int allcount = 0;
            Condition c = Condition.Empty;
            if (!String.IsNullOrEmpty(SearchText))
            {
                if (string.IsNullOrEmpty(ValueField))
                {
                    c = CK.K["WRHSNAME"].Like(SearchText);
                    c |= CK.K["WRHSCODE"].LeftLike(SearchText);
                }
                else {
                    c = CK.K[ValueField].Eq(SearchText);
                }
            }
            if (SearchCondition != null) { c &= SearchCondition; }

            return this.ExecuteSelect(c, OrderBy.Parse("WRHSCODE"), 20, 0, ref allcount).ToDataTable();
        }

    }
}
