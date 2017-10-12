using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using G.Interface.CLIENT;
using G.Data.Definition;

namespace G.Controls.Base
{
    public class EditorAdapter<T, TT> : IEditorAdapter where T : class, IDbObject, new()
    {
        private List<EditorInfo> listEditor = new List<EditorInfo>();
        public EditorAdapter() { }
        private T EditData;
        public virtual void SetReadOnly(bool isreadonly)
        {
            foreach (EditorInfo e in listEditor)
            {
                if (!e.IsReadOnly)
                {
                    if (e.Editor.GetType().GetInterface("IControl") != null)
                    {
                        ((IControl)e.Editor).ReadOnly = isreadonly;
                    }
                    else if (e.Editor.GetType().GetInterface("ITableControl") != null)
                    {
                        ((ITableControl)e.Editor).ReadOnly = isreadonly;
                    }
                    
                }
            }
        }
        public virtual void SetData(T data)
        {
            EditData = data;
            if (data != null)
            {
                foreach (EditorInfo e in listEditor)
                {
                    PropertyInfo pi = data.GetType().GetProperty(e.FieldName);
                    if (pi != null)
                    {
                        SetEditorValue(e, pi.GetValue(data, null));
                    }
                }
            }
        }
        public virtual void SetEditorValue(EditorInfo e, object value)
        {
            if (e.Editor != null)
            {
                if (e.Editor.GetType().GetInterface("IControl") != null)
                {
                    ((IControl)e.Editor).SetValue(value);
                }
                else if (e.Editor.GetType().GetInterface("ITableControl") != null)
                {
                    ((ITableControl)e.Editor).SetValue<TT>((IList<TT>)value);
                }
                else
                {
                    e.Editor.Text = value.ToString();
                }

            }
        }
        public virtual T GetData()
        {
            foreach (EditorInfo e in listEditor)
            {
                PropertyInfo pi = EditData.GetType().GetProperty(e.FieldName);
                if (pi != null)
                {
                    object value = null;
                    try
                    {
                        value = GetEditorValue(e);
                        value = FormatValue(pi.PropertyType, value);
                        this.Valid(e, pi.PropertyType, value);
                        pi.SetValue(EditData, value, null);
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(pi.Name + ex.Message);
                    }
                    
                }

            }
            return EditData;
        }
        public virtual object GetEditorValue(EditorInfo e)
        {
            object value = null;
            if (e.Editor != null)
            {
                if (e.Editor.GetType().GetInterface("IControl") != null)
                {
                    value = ((IControl)e.Editor).GetValue();
                }
                else if (e.Editor.GetType().GetInterface("ITableControl") != null)
                {
                    value = ((ITableControl)e.Editor).GetValue();
                }
                else
                {
                    value = e.Editor.Text;
                }
            }
            return value;
        }
        private object FormatValue(Type t, object value)
        {
            object v = value;
            if (t == typeof(int) || t == typeof(int?))
            {
                v = G.Core.GConvert.ToInt(value);
            }
            if (t == typeof(Decimal) || t == typeof(Decimal?))
            {
                v = G.Core.GConvert.ToDecimal(value);
            }
            if (t == typeof(Boolean) || t == typeof(Boolean?))
            {
                v = G.Core.GConvert.ToBool(value);
            }
            if (t == typeof(String))
            {
                v = G.Core.GConvert.ToString(value);
            }
            if (t == typeof(DateTime))
            {
                v = G.Core.GConvert.ToDateTime(value);
            }
            if (t == typeof(DateTime?))
            {
                if (value.ToString() != "")
                {
                    v = G.Core.GConvert.ToDateTime(value);
                }
                else v = null;
            }
            return v;
        }
        public void AddEditorInfo(EditorInfo info) { 
            listEditor.Add(info);
            switch(info.ValidType) { 
                case "notnull":
                    if (info.Editor.GetType().GetInterface("IControl") != null)
                    {
                        ((IControl)info.Editor).NotNullFormat();
                    }
                   break;
            }
        }
        public void ClearEditorInfo() { listEditor.Clear(); }
        public virtual void Save() { }
        private bool ISNULL(Type t, object value)
        {
            bool isnull = false;
            if (t == typeof(int) || t == typeof(int?))
            {
                if (G.Core.GConvert.ToInt(value) == 0)
                {
                    isnull = true;
                }
            }
            if (t == typeof(Decimal) || t == typeof(Decimal?))
            {
                if (G.Core.GConvert.ToInt(value) == 0)
                {
                    isnull = true;
                }
            }
            if (t == typeof(String) || t == typeof(DateTime) || t == typeof(DateTime?))
            {
                if (value.ToString().IsNullOrEmpty()) { isnull = true; }
            }
            return isnull;
        }
        public virtual void Valid(EditorInfo info, Type t, object value)
        {
            switch (info.ValidType.ToLower())
            {
                case "notnull":
                    if (ISNULL(t, value))
                    {
                        throw new Exception(string.Format("{0}不能为空！", info.FieldCaption));
                    }
                    break;
            }
        }
        public virtual void GetSaveData() { }


        void IEditorAdapter.SetData(IDbObject data)
        {
            this.SetData(data as T);
        }

        IDbObject IEditorAdapter.GetData()
        {
            return this.GetData() as IDbObject;
        }
    }
    public class EditorInfo
    {
        private string m_fieldname = ""; //字段名    
        private string m_fieldcaption = "";//字段标题
        private string m_DataType = "";//字段类型
        private bool m_IsNotEmpty = false;//是否允许空
        private bool m_IsReadOnly;   //是否只读
        private System.Windows.Forms.Control m_editor;    //对应的编辑控件
        private object m_DefaultValue; //默认值
        private string m_ValidType = "";//校验类型 
        private int m_TabIndex;       //录入顺序
        private int m_MaxLength;      //最大长度(字符型)
        private string m_DispFormat = ""; //显示格式
        private string DisplayName = "";
        private int DisplayWidth;
        private bool IsVisible = true;
        private bool IsAutoCopy = false;
        private string Formula = "";

        public string DispFormat
        {
            get { return this.m_DispFormat; }
            set { this.m_DispFormat = value; }
        }
        public string FieldName
        {
            get { return m_fieldname; }
            set { m_fieldname = value; }
        }

        public string FieldCaption
        {
            get { return m_fieldcaption; }
            set { m_fieldcaption = value; }
        }

        public string DataType
        {
            get { return m_DataType; }
            set { m_DataType = value; }
        }

        public System.Windows.Forms.Control Editor
        {
            get { return m_editor; }
            set { m_editor = value; }
        }

        public bool IsNotEmpty
        {
            get { return m_IsNotEmpty; }
            set { m_IsNotEmpty = value; }
        }

        public bool IsReadOnly
        {
            get { return m_IsReadOnly; }
            set { m_IsReadOnly = value; }
        }
        private bool m_IsUpdate = true;
        public bool IsUpdate
        {
            get { return m_IsUpdate; }
            set { m_IsUpdate = value; }
        }

        public object DefaultValue
        {
            get { return m_DefaultValue; }
            set { m_DefaultValue = value; }
        }

        public string ValidType
        {
            get { return m_ValidType; }
            set { m_ValidType = value; }
        }

        public int TabIndex
        {
            get { return m_TabIndex; }
            set { m_TabIndex = value; }
        }
        //public object Value
        //{
        //    get
        //    {
        //        IUIControl myUICtl = UIControlFactory.CreateUI(this.editctl, this.DataType);
        //        return myUICtl.getValue();
        //    }
        //    set
        //    {
        //        IUIControl myUICtl = UIControlFactory.CreateUI(this.editctl, this.DataType);
        //        myUICtl.setValue(value);
        //        ;
        //    }
        //}

        public int MaxLength
        {
            get { return m_MaxLength; }
            set { m_MaxLength = value; }
        }


    }
}
