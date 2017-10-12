using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using G.Entity.ERP;
using G.Data.Model.QuerySyntax;
using G.Data;
using G.BLL.Base;
using G.Data.Model.Linq;
using G.Entity.SysEnt;
using System.Data;

namespace G.BLL.ERP.BaseData
{
    public class DM_CUSTOMERLogic : BaseBLL<DM_CUSTOMER>, G.Interface.BLL.ISearch
    {

        public System.Data.DataTable SearchValue(Condition SearchCondition, string SearchText, string Fields, string ValueField)
        {
            int allcount = 0;
            Condition c = Condition.Empty;
            if (!String.IsNullOrEmpty(SearchText))
            {
                if (ValueField.IsNullOrEmpty())
                {
                    c = CK.K["CUSTCODE"].LeftLike(SearchText);
                    c |= CK.K["CUSTNAME"].Like(SearchText);
                }
                else {
                    c = CK.K[ValueField].Eq(SearchText);
                }
            }
            if (SearchCondition != null) { c &= SearchCondition; }

            return this.ExecuteSelect(c, OrderBy.Parse("CUSTCODE"), 20, 0, ref allcount).ToDataTable();
        }
        public override int ExecuteUpdate(ND_USER user, DM_CUSTOMER obj)
        {
            if (obj.Id <= 0)
            {
                DateTime now = BaseExtends.GetServerDate();
                obj.OPERDATE = DateTime.Parse(now.ToShortDateString());
                obj.CUSTCODE = GetNewCustCode(obj.AREA);
                obj.OPERATOR = user.USERDM;
            }
            base.ExecuteUpdate(user, obj);
            return obj.Id;
        }
        private string GetNewCustCode(string area) {
            string custcode = "";
            if (area == "") throw new Exception("地区不能为空！");
            List<DM_CUSTOMER> custlist = this.ExecuteSelect(CK.K["CUSTCODE"].LeftLike(area), OrderBy.Parse("CUSTCODE"), 0, 0);
            DM_CUSTOMER cust = custlist.Count == 0 ? null : custlist[custlist.Count - 1];
            //DM_CUSTOMER cust=this.ExecuteSelect(CK.K["CUSTCODE"].LeftLike(area), OrderBy.Parse("CUSTCODE"), 0, 0).Max();
            if(cust!=null){
                custcode = cust.CUSTCODE;
                if (custcode.Substring(4, 3) == "999")
                {
                    throw new Exception("编号超出范围！");
                }
                custcode = area + (Convert.ToInt32(custcode.Substring(4)) + 1).ToString().PadLeft(3, '0');
            }
            else
            {
                custcode = area + "001";
            }
            return custcode;
        }
    }
}
