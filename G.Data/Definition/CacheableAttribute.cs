using System;

namespace G.Data.Definition
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
    public class CacheableAttribute : Attribute
    {
    }
}
