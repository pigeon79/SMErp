using System.Collections.Generic;
using G.Data.Definition;
using G.Core.Setting;

namespace G.Data.Common
{
    public class GSetting : DbObjectModel<GSetting>
    {
        [Length(1, 50), Index(UNIQUE = true)]
        public string Name { get; set; }

        public string Content { get; set; }
    }

    public class DbConfigHelper : ConfigHelperBase
    {
        public static readonly DbConfigHelper Instance = new DbConfigHelper();

        private readonly Dictionary<string, string> nvc = new Dictionary<string, string>();

        public DbConfigHelper()
        {
            GSetting.Find(Condition.Empty).ForEach(p => nvc.Add(p.Name, p.Content));
        }

        protected override string GetString(string key)
        {
            return nvc[key];
        }
    }
}
