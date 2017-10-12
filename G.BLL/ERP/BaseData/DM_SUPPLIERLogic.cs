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

namespace G.BLL.ERP.BaseData
{
    public class DM_SUPPLIERLogic : BaseBLL<DM_SUPPLIER>, G.Interface.BLL.ISearch
    {
        public System.Data.DataTable SearchValue(Condition SearchCondition, string SearchText, string Fields, string ValueField)
        {
            int allcount = 0;
            Condition c = Condition.Empty;
            if (!String.IsNullOrEmpty(SearchText))
            {
                if (string.IsNullOrEmpty(ValueField))
                {
                    c = CK.K["SUPPCODE"].LeftLike(SearchText);
                    c |= CK.K["SUPPNAME"].Like(SearchText);
                    c |= CK.K["PY"].Like(SearchText);
                }
                else
                {
                    c = CK.K[ValueField].Eq(SearchText);
                }
            }
            if (SearchCondition != null) { c &= SearchCondition; }

            return this.ExecuteSelect(c, OrderBy.Parse("SUPPNAME"), 100, 0, ref allcount).ToDataTable();
        }

        public override int ExecuteUpdate(ND_USER user, DM_SUPPLIER obj)
        {
            if (obj.Id <= 0)
            {
                DateTime now = BaseExtends.GetServerDate();
                obj.OPERDATE = DateTime.Parse(now.ToShortDateString());
                obj.OPERATOR = user.USERDM;
            }
            if (obj.SUPPCODE == "")
            {
                obj.SUPPCODE = GetNewSuppCode(obj.PY.PadRight(3, 'A').Substring(0, 3));
            }

            base.ExecuteUpdate(user, obj);
            return obj.Id;
        }
        private string GetNewSuppCode(string suppname)
        {
            string suppcode = "";
            try
            {
                if (suppname == "") throw new Exception("供应商名称不能为空！");
                List<DM_SUPPLIER> supplist = this.ExecuteSelect(CK.K["SUPPCODE"].LeftLike(suppname), OrderBy.Parse("SUPPCODE"), 0, 0);
                DM_SUPPLIER supp = supplist.Count == 0 ? null : supplist[supplist.Count - 1];
                if (supp != null)
                {
                    suppcode = supp.SUPPCODE;
                    if (suppcode.Substring(3, 2) == "99")
                    {
                        throw new Exception("编号超出范围！");
                    }
                    suppcode = suppname + (Convert.ToInt32(suppcode.Substring(3)) + 1).ToString().PadLeft(2, '0');
                }
                else
                {
                    suppcode = suppname + "01";
                }
            }
            catch (Exception)
            {
            }
            return suppcode;
        }
    }
}
