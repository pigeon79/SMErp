using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace G.BLL.WX
{
    public class WeiXinService
    {
        private HttpRequest Request;
        private string token = "";
        public WeiXinService(HttpRequest request)
        {
            this.Request = request;
        }
        public string Token {
            set { this.token = value; }
        }
        /// <summary>
        /// 处理请求，产生响应
        /// </summary>
        /// <returns></returns>
        public string Response()
        {
            string method = Request.HttpMethod.ToUpper();
            //验证签名
            if (method == "GET")
            {
                if (CheckSignature(this.token))
                {
                    return Request.QueryString["ECHOSTR"];
                }
                else
                {
                    return "error";
                }
            }

            //处理消息
            if (method == "POST")
            {
                return "";// ResponseMsg();
            }
            else
            {
                return "无法处理";
            }
        }
        public bool CheckSignature(string token)
        {
            bool checker = false;
            /*
             * signature 	微信加密签名，signature结合了开发者填写的token参数和请求中的timestamp参数、nonce参数。
                timestamp 	时间戳
                nonce 	随机数
                echostr 	随机字符串 
             * 1. 将token、timestamp、nonce三个参数进行字典序排序
                2. 将三个参数字符串拼接成一个字符串进行sha1加密
                3. 开发者获得加密后的字符串可与signature对比，标识该请求来源于微信
             * 
             * 
             * ****/
            //1 自己的服务器代码接受微信提交过来的4个参数
            //HttpContext context = HttpContext.Current;//得到当前请求的上下文对象
            //string token = "abcde";
            string signature = Request["signature"];
            string timestamp = Request["timestamp"];
            string nonce = Request["nonce"];
            string echostr = Request["echostr"];
            string[] temp = { token, timestamp, nonce };
            //字典排序
            Array.Sort(temp);
            //3个参数拼接成一个字符串
            string temp1 = string.Join("", temp);
            //字符串进行sha1加密
            string code = System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(temp1, "SHA1");
            if (code.ToLower().Equals(signature))
            {
                checker = true;
                //比较一致，表示通过微信的效验了，返回echostr字符串
                //context.Response.Write();
            }
            return checker;

        }

        /// <summary>
        /// 处理请求
        /// </summary>
        /// <returns></returns>
        private string ResponseMsg()
        {
            string requestXml = Common.ReadRequest(this.Request);
            IHandler handler = HandlerFactory.CreateHandler(requestXml);
            if (handler != null)
            {
                return handler.HandleRequest();
            }

            return string.Empty;
        }
    }
}
