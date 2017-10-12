using System;
using System.Data;
using G.Data.Definition;
using G.Data.Model.Handler;

namespace G.Entity.WX
{
    /// <summary>
    /// 用户发送消息表
    /// </summary>
    [Cacheable]
    public class WX_UserMsg : DbObjectModel<WX_UserMsg>
    {
       /// <summary>
       /// 消息类别
       /// </summary>
        [DbColumn("MsgType")]
        public string MsgType { get; set; }

        [DbColumn("EventId")]
        public string EventId { get; set; }
        /// <summary>
        /// 内容
        /// </summary>
        [DbColumn("Content")]
        public string Content { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        [DbColumn("CreateTime")]
        public string CreateTime { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        [DbColumn("State")]
        public string State { get; set; }
        /// <summary>
        /// 回复状态
        /// </summary>
        [DbColumn("ReState")]
        public string ReState { get; set; }
        /// <summary>
        /// 微信消息ID
        /// </summary>
        [DbColumn("MsgId")]
        public string WeiMsgId { get; set; }

        [DbColumn("ToUserName")]
        public int ToUserName { get; set; }

        [DbColumn("FromUserName")]
        public int FromUserName { get; set; }
    }
}