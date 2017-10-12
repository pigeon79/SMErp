using System;
using System.Data;
using G.Data.Definition;
using G.Data.Model.Handler;

namespace G.Entity.WX
{
    /// <summary>
    /// �û�������Ϣ��
    /// </summary>
    [Cacheable]
    public class WX_UserMsg : DbObjectModel<WX_UserMsg>
    {
       /// <summary>
       /// ��Ϣ���
       /// </summary>
        [DbColumn("MsgType")]
        public string MsgType { get; set; }

        [DbColumn("EventId")]
        public string EventId { get; set; }
        /// <summary>
        /// ����
        /// </summary>
        [DbColumn("Content")]
        public string Content { get; set; }
        /// <summary>
        /// ����ʱ��
        /// </summary>
        [DbColumn("CreateTime")]
        public string CreateTime { get; set; }
        /// <summary>
        /// ״̬
        /// </summary>
        [DbColumn("State")]
        public string State { get; set; }
        /// <summary>
        /// �ظ�״̬
        /// </summary>
        [DbColumn("ReState")]
        public string ReState { get; set; }
        /// <summary>
        /// ΢����ϢID
        /// </summary>
        [DbColumn("MsgId")]
        public string WeiMsgId { get; set; }

        [DbColumn("ToUserName")]
        public int ToUserName { get; set; }

        [DbColumn("FromUserName")]
        public int FromUserName { get; set; }
    }
}