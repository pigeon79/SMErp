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

namespace G.Controls
{
    public partial class DefaultDropDownForm : C1.Win.C1Input.DropDownForm, IDropDownForm
    {
        private bool m_loading;
        private string m_warningText = string.Empty;
        private string m_errorText = string.Empty;
        private int m_numVisibleItems = 20;
        private DataRow m_lastSelectedRow;
        private DataRow m_lastHightlightedRow;
        private List<C1DataColumn> listcolumns;

        public DataRow SelectRow { get { return null; } }

        public event EventHandler<DataRowEvent> EventRowSelected;

        public event EventHandler<EventArgs> EventRequestClose;

        public event EventHandler<DataRowEvent> RowHighlighted;

        public DefaultDropDownForm()
        {
            InitializeComponent();
        }

        public List<C1DataColumn> Columns
        {
            set {
                listcolumns = value;
            }
            get { return listcolumns; }
        }
        private void InitColumns() {
            if (listcolumns != null)
            {
                this.Columns = listcolumns;
            }
        }
        public void SetLoading()
        {
            m_loading = true;
            innerList.DataSource = null;
            ResizeControl();
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
            DataTable t = innerList.DataSource as DataTable;
            if (t == null)
            {
                Height = 0;
                return;
            }
            int numRows = t.Rows.Count;
            int totalWidth = 0;
            int totalHeight = 0;
            foreach (C1DisplayColumn column in innerList.Splits[0].DisplayColumns)
            {
                if (column.Visible)
                {
                    column.AutoSize();
                    totalWidth += column.Width;
                    System.Console.WriteLine(string.Format("Column Width: {0} Total Width: {1}", column.Width, totalWidth));
                }
            }
            if (this.BorderStyle == BorderStyle.FixedSingle)
                totalWidth += 2;
            if (innerList.ColumnHeaders)
                totalWidth += innerList.Splits[0].DisplayColumns.Count;
            if (numRows > m_numVisibleItems)
            {
                totalWidth += innerList.VScrollBar.Width;
            }
            totalWidth = Math.Max(totalWidth, OwnerControl.Width);
            int numItemsToShow = Math.Min(m_numVisibleItems, numRows);
            if (numItemsToShow != 0)
            {
                totalHeight = numItemsToShow * innerList.ItemHeight + innerList.ColumnCaptionHeight;
            }
            if (this.BorderStyle == BorderStyle.FixedSingle)
                totalHeight += 2;
            bool showMessage = !string.IsNullOrEmpty(m_errorText) || !string.IsNullOrEmpty(m_warningText) || m_loading || numItemsToShow == 0;
            if (showMessage)
            {
                //innerList.Location = new Point(0, messageLabel.Height);
                innerList.Width = totalWidth;
                innerList.Height = totalHeight;
                messageLabel.Width = totalWidth;
                messageLabel.Visible = true;

                if (m_loading)
                {
                    messageLabel.BackColor = SystemColors.Window;
                    messageLabel.Text = "Loading...";
                }
                else if (numItemsToShow == 0)
                {
                    messageLabel.BackColor = SystemColors.Window;
                    messageLabel.Text = "No results";
                }
                else if (!string.IsNullOrEmpty(m_errorText))
                {
                    messageLabel.BackColor = Color.Red;
                    messageLabel.Text = m_errorText;
                }
                else
                {
                    messageLabel.BackColor = Color.LemonChiffon;
                    messageLabel.Text = m_warningText;
                }
            }
            else
            {
                innerList.Location = new Point(0, 0);
                innerList.Width = totalWidth;
                innerList.Height = totalHeight;
                messageLabel.Text = string.Empty;
                messageLabel.Visible = false;
            }
            System.Console.WriteLine(string.Format("Width: {0} Height: {1}", totalWidth, totalHeight));
            Size = new Size(totalWidth, totalHeight);
            ResumeLayout(false);
        }

        private void SetNoResults()
        {
            m_loading = false;
            innerList.DataSource = new DataTable();
            ResizeControl();
        }

        public void SetData(DataTable data)
        {
            m_loading = false;
            if (data.Rows.Count == 0)
            {
                SetNoResults();
                return;
            }
            InitColumns();
            innerList.ColumnHeaders = true;
            innerList.DataSource = data;
            if (data.Rows.Count == 1)
            {
                innerList.SelectedIndex = 0;
            }
            ResizeControl();
        }

        private void OnRowSelected(DataRowEvent dataRowEvent)
        {
            if (dataRowEvent.DataRow != m_lastSelectedRow)
            {
                m_lastSelectedRow = dataRowEvent.DataRow;
                if (EventRowSelected != null)
                    EventRowSelected(this, dataRowEvent);
            }
        }

        private void OnRowHighlighted(DataRowEvent dataRowEvent)
        {
            if (dataRowEvent.DataRow != m_lastHightlightedRow)
            {
                m_lastHightlightedRow = dataRowEvent.DataRow;
                if (RowHighlighted != null)
                    RowHighlighted(this, dataRowEvent);
            }
        }

        private void innerList_MouseMove(object sender, MouseEventArgs e)
        {
            if (m_loading)
                return;
            int index = innerList.IndexFromPoint(new Point(e.X, e.Y));
            if (index >= 0)
                innerList.SelectedIndex = index;
            if (innerList.SelectedIndex < 0)
                return;
            DataRowEvent dataRowEvent = new DataRowEvent { DataRow = ((DataTable)innerList.DataSource).Rows[innerList.SelectedIndex] };
            OnRowHighlighted(dataRowEvent);
        }

        private void innerList_MouseClick(object sender, MouseEventArgs e)
        {
            if (m_loading)
            {
                innerList.SelectedIndex = -1;
                return;
            }
            if (innerList.SelectedIndex >= 0)
            {
                OnRowSelected(new DataRowEvent { DataRow = ((DataTable)innerList.DataSource).Rows[innerList.SelectedIndex] });
                if (EventRequestClose != null)
                    EventRequestClose(this, new EventArgs());
            }
        }


    }
    
}
