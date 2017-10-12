using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using G.API.WX;
using System.Xml;
using System.Web;

namespace G.BLL.WX.Handler
{
    public class HandlerFactory
    {
        /// <summary>
        /// 创建处理器
        /// </summary>
        /// <param name="requestXml">请求的xml</param>
        /// <returns>IHandler对象</returns>
        public static IHandler CreateHandler(HttpRequest Request)
        {
            IHandler handler = null;
            
                //解析数据
                XmlDocument doc = new System.Xml.XmlDocument();
                doc.Load(Request.InputStream);
                XmlNode node = doc.SelectSingleNode("/xml/MsgType");
                if (node != null)
                {
                    XmlCDataSection section = node.FirstChild as XmlCDataSection;
                    if (section != null)
                    {
                        string msgType = section.Value;
                        switch (msgType)
                        {
                            case "text":
                                handler = new TextHandler(requestXml);
                                break;
                            case "event":
                                handler = new EventHandler(requestXml);
                                break;
                        }
                    }
                }

            return handler;
        }
    }
}
