﻿using System;

namespace G.BLL.Base
{
    public enum ListStyle
    {
        Default,
        Static,
        StaticLite,
        Hybird,
    }

    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public class ListStyleAttribute : Attribute
    {
        public ListStyle Style;

        public ListStyleAttribute(ListStyle style)
        {
            this.Style = style;
        }
    }
}


