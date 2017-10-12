using System.Collections.Generic;
using G.Data.Dialect;
using G.Data.SqlEntry;

namespace G.Data.Builder
{
    public interface IWhereClause
    {
        string ToSqlText(DataParameterCollection dpc, DbDialect dd, List<string> queryRequiredFields);
    }
}
