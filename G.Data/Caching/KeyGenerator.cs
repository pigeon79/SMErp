using System;
using G.Core.Ioc;

namespace G.Data.Caching
{
    [DependenceEntry, Implementation(1)]
    public class KeyGenerator
    {
        public static readonly KeyGenerator Instance = SimpleContainer.Get<KeyGenerator>();

        public string this[object obj]
        {
            get
            {
                var type = obj.GetType();
                var ctx = ModelContext.GetInstance(type);
                return GetKey(type, ctx.Handler.GetKeyValue(obj));
            }
        }

        public virtual string GetKey(Type t, object dbKey)
        {
            string s = string.Format("{0},{1}", t.FullName, dbKey);
            return s;
        }
    }
}
