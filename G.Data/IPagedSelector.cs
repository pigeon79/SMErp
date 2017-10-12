using System.Collections.Generic;
using G.Data.Definition;

namespace G.Data
{
    public interface IPagedSelector<T> where T : class, IDbObject
    {
        int PageSize{get;}
        long GetResultCount();
        List<T> GetCurrentPage(long pageIndex);
        List<T> GetCurrentPage( long pageIndex,G.Data.Builder.Clause.FromClause from);
        long GetPageCount();
        //long GetPageCount(G.Data.Builder.Clause.FromClause from);
    }
}
