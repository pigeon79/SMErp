using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using G.Entity.ERP;
using G.Data.Model.QuerySyntax;
using G.Data;
using G.BLL.Base;
using G.Data.Model.Linq;
using System.Collections;
using G.Data.SqlEntry;

namespace G.BLL.ERP.BaseData
{
    public class DM_LOCATIONLogic : BaseBLL<DM_LOCATION>, G.Interface.BLL.ISearch
    {
        public DM_LOCATIONLogic(){
            //this.ViewName = DM_LOCATION.ViewName;
        }
        public System.Data.DataTable SearchValue(Condition SearchCondition, string SearchText, string Fields, string ValueField)
        {
            int allcount = 0;
            Condition c = Condition.Empty;
            if (!String.IsNullOrEmpty(SearchText))
            {
                if (string.IsNullOrEmpty(ValueField))
                {
                    c = CK.K["LOCCODE"].LeftLike(SearchText);
                    c |= CK.K["LOCNAME"].LeftLike(SearchText);
                }
                else {
                    c = CK.K[ValueField].Eq(SearchText);
                }
            }
            if (SearchCondition != null) { c &= SearchCondition; }

            return this.GetData(c, OrderBy.Parse("LOCCODE"), 20, 0, ref allcount).ToDataTable();
        }
        //public List<DM_LOCATION> GetData(Condition iwc, OrderBy order)
        //{
        //    return DbEntry.GetData<DM_LOCATION>(DM_LOCATION.ViewName, iwc, order);
        //}
       


    }
}
