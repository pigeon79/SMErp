using System.Collections.Generic;
using System.Data;
using G.Data.Driver;
using G.Data.SqlEntry;
using G.Data.Builder;
using G.Data.Common;

namespace G.Data.Dialect
{
	public class SqlServer2000 : DbDialect
	{
		public SqlServer2000()
		{
            TypeNames[DataType.Boolean] = "BIT";
            TypeNames[DataType.Date]    = "SMALLDATETIME";
        }

        public override string DbNowString
        {
            get { return "GETDATE()"; }
        }

        public override DbDriver CreateDbDriver(string name, string connectionString, string dbProviderFactoryName, AutoScheme autoScheme)
        {
            return new SqlServerDriver(this, name, connectionString, dbProviderFactoryName, autoScheme);
        }

        public override DbStructInterface GetDbStructInterface()
        {
            return new DbStructInterface(null, new[] { null, null, null, "BASE TABLE" }, null, null, null);
        }

        public override bool SupportsRangeStartIndex
        {
            get { return false; }
        }

        public override SqlStatement GetPagedSelectSqlStatement(SelectStatementBuilder ssb, List<string> queryRequiredFields)
        {
            var dpc = new DataParameterCollection();
            string sqlString = string.Format("SELECT TOP {4} {0} FROM {1}{2}{3}",
                ssb.GetColumns(this),
                ssb.From.ToSqlText(dpc, this,true),
                ssb.Where.ToSqlText(dpc, this, queryRequiredFields),
                (ssb.Order == null || ssb.Keys.Count == 0) ? "" : ssb.Order.ToSqlText(dpc, this,true ),
                ssb.Range.EndIndex
                );
            return new TimeConsumingSqlStatement(CommandType.Text, sqlString, dpc);
        }
        
		public override string IdentitySelectString
		{
			get { return "SELECT SCOPE_IDENTITY();\n"; }
		}

		public override string IdentityColumnString
		{
            get { return "IDENTITY NOT FOR REPLICATION NOT NULL"; }
		}

		public override char CloseQuote
		{
			get { return ']'; }
		}

		public override char OpenQuote
		{
			get { return '['; }
		}

		protected override string QuoteSingle( string name )
		{
			return OpenQuote + name.Replace( CloseQuote.ToString(), new string( CloseQuote, 2 ) ) + CloseQuote;
		}
	}
}
