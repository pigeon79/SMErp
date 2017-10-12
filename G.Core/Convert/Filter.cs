using System;
using System.Xml;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace G.Core
{
    public class Filter
    {
        private List<Filt> m_ListFilt = new List<Filt>();
        private string m_OrderBy = "";
        private XmlDocument xmlDoc = null;
        public Filter() { }
        //json转FILTER
        public Filter(string filter)
        {

            JArray o = (JArray)JsonConvert.DeserializeObject(filter);
            if (o != null)
            {
                foreach (JToken jt in o)
                {
                    Filt f = new Filt();
                    f.Caption = ((JValue)jt["caption"]).Value.ToString();
                    f.FieldName = ((JValue)jt["field"]).Value.ToString();
                    f.FieldType = ((JValue)jt["type"]).Value.ToString();
                    f.StartOperator = ((JValue)jt["sjoin"]).Value.ToString();
                    f.StartValue = ((JValue)jt["svalue"]).Value.ToString();
                    if (jt["ejoin"] != null)
                    {
                        f.EndOperator = ((JValue)jt["ejoin"]).Value.ToString();
                    }
                    if (jt["evalue"] != null)
                    {
                        f.EndValue = ((JValue)jt["evalue"]).Value.ToString();
                    }
                    if (jt["prestr"] != null)
                    {
                        f.PreStr = ((JValue)jt["prestr"]).Value.ToString();
                    }
                    if (jt["nextstr"] != null)
                    {
                        f.NextStr = ((JValue)jt["nextstr"]).Value.ToString();
                    }
                    m_ListFilt.Add(f);
                }
            }
        }
        public List<Filt> ListFilt
        {
            get { return m_ListFilt; }
            set { m_ListFilt = value; }
        }
        //排序字段
        public string OrderBy
        {
            get { return m_OrderBy; }
            set { m_OrderBy = value; }
        }
        /// <summary>
        /// 增加单个条件 
        /// </summary>
        public void AddFilt(string fieldname, string fieldtype, string fieldoperator, string fieldvalue)
        {
            m_ListFilt.Add(new Filt(fieldname,fieldtype, fieldoperator, fieldvalue, "", ""));
        }
        /// <summary>
        /// 增加单个条件 包括字段说明 
        /// </summary>
        public void AddFilt(string fieldname, string fieldtype, string fieldoperator, string fieldvalue, string caption, string captionvalue)
        {
            m_ListFilt.Add(new Filt(fieldname, fieldtype, fieldoperator, fieldvalue, caption, captionvalue));
        }
        /// <summary>
        ///  增加单个范围条件 包括字段说明 
        /// </summary>
        public void AddFilt(string fieldname, string fieldtype, string startoperator, string startvalue, string endoperator, string endvalue, string caption)
        {
            m_ListFilt.Add(new Filt(fieldname, fieldtype, startoperator, startvalue, endoperator, endvalue, caption));
        }
        /// <summary>
        /// 增加单个条件 前置符 和后置符
        /// </summary>
        public void AddComplexFilt(string prestr, string fieldname, string fieldtype, string fieldoperator, string fieldvalue, string nextstr)
        {
            m_ListFilt.Add(new Filt(prestr, fieldname, fieldtype, fieldoperator, fieldvalue, "", "", nextstr));
        }
        /// <summary>
        /// 增加单个条件 前置符 和后置符 包括字段内容说明
        /// </summary>
        public void AddComplexFilt(string prestr, string fieldname, string fieldtype, string fieldoperator, string fieldvalue, string caption, string captionvalue, string nextstr)
        {
            m_ListFilt.Add(new Filt(prestr,fieldname, fieldtype, fieldoperator, fieldvalue, caption, captionvalue,nextstr));
        }
        /// <summary>
        /// 增加单个范围条件 前置符 和后置符 包括字段内容说明
        /// </summary>
        public void AddComplexFilt(string prestr, string fieldname, string fieldtype, string startoperator, string startvalue, string endoperator, string endvalue, string caption, string nextstr)
        {
            m_ListFilt.Add(new Filt(prestr,fieldname, fieldtype, startoperator, startvalue, endoperator, endvalue, caption,nextstr));
        }

        /// <summary>
        /// filter 转SQL条件
        /// </summary>
        /// <returns></returns>
        public string ToFiltString()
        {
            string str = "";
            int i = 0;
            foreach (Filt f in m_ListFilt)
            {
                i++;
                str += f.PreStr;
                if (f.StartValue != "")
                {
                    string value = "";
                    value = getFiltValue(f.FieldType, f.StartValue, f.StartOperator);
                    if (f.StartOperator.ToLower() == "in")
                    {
                        str += getFieldName(f.FieldName, f.FieldType) + " " + getOperator(f.StartOperator) + " ( " + value + " )";
                    }
                    else
                    {
                        str += getFieldName(f.FieldName, f.FieldType) + " " + getOperator(f.StartOperator) + " " + value;
                    }
                }
                if (f.EndValue != "")
                {
                    string value = "";
                    value = getFiltValue(f.FieldType, f.EndValue, f.EndOperator);
                    str += " and " + getFieldName(f.FieldName, f.FieldType) + " " + getOperator(f.EndOperator) + " " + value;
                }
                if (f.NextStr == "" && i < m_ListFilt.Count) { str += " and "; }
                else { str += " " + f.NextStr + " "; }
            }
            if (m_ListFilt.Count == 0) { str = "1=1"; }
            return str;
        }
        /// <summary>
        /// FILTER 转QM
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        //public QueryParameterCollection ToQm(ref string condition)
        //{
        //    string str = "";
        //    QueryParameterCollection qm = new QueryParameterCollection();
        //    string prefix = Websharp.Service.ApplicationConfiguration.DefaultPersistenceProperty.ParaPrefix;
        //    int i = 0, j = 0;
        //    string value = "";
        //    foreach (Filt f in m_ListFilt)
        //    {
        //        i++;
        //        str += f.PreStr;
        //        if (f.StartValue != "")
        //        {
        //            j++;
        //            value = "";
        //            value = getFiltValue(f.FieldType, f.StartValue, f.StartOperator);
        //            switch (f.StartOperator.ToLower()) { 
        //                case "in":
        //                    str += getFieldName(f.FieldName, f.FieldType) + " " + getOperator(f.StartOperator) + " ( " + value + " )";
        //                    break;
        //                default:
        //                    str += getFieldName(f.FieldName, f.FieldType) + " " + getOperator(f.StartOperator) + " " + prefix + "G" + j;
        //                    break;
        //            }
        //            qm.Add("G" + j.ToString(), value);
        //        }
        //        if (f.EndValue != "")
        //        {
        //            j++;
        //            value = "";
        //            value = getFiltValue(f.FieldType, f.EndValue, f.EndOperator);
        //            str += " and " + getFieldName(f.FieldName, f.FieldType) + " " + getOperator(f.EndOperator) + " " + prefix + "G" + j;
        //            qm.Add("G" + j.ToString(), value);
        //        }
        //        if (f.NextStr == "" && i < m_ListFilt.Count) { str += " and "; }
        //        else { str += " "+f.NextStr+" "; }
        //    }
        //    if (m_ListFilt.Count == 0) { str = "1=1"; }
        //    condition = str;
        //    return qm;
        //}
        /// <summary>
        /// 获取条件内容
        /// </summary>
        /// <param name="type"></param>
        /// <param name="value"></param>
        /// <param name="join"></param>
        /// <returns></returns>
        private string getFiltValue(string type,string value, string join) {
            string str = "";
            switch (type)
            {
                case "String":
                    if (join=="like"){
                        str = "%" + value + "%";
                    }
                    else if (join == "llike") {
                        str = "%" + value + "";
                    }
                    else if (join == "rlike") {
                        str = "" + value + "%";
                    }
                    else
                    {
                        str = value;
                    }
                    break;
                case "Int":
                    str = G.Core.GConvert.ToInt(value).ToString();
                    break;
                case "Decimal":
                    str = G.Core.GConvert.ToInt(value).ToString();
                    break;
                default:
                    str = value;
                    break;
            }
            return str;
        }
        /// <summary>
        /// 获取条件值
        /// </summary>
        /// <param name="fieldname"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        private string getFieldName(string fieldname, string type) {
            string str = "";
            switch (type)
            {
                case "Int32":
                case "Decimal":
                    str = "isnull(" + fieldname + ",0)";
                    break;
                default:
                    str = fieldname;
                    break;
            }
            return str;
        }
        /// <summary>
        /// 获取SQL操作符
        /// </summary>
        /// <param name="join"></param>
        /// <returns></returns>
        private string getOperator(string join) {
            string str = "";
            if (join.ToLower().Contains("like"))
            {
                str = "like";
            }
            else {
                str = join;
            }
            return str;
        }
        /// <summary>
        /// 转条件显示信息
        /// </summary>
        /// <returns></returns>
        public string ToShowString()
        {
            string str = "";
            foreach (Filt f in m_ListFilt)
            {
                if (f.CaptionValue != "")
                {
                    str += f.Caption + ":" + f.CaptionValue + " ";
                }
                else if (f.EndValue != "" && f.StartValue != "")
                {
                    str += f.Caption + ":" + f.StartValue + "～" + f.EndValue + " ";
                }
                else if (f.StartValue != "")
                {
                    str += f.Caption + ":" + f.StartValue + " ";
                }
            }
            return str;
        }
        #region xml
        public string ToXml()
        {
            this.xmlDoc = this.CreateFilterXmlDoc();
            xmlDoc.SelectNodes("FilterCondition")[0].Attributes["OrderbyField"].Value = this.OrderBy;
            
            foreach (Filt f in m_ListFilt)
            {
                if (f.StartValue != "")
                {
                    this.AddXmlField("", "and", f.FieldName, f.Caption, f.FieldType, f.StartOperator, f.StartValue);
                }
                if (f.EndValue != "")
                {
                    this.AddXmlField("", "and", f.FieldName, f.Caption, f.FieldType, f.EndOperator, f.EndValue);
                }
                
            }
            return xmlDoc.InnerXml;
        }
        public XmlDocument CreateFilterXmlDoc() {
            string initxml = "<root><FilterCondition OrderbyField=\"\" FixedCondition=\"\"><GENERAL></GENERAL><ADVANCED></ADVANCED></FilterCondition></root>";
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(initxml);
            return xmlDoc;
        }
        public void AddXmlField(string Parenthesis, string UnionSign, string FieldName, string FieldCaption, string DataType, string OPERATESIGN, string New_Value)
        {
            XmlNodeList list = this.xmlDoc.SelectNodes("root/FilterCondition/GENERAL");
            XmlNode newChild = this.xmlDoc.CreateNode(XmlNodeType.Element, "GFIELD", "");
            list.Item(0).AppendChild(newChild);
            XmlNode node = this.xmlDoc.CreateNode(XmlNodeType.Element, "PARENTHESIS", "");
            node.InnerText = Parenthesis;
            newChild.AppendChild(node);
            node = this.xmlDoc.CreateNode(XmlNodeType.Element, "UNIONSIGN", "");
            node.InnerText = UnionSign;
            newChild.AppendChild(node);
            node = this.xmlDoc.CreateNode(XmlNodeType.Element, "NAME", "");
            node.InnerText = FieldName;
            newChild.AppendChild(node);
            node = this.xmlDoc.CreateNode(XmlNodeType.Element, "DATATYPE", "");
            node.InnerText = DataType;
            newChild.AppendChild(node);
            node = this.xmlDoc.CreateNode(XmlNodeType.Element, "OPERATESIGN", "");
            node.InnerText = OPERATESIGN;
            newChild.AppendChild(node);
            node = this.xmlDoc.CreateNode(XmlNodeType.Element, "VALUE", "");
            node.InnerText = New_Value;
            newChild.AppendChild(node);
            node = this.xmlDoc.CreateNode(XmlNodeType.Element, "FIELDCAPTION", "");
            node.InnerText = FieldCaption;
            newChild.AppendChild(node);
        }
        public void AddAdvanceXmlField(string Parenthesis, string UnionSign, string FieldName, string DataType, string OPERATESIGN, string New_Value)
        {
            XmlNodeList list = this.xmlDoc.SelectNodes("root/FilterCondition/ADVANCED");
            XmlNode newChild = this.xmlDoc.CreateNode(XmlNodeType.Element, "GFIELD", "");
            list.Item(0).AppendChild(newChild);
            XmlNode node = this.xmlDoc.CreateNode(XmlNodeType.Element, "PARENTHESIS", "");
            node.InnerText = Parenthesis;
            newChild.AppendChild(node);
            node = this.xmlDoc.CreateNode(XmlNodeType.Element, "UNIONSIGN", "");
            node.InnerText = UnionSign;
            newChild.AppendChild(node);
            node = this.xmlDoc.CreateNode(XmlNodeType.Element, "NAME", "");
            node.InnerText = FieldName;
            newChild.AppendChild(node);
            node = this.xmlDoc.CreateNode(XmlNodeType.Element, "DATATYPE", "");
            node.InnerText = DataType;
            newChild.AppendChild(node);
            node = this.xmlDoc.CreateNode(XmlNodeType.Element, "OPERATESIGN", "");
            node.InnerText = OPERATESIGN;
            newChild.AppendChild(node);
            node = this.xmlDoc.CreateNode(XmlNodeType.Element, "VALUE", "");
            node.InnerText = New_Value;
            newChild.AppendChild(node);
        }
        #endregion
    }
    /// <summary>
    /// 单个过滤条件
    /// </summary>
    public class Filt
    {
        private string m_FieldName = "";
        private string m_StartOperator = "";
        private string m_StartValue = "";
        private string m_EndOperator = "";
        private string m_EndValue = "";
        private string m_FieldType = "";
        private string m_Caption = "";
        private string m_CaptionValue = "";
        private string m_PreStr = "";
        private string m_NextStr = "";

        public Filt() { }
        public Filt(string fieldname, string fieldtype, string fieldoperator, string fieldvalue, string caption, string captionvalue)
        {
            this.FieldName = fieldname;
            this.StartOperator = fieldoperator;
            this.FieldType = fieldtype;
            this.StartValue = fieldvalue;
            this.Caption = caption;
            if (captionvalue != "")
                this.CaptionValue = captionvalue;
            else this.CaptionValue = fieldvalue;
        }
        public Filt(string prestr,string fieldname, string fieldtype, string fieldoperator, string fieldvalue, string caption, string captionvalue,string nextstr)
        {
            this.PreStr = prestr;
            this.FieldName = fieldname;
            this.StartOperator = fieldoperator;
            this.FieldType = fieldtype;
            this.StartValue = fieldvalue;
            this.Caption = caption;
            if (captionvalue != "")
                this.CaptionValue = captionvalue;
            else this.CaptionValue = fieldvalue;
            this.NextStr = nextstr;
        }
        public Filt(string fieldname, string fieldtype, string startoperator, string startvalue, string endoperator, string endvalue, string caption)
        {
            this.FieldName = fieldname;
            this.StartOperator = startoperator;
            this.FieldType = fieldtype;
            this.StartValue = startvalue;
            this.EndOperator = endoperator;
            this.EndValue = endvalue;
            this.Caption = caption;
            this.CaptionValue = startvalue + "～" + endvalue;
        }
        public Filt(string prestr,string fieldname, string fieldtype, string startoperator, string startvalue, string endoperator, string endvalue, string caption,string nextstr)
        {
            this.PreStr = prestr;
            this.FieldName = fieldname;
            this.StartOperator = startoperator;
            this.FieldType = fieldtype;
            this.StartValue = startvalue;
            this.EndOperator = endoperator;
            this.EndValue = endvalue;
            this.Caption = caption;
            this.CaptionValue = startvalue + "～" + endvalue;
            this.NextStr = nextstr;
        }

        public string FieldName { get { return m_FieldName; } set { m_FieldName = value; } }//字段名
        public string StartOperator { get { return m_StartOperator; } set { m_StartOperator = value; } }//操作符=<> like
        public string StartValue { get { return m_StartValue; } set { m_StartValue = value; } }//字段值
        public string EndOperator { get { return m_EndOperator; } set { m_EndOperator = value; } }//操作符=<> like
        public string EndValue { get { return m_EndValue; } set { m_EndValue = value; } }//字段值
        public string FieldType { get { return m_FieldType; } set { m_FieldType = value; } }//字段类型
        public string PreStr { get { return m_PreStr; } set { m_PreStr = value; } }//前置符 (
        public string NextStr { get { return m_NextStr; } set { m_NextStr = value; } }//后置符) or and ...
        public string Caption { get { return m_Caption; } set { m_Caption = value; } }//显示时候的名称
        public string CaptionValue { get { return m_CaptionValue; } set { m_CaptionValue = value; } }//显示时候的值
    }
}
