using System;

namespace G.Data.Definition
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    public class QueryRequiredAttribute : Attribute
    {
    }
}
