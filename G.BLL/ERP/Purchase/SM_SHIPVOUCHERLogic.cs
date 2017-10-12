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
    public class SM_SHIPVOUCHERLogic : BaseBLL<SM_SHIPVOUCHER>
    {
        public override int ExecuteDelete(ND_USER user, SM_SHIPVOUCHER obj)
        {
            if (obj.STATUS == "N")
            {
                return base.ExecuteDelete(user, obj);
            }
            else { throw new Exception("新增单据才能删除"); }
        }
        public void Audit(ND_USER user, int id)
        {
            DbEntry.UsingTransaction(delegate
            {
                string csql = string.Format("exec SMProc_ApproveShipVoucher {0},'{1}' ", id, user.USERDM);
                DbEntry.Provider.ExecuteNonQuery(csql);
            });
        }
        public override int ExecuteUpdate(ND_USER user, SM_SHIPVOUCHER obj)
        {
            if (obj.Id <= 0)
            {
                DateTime now = BaseExtends.GetServerDate();
                obj.OPERDATE = DateTime.Parse(now.ToShortDateString());
                obj.SHIPVID = BaseExtends.GetNewAutoNo("SH");
                obj.OPERATOR = user.USERDM;
            }

            int lnno = 1;
            foreach (SM_SHIPVOUCHERDTL d in obj.SHIPVOUCHERDTL)
            {
                d.SHIPVID = obj.SHIPVID;
                d.SHIPVLNNO = lnno;
                lnno++;
            }

            base.ExecuteUpdate(user,obj);
            return obj.Id;
        }
        public override bool SaveBefore(ref SM_SHIPVOUCHER obj)
        {
            bool ispass = true;
            foreach (SM_SHIPVOUCHERDTL dtl in obj.SHIPVOUCHERDTL)
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
