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
    public class DM_ITEMSPLITLogic : BaseBLL<DM_ITEMSPLIT>, G.Interface.BLL.ISearch
    {
        public DM_ITEMSPLITLogic()
        {
            //this.ViewName = "DM_ITEMSPLIT_V1";
        }
        public System.Data.DataTable SearchValue(Condition SearchCondition, string SearchText, string Fields, string ValueField)
        {
            int allcount = 0;
            Condition c = Condition.Empty;
            if (!String.IsNullOrEmpty(SearchText))
            {
                c = CK.K["ItemCode"].LeftLike(SearchText);
                c |= CK.K["ItemDesc"].Like(SearchText);
                c |= CK.K["HelpMarker"].Like(SearchText);
            }
            if (SearchCondition != null) { c &= SearchCondition; }

            return this.GetData(c, OrderBy.Parse("ID"), 20, 0, ref allcount).ToDataTable();
        }
        public void Save(DM_ITEMSPLIT itemsplit, DM_ITEM itemA, DM_ITEM itemB, DM_ITEM itemC, DM_ITEM itemD)
        {
            try
            {
                DbEntry.UsingTransaction(delegate
                {
                    if (itemsplit.ItemCodeA == "" && itemsplit.Id>0)
                    {
                        this.ExecuteDelete(itemsplit);
                    }
                    else
                    {
                        this.ExecuteUpdate(itemsplit);
                        if (itemA != null)
                        {
                            DbEntry.Save(itemA);
                            //itemA.Save();
                        }
                        if (itemB != null) { DbEntry.Save(itemB); }
                        if (itemC != null) { DbEntry.Save(itemC); }
                        if (itemD != null) { DbEntry.Save(itemD); }
                    }
                });
            }
            catch (Exception e) { throw e; }
        }
    }
}
