using G.Core;
using G.Data.Common;
using G.Data.Driver;

namespace G.Data.SqlEntry
{
    public class DataProviderFactory : FlyweightBase<string, DataProvider>
    {
        public static readonly DataProviderFactory Instance = new DataProviderFactory();

        protected override DataProvider GetInst(string tk)
        {
            var name = tk.IsNullOrEmpty() ? DataSettings.DefaultContext : tk;
            return base.GetInst(name);
        }

        protected override DataProvider CreateInst(string t)
        {
            return new DataProvider(DbDriverFactory.Instance.GetInstance(t));
        }
    }
}
