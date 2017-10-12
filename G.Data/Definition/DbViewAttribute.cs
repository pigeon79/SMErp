using System;

namespace G.Data.Definition
{
	[AttributeUsage(AttributeTargets.Class, AllowMultiple=false)]
	public class DbViewAttribute : Attribute
	{
        public string ViewName="";

		public DbViewAttribute(string viewName)
		{
            this.ViewName = viewName;
		}
    }
}
