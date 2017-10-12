using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using G.Entity.ERP;
using G.Data.Model.QuerySyntax;
using G.Data;
using G.BLL.Base;
using G.Data.Model.Linq;
using System.Data;

namespace G.BLL.ERP.BaseData
{
    public class DM_ITEMLogic : BaseBLL<DM_ITEM>, G.Interface.BLL.ISearch
    {
        public DM_ITEM GetItemByCode(string itemcode) {
            DM_ITEM item = null;
            int totalcount=0;
            List<DM_ITEM> list=this.GetData(CK.K["ItemCode"].Eq(itemcode), OrderBy.Parse("ItemCode"), 0, 0,ref totalcount);
            if (list.Count == 1) { item = list[0]; }
            return item;
        }
        public System.Data.DataTable SearchValue(Condition SearchCondition, string SearchText, string Fields, string ValueField)
        {
            int allcount = 0;
            Condition c = Condition.Empty;
            if (!String.IsNullOrEmpty(SearchText))
            {
                if (string.IsNullOrEmpty(ValueField))
                {
                    c = CK.K["ITEMCODE"].LeftLike(SearchText);
                    c |= CK.K["ITEMNAME"].Like(SearchText);
                    c |= CK.K["PY"].Like(SearchText);
                }
                else
                {
                    c = CK.K[ValueField].Eq(SearchText);
                }

                
            }
            if (SearchCondition != null) { c &= SearchCondition; }

            return this.ExecuteSelect(c, OrderBy.Parse("ITEMCODE"), 20, 0, ref allcount).ToDataTable();
        }
        public DataSet SearLocStorage(string itemcode, string itemname, string wrhs, string loc, string attributea, string attributeb, string attributec, bool iszero)
        {
            DataSet ds = new DataSet();
            string condition = "1=1";
            if (itemcode != null && itemcode != "")
            {
                condition += " and ITEMCODE like '%" + itemcode + "%'";
            }
            if (itemname != null && itemname != "")
            {
                condition += " and ITEMNAME like '%" + itemname + "%'";
            }
            if (wrhs != null && wrhs != "" && wrhs != "0")
            {
                condition += " and WRHSCODE = '" + wrhs + "'";
            }
            if (loc != null && loc != "" && loc != "0")
            {
                condition += " and LOCCODE = '" + loc + "'";
            }
            if (attributea != null && attributea != "")
            {
                condition += " and ATTRIBUTEA like '%" + attributea + "%'";
            }
            if (attributeb != null && attributeb != "")
            {
                condition += " and ATTRIBUTEB = '" + attributeb + "'";
            }
            if (attributec != null && attributec != "")
            {
                condition += " and ATTRIBUTEC = " + G.Core.GConvert.ToDecimal(attributec);
            }
            if (iszero == true)
            {
                condition += " and ONHANDQTY > 0";
            }
            DbEntry.UsingTransaction(delegate
            {
                string csql = string.Format("SELECT * FROM SM_LOCSTORAGE_V1 where " + condition);
                ds = DbEntry.Provider.ExecuteDataset(csql);
            });
            return ds;
        }
    }
}
