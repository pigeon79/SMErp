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
    public class SM_ITEMTYPELogic : BaseBLL<SM_ITEMTYPE>, G.Interface.BLL.ISearch
    {
        public System.Data.DataTable SearchValue(Condition SearchCondition, string SearchText, string Fields, string ValueField)
        {
            int allcount = 0;
            Condition c = Condition.Empty;
            if (!String.IsNullOrEmpty(SearchText))
            {
                if (string.IsNullOrEmpty(ValueField))
                {
                    CK.K["ITEMTYPENAME"].Like(SearchText);
                }
                else
                {
                    c = CK.K[ValueField].Eq(SearchText);
                }
            }
            if (SearchCondition != null) { c &= SearchCondition; }

            return this.ExecuteSelect(c, OrderBy.Parse("ID"), 0, 0, ref allcount).ToDataTable();
        }
    }
}
