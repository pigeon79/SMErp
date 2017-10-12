using System.Collections.Generic;
using G.Data.Definition;

namespace G.BLL.Base
{
    public class ItemList<T> where T : class, IDbObject
    {
        public List<T> List;
        public long Count;
        public int PageSize;
        public long PageCount;
        public long PageIndex;
    }
}


