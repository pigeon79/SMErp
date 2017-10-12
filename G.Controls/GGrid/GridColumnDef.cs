using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace G.Controls.GGrid
{
    [Serializable]
    public class ColumnInfo
    {
        public ColumnInfo() { }
        public static ColumnInfo Initialize(string caption, string caption2, string columnName, string viewname, string type, string dispFormat, int width, bool isreadonly, bool isvisible, bool issum)
        {
            ColumnInfo ci = new ColumnInfo();
            ci.ColumnCaption = caption;
            ci.ColumnName = columnName;
            ci.ColumnType = type;
            ci.ColumnWidth = width;
            ci.ColumnCaptionTwo = caption2;
            ci.DispFormat = dispFormat;
            ci.ViewName = viewname;
            ci.IsReadOnly = isreadonly;
            ci.Isvisible = isvisible;
            ci.IsSum = issum;
            return ci;
        }
        public static ColumnInfo Initialize(string caption, string columnName, string type, int width)
        {
            ColumnInfo ci = new ColumnInfo();
            ci.ColumnCaption = caption;
            ci.ColumnName = columnName;
            ci.ColumnType = type;
            ci.ColumnWidth = width;
            ci.ColumnCaptionTwo = "";
            ci.DispFormat = "";
            ci.ViewName = "";
            ci.IsReadOnly = true;
            ci.Isvisible = true;
            ci.IsSum = false;
            return ci;
        }
        public static ColumnInfo Initialize(string caption, string columnName, string type, int width, bool isreadonly)
        {
            ColumnInfo ci = new ColumnInfo();
            ci.ColumnCaption = caption;
            ci.ColumnName = columnName;
            ci.ColumnType = type;
            ci.ColumnWidth = width;
            ci.ColumnCaptionTwo = "";
            ci.DispFormat = "";
            ci.ViewName = "";
            ci.IsReadOnly = isreadonly;
            ci.Isvisible = true;
            ci.IsSum = false;
            return ci;
        }
        public static ColumnInfo Initialize(string caption, string columnName, string type, string dispFormat, int width)
        {
            ColumnInfo ci = new ColumnInfo();
            ci.ColumnCaption = caption;
            ci.ColumnName = columnName;
            ci.ColumnType = type;
            ci.ColumnWidth = width;
            ci.ColumnCaptionTwo = "";
            ci.DispFormat = dispFormat;
            ci.ViewName = "";
            ci.IsReadOnly = true;
            ci.Isvisible = true;
            ci.IsSum = false;
            return ci;
        }
        public static ColumnInfo Initialize(string caption, string columnName, string type, string dispFormat, int width,bool issum)
        {
            ColumnInfo ci = new ColumnInfo();
            ci.ColumnCaption = caption;
            ci.ColumnName = columnName;
            ci.ColumnType = type;
            ci.ColumnWidth = width;
            ci.ColumnCaptionTwo = "";
            ci.DispFormat = dispFormat;
            ci.ViewName = "";
            ci.IsReadOnly = true;
            ci.Isvisible = true;
            ci.IsSum = issum;
            return ci;
        }
        public ColumnInfo(string caption,string columnName,string type,int width) {
            this.ColumnCaption = caption;
            this.ColumnName = columnName;
            this.ColumnType = type;
            this.ColumnWidth = width;
            this.ColumnCaptionTwo = "";
            this.DispFormat = "";
            this.ViewName = "";
            this.IsReadOnly = true;
            this.Isvisible = true;
        }
        public ColumnInfo(string caption, string columnName, string type, int width,bool isreadonly)
        {
            this.ColumnCaption = caption;
            this.ColumnName = columnName;
            this.ColumnType = type;
            this.ColumnWidth = width;
            this.ColumnCaptionTwo = "";
            this.DispFormat = "";
            this.ViewName = "";
            this.IsReadOnly = isreadonly;
            this.Isvisible = true;
        }
        public ColumnInfo(string caption, string columnName, string type,string dispFormat, int width)
        {
            this.ColumnCaption = caption;
            this.ColumnName = columnName;
            this.ColumnType = type;
            this.ColumnWidth = width;
            this.ColumnCaptionTwo = "";
            this.DispFormat = dispFormat;
            this.ViewName = "";
            this.IsReadOnly = true;
            this.Isvisible = true;
        }
        public ColumnInfo(string caption,string caption2, string columnName,string viewname, string type, string dispFormat, int width,bool isreadonly,bool isvisible,bool issum)
        {
            this.ColumnCaption = caption;
            this.ColumnName = columnName;
            this.ColumnType = type;
            this.ColumnWidth = width;
            this.ColumnCaptionTwo = caption2;
            this.DispFormat = dispFormat;
            this.ViewName = viewname;
            this.IsReadOnly = isreadonly;
            this.Isvisible = isvisible;
            this.IsSum = issum;
        }
        public string ColumnCaption;
        public string ColumnCaptionTwo;
        public int ColumnIndex_bak;
        public string ColumnName;
        public string ViewName;
        public string ColumnType;
        public int ColumnWidth;
        public int ColumnWidth_bak;
        public string DispFormat;
        public bool IsReadOnly;
        public bool Isvisible;
        public bool IsSum;
        public System.Windows.Forms.Control Editor;
    }
    public class GridColumnDef
    {
        
        private string m_AttachField = "";
        private string m_AttachFieldTwo = "";
        private bool m_AutoCopy = false;
        private string m_ControlType = "";
        private string m_DataType = "";
        private object m_DefaultValue;
        private string m_DispFormat = "";
        private string m_DispName = "";
        private int m_DispWidth;
        //private Control m_editctl;
        private string m_Expression = "";
        private string m_ExtendXml = "";

        private string m_FieldCaption = "";
        private string m_FieldCaptionTwo = "";
        private string m_FieldName = "";

        private bool m_IsNotEmpty = false;
        private bool m_IsReadOnly;
        private bool m_IsUpdate = false;
        private bool m_IsValid = false;
        private bool m_IsVisible = false;
        private int m_MaxLength;
        private int m_PointLen = 0;
        private string m_SourceCode = "";
        private string m_SourceCondition = "";
        private string m_SourceKeyName = "";
        private string m_SourceTable = "";
        private string m_ValidType = "";
        private bool m_IsSum = false;

        public string AttachField
        {
            get
            {
                return this.m_AttachField;
            }
            set
            {
                this.m_AttachField = value;
            }
        }

        public string AttachFieldTwo
        {
            get
            {
                return this.m_AttachFieldTwo;
            }
            set
            {
                this.m_AttachFieldTwo = value;
            }
        }

        public bool AutoCopy
        {
            get
            {
                return this.m_AutoCopy;
            }
            set
            {
                this.m_AutoCopy = value;
            }
        }

        public string ControlType
        {
            get
            {
                return this.m_ControlType;
            }
            set
            {
                this.m_ControlType = value;
            }
        }

        public string DataType
        {
            get
            {
                return this.m_DataType;
            }
            set
            {
                this.m_DataType = value;
            }
        }

        public object DefaultValue
        {
            get
            {
                return this.m_DefaultValue;
            }
            set
            {
                this.m_DefaultValue = value;
            }
        }

        public string DispFormat
        {
            get
            {
                return this.m_DispFormat;
            }
            set
            {
                this.m_DispFormat = value;
            }
        }

        public string DispName
        {
            get
            {
                return this.m_DispName;
            }
            set
            {
                this.m_DispName = value;
            }
        }

        public int DispWidth
        {
            get
            {
                return this.m_DispWidth;
            }
            set
            {
                this.m_DispWidth = value;
            }
        }

        //public Control editctl
        //{
        //    get
        //    {
        //        return this.m_editctl;
        //    }
        //    set
        //    {
        //        this.m_editctl = value;
        //    }
        //}

        public string Expression
        {
            get
            {
                return this.m_Expression;
            }
            set
            {
                this.m_Expression = value;
            }
        }

        public string ExtendXml
        {
            get
            {
                return this.m_ExtendXml;
            }
            set
            {
                this.m_ExtendXml = value;
            }
        }

        public string FieldCaption
        {
            get
            {
                return this.m_FieldCaption;
            }
            set
            {
                this.m_FieldCaption = value;
            }
        }

        public string FieldCaptionTwo
        {
            get
            {
                return this.m_FieldCaptionTwo;
            }
            set
            {
                this.m_FieldCaptionTwo = value;
            }
        }

        public string FieldName
        {
            get
            {
                return this.m_FieldName;
            }
            set
            {
                this.m_FieldName = value;
            }
        }

        public bool IsNotEmpty
        {
            get
            {
                return this.m_IsNotEmpty;
            }
            set
            {
                this.m_IsNotEmpty = value;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return this.m_IsReadOnly;
            }
            set
            {
                this.m_IsReadOnly = value;
            }
        }

        public bool IsUpdate
        {
            get
            {
                return this.m_IsUpdate;
            }
            set
            {
                this.m_IsUpdate = value;
            }
        }

        public bool IsValid
        {
            get
            {
                return this.m_IsValid;
            }
            set
            {
                this.m_IsValid = value;
            }
        }

        public bool IsVisible
        {
            get
            {
                return this.m_IsVisible;
            }
            set
            {
                this.m_IsVisible = value;
            }
        }

        public int MaxLength
        {
            get
            {
                return this.m_MaxLength;
            }
            set
            {
                this.m_MaxLength = value;
            }
        }

        public int PointLen
        {
            get
            {
                return this.m_PointLen;
            }
            set
            {
                this.m_PointLen = value;
            }
        }

        public string SourceCode
        {
            get
            {
                return this.m_SourceCode;
            }
            set
            {
                this.m_SourceCode = value;
            }
        }

        public string SourceCondition
        {
            get
            {
                return this.m_SourceCondition;
            }
            set
            {
                this.m_SourceCondition = value;
            }
        }

        public string SourceKeyName
        {
            get
            {
                return this.m_SourceKeyName;
            }
            set
            {
                this.m_SourceKeyName = value;
            }
        }

        public string SourceTable
        {
            get
            {
                return this.m_SourceTable;
            }
            set
            {
                this.m_SourceTable = value;
            }
        }

        public string ValidType
        {
            get
            {
                return this.m_ValidType;
            }
            set
            {
                this.m_ValidType = value;
            }
        }
        public bool IsSum
        {
            get
            {
                return this.m_IsSum;
            }
            set
            {
                this.m_IsSum = value;
            }
        }
        //public object Value
        //{
        //    get
        //    {
        //        return UIControlFactory.CreateUI(this.editctl, this.DataType).getValue();
        //    }
        //    set
        //    {
        //        UIControlFactory.CreateUI(this.editctl, this.DataType).setValue(value);
        //    }
        //}
    }
}
