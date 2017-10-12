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
    public class BaseBLL<T> : DbEntryDataSource<T>, IBaseBLL where T : class, IDbObject, new()
    {
        public virtual List<T> ExecuteSelect(ND_USER user, Condition condition, OrderBy order, int pageSize, int pageIndex, ref int totalRowCount)
        {
            return this.ExecuteSelect(condition, order, pageSize, pageIndex, ref totalRowCount);
        }
        public virtual List<T> ExecuteSelect(ND_USER user, Condition condition, OrderBy order, int pageSize, int pageIndex)
        {
            return this.ExecuteSelect(condition, order, pageSize, pageIndex);
        }

        public virtual DataTable ExecuteSelect2Table(ND_USER user, Condition condition, OrderBy order, int pageSize, int pageIndex, ref int totalRowCount)
        {
            return this.ExecuteSelect(condition, order, pageSize, pageIndex, ref totalRowCount).ToDataTable<T>();
        }
        public virtual DataTable ExecuteSelect2Table(ND_USER user, Condition condition, OrderBy order, int pageSize, int pageIndex)
        {
            return this.ExecuteSelect(condition, order, pageSize, pageIndex).ToDataTable<T>();
        }

        public virtual int ExecuteDelete(ND_USER user, T obj)
        {
            return this.ExecuteDelete(obj);
        }

       
        //public virtual int ExecuteInsert(ND_USER user, T obj)
        //{
        //        return this.ExecuteInsert(obj);
        //}
        public virtual int ExecuteUpdate(ND_USER user, T obj)
        {
                return this.ExecuteUpdate(obj);
        }
        public virtual int ExecuteUpdate(ND_USER user, List<T> list)
        {
                return this.ExecuteUpdate(list);
        }
        public virtual int ExecuteUpdate(ND_USER user, List<T> list, List<T> deletelist)
        {
            int c = 0;
            DbEntry.UsingTransaction(delegate
            {
                foreach (T s in deletelist)
                {
                    this.ExecuteDelete(s);
                }
                c= this.ExecuteUpdate(list);
            });
            return c;
        }


        int IBaseBLL.Delete(ND_USER user, IDictionary keys, IDictionary values)
        {
            object key = ClassHelper.ChangeType(keys[KeyName], Ctx.Info.KeyMembers[0].MemberType);
            var obj = DbEntry.GetObject<T>(key);
            return ExecuteDelete(user, obj);
        }
        int IBaseBLL.Insert(ND_USER user, IDictionary values)
        {
            T obj = CreateObject(null, values);
            return ExecuteUpdate(user, obj);
        }
        int IBaseBLL.Update(ND_USER user, IDictionary keys, IDictionary values, IDictionary oldValues)
        {
            T obj = CreateObject(keys, values);
            return this.ExecuteUpdate(user, obj);
        }
        object IBaseBLL.IExecuteSelect(ND_USER user, Condition condition, OrderBy order, int pageSize, int pageIndex, ref int totalRowCount)
        {
            return new BindingList<T>(this.ExecuteSelect(user, condition, order, pageSize, pageIndex, ref totalRowCount));   
        }
        public virtual IDbObject IFindObject(ND_USER user, int pkey)
        {
            return DbEntry.GetObject<T>(pkey) as IDbObject;
        }

        public int IExecuteDelete(ND_USER user, IDbObject obj)
        {
            T o = obj as T;
            return this.ExecuteDelete(user, o);
        }

        public int IExecuteUpdate(ND_USER user, IDbObject obj)
        {
            T o = obj as T;
            return this.ExecuteUpdate(user, o);
        }


        public virtual bool IAudit(ND_USER user, IDbObject obj)
        {
            throw new NotImplementedException();
        }


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
            return this.ExecuteSelect2Table(user, condition, order, pageSize, pageIndex,ref totalRowCount);
        }

    }
}
