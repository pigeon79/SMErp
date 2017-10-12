using System;

namespace G.Data.Definition
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple=false, Inherited=true)]
    public class SpecialNameAttribute : Attribute
    {
    }
}
