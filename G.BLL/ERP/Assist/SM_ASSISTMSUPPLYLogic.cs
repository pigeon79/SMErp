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
    public class SM_ASSISTMSUPPLYLogic : BaseBLL<SM_ASSISTMSUPPLY>, G.Interface.BLL.ISearch
    {
        public override int ExecuteDelete(ND_USER user, SM_ASSISTMSUPPLY obj)
        {
            if (obj.STATUS == "N")
            {
                return base.ExecuteDelete(user, obj);
            }
            else { throw new Exception("新增单据才能删除");}
        }
        public void Audit(ND_USER user, SM_ASSISTMSUPPLY obj)
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
                    string csql = string.Format("exec SMProc_AssistSupply {0},'{1}' ", obj.Id, user.USERDM);
                    DbEntry.Provider.ExecuteNonQuery(csql);
                });
            }
            else { throw new Exception("订单已审核！"); }
        }
        public override int ExecuteUpdate(ND_USER user, SM_ASSISTMSUPPLY obj)
        {
            if (obj.Id <= 0)
            {
                DateTime now = BaseExtends.GetServerDate();
                obj.OPERDATE = DateTime.Parse(now.ToShortDateString());
                obj.ASSISTMSCODE = BaseExtends.GetNewAutoNo("WX");
                obj.OPERATOR = user.USERDM;
            }

            int lnno = 1;
            foreach (SM_ASSISTMSUPPLYDTL d in obj.ASSISTMSUPPLYDTL)
            {
                d.ASSISTMSCODE = obj.ASSISTMSCODE;
                d.LNNO = lnno;
                lnno++;
            }

            base.ExecuteUpdate(user, obj);
            return obj.Id;
        }
       
        public System.Data.DataTable SearchValue(Condition SearchCondition, string SearchText, string Fields, string ValueField)
        {
            int allcount = 0;
            Condition c = Condition.Empty;
            if (!String.IsNullOrEmpty(SearchText))
            {
                if (string.IsNullOrEmpty(ValueField))
                {
                    c = CK.K["ASSISTMSCODE"].Like(SearchText);
                }
                else
                {
                    c = CK.K[ValueField].Eq(SearchText);
                }
            }
            if (SearchCondition != null) { c &= SearchCondition; }

            c &= CK.K["STATUS"].Eq("A");

            return this.ExecuteSelect(c, OrderBy.Parse("ASSISTMSCODE"), 100, 0, ref allcount).ToDataTable();
        }
        public override bool SaveBefore(ref SM_ASSISTMSUPPLY obj)
        {
            bool ispass = true;
            foreach (SM_ASSISTMSUPPLYDTL dtl in obj.ASSISTMSUPPLYDTL)
            {
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
