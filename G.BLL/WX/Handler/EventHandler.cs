using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace G.BLL.WX.Handler
{
    class EventHandler : IHandler
    {
        /// <summary>
        /// 请求的xml
        /// </summary>
        private string RequestXml { get; set; }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="requestXml"></param>
        public EventHandler(string requestXml)
        {
            this.RequestXml = requestXml;
        }
        /// <summary>
        /// 处理请求
        /// </summary>
        /// <returns></returns>
        public string HandleRequest()
        {
            string response = string.Empty;
            EventMessage em = EventMessage.LoadFromXml(RequestXml);
            if (em.Event.Equals("subscribe",StringComparison.OrdinalIgnoreCase))
            {
                //回复欢迎消息
                TextMessage tm = new TextMessage();
                tm.ToUserName = em.FromUserName;
                tm.FromUserName = em.ToUserName;
                tm.CreateTime = Common.GetNowTime();
                tm.Content = "欢迎您关注***，我是大哥大，有事就问我，呵呵！\n\n";
                response = tm.GenerateContent();
            }

            return response;
        }
    }
}
