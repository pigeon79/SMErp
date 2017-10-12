using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using C1.Win.C1List;
using System.Collections.Generic;
using System.ComponentModel;
using G.Interface.Event;
using G.Interface.CLIENT;
using G.Data.Definition;
using G.Controls.GGrid;

namespace G.Controls.Input
{
    public partial class DefaultDropDownList : C1.Win.C1Input.DropDownForm, IDropDownForm
    {
        private string m_warningText = string.Empty;
        private string m_errorText = string.Empty;
        private DataRow m_lastSelectedRow;
        public DataRow SelectRow { get { return m_lastSelectedRow; } }
        private List<ColumnInfo> listcolumns = new List<ColumnInfo>();

        //public event EventHandler<DataRowEvent> EventRowSelected;
        public event EventHandler<EventArgs> EventRequestClose;

        public DefaultDropDownList()
        {
            InitializeComponent();

        }

        public void AddGridColumn(string new_FieldName, string new_FieldCaption, string new_DataType, int new_FieldWidth)
        {
            gGrid1.AddGridColumn(new_FieldName, new_FieldCaption, new_DataType, new_FieldWidth);
        }
        public void InitColumns()
        {
            this.gGrid1.AutoGenerateColumns = false;
            this.gGrid1.InitGrid();
        }

        private void ResizeControl()
        {
            if (InvokeRequired)
                BeginInvoke(new MethodInvoker(ActualResize));
            else
                ActualResize();
        }

        private void ActualResize()
        {
            SuspendLayout();
            DataTable t = gGrid1.DataSource as DataTable;
            if (t == null)
            {
                Height = 0;
                return;
            }
            int numRows = t.Rows.Count;
            int totalWidth = 0;
            int totalHeight = 0;

            if (this.BorderStyle == BorderStyle.FixedSingle)
                totalHeight += 2;
            System.Console.WriteLine(string.Format("Width: {0} Height: {1}", totalWidth, totalHeight));
            Size = new Size(totalWidth, totalHeight);
            ResumeLayout(false);
        }

        public void SetData(DataTable data)
        {
            this.gGrid1.DataSource = data;
        }

        private void OnRowSelected(DataRowEvent dataRowEvent)
        {
            if (dataRowEvent.DataRow != m_lastSelectedRow)
            {
                m_lastSelectedRow = dataRowEvent.DataRow;
                //if (EventRowSelected != null)
                //    EventRowSelected(this, dataRowEvent);
            }
        }

        public void KeyEnter()
        {
            if (this.gGrid1.DataSource != null)
            {
                if (this.gGrid1.RowSel > 0)
                {
                    int rs = this.gGrid1.RowSel;
                    rs -= gGrid1.Rows.Fixed;
                    if (rs >= 0)
                    {
                        if (((DataTable)this.gGrid1.DataSource).Rows.Count > rs)
                        {
                            DataRow dr = ((DataTable)this.gGrid1.DataSource).Rows[rs];
                            OnRowSelected(new DataRowEvent { DataRow = dr });
                        }
                        else
                        {
                            OnRowSelected(new DataRowEvent { DataRow = null });
                        }
                    }
                }
            }
        }
        private void gGrid1_MouseClick(object sender, MouseEventArgs e)
        {
            this.gGrid1.Select(gGrid1.MouseRow, 0, true);
            KeyEnter();
            if (EventRequestClose != null)
                EventRequestClose(this, new EventArgs());
        }

        private void gGrid1_SelChange(object sender, EventArgs e)
        {
                KeyEnter();
        }

    }

}
