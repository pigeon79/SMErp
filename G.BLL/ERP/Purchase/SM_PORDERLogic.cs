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
    public class SM_PORDERLogic : BaseBLL<SM_PORDER>, G.Interface.BLL.ISearch
    {
        public override int ExecuteDelete(ND_USER user, SM_PORDER obj)
        {
            if (obj.STATUS == "N")
            {
                return base.ExecuteDelete(user, obj);
            }
            else { throw new Exception("新增单据才能删除"); }
        }
        public void Audit(ND_USER user, SM_PORDER obj)
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
        public void UnAudit(ND_USER user, SM_PORDER obj) {
            if (obj.STATUS == "A")
            {
                SM_SHIPVOUCHERLogic shipv = new SM_SHIPVOUCHERLogic();
                List<SM_SHIPVOUCHER> listship=shipv.ExecuteSelect(CK.K["POID"].Eq(obj.POID), OrderBy.Parse(""), 0, 0);
                if (listship.Count == 0)
                {
                    DateTime now = BaseExtends.GetServerDate();
                    obj.STATUS = "N";
                    obj.AUDITDATE = now;
                    obj.AUDITOR = user.USERDM;
                    this.ExecuteUpdate(obj);
                }
                else { throw new Exception("该采购已收货,不能反审核！"); }
            }
            else { throw new Exception("订单没有审核！"); }
        }
        public void Closed(ND_USER user, SM_PORDER obj) {
            if (obj.Id > 0 && obj.STATUS == "A")
            {
                obj.STATUS = "C";
                obj.Save();
            }
            else { throw new Exception("该订单不是审核状态"); }
        }
        public void UnClosed(ND_USER user, SM_PORDER obj) {
            if (obj.Id > 0 && obj.STATUS == "C")
            {
                obj.STATUS = "A";
                obj.Save();
            }
            else { throw new Exception("该订单不是结清状态"); }
        }
        public override bool SaveBefore(ref SM_PORDER obj)
        {
            bool ispass = true;
            foreach (SM_PORDERDTL dtl in obj.PORDERDTL)
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
        public override int ExecuteUpdate(ND_USER user, SM_PORDER obj)
        {
            if (obj.Id <= 0)
            {
                DateTime now = BaseExtends.GetServerDate();
                obj.OPERDATE = DateTime.Parse(now.ToShortDateString());
                obj.POID = BaseExtends.GetNewAutoNo("PO");
                obj.OPERATOR = user.USERDM;
            }

            int lnno = 1;
            foreach (SM_PORDERDTL d in obj.PORDERDTL)
            {
                d.POID = obj.POID;
                d.POLNNO = lnno;
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
                    c = CK.K["POID"].Like(SearchText);
                }
                else
                {
                    c = CK.K[ValueField].Eq(SearchText);
                }
            }
            if (SearchCondition != null) { c &= SearchCondition; }
            c &= CK.K["STATUS"].Eq("A");

            return this.ExecuteSelect(c, OrderBy.Parse("POID"), 100, 0, ref allcount).ToDataTable();
        }
    }
}
