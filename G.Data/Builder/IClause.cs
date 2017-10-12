using G.Data.Dialect;
using G.Data.SqlEntry;

namespace G.Data.Builder
{
	public interface IClause
	{
        string ToSqlText(DataParameterCollection dpc, DbDialect dd, bool isView);
	}
}
