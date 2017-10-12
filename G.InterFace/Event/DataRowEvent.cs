using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace G.Interface.Event
{
    public class DataRowEvent : EventArgs
    {
        public DataRow DataRow { get; set; }
    }
}
