using G.Interface.CLIENT;
using G.Interface.Event;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace G.Controls.Input
{
    public class BaseSearchForm : Form, IDropDownForm
    {
        public event EventHandler<DataRowEvent> EventRowSelected;
        public event EventHandler<EventArgs> EventRequestClose;
        public DataRow SelectRow { get { return m_lastSelectedRow; } }
        public DataRow m_lastSelectedRow;
        public void ChangeStatus() {
            this.m_lastSelectedRow = null;
        }
        public void OnRowSelected(DataRowEvent dataRowEvent)
        {
            if (dataRowEvent.DataRow != m_lastSelectedRow)
            {
                m_lastSelectedRow = dataRowEvent.DataRow;
                if (EventRowSelected != null)
                    EventRowSelected(this, dataRowEvent);
            }
        }
    }
}
