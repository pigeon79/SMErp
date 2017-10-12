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

namespace G.BLL.ERP.Plan
{
    public class SM_BOMTEMPLogic : BaseBLL<SM_BOMTEMP>
    {
        public void PlanFin(ND_USER user, string orderid)
        {
            DbEntry.UsingTransaction(delegate
            {
                string sql = string.Format("update SM_SALEORDERSTATUS set ORDSTATUS=2 where OrderID='{0}'", orderid);
                DbEntry.Provider.ExecuteNonQuery(sql);
            });
        }
        public void AssistFirstDown(ND_USER user, string orderid)
        {
            DbEntry.UsingTransaction(delegate
            {
                string csql = string.Format("exec SMProc_AssistFirstDown '{0}','{1}' ", orderid, user.USERDM);
                DbEntry.Provider.ExecuteNonQuery(csql);
            });
        }
        public void AssistAllDown(ND_USER user, string orderid)
        {
            DbEntry.UsingTransaction(delegate
            {
                string csql = string.Format("exec SMProc_AssistAllDown '{0}','{1}' ", orderid, user.USERDM);
                DbEntry.Provider.ExecuteNonQuery(csql);
            });
        }
        public void ClearBomtemp(ND_USER user, string orderid)
        {
            DbEntry.UsingTransaction(delegate
            {
                string csql = string.Format("exec SMProc_ClearBomTemp '{0}','{1}' ", orderid, user.USERDM);
                DbEntry.Provider.ExecuteNonQuery(csql);
            });
        }
        public List<SM_BOMTEMP> GetBomTempDataByGx(ND_USER user, string orderid, string gxname, int typeid)
        {
            List<SM_BOMTEMP> list = new List<SM_BOMTEMP>();
            string csql = string.Format("select ISSELECT, F1.ID, FATHERITEM, F1.ITEMCODE, F1.REQUIREQTY, F1.SAFESTOCK, F1.ADVICEQTY, F1.BOMQTY, F1.ITEMLEVEL, F1.ORDERID,F1.ORDLNNO, F1.ATTRIBUTEA, F1.ATTRIBUTEB, F1.ATTRIBUTEC, F1.ATTRIBUTED, F1.ATTRIBUTEE, F1.SBEGINDATE, F1.SENDDATE, F1.STATUS, F1.SHOPORDERID, F1.TYPEID, F1.BATCHNUMBER, F1.MEMO, F1.OPERDATE, F1.OPERATOR, F1.ITEMNAME, F1.ATTRIBUTEBNAME, F1.PURDATE, F1.PRODATE, F1.ASSISTDATE, F1.ASSISTQTY, F1.ASSISTSTATUS, F1.UNASSISTQTY, F1.InvUnit, F1.PLANQTY, F1.UNPLANQTY, F1.PURQTY, F1.SUPPRICE, F1.SUPCODE, F1.STOCKQTY, F1.TCOLOR,  " +
            " F1.ONHANDQTY, F1.ONHANDQTY1, F1.RDATE, F1.FATHERITEMNAME, F1.FATHERISIZE,f2.DUEQTY,CASE WHEN F1.TYPEID=2 THEN CASE WHEN LEFT(F1.FATHERITEM,4)='S1LS' THEN CAST(CEILING(F1.BOMQTY*(1+isnull(F7.WASTING,0))*F3.ISIZE/100-ISNULL(f2.DUEQTY,0)-ISNULL(PURQTY,0)) AS INT) ELSE CAST(CEILING(F1.BOMQTY*(1+isnull(F7.WASTING,0))-ISNULL(f2.DUEQTY,0)-ISNULL(PURQTY,0)) AS INT) END ELSE CAST(CEILING(F1.BOMQTY*(1+isnull(F7.WASTING,0))-ISNULL(f2.DUEQTY,0)-ISNULL(PURQTY,0)) AS INT) END AS LEFTQTY from SM_BOMTEMP_V1 f1  " +
            "left join (select cast(SUM(isnull(REQQTY,0)) as int) as DUEQTY,BOMTEMPID FROM SM_SHOPORDER where WORKSHOP='{1}' GROUP BY BOMTEMPID) f2 ON f1.ID=f2.BOMTEMPID LEFT JOIN DM_ITEM F3 ON F1.FATHERITEM=F3.ITEMCODE " +
            "LEFT JOIN SM_ITEMROUTING_V1 F6 ON F3.ItemType=F6.ITEMTYPEID AND F6.GXNAME='{1}' LEFT JOIN SM_ITEMROUTINGWASTING F7 ON F6.ID=F7.ITEMROUTINGID AND f1.BOMQTY>=F7.FQTY AND f1.BOMQTY<=F7.TQTY WHERE F1.ORDERID='{0}' AND TYPEID={2}", orderid, gxname, typeid);

            if (gxname.Trim() == "品检（包装）")
            {
                csql = string.Format("select ISSELECT, F1.ID, FATHERITEM, F1.ITEMCODE, F1.REQUIREQTY, F1.SAFESTOCK, F1.ADVICEQTY, F1.BOMQTY, F1.ITEMLEVEL, F1.ORDERID,F1.ORDLNNO, F1.ATTRIBUTEA, F1.ATTRIBUTEB, F1.ATTRIBUTEC, F1.ATTRIBUTED, F1.ATTRIBUTEE, F1.SBEGINDATE, F1.SENDDATE, F1.STATUS, F1.SHOPORDERID, F1.TYPEID, F1.BATCHNUMBER, F1.MEMO, F1.OPERDATE, F1.OPERATOR, F1.ITEMNAME, F1.ATTRIBUTEBNAME, F1.PURDATE, F1.PRODATE, F1.ASSISTDATE, F1.ASSISTQTY, F1.ASSISTSTATUS, F1.UNASSISTQTY, F1.InvUnit, F1.PLANQTY, F1.UNPLANQTY, F1.PURQTY, F1.SUPPRICE, F1.SUPCODE, F1.STOCKQTY, F1.TCOLOR,  " +
                " F1.ONHANDQTY, F1.ONHANDQTY1, F1.RDATE, F1.FATHERITEMNAME, F1.FATHERISIZE,f2.DUEQTY,CASE WHEN F1.TYPEID=2 THEN CASE WHEN LEFT(F1.FATHERITEM,4)='S1LS' THEN CAST(CEILING(f1.BOMQTY*F3.ISIZE/100-ISNULL(f2.DUEQTY,0)-ISNULL(PURQTY,0)) AS INT) ELSE CAST(CEILING(f1.BOMQTY-ISNULL(f2.DUEQTY,0)-ISNULL(PURQTY,0)) AS INT) END ELSE CAST(CEILING(f1.BOMQTY-ISNULL(f2.DUEQTY,0)-ISNULL(PURQTY,0)) AS INT) END AS LEFTQTY from SM_BOMTEMP_V1 f1 left join (select cast(SUM(isnull(REQQTY,0)) as int) as DUEQTY,BOMTEMPID FROM SM_SHOPORDER where WORKSHOP='{1}' GROUP BY BOMTEMPID) f2 ON f1.ID=f2.BOMTEMPID " +
                "LEFT JOIN DM_ITEM F3 ON F1.FATHERITEM=F3.ITEMCODE WHERE F1.ORDERID='{0}' AND TYPEID={2}", orderid, gxname, typeid);
            }
            DbEntry.UsingTransaction(delegate
            {
                
                list = SM_BOMTEMP.FindBySql(csql);
            });
            return list;
        }
    }
}
