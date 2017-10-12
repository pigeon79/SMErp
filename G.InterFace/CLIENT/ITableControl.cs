using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace G.Interface.CLIENT
{
    public interface ITableControl
    {
        object GetValue();
        bool ReadOnly { set; get; }
        void SetValue<T>(IList<T> value);
    }
}
