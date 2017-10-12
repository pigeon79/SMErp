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
    public class SM_SHOPSUPPLYLogic : BaseBLL<SM_SHOPSUPPLY>
    {
        public override int ExecuteDelete(ND_USER user, SM_SHOPSUPPLY obj)
        {
            if (obj.STATUS == "N")
            {
                return base.ExecuteDelete(user, obj);
            }
            else { throw new Exception("新增单据才能删除"); }
        }
        public void Audit(ND_USER user, SM_SHOPSUPPLY obj)
        {
            if (obj.STATUS == "N")
            {
                DbEntry.UsingTransaction(delegate
                {
                    string csql = string.Format("exec SMProc_ApproveShopSupply {0},'{1}' ", obj.Id, user.USERDM);
                    DbEntry.Provider.ExecuteNonQuery(csql);
                });
            }
            else { throw new Exception("订单已审核！"); }
        }
        public override int ExecuteUpdate(ND_USER user, SM_SHOPSUPPLY obj)
        {
            if (obj.Id <= 0)
            {
                DateTime now = BaseExtends.GetServerDate();
                obj.OPERDATE = DateTime.Parse(now.ToShortDateString());
                obj.SUPPLYID = BaseExtends.GetNewAutoNo("SP");
                obj.OPERATOR = user.USERDM;
            }

            int lnno = 1;
            
            //foreach (SM_SHOPSUPPLYDTL d in obj.SHOPSUPPLYDTL)
            //{
            //    if (d.ITEMCODE.IsNullOrEmpty()) { obj.SHOPSUPPLYDTL.Remove(d); continue; }
            //    d.SUPPLYID = obj.SUPPLYID;
            //    d.SUPLNNO = lnno;
            //    lnno++;
            //}
            for (int i = 0; i < obj.SHOPSUPPLYDTL.Count; i++)
            {
                SM_SHOPSUPPLYDTL d = obj.SHOPSUPPLYDTL[i];
                if (d.ITEMCODE.IsNullOrEmpty()) { obj.SHOPSUPPLYDTL.Remove(d); i--; continue; }
                d.SUPPLYID = obj.SUPPLYID;
                d.SUPLNNO = lnno;
                lnno++;
            }

            base.ExecuteUpdate(obj);
            return obj.Id;
        }
        public override bool SaveBefore(ref SM_SHOPSUPPLY obj)
        {
            bool ispass = true;
            foreach (SM_SHOPSUPPLYDTL dtl in obj.SHOPSUPPLYDTL)
            {
                if (dtl.ISATTRIBUTEA == false)
                {
                    dtl.ATTRIBUTEA = "";
                }
                if (dtl.ISATTRIBUTEB == false)
                {
                    dtl.ATTRIBUTEB = "";
                    dtl.ATTRIBUTEBNAME = "";
                }
                if (dtl.ISATTRIBUTEC == false)
                {
                    dtl.ATTRIBUTEC = 0;
                }
            }
            return ispass;
        }
    }
}
