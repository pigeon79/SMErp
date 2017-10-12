using System.Data;
using G.Data.Builder;
using G.Data.Builder.Clause;
using G.Data.Model;
using G.Data.SqlEntry;

namespace G.Data.Dialect
{
    public abstract class SequencedDialect : DbDialect
    {
        protected override object ExecuteInsertIntKey(InsertStatementBuilder sb, ObjectInfo info, DataProvider provider)
        {
            string seqStr = GetSelectSequenceSql(info.From.MainTableName);
            var seq = new SqlStatement(CommandType.Text, seqStr);
            object key = provider.ExecuteScalar(seq);
            sb.Values.Add(new KeyOpValue(info.KeyMembers[0].Name, key, KvOpertation.None));
            SqlStatement sql = sb.ToSqlStatement(provider.Dialect, null, info.AllowSqlLog);
            provider.ExecuteNonQuery(sql);
            return key;
        }

        public abstract string GetSelectSequenceSql(string tableName);
    }
}
