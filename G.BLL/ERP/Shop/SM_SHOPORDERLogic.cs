using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using G.BLL.Base;
using G.BLL.ERP.BaseData;
using G.Data;
using G.Data.Model.Linq;
using G.Data.Model.QuerySyntax;
using G.Entity.ERP;
using G.Entity.SysEnt;

namespace G.BLL.ERP.Shop
{
    public class SM_SHOPORDERLogic : BaseBLL<SM_SHOPORDER>
    {
        public override int ExecuteUpdate(ND_USER user, List<SM_SHOPORDER> list)
        {
            foreach (SM_SHOPORDER mo in list) {
                if (mo.Id <= 0)
                {
                    DateTime now = BaseExtends.GetServerDate();
                    mo.OPERDATE = DateTime.Parse(now.ToShortDateString());
                    mo.SHOPORDID = BaseExtends.GetNewAutoNo("MO");
                    mo.OPERATOR = user.USERDM;
                }
            }
            return base.ExecuteUpdate(user, list);
        }
    }
}
