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

namespace G.BLL.ERP.Assist
{
    public class SM_ASSISTMENTRYLogic : BaseBLL<SM_ASSISTMENTRY>
    {
        public override int ExecuteDelete(ND_USER user, SM_ASSISTMENTRY obj)
        {
            if (obj.STATUS == "N")
            {
                return base.ExecuteDelete(user, obj);
            }
            else { throw new Exception("新增单据才能删除"); }
        }
        public void Audit(ND_USER user, SM_ASSISTMENTRY obj)
        {
            if (obj.STATUS == "N")
            {
                //DateTime now = BaseExtends.GetServerDate();
                //obj.STATUS = "A";
                //obj.AFFIRMDATE = now;
                //obj.AFFIRMER = user.USERDM;
                //this.ExecuteUpdate(obj);
                DbEntry.UsingTransaction(delegate
                {
                    string csql = string.Format("exec SMProc_AssistEntry {0},'{1}' ", obj.Id, user.USERDM);
                    DbEntry.Provider.ExecuteNonQuery(csql);
                });
            }
            else { throw new Exception("订单已审核！"); }
        }
        public override int ExecuteUpdate(ND_USER user, SM_ASSISTMENTRY obj)
        {
            if (obj.Id <= 0)
            {
                DateTime now = BaseExtends.GetServerDate();
                obj.OPERDATE = DateTime.Parse(now.ToShortDateString());
                obj.ASSISTMECODE = BaseExtends.GetNewAutoNo("WR");
                obj.OPERATOR = user.USERDM;
            } 
            
            int lnno = 1;
            foreach (SM_ASSISTMENTRYDTL d in obj.ASSISTMENTRYDTL)
            {
                d.ASSISTMECODE = obj.ASSISTMECODE;
                d.LNNO = lnno;
                lnno++;
            }

            base.ExecuteUpdate(user, obj);
            return obj.Id;
        }
        public override bool SaveBefore(ref SM_ASSISTMENTRY obj)
        {
            bool ispass = true;
            foreach (SM_ASSISTMENTRYDTL dtl in obj.ASSISTMENTRYDTL)
            {
                if (dtl.ISATTRIBUTEA == false)
                {
                    throw new Exception("该物品没有设置是否色号！请在项目数据维护中设置！");
                    return false;
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
