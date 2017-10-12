using System.Collections.Generic;

namespace G.Data.Builder
{
    public interface ISqlKeys
    {
        List<KeyValuePair<string, string>> Keys { get; }
    }
}
