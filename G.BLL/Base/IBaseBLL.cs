using System.Collections;
using System.Collections.Generic;
using G.Data.Definition;
using G.Data;
using G.Entity.SysEnt;
using System.ComponentModel;
using System.Data;

namespace G.BLL.Base
{
    public interface IBaseBLL
    {
        int Delete(ND_USER user, IDictionary keys, IDictionary values);
        int Insert(ND_USER user, IDictionary values);
        int Update(ND_USER user, IDictionary keys, IDictionary values, IDictionary oldValues);
        int IExecuteDelete(ND_USER user, IDbObject obj);
        int IExecuteUpdate(ND_USER user, IDbObject obj);
        bool IAudit(ND_USER user, IDbObject obj);
        IDbObject IFindObject(ND_USER user, int key);
        object IExecuteSelect(ND_USER user, Condition condition, OrderBy order, int pageSize, int pageIndex, ref int totalRowCount);
        //DataTable IExecuteSelect2Table(ND_USER user, Condition condition, OrderBy order, int pageSize, int pageIndex, ref int totalRowCount);
        DataSet IGetData(ND_USER user, string sqlstr, Condition condition, OrderBy order, int pageSize, int pageIndex, ref int totalRowCount);
        DataTable IGetData(ND_USER user, Condition condition, OrderBy order, int pageSize, int pageIndex, ref int totalRowCount);
    }
}
