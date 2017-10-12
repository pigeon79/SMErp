using System.Collections.Generic;

namespace G.Data.Common
{
    public class EmptyCondition : Condition
    {
        public override bool SubClauseNotEmpty
        {
            get { return false; }
        }

        public override string ToSqlText(SqlEntry.DataParameterCollection dpc, Dialect.DbDialect dd, List<string> queryRequiredFields)
        {
            return null;
        }
        public override string GetSqlCondition()
        {
            return "";
        }
    }
}
