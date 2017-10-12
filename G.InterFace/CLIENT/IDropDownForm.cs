using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace G.Interface.CLIENT
{
    public interface IDropDownForm
    {
        //event EventHandler<Event.DataRowEvent> EventRowSelected;
        event EventHandler<EventArgs> EventRequestClose;
        DataRow SelectRow { get;  }
        //event EventHandler<Event.DataRowEvent> RowHighlighted;

    }
    
}
