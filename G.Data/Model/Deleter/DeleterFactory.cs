using G.Data.Model.Composer;
using G.Data.Model.Handler;
using G.Data.SqlEntry;

namespace G.Data.Model.Deleter
{
    static class DeleterFactory
    {
        public static SimpleDeleter CreateDeleter(ObjectInfo info, QueryComposer composer, DataProvider provider, IDbObjectHandler handler)
        {
            if(info.HasRelation)
            {
                return new RelationModelDeleter(info, composer, provider, handler);
            }
            if(info.HasOnePrimaryKey && info.KeyMembers[0].UnsavedValue != null)
            {
                return new KeyModelDeleter(info, composer, provider, handler);
            }
            return new SimpleDeleter(info, composer, provider, handler);
        }
    }
}
