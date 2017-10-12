using System;
using System.Data;
using G.Data.Definition;
using G.Data.Model.Handler;

namespace G.Entity.WX
{
    /// <summary>
    /// 微信配置文件
    /// </summary>
    [Cacheable]
    public class WX_Config : DbObjectModel<WX_Config>
    {
        //微信公众号原始ID
        [DbColumn("OriginalID")]
        public string OriginalID { get; set; }

        [DbColumn("Token")]
        public string Token { get; set; }

        [DbColumn("AppID")]
        public string AppID { get; set; }

        [DbColumn("EncodingAESKey")]
        public string EncodingAESKey { get; set; }

        [DbColumn("UserName")]
        public string UserName { get; set; }

        [DbColumn("PWD")]
        public string PWD { get; set; }

        [DbColumn("Access_Token")]
        public string Access_Token { get; set; }

        [DbColumn("AppSecret")]
        public string AppSecret { get; set; }

        [DbColumn("Status")]
        public int Status { get; set; }
    }
}