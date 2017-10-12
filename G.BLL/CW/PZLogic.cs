using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using G.Entity.CW;
using G.Data.Model.QuerySyntax;
using G.Data;
using G.BLL.Base;
using G.Data.Model.Linq;

namespace G.BLL.CW
{
    public class PZLogic : DbEntryDataSource<CW_PZ_NO>
    {
        public override List<CW_PZ_NO> ExecuteSelect(Condition condition, OrderBy order, int pageSize, int pageIndex, ref int totalRowCount)
        {
            return base.ExecuteSelect(condition, order, pageSize, pageIndex, ref totalRowCount);
        }
    }
}
