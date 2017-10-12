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
    public class DM_MOULDLogic : BaseBLL<DM_MOULD>, G.Interface.BLL.ISearch
    {
        public System.Data.DataTable SearchValue(Condition SearchCondition, string SearchText, string Fields, string ValueField)
        {
            int allcount = 0;
            Condition c = Condition.Empty;
            if (!String.IsNullOrEmpty(SearchText))
            {
                if (string.IsNullOrEmpty(ValueField))
                {
                    c = CK.K["MDCODE"].LeftLike(SearchText);
                    c |= CK.K["MDNAME"].Like(SearchText);
                }
                else
                {
                    c = CK.K[ValueField].Eq(SearchText);
                }
            }
            if (SearchCondition != null) { c &= SearchCondition; }

            return this.ExecuteSelect(c, OrderBy.Parse("MDCODE"), 100, 0, ref allcount).ToDataTable();
        }
        //public override int ExecuteUpdate(Entity.SysEnt.ND_USER user, DM_MOULD obj)
        //{
        //    if (obj.Id > 0) {
        //        DM_ITEMLogic itemlogic = new DM_ITEMLogic();
        //        DM_ITEM item = new DM_ITEM();
        //        item.ItemCode = obj.MDCODE.Trim() + "W";
        //        item.ItemName = "纽扣面" + obj.MDCODE.Substring(obj.MDCODE.Length - 4, 4);
        //        item.ItemDesc = "纽扣面" + obj.MDCODE.Substring(obj.MDCODE.Length - 4, 4);
        //        item.InvUnit = "个";
        //        item.InvClassID = 3;

        //    }
        //    return base.ExecuteUpdate(user, obj);
        //}
    }
}
