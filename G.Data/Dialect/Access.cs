﻿using System;
using System.Data;
using G.Data.Builder;
using G.Data.Builder.Clause;
using G.Data.Common;
using G.Data.Driver;
using G.Data.SqlEntry;

namespace G.Data.Dialect
{
	public class Access : SqlServer2000
	{
        public Access()
        {
            TypeNames[DataType.Int64] = "DECIMAL";
            TypeNames[DataType.UInt64] = "DECIMAL";
        }

        public override IDataReader GetDataReader(IDataReader dr, Type returnType)
        {
            return new AccessDataReader(dr, returnType);
        }

        public override DbDriver CreateDbDriver(string name, string connectionString, string dbProviderFactoryName, AutoScheme autoScheme)
        {
            return new OleDbDriver(this, name, connectionString, dbProviderFactoryName, autoScheme);
        }

        public override DbStructInterface GetDbStructInterface()
        {
            return new DbStructInterface(null, new[] { null, null, null, "TABLE" }, null, null, null);
        }

        public override string GetConnectionString(string connectionString)
        {
            string s = ProcessConnectionnString(connectionString);
            if (s[0] == '@')
            {
                return "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + s.Substring(1);
            }
            return s;
        }

		public override string IdentitySelectString
		{
			get { return "SELECT @@IDENTITY;\n"; }
		}

        public override string IdentityColumnString
        {
            get { return ""; }
        }

        public override string IdentityTypeString
        {
            get { return "COUNTER"; }
        }

		public override bool ExecuteEachLine
		{
			get { return true; }
		}

        public override string QuoteDateTimeValue(string theDate)
        {
            return "#" + theDate + "#";
        }

        public override string DbNowString
        {
            get
            {
                return "Now()";
            }
        }

        public override void AddColumn(ModelContext ctx, string columnName, object o)
        {
            base.AddColumn(ctx, columnName, null);
            if(o != null)
            {
                var stm = new UpdateStatementBuilder(ctx.Info.From);
                stm.Values.Add(new KeyOpValue(columnName, o, KvOpertation.None));
                var sql = stm.ToSqlStatement(ctx);
                ctx.Provider.ExecuteNonQuery(sql);
            }
        }
	}
}
