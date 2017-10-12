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

namespace G.BLL.ERP.Sale
{
    public class SM_POCKETLogic : BaseBLL<SM_POCKET>
    {
        public override int ExecuteDelete(ND_USER user, SM_POCKET obj)
        {
            if (obj.STATUS == "N")
            {
                return base.ExecuteDelete(user, obj);
            }
            else { throw new Exception("新增单据才能删除"); }
        }
        public void Audit(ND_USER user, SM_POCKET obj)
        {
            if (obj.STATUS == "N")
            {
                //DateTime now = BaseExtends.GetServerDate();
                //obj.STATUS = "A";
                //obj.AUDITDATE = now;
                //obj.AUDITOR = user.USERDM;
                //this.ExecuteUpdate(obj);
                DbEntry.UsingTransaction(delegate
                {
                    string csql = string.Format("exec SMProc_ApprovePocket {0},'{1}' ", obj.POCKID, user.USERDM);
                    DbEntry.Provider.ExecuteNonQuery(csql);
                });
            }
            else { throw new Exception("订单已审核！"); }
        }
        public override int ExecuteUpdate(ND_USER user, SM_POCKET obj)
        {
            this.ValidPocketData(obj);
            if (obj.Id <= 0)
            {
                DateTime now = BaseExtends.GetServerDate();
                obj.POCKETDATE = DateTime.Parse(now.ToShortDateString());
                obj.OPERDATE = DateTime.Parse(now.ToShortDateString());
                obj.POCKID = BaseExtends.GetNewAutoNo("PK");
                obj.OPERATOR = user.USERDM;
            }

            int lnno = 1;
            foreach (SM_POCKETDTL d in obj.POCKETDTL)
            {
                d.POCKID = obj.POCKID;
                d.POCKLNNO = lnno;
                lnno++;
            }
            DbEntry.NewTransaction(delegate
            {
                base.ExecuteUpdate(user, obj);
                string csql = string.Format("exec SMProc_PocketStatus '{0}' ", obj.ORDERID);
                DbEntry.Provider.ExecuteNonQuery(csql);
            });
            return obj.Id;
        }
        public override int ExecuteDelete(SM_POCKET obj)
        {
            int c = 0;
            DbEntry.NewTransaction(delegate
            {
                c = base.ExecuteDelete(obj);
                if (c == 1)
                {
                    string csql = string.Format("update SM_SALEORDERSTATUS set POCKETTAG=0 WHERE ORDERID='{0}' ", obj.ORDERID);
                    DbEntry.Provider.ExecuteNonQuery(csql);
                }
            });
            return c;
            
        }
        private void ValidPocketData(SM_POCKET obj)
        {
            foreach (SM_POCKETDTL d in obj.POCKETDTL)
            {
                decimal unfinishqty = G.Core.GConvert.ToDecimal(d.UNFINISHQTY);
                decimal pocketqty = G.Core.GConvert.ToDecimal(d.POCKETQTY);
                if (pocketqty > unfinishqty)
                {
                    throw new Exception("本次装箱数超出可装箱数，不能保存！");
                }
            }
        }
    }
}
