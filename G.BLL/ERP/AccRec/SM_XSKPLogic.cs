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

namespace G.BLL.ERP.AccRec
{
    public class SM_XSKPLogic : BaseBLL<SM_XSKP>
    {
        public override int ExecuteDelete(ND_USER user, SM_XSKP obj)
        {
            if (obj.STATUS == "N")
            {
                return base.ExecuteDelete(user, obj);
            }
            else { return 0; }
        }
        public void Audit(ND_USER user, SM_XSKP obj)
        {
            if (obj.Id > 0)
            {
                if (obj.STATUS == "N")
                {
                    DbEntry.UsingTransaction(delegate
                    {
                        string csql = string.Format("SMProc_ApproveXskp {0},'{1}'", obj.Id, user.USERDM);
                        DbEntry.Provider.ExecuteNonQuery(csql);
                    });

                }
                else { throw new Exception("订单已审核！"); }
            }
            else { throw new Exception("请先保存订单！"); }
        }
        public void UnAudit(ND_USER user, SM_XSKP obj)
        {
            if (obj.STATUS == "A" && !G.Core.GConvert.ToBool(obj.ISRED) && !G.Core.GConvert.ToBool(obj.ISREVERSE))
            {
                DbEntry.UsingTransaction(delegate
                    {
                        obj.STATUS = "N";
                        obj.AUDITOR = "";
                        obj.AUDITDATE = null;
                        obj.Save();
                        string csql = string.Format("update SM_SALEORDERSTATUS set INVOICETAG=0 where ORDERID in (select orderid from SM_XSKPDTL where XSKPID={0})", obj.Id);
                        DbEntry.Provider.ExecuteNonQuery(csql);
                    });
            }
        }
        public void InValid(ND_USER user, SM_XSKP obj)
        {
            if (obj.STATUS == "A" && !G.Core.GConvert.ToBool(obj.ISRED) && !G.Core.GConvert.ToBool(obj.ISREVERSE))
            {
                DbEntry.UsingTransaction(delegate
                {
                    obj.STATUS = "C";
                    obj.ISINVALID = true;
                    obj.Save();
                    string csql = string.Format("update SM_SALEORDERSTATUS set INVOICETAG=0 where ORDERID in (select orderid from SM_XSKPDTL where XSKPID={0})", obj.Id);
                    DbEntry.Provider.ExecuteNonQuery(csql);
                });
            }
        }
        public void Red(ND_USER user, SM_XSKP obj)
        {
            if (obj.STATUS == "A" && !G.Core.GConvert.ToBool(obj.ISRED) && !G.Core.GConvert.ToBool(obj.ISREVERSE))
            {
                DbEntry.UsingTransaction(delegate
                {
                    SM_XSKP redobj = G.Core.Common.EnityClone.Clone<SM_XSKP>(obj);
                    redobj.ISRED = true;
                    redobj.STATUS = "C";
                    redobj.Id = 0;
                    redobj.SUMQTY = redobj.SUMQTY * -1;
                    redobj.SUMVAT = redobj.SUMVAT * -1;
                    redobj.SUMVOT = redobj.SUMVOT * -1;
                    redobj.SUMTAX = redobj.SUMTAX * -1;
                    foreach (SM_XSKPDTL xd in redobj.XSKPDTL) {
                        xd.Id = 0;
                        xd.ATMONEY = xd.ATMONEY * -1;
                        xd.OTMONEY = xd.OTMONEY * -1;
                        xd.QTY = xd.QTY * -1;
                        xd.TAXMONEY = xd.TAXMONEY * -1;
                    }
                    redobj.Save();
                    obj.ISREVERSE = true;
                    obj.STATUS = "C";
                    obj.Save();

                });
            }
        }
        public override int ExecuteUpdate(ND_USER user, SM_XSKP obj)
        {
            if (obj.Id <= 0)
            {
                DateTime now = BaseExtends.GetServerDate();
                obj.OPERDATE = DateTime.Parse(now.ToShortDateString());
                obj.NO = BaseExtends.GetNewAutoNo("SK");
                obj.OPERATOR = user.USERDM;
            }

            base.ExecuteUpdate(user, obj);
            return obj.Id;
        }
    }
}
