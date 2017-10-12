using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace G.Interface.CLIENT
{
    public interface IControl
    {
        object GetValue();
        void SetValue(object value);
        bool ReadOnly{get;set;}
        void NotNullFormat();
    }
}
