using System.Collections.Generic;
using System.Data;
using G.Data.Dialect;
using G.Data.Builder.Clause;
using G.Data.SqlEntry;

namespace G.Data.Builder
{
	public class UpdateStatementBuilder : SqlStatementBuilder, ISqlValues, ISqlWhere
	{
		private const string StatementTemplate = "UPDATE {0} {1} {2};\n";
		private readonly FromClause _from;
        private readonly WhereClause _whereOptions = new WhereClause();
		private readonly SetClause _setOptions = new SetClause();

        public UpdateStatementBuilder(FromClause from)
		{
            this._from = from;
		}

        protected override SqlStatement ToSqlStatement(DbDialect dd, List<string> queryRequiredFields)
		{
			var dpc = new DataParameterCollection();
            var sqlString = string.Format(StatementTemplate, _from.ToSqlText(dpc, dd,false),
                                          _setOptions.ToSqlText(dpc, dd,queryRequiredFields),
                                          Where.ToSqlText(dpc, dd, queryRequiredFields));
			var sql = new SqlStatement(CommandType.Text, sqlString, dpc);
			return sql;
		}

        public List<KeyOpValue> Values
		{
			get { return _setOptions; }
		}

		public WhereClause Where
		{
			get { return _whereOptions; }
		}
	}
}
