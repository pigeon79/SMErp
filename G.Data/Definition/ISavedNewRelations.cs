using System.Collections.Generic;

namespace G.Data.Definition
{
    public interface IHasAndBelongsToManyRelations
    {
        List<object> SavedNewRelations { get;}
        List<object> RemovedRelations { get;}
    }
}
