using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using C1.Win.C1FlexGrid;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;
using System.Collections;
using G.Interface.CLIENT;
using G.Data.Definition;

namespace G.Controls.GGrid
{
    public class GGrid : C1.Win.C1FlexGrid.C1FlexGrid, G.Interface.CLIENT.ITableControl
    {
        private List<ColumnInfo> ArrayColumn = new List<ColumnInfo>();
        private bool IsDoubleHead = false;//是否双表头
        private bool IsNegativeRed = false;//负数红字显示
        private int frozencell = 0;
        public int FrozenCell { get { return frozencell; } set { frozencell = value; } }
        public VisualStyle _VisualStyle = VisualStyle.Office2010Blue;
        public bool NegativeRed
        {
            get { return IsNegativeRed; }
            set { IsNegativeRed = value; if (value) { this.DrawMode = DrawModeEnum.OwnerDraw; } }
        }
        public void SetColumns(List<ColumnInfo> columns) { ArrayColumn = columns; }
        public void AddGridColumn(string new_FieldName, string new_FieldCaption, string new_DataType, int new_FieldWidth)
        {
            AddGridColumn(new_FieldName, new_FieldCaption, new_DataType, "", new_FieldWidth, "", true, false, false);
        }
        public void AddGridColumn(string new_FieldName, string new_FieldCaption, string new_DataType, string new_DispFormat, int new_FieldWidth)
        {
            AddGridColumn(new_FieldName, new_FieldCaption, new_DataType, new_DispFormat, new_FieldWidth, "", true, false, false);
        }
        public void AddGridColumn(string new_FieldName, string new_FieldCaption, string new_DataType, int new_FieldWidth, bool new_readonly)
        {
            AddGridColumn(new_FieldName, new_FieldCaption, new_DataType, "", new_FieldWidth, "", true, new_readonly, false);
        }
        public void AddGridColumn(string new_FieldName, string new_FieldCaption, string new_DataType, string new_DispFormat, int new_FieldWidth, bool new_readonly)
        {
            AddGridColumn(new_FieldName, new_FieldCaption, new_DataType, new_DispFormat, new_FieldWidth, "", true, new_readonly, false);
        }
        public void AddGridColumn(string new_FieldName, string new_FieldCaption, string new_DataType, int new_FieldWidth, Control new_Editor, string new_ViewName)
        {
            AddGridColumn(new_FieldName, new_FieldCaption, new_DataType, "", new_FieldWidth, "", true, new_Editor, false, new_ViewName, false);
        }
        public void AddGridColumn(string new_FieldName, string new_FieldCaption, string new_DataType, string new_DispFormat, int new_FieldWidth, string new_FieldCaptionTwo, bool new_Isvisible, bool new_readonly, bool issum)
        {
            if (new_FieldCaptionTwo != "")
            {
                this.IsDoubleHead = true;
            }
            ColumnInfo info = new ColumnInfo();
            info.DispFormat = new_DispFormat;
            info.ColumnCaption = new_FieldCaption;
            info.ColumnName = new_FieldName;
            info.ColumnType = new_DataType;
            info.ColumnWidth = new_FieldWidth;
            info.ColumnCaptionTwo = new_FieldCaptionTwo;
            info.Isvisible = new_Isvisible;
            info.IsReadOnly = new_readonly;
            info.IsSum = issum;
            this.ArrayColumn.Add(info);
        }
        public void AddGridColumn(string new_FieldName, string new_FieldCaption, string new_DataType, string new_DispFormat, int new_FieldWidth, string new_FieldCaptionTwo, bool new_Isvisible, Control new_Editor, bool new_readonly, string new_ViewName, bool issum)
        {
            if (new_FieldCaptionTwo != "")
            {
                this.IsDoubleHead = true;
            }
            ColumnInfo info = new ColumnInfo();
            info.DispFormat = new_DispFormat;
            info.ViewName = new_ViewName;
            info.ColumnCaption = new_FieldCaption;
            info.ColumnName = new_FieldName;
            info.ColumnType = new_DataType;
            info.ColumnWidth = new_FieldWidth;
            info.ColumnCaptionTwo = new_FieldCaptionTwo;
            info.Isvisible = new_Isvisible;
            info.Editor = new_Editor;
            info.IsReadOnly = new_readonly;
            info.IsSum = issum;
            this.ArrayColumn.Add(info);
        }
        public VisualStyle CurVisualStyle { set { _VisualStyle = value; this.VisualStyle = _VisualStyle; } get { return this._VisualStyle; } }
        bool _readonly = false;
        public bool ReadOnly
        {
            set
            {
                _readonly = value;
                foreach (Column c in this.Cols)
                {
                    ColumnInfo ci = c.UserData as ColumnInfo;
                    if (ci != null)
                    {
                        if (!ci.IsReadOnly) { c.AllowEditing = !value; }
                    }
                    else
                    {
                        c.AllowEditing = !value;
                    }
                }

            }
            get { return _readonly; }
        }
        private bool UseSum = false;
        public void InitGrid()
        {
            this.Rows.DefaultSize = 20;
            if (this.ArrayColumn.Count > 0)
            {
                this.AutoGenerateColumns = false;

                this.Cols.RemoveRange(0, this.Cols.Count);
                this.Cols.Count = this.ArrayColumn.Count;
                int num = 0;
                if (!this.IsDoubleHead)
                {
                    this.Rows.Fixed = 1;
                    if (this.Rows.Count < 1)
                    {
                        this.Rows.Count = 1;
                        //this.Rows[0].Height = 100;
                    }
                }
                else
                {
                    this.Rows.Fixed = 2;
                    if (this.Rows.Count < 2)
                    {
                        this.Rows.Count = 2;
                    }
                    this.AllowMerging = AllowMergingEnum.FixedOnly;
                    //this.Rows[0].Height = 22;
                    //this.Rows[1].Height = 22;
                }
                foreach (ColumnInfo info in this.ArrayColumn)
                {
                    this.Cols[num].UserData = info;
                    this.Cols[num].Format = "c";
                    if (info.IsSum && !UseSum) { UseSum = true; }
                    if (!info.ViewName.IsNullOrEmpty())
                    {
                        this.Cols[num].Name = info.ViewName;
                    }
                    else
                    {
                        this.Cols[num].Name = info.ColumnName;
                    }
                    string columnType = info.ColumnType;

                    this.Cols[num].DataType = Type.GetType("System." + columnType);
                    this.Cols[num].Format = info.DispFormat;
                    this.Cols[num].WidthDisplay = info.ColumnWidth;
                    if (info.IsReadOnly)
                    {
                        this.Cols[num].AllowEditing = false;
                        this.Cols[num].Style.BackColor = Color.WhiteSmoke;
                    }
                    else { this.Cols[num].AllowEditing = true; }
                    if (info.Editor != null)
                    {
                        this.Cols[num].Editor = info.Editor;
                    }
                    if (info.ColumnWidth == 0)
                    {
                        this.Cols[num].Visible = false;
                    }

                    switch (columnType)
                    {
                        case "Double":
                        case "Int32":
                        case "Decimal":
                            this.Cols[num].TextAlign = TextAlignEnum.RightCenter;
                            break;
                        case "Boolean":
                        case "DateTime":
                            this.Cols[num].TextAlign = TextAlignEnum.CenterCenter;
                            break;
                        default:
                            //this.Cols[num].Style.WordWrap = true;
                            this.Cols[num].TextAlign = TextAlignEnum.LeftCenter;
                            break;
                    }
                    //this.Cols[num].StyleFixed =style;
                    if (!this.IsDoubleHead)
                    {
                        this.Cols[num].Caption = info.ColumnCaption;
                    }
                    else
                    {
                        this.Rows[0].Move(1);
                        this[1, num] = info.ColumnCaption;
                        this[0, num] = info.ColumnCaptionTwo;
                    }
                    num++;
                }
            }
            this.Cols.Frozen = frozencell;
            this.VisualStyle = this.CurVisualStyle;
        }
        public T GetCurSelect<T>()
        {
            T data = default(T);
            int i = this.Row - this.Rows.Fixed;
            if (i >= 0)
            {
                try
                {
                    IEnumerable<T> list = this.DataSource as IEnumerable<T>;

                    data = (T)list.ToList<T>()[i];
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
            return data;
        }
        public T GetCurSelect<T>(int row)
        {
            T data = default(T);
            int i = row - this.Rows.Fixed;
            if (i >= 0)
            {
                try
                {
                    IEnumerable<T> list = this.DataSource as IEnumerable<T>;

                    data = (T)list.ToList<T>()[i];
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
            return data;
        }
        /// <summary>
        /// 删除的行
        /// </summary>
        private List<object> DeleteRows = new List<object>();
        public void DataBind<T>(IList<T> list)
        {
            this.DataSource = new BindingList<T>(list);
        }
        public void DataBind(object list)
        {
            this.DataSource = list;
        }
        public void DataBind(System.Data.DataTable dt)
        {
            if (UseSum)
            {
                System.Data.DataRow dr = dt.NewRow();
                bool sumStr = false;
                foreach (ColumnInfo info in this.ArrayColumn)
                {
                    switch (info.ColumnType)
                    {
                        case "Double":
                        case "Int32":
                        case "Decimal":
                            if (info.IsSum)
                            {
                                dr[info.ColumnName] = dt.Compute(string.Format("Sum({0})", info.ColumnName), "true");
                            }
                            break;
                        case "String":
                            if (!sumStr)
                            {
                                dr[info.ColumnName] = "合计";
                                sumStr = true;
                            }
                            break;
                        default:
                            break;
                    }
                }
                dt.Rows.Add(dr);
            }

            this.DataSource = dt;
        }
        public T AddRow<T>()
        {
            T t = System.Activator.CreateInstance<T>();
            try
            {
                if (this.DataSource != null)
                {
                    ((BindingList<T>)this.DataSource).Add(t);
                }
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
            return t;
        }
        public T AddRow<T>(T t)
        {
            if (this.DataSource != null)
            {
                ((BindingList<T>)this.DataSource).Add(t);
            }
            return t;
        }
        public void DeleteRow<T>()
        {
            int i = this.RowSel - this.Rows.Fixed;
            if (i >= 0)
            {
                DeleteRows.Add(((BindingList<T>)this.DataSource)[i]);
                ((BindingList<T>)this.DataSource).RemoveAt(i);
            }
        }
        public List<T> getDeleteRows<T>() {
            return this.DeleteRows.ConvertAll<T>((o) => (T)o);
        }
        #region 重写

        protected override void OnBeforeEdit(RowColEventArgs e)
        {
            Control ctr = this.Cols[e.Col].Editor;
            if (ctr != null)
            {
                if (ctr.GetType().GetInterface("IControl") != null)
                {
                    ColumnInfo info = this.Cols[e.Col].UserData as ColumnInfo;
                    //var v=G.Core.ClassHelper.GetAttribute(this.Rows[e.Row].DataSource.GetType(), info.ColumnName);
                    var v = this.Rows[e.Row].DataSource;
                    var s = G.Core.ClassHelper.GetFieldValue(v, info.ColumnName);
                    ((IControl)ctr).SetValue(s);
                }
            }
            base.OnBeforeEdit(e);
        }
        protected override void OnAfterEdit(RowColEventArgs e)
        {
            if (this.Cols[e.Col].UserData != null)
            {
                ColumnInfo info = this.Cols[e.Col].UserData as ColumnInfo;

                if (!info.ViewName.IsNullOrEmpty())
                {
                    if (info.ViewName != info.ColumnName)
                    {
                        G.Controls.Input.DropDown control = this.Cols[e.Col].Editor as G.Controls.Input.DropDown;
                        DbObjectSmartUpdate obj = this.GetCurSelect<DbObjectSmartUpdate>();
                        obj.setValue(info.ColumnName, control.GetValue());
                        obj.setValue(info.ViewName, control.Text);
                    }
                    else
                    {
                        G.Controls.Input.DropDown control = this.Cols[e.Col].Editor as G.Controls.Input.DropDown;
                        if (control != null)
                        {
                            DbObjectSmartUpdate obj = this.GetCurSelect<DbObjectSmartUpdate>();
                            obj.setValue(info.ColumnName, control.GetValue());
                        }
                    }
                }
            }
            base.OnAfterEdit(e);
        }
        CellStyle cs, cs1;
        protected override void InitLayout()
        {
            base.InitLayout();
            //cs = this.Styles.Add("NegativeRed");
            //cs.ForeColor = Color.Red;
            //cs1 = this.Styles.Add("PlusBlack");
            //cs1.ForeColor = Color.Black;
        }
        protected override void OnOwnerDrawCell(OwnerDrawCellEventArgs e)
        {
            base.OnOwnerDrawCell(e);

        }
        #endregion

        public object GetValue()
        {
            this.FinishEditing();
            return this.DataSource;
        }

        public void SetValue<T>(IList<T> value)
        {
            this.DataBind<T>(value);
        }
    }
}
