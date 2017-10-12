using System;

namespace G.Data.Definition
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false)]
    public class AllowNullAttribute : Attribute
    {
    }
}
