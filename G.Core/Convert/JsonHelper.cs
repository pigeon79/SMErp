using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.ComponentModel;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;

namespace G.Core
{
    public class JsonHelper
    {
        static JsonHelper()
        {

        }
        public static JsonSerializerSettings Getsettings()
        {
            JsonSerializerSettings _jsonSettings;
            IsoDateTimeConverter datetimeConverter = new IsoDateTimeConverter();
            datetimeConverter.DateTimeFormat = "yyyy-MM-dd HH:mm:ss";
            
            _jsonSettings = new JsonSerializerSettings();
            _jsonSettings.MissingMemberHandling = Newtonsoft.Json.MissingMemberHandling.Ignore;
            _jsonSettings.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore;
            _jsonSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
            _jsonSettings.Converters.Add(datetimeConverter);
            return _jsonSettings;
        }

        public static T Json2Object<T>(string jsonString)
        {
            T obj = default(T);//返回类型的默认值，T为引用类型时返回null,数值类型返回0 
            try
            {
                jsonString = ToChinese(jsonString);
                obj = (T)JsonConvert.DeserializeObject(jsonString, typeof(T));
            }
            catch (Exception e)
            {
                throw e;
            }
            return obj;
        }
        public static string Object2Json(object obj)
        {
            string json = "";
            json = JsonConvert.SerializeObject(obj, Getsettings());
            return json;
        }

        #region dataset
        public static void JsonUpdateDataSet(ref DataSet entity, string jsonString)
        {
            jsonString = ToChinese(jsonString);
            JArray o = (JArray)JsonConvert.DeserializeObject(jsonString);
            if (o != null)
            {
                foreach (JToken jt in o)
                {
                    string tablename = ((JValue)jt["tablename"]).Value.ToString().ToUpper();
                    DataTable dt = entity.Tables[tablename];
                    JArray rows = (JArray)jt["rows"];
                    if (rows != null)
                    {
                        foreach (JToken row in rows)
                        {
                            DataRow dr = dt.NewRow();
                        }
                    }
                }
            }
        }
        public static DataSet Json2DataSet(string jsonString)
        {
            jsonString = ToChinese(jsonString);
            DataSet ds = new DataSet();
            JArray o = (JArray)JsonConvert.DeserializeObject(jsonString);
            if (o != null)
            {
                foreach (JObject jt in o)
                {
                    string tablename = jt["tablename"].ToString().ToUpper();
                    DataTable dt = new DataTable();
                    dt.TableName = tablename;
                    JArray rows = (JArray)jt["rows"];
                    if (rows != null)
                    {
                        foreach (JObject row in rows)
                        {
                            DataRow dr = dt.NewRow();
                            foreach (JProperty jp in row.Properties())
                            {
                                string col = jp.Name;
                                var value = jp.Value.ToString();
                                if (dt.Columns.Contains(col))
                                {
                                    dr[col] = value;
                                }
                                else
                                {
                                    dt.Columns.Add(col);
                                    dr[col] = value;
                                }
                            }
                            dt.Rows.Add(dr);

                        }
                    }
                    ds.Tables.Add(dt);
                }
            }
            return ds;
        }
        public static List<object> DataSet2Object(DataSet ds)
        {
            List<object> list = new List<object>();
            Dictionary<string, object> dic = new Dictionary<string, object>();
            foreach (DataTable dt in ds.Tables)
            {
                dic = new Dictionary<string, object>();
                object o = JsonConvert.SerializeObject(dt);
                dic.Add("tablename", dt.TableName);
                dic.Add("rows", dt);
                list.Add(dic);
            }
            return list;
        }
        public static List<object> DataSet2Object(DataSet ds, int count)
        {
            List<object> list = new List<object>();
            Dictionary<string, object> dic = new Dictionary<string, object>();
            foreach (DataTable dt in ds.Tables)
            {
                dic = new Dictionary<string, object>();
                //object o = JsonConvert.SerializeObject(dt);
                dic.Add("tablename", dt.TableName);
                dic.Add("rows", dt);
                dic.Add("count", count);
                list.Add(dic);
            }
            return list;
        }
        public static string DataSet2Json(DataSet ds, int count)
        {
            string json = "";
            List<object> list = DataSet2Object(ds, count);
            json = JsonConvert.SerializeObject(list);
            return json;
        }
        public static string DataSet2Json(DataSet ds)
        {
            string json = "";
            List<object> list = DataSet2Object(ds);
            json = JsonConvert.SerializeObject(list);
            return json;
        }
        public static string DataTable2Json(DataSet ds)
        {
            string json = "";
            json = JsonConvert.SerializeObject(ds.Tables[0], Getsettings());
            return json;
        }
        #endregion
        public static string ToChinese(string data)
        {
            System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex(@"\\u(\w{4})");
            string result = regex.Replace(data, delegate(System.Text.RegularExpressions.Match m)
            {
                string hexStr = m.Groups[1].Value;
                string charStr = ((char)int.Parse(hexStr, System.Globalization.NumberStyles.HexNumber)).ToString();
                return charStr;
            });
            return result;
        }
    }

}
