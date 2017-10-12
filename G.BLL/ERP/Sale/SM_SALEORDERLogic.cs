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
    public class SM_SALEORDERLogic : BaseBLL<SM_SALEORDER>, G.Interface.BLL.ISearch
    {
        public override int ExecuteDelete(ND_USER user, SM_SALEORDER obj)
        {
            if (obj.STATUS == "C")
            {
               throw new Exception("结清订单不能删除"); 
            }
            else { return base.ExecuteDelete(user, obj); }
        }
        public void Audit(ND_USER user, SM_SALEORDER obj)
        {
            if (obj.STATUS == "N" || obj.STATUS == "B")
            {
                //DateTime now = BaseExtends.GetServerDate();
                //obj.STATUS = "A";
                //obj.AUDITDATE = now;
                //obj.AUDITOR = user.USERDM;
                //this.ExecuteUpdate(obj);

                DbEntry.UsingTransaction(delegate
                {
                    string csql = string.Format("exec SMProc_ApproveSaleOrder {0},'{1}' ", obj.ORDERID, user.USERDM);
                    DbEntry.Provider.ExecuteNonQuery(csql);
                });
            }
            else { throw new Exception("订单已审核！"); }
        }
        public override int ExecuteUpdate(ND_USER user,SM_SALEORDER obj)
        {
            if (obj.Id <= 0)
            {
                DateTime now = BaseExtends.GetServerDate();
                obj.ORDERDATE = DateTime.Parse(now.ToShortDateString());
                obj.OPERDATE = DateTime.Parse(now.ToShortDateString());
                obj.ORDERID = BaseExtends.GetNewAutoNo("SO");
                obj.OPERATOR = user.USERDM;
            }
            decimal allqty = 0, allamount = 0, addamount = 0,baseamount=0;
            int ordindex = 0;
            foreach (SM_SALEORDERDTL d in obj.SALEORDERDTL) {
                ordindex++;
                
                d.ORDERID = obj.ORDERID;
                allqty += (decimal)d.LNQTY;
                d.LNAMOUNT = d.LNPRICE * d.LNQTY;
                addamount += (decimal)(d.LNQTY * d.ADDPRICE);
                baseamount += (decimal)(d.LNQTY * d.BASICPRICE);
                allamount += (decimal)d.LNAMOUNT;
                d.ORDLNNO = ordindex;
            }
            obj.ORDQTY = allqty;
            obj.ORDAMOUNT = allamount;
            obj.ORDDISCOUNT = 0;
            if (baseamount != 0)
            { obj.ORDDISCOUNT = decimal.Round((allamount - addamount) / baseamount, 3); }
            if (obj.STATUS == "A")
            {
                string csql = string.Format("SMProc_SaleOrderChange '{0}','{1}'", obj.ORDERID, user.USERDM);
                DbEntry.UsingTransaction(delegate
                {
                    DbEntry.Provider.ExecuteNonQuery(csql);
                    obj.STATUS = "B";
                    base.ExecuteUpdate(user, obj);
                });
            }
            else
            {
                base.ExecuteUpdate(user, obj);
            }
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
                    c = CK.K["ORDERID"].Like(SearchText);
                }
                else
                {
                    c = CK.K[ValueField].Eq(SearchText);
                }
            }
            if (SearchCondition != null) { c &= SearchCondition; }
            c &= CK.K["STATUS"].Eq("A");

            return this.ExecuteSelect(c, OrderBy.Parse("ORDERID"), 100, 0, ref allcount).ToDataTable();
        }

        public SM_SALEORDER GetSaleOrder(ND_USER user, string orderid) {
            SM_SALEORDER order = new SM_SALEORDER();
            List<SM_SALEORDER> orders = this.ExecuteSelect(CK.K["ORDERID"].Eq(orderid), OrderBy.Parse("ORDERID"), 0, 0);
            if (orders.Count > 0) { order = orders[0]; }
            return order;
        }
    }
}
