using System;
using G.Core;

namespace G.Data.Model
{
    public class ObjectInfoFactory : FlyweightBase<Type, ObjectInfo>
    {
        public static readonly ObjectInfoFactory Instance = new ObjectInfoFactory();

        protected override ObjectInfo CreateInst(Type t)
        {
            return new ObjectInfo(t);
        }
    }
}

