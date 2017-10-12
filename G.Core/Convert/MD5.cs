using System;
using System.Collections.Generic;

using System.Text;
using System.Security.Cryptography;

namespace G.Core
{
    public class MD5Encrypt
    {
        /// <summary>
        /// MD5加密
        /// </summary>
        /// <param name="str">需加密的字符串</param>
        /// <returns>加密后的字符</returns>
        public static string Md5Encryption(string str)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] data = System.Text.Encoding.Unicode.GetBytes(str);
            byte[] todata = md5.ComputeHash(data);
            string bytestr = null;
            for (int i = 0; i < todata.Length; i++)
            {
                bytestr += todata[i].ToString("x");
            }
            return bytestr;
        }


        /// <summary>
        /// 加密
        /// </summary>
        /// <param name="str">需加密的字符串</param>
        /// <returns>加密后的字符</returns>
        public static string MD5ToBase64String(string str)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] MD5 = md5.ComputeHash(System.Text.Encoding.UTF8.GetBytes(str));//MD5(注意UTF8编码)
            string result = System.Convert.ToBase64String(MD5, 0, MD5.Length);//Base64
            return result;
        }
        ///   <summary>
        ///   给一个字符串进行MD5加密
        ///   </summary>
        ///   <param   name="strText">待加密字符串</param>
        ///   <returns>加密后的数组</returns>
        public static byte[] MD5EncryptEX(string strText)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] result = md5.ComputeHash(System.Text.Encoding.UTF8.GetBytes(strText));
            return result;
        }
        /// <summary>
        /// Base64 编码
        /// </summary>
        /// <param name="bytedata">待编码数组</param>
        /// <returns>编码后字符串</returns>
        public static string ToBase64String(byte[] bytedata)
        {
            string strPath = System.Convert.ToBase64String(bytedata, 0, bytedata.Length);
           return strPath;
        }
    }
}
