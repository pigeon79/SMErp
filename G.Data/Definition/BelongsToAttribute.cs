using System;

namespace G.Data.Definition
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    public class BelongsToAttribute : Attribute
    {
    }
}
