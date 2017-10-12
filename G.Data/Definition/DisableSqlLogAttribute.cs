using System;

namespace G.Data.Definition
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class DisableSqlLogAttribute : Attribute
    {
    }
}
