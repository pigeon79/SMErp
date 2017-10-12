using System.Collections.Generic;
using G.Data.Builder.Clause;

namespace G.Data.Builder
{
	public interface ISqlValues
	{
        List<KeyOpValue> Values { get; }
	}
}
