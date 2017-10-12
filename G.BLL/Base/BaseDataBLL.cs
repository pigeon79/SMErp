using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.ComponentModel;
using System.Security.Permissions;
using G.Data;
using G.Data.Model.Linq;
using G.Data.Model.Member;
using G.Core;
using G.Data.Definition;
using G.Entity.SysEnt;
using System.Data;

namespace G.BLL.Base
{
    public class BaseDataBLL : IBaseBLL
    {
        
        public DataSet IGetData(ND_USER user, string sqlstr, Condition condition, OrderBy order, int pageSize, int pageIndex, ref int totalRowCount)
        {
            DataSet ds = new DataSet();

            if (sqlstr != "")
            {
                string s = condition.GetSqlCondition().Replace("'", "''");
                sqlstr = sqlstr.Trim().ToUpper();
                if (sqlstr.Substring(6) == "SELECT")
                {
                    if (sqlstr.Contains("[GCONDITION]")) {
                        sqlstr = sqlstr.Replace("[GCONDITION]", s);
                    }
                    else
                    {
                        sqlstr=string.Format("select * from ({0}) p where {1}",sqlstr,s);
                    }
                    ds = DbEntry.Provider.ExecuteDataset(sqlstr);
                    totalRowCount = ds.Tables[0].Rows.Count;
                }
                else
                {
                    sqlstr = string.Format("EXEC {0} '{1}','{2}'", sqlstr, user.USERDM, s);
                    ds = DbEntry.Provider.ExecuteDataset(sqlstr);
                    totalRowCount = ds.Tables[0].Rows.Count;
                }
            }
            return ds;
        }
        public DataTable IGetData(ND_USER user, Condition condition, OrderBy order, int pageSize, int pageIndex, ref int totalRowCount)
        {
            throw new NotImplementedException();
        }

        public int Delete(ND_USER user, IDictionary keys, IDictionary values)
        {
            throw new NotImplementedException();
        }

        public int Insert(ND_USER user, IDictionary values)
        {
            throw new NotImplementedException();
        }

        public int Update(ND_USER user, IDictionary keys, IDictionary values, IDictionary oldValues)
        {
            throw new NotImplementedException();
        }

        public int IExecuteDelete(ND_USER user, IDbObject obj)
        {
            throw new NotImplementedException();
        }

        public int IExecuteUpdate(ND_USER user, IDbObject obj)
        {
            throw new NotImplementedException();
        }

        public bool IAudit(ND_USER user, IDbObject obj)
        {
            throw new NotImplementedException();
        }

        public IDbObject IFindObject(ND_USER user, int key)
        {
            throw new NotImplementedException();
        }

        public object IExecuteSelect(ND_USER user, Condition condition, OrderBy order, int pageSize, int pageIndex, ref int totalRowCount)
        {
            throw new NotImplementedException();
        }
    }
}
