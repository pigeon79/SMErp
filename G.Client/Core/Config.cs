using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Xml;

namespace G.Client.Core
{
    public class Config
    {
        public static void ChangeServer(string conn)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load(System.Windows.Forms.Application.ExecutablePath + @".Config");
            XmlNodeList nodelist = xml.SelectNodes("//configuration/G.Settings/add");
            foreach (XmlNode x in nodelist)
            {
                if (x.Attributes["add"].Value.Contains("DataBase") && x.Attributes["value"].Value.Contains("data source"))
                {
                    //string v=x.Attributes["value"].Value;
                    //string[] sl=v.Split('=');
                    //sl[1].Split
                    //v="@SqlServer2005 : data source=.;initial catalog=eis;user id=sa;password=123"/>
                    x.Attributes["value"].Value = conn;
                }
            }
            xml.Save(System.Windows.Forms.Application.ExecutablePath + @".Config");
        }
        public static string GetServerIP() {
            string ip = "";
            XmlDocument xml = new XmlDocument();
            xml.Load(System.Windows.Forms.Application.ExecutablePath + @".Config");
            XmlNodeList nodelist = xml.SelectNodes("//configuration/G.Settings/add");
            foreach (XmlNode x in nodelist)
            {
                if (x.Attributes["add"].Value.Contains("DataBase") && x.Attributes["value"].Value.Contains("data source"))
                {
                    ip=x.Attributes["value"].Value;
                }
            }
            return ip;
        }
        ///<summary>
        ///在＊.exe.config文件中appSettings配置节增加一对键、值对
        ///</summary>
        ///<param ></param>
        ///<param ></param>
        public static void UpdateAppConfig(string Key, string newValue)
        {
            XmlDocument doc = new XmlDocument();
            //获得配置文件的全路径
            string strFileName = System.Windows.Forms.Application.ExecutablePath + @".Config";
            doc.Load(strFileName);
            //找出名称为“add”的所有元素
            XmlNodeList nodes = doc.GetElementsByTagName(string.Format("/configuration/appSettings/add[@key='{0}']", Key));
            if (nodes.Count > 0) {
                XmlAttribute att = nodes[0].Attributes["key"];
                //根据元素的第一个属性来判断当前的元素是不是目标元素
                if (att.Value == Key)
                {
                    //对目标元素中的第二个属性赋值
                    att = nodes[0].Attributes["value"];
                    att.Value = newValue;
                }
            }
            else {
                XmlNode node = doc.SelectSingleNode("/configuration/appSettings");
                XmlElement xe1 = doc.CreateElement("add");//创建一个<book>节点   
                xe1.SetAttribute("key", Key);//设置该节点genre属性   
                xe1.SetAttribute("value", newValue);//设置该节点ISBN属性   
                node.AppendChild(xe1);
            }
            //for (int i = 0; i < nodes.Count; i++)
            //{
            //    //获得将当前元素的key属性
            //    XmlAttribute att = nodes[i].Attributes["key"];
            //    //根据元素的第一个属性来判断当前的元素是不是目标元素
            //    if (att.Value == Key)
            //    {
            //        //对目标元素中的第二个属性赋值
            //        att = nodes[i].Attributes["value"];
            //        att.Value = newValue;
            //        break;
            //    }
            //}
            //保存上面的修改
            doc.Save(strFileName);
        }

    }
}
