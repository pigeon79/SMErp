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
    public class DM_PRICEBILLLogic : BaseBLL<DM_PRICEBILL>, G.Interface.BLL.ISearch
    {
        public DM_PRICEBILL GetUsePrice() {
            return this.ExecuteSelect(CK.K["USETAG"].Eq(true), OrderBy.Parse("ID"), 0, 0)[0];
        }

        public System.Data.DataTable SearchValue(Condition SearchCondition, string SearchText, string Fields, string ValueField)
        {
            throw new NotImplementedException();
        }
    }
}
