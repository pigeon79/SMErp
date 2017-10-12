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
using System.Data;
using G.Data.SqlEntry;

namespace G.BLL.Base
{
    public abstract partial class DbEntryDataSource<T> where T : class, IDbObject, new()
    {
        public void AddAndCondition(Expression<Func<T, bool>> condition)
        {
            var c = ExpressionParser<T>.Parse(condition);
            Condition &= c;
        }

        protected static readonly ModelContext Ctx = ModelContext.GetInstance(typeof(T));
        protected static readonly string KeyName = Ctx.Info.KeyMembers[0].Name;
        public event EventHandler DataSourceChanged;

        protected void RaiseDataSourceChanged()
        {
            if (DataSourceChanged != null)
            {
                DataSourceChanged(this, new EventArgs());
            }
        }

        protected ICollection GetViewNames()
        {
            return new[] { "MainView" };
        }

        private OrderBy _mOrderBy;

        [DefaultValue("Id DESC"), Category("Behavior")]
        public string DefaultOrderBy
        {
            get;
            set;
        }

        [DefaultValue(false), Category("Behavior")]
        public bool IsStatic
        {
            get;
            set;
        }
        private Condition _condition;

        [Browsable(false)]
        public Condition Condition
        {
            get { return _condition; }
            set { _condition = value; }
        }

        public virtual List<T> ExecuteSelect(Condition condition, OrderBy order, int pageSize, int pageIndex, ref int totalRowCount)
        {
            if (pageSize == 0)
            {
                return DbEntry.From<T>().Where(condition).OrderBy(order).Select();
            }
            var igp = DbEntry
                .From<T>()
                .Where(condition)
                .OrderBy(order)
                .PageSize(pageSize);
            var ps = IsStatic ? igp.GetStaticPagedSelector() : igp.GetPagedSelector();
            totalRowCount = (int)ps.GetResultCount();
            IList result = ps.GetCurrentPage(pageIndex);
            return (List<T>)result;
        }
        public virtual List<T> ExecuteSelect(Condition condition, OrderBy order, int pageSize, int pageIndex)
        {
            if (pageSize == 0)
            {
                return DbEntry.From<T>().Where(condition).OrderBy(order).Select();
            }
            var igp = DbEntry
                .From<T>()
                .Where(condition)
                .OrderBy(order)
                .PageSize(pageSize);
            var ps = IsStatic ? igp.GetStaticPagedSelector() : igp.GetPagedSelector();
            IList result = ps.GetCurrentPage(pageIndex);
            return (List<T>)result;
        }

        
        public virtual int ExecuteDelete(T obj)
        {
            if (obj != null)
            {
                var o = obj as DbObjectSmartUpdate;
                if (o != null)
                {
                    o.Delete();
                }
                else
                {
                    DbEntry.Delete(obj);
                }

                return 1;
            }
            return 0;
        }
        public virtual bool SaveBefore(ref T obj)
        {
            return true;
        }
        public virtual bool SaveBefore(ref List<T> list)
        {
            return true;
        }
        public virtual int ExecuteInsert(T obj)
        {
            if (obj != null)
            {
                if (SaveBefore(ref obj))
                {
                    var o = obj as DbObjectSmartUpdate;
                    if (o != null)
                    {
                        o.Save();
                    }
                    else
                    {
                        DbEntry.Save(obj);
                    }

                    return 1;
                }
            }
            return 0;
        }

       
        public virtual int ExecuteUpdate(T obj)
        {
            if (obj != null)
            {
                if (SaveBefore(ref obj))
                {
                    var o = obj as DbObjectSmartUpdate;
                    if (o != null)
                    {
                        o.Save();
                    }
                    else
                    {
                        DbEntry.Save(obj);
                    }
                    return 1;
                }
            }
            return 0;
        }
        public virtual int ExecuteUpdate(List<T> list) {
            if (list.Count > 0) {
                DbEntry.Save(list.ToArray());
                return 1;
            }
            return 0;
        }
        
        protected virtual T CreateObject(IDictionary keys, IDictionary values)
        {
            T obj;
            object key = null;
            if (keys != null)
            {
                key = ClassHelper.ChangeType(keys[KeyName], Ctx.Info.KeyMembers[0].MemberType);
            }
            if (key == null || key.Equals(Ctx.Info.KeyMembers[0].UnsavedValue))
            {
                obj = (T)Ctx.NewObject();
            }
            else
            {
                obj = DbEntry.GetObject<T>(key);
            }
            foreach (MemberHandler mh in Ctx.Info.SimpleMembers)
            {
                string name = mh.MemberInfo.IsProperty ? mh.MemberInfo.Name : mh.Name;
                if (name != KeyName)
                {
                    if (values.Contains(name))
                    {
                        object ov = values[name];
                        object mo;
                        if (ov != null)
                        {
                            mo = ClassHelper.ChangeType(ov.ToString(), mh.MemberType);
                        }
                        else
                        {
                            mo = !mh.Is.AllowNull ? "" : null;
                        }
                        object ho = mh.GetValue(obj);
                        if (!Util.AreEqual(ho, mo))
                        {
                            mh.SetValue(obj, mo);
                        }
                    }
                }
            }
            return obj;
        }

        #region extend
        public virtual List<T> GetData(Condition condition, OrderBy order, int pageSize, int pageIndex, ref int totalRowCount)
        {
            if (pageSize == 0)
            {
                return DbEntry.From<T>().Where(condition).OrderBy(order).Select();
            }
            var igp = DbEntry
                .From<T>()
                .Where(condition)
                .OrderBy(order)
                .PageSize(pageSize);
            var ps = IsStatic ? igp.GetStaticPagedSelector() : igp.GetPagedSelector();
            totalRowCount = (int)ps.GetResultCount();
            IList result = ps.GetCurrentPage(pageIndex);
            return (List<T>)result;
        }
        public virtual T FindObject(int pkey)
        {
            return DbEntry.GetObject<T>(pkey);
        }
        
        public virtual T FindObject(Condition c)
        {
            return DbEntry.GetObject<T>(c);
        }
        #endregion

        public virtual DataSet GetProcedureData(string userdm,Condition c,string ProcedureName) {
            DataSet ds = new DataSet();
            DbEntry.UsingTransaction(delegate{
                var sql = new SqlStatement(
                ProcedureName,
                new DataParameter("@userdm", userdm),
                new DataParameter("@tj", c.ToString())
                );
                
                ds = DbEntry.Provider.ExecuteDataset(sql);
            });
            return ds;
        }
    }
}
