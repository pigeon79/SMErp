using System;

namespace G.Data.Builder.Clause
{
	[Serializable]
	public class AndClause : ConditionClause
	{
		public AndClause(params Condition[] kvs) : base("AND", kvs)
		{
		}
	}
}
