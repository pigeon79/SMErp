using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using G.Entity.ERP;
using G.Data.Model.QuerySyntax;
using G.Data;
using G.BLL.Base;
using G.Data.Model.Linq;
using G.BLL.ERP.BaseData;
using G.Entity.SysEnt;

namespace G.BLL.ERP.Purchase
{
    public class SM_PREPURORDERLogic : BaseBLL<SM_PREPURORDER>
    {
        public override int ExecuteDelete(ND_USER user, SM_PREPURORDER obj)
        {
            if (obj.STATUS == "N")
            {
                return base.ExecuteDelete(user, obj);
            }
            else { throw new Exception("新增单据才能删除"); }
        }
        public void Audit(ND_USER user, SM_PREPURORDER obj)
        {
            if (obj.STATUS == "N")
            {
                DateTime now = BaseExtends.GetServerDate();
                obj.STATUS = "A";
                obj.AUDITDATE = now;
                obj.AUDITOR = user.USERDM;
                this.ExecuteUpdate(obj);
            }
            else { throw new Exception("订单已审核！"); }
        }
        public override bool SaveBefore(ref SM_PREPURORDER obj)
        {
            DM_ITEMLogic itemlogic = new DM_ITEMLogic();
            DM_ITEM item = itemlogic.GetItemByCode(obj.ITEMCODE);
            if (item != null)
            {
                obj.ISATTRIBUTEA = G.Core.GConvert.ToBool(item.IsAttributeA);
                obj.ISATTRIBUTEB = G.Core.GConvert.ToBool(item.IsAttributeB);
                obj.ISATTRIBUTEC = G.Core.GConvert.ToBool(item.IsAttributeC);
            }
            if (obj.ISATTRIBUTEA == false)
            {
                obj.ATTRIBUTEA = "";
            }
            if (obj.ISATTRIBUTEB == false)
            {
                obj.ATTRIBUTEB = "";
                obj.ATTRIBUTEBNAME = "";
            }
            if (obj.ISATTRIBUTEC == false)
            {
                obj.ATTRIBUTEC = 0;
            }
            return true;
        }
        public override int ExecuteUpdate(ND_USER user, SM_PREPURORDER obj)
        {
            if (obj.Id <= 0)
            {
                DateTime now = BaseExtends.GetServerDate();
                obj.OPERDATE = DateTime.Parse(now.ToShortDateString());
                obj.PREPURORDID = BaseExtends.GetNewAutoNo("PP");
                obj.OPERATOR = user.USERDM;
            }
            base.ExecuteUpdate(user,obj);
            return obj.Id;
        }
        public void XD(ND_USER user,string id)
        {
            DbEntry.UsingTransaction(delegate
            {
                string csql = string.Format("exec SMProc_MergePrePurOrder '{0}','{1}' ", id, user.USERDM);
                DbEntry.Provider.ExecuteNonQuery(csql);
            });
        }
    }
}
