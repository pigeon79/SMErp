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
    public class SM_BOMLogic : BaseBLL<SM_BOM>
    {
        public List<SM_BOM> GetBomByFItem(string FITEM)
        {
            Condition c = null;
            if (!String.IsNullOrEmpty(FITEM))
            {
                c = CK.K["FITEM"].Eq(FITEM);
                return this.ExecuteSelect(c, OrderBy.Parse("ID"), 0, 0);
            }
            else { return new List<SM_BOM>(); }
            
        }
    }
}
