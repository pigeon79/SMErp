﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace G.BLL.WX.Message
{
    /// <summary>
    /// 
    /// </summary>
    public class VioceMessage:Message
    {
        /// <summary>
        /// 模板静态字段
        /// </summary>
        private static string m_Template;
        /// <summary>
        /// 内容
        /// </summary>
        public string Content { get; set; }
        /// <summary>
        /// 消息ID
        /// </summary>
        public string MsgId { get; set; }
        /// <summary>
        /// 默认构造函数
        /// </summary>
        public VioceMessage()
        {
            this.MsgType = "music";
        }
        /// <summary>
        /// 加载模板
        /// </summary>
        private static void LoadTemplate()
        {
            m_Template = @"<xml>
                               <ToUserName><![CDATA[{0}]]></ToUserName>
                                <FromUserName><![CDATA[{1}]]></FromUserName>
                                <CreateTime>{2}</CreateTime>
                                <MsgType><![CDATA[music]]></MsgType>
                                <Music>
                                <Title><![CDATA[{3}]]></Title>
                                <Description><![CDATA[{4}]]></Description>
                                <MusicUrl><![CDATA[{5}]]></MusicUrl>
                                <HQMusicUrl><![CDATA[{5}]]></HQMusicUrl>
                                </Music>
                            </xml>";
        }
        /// <summary>
        /// 从xml数据加载文本消息
        /// </summary>
        /// <param name="xml"></param>
        public static TextMessage LoadFromXml(string xml)
        {
            TextMessage tm = null;
            if (!string.IsNullOrEmpty(xml))
            {
                XElement element = XElement.Parse(xml);
                if (element != null)
                {
                    tm = new TextMessage();
                    tm.FromUserName = element.Element(FROM_USERNAME).Value;
                    tm.ToUserName = element.Element(TO_USERNAME).Value;
                    tm.CreateTime = element.Element(CREATE_TIME).Value;
                    tm.Content = element.Element(CONTENT).Value;
                    tm.MsgId = element.Element(MSG_ID).Value;
                }
            }

            return tm;
        }
        /// <summary>
        /// 模板
        /// </summary>
        public override string Template
        {
            get
            {
                if (string.IsNullOrEmpty(m_Template))
                {
                    LoadTemplate();
                }

                return m_Template;
            }
        }
        /// <summary>
        /// 生成内容
        /// </summary>
        /// <returns></returns>
        public override string GenerateContent()
        {
            this.CreateTime = WxUtility.GetTime().ToString();
            return string.Format(this.Template,this.ToUserName,this.FromUserName,this.CreateTime,this.MsgType,this.Content,this.MsgId);
        }
       
    }
}
