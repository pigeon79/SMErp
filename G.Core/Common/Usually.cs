using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;

namespace G.Core.Common
{
    public class Usually
    {
        #region 采用Socket方式，测试服务器连接
        /// <summary> 
        /// 采用Socket方式，测试服务器连接 
        /// </summary> 
        /// <param name="host">服务器主机名或IP</param> 
        /// <param name="port">端口号</param> 
        /// <param name="millisecondsTimeout">等待时间：毫秒</param> 
        /// <returns></returns> 
        public static bool TestConnection(string host, int port, int millisecondsTimeout)
        {
            TcpClient client = new TcpClient();
            try
            {
                var ar = client.BeginConnect(host, port, null, null);
                ar.AsyncWaitHandle.WaitOne(millisecondsTimeout);
                return client.Connected;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                client.Close();
            }
        }
        #endregion
        /// <summary> 
        /// 数据库连接操作，可替换为你自己的程序 
        /// </summary> 
        /// <param name="ConnectionString">连接字符串</param> 
        /// <returns></returns> 
        public static bool TestConnection(string ConnectionString)
        {
            bool result = true;
            try
            {
                SqlConnection m_myConnection = new SqlConnection(ConnectionString);
                m_myConnection.Open();
                //数据库操作...... 
                m_myConnection.Close();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
                result = false;
            }
            return result;
        }
        public static string GetIp()
        {
            string ip = ""; IPAddress p;
            System.Net.IPAddress[] iplist = System.Net.Dns.GetHostAddresses(GetMachineName());
            foreach (IPAddress i in iplist)
            {
                //if (IPAddress.TryParse(i.ToString(), out p)) { 
                //    ip = i.ToString();
                //}
                if (i.AddressFamily == AddressFamily.InterNetwork)
                {
                    ip = i.ToString();
                }
            }
            return ip;
        }
        public static string GetMachineName()
        {
            string n = "";
            n = System.Net.Dns.GetHostName();
            return n;
        }
        public static string DownLoad(string url, string dir)
        {
            WebClient client = new WebClient();
            string filename = url.Substring(url.LastIndexOf("/") + 1);
            string path = "";
            try
            {
                path = dir + filename;
                client.DownloadFile(url, path);
            }
            catch (Exception e) { }
            return path;
        }
        public static bool TestNetConnectity(string strIP)
        {
            IPAddress p;
            if (!IPAddress.TryParse(strIP, out p))
            {
                return false;
            }
            // Windows L2TP VPN和非Windows VPN使用ping VPN服务端的方式获取是否可以连通     
            Ping pingSender = new Ping();
            PingOptions options = new PingOptions();

            // Use the default Ttl value which is 128,     
            // but change the fragmentation behavior.     
            options.DontFragment = true;

            // Create a buffer of 32 bytes of data to be transmitted.     
            string data = "testtesttesttesttesttesttesttest";
            byte[] buffer = Encoding.ASCII.GetBytes(data);
            int timeout = 120;
            PingReply reply = pingSender.Send(strIP, timeout, buffer, options);

            return (reply.Status == IPStatus.Success);
        }

        public static string GetPadingNO(string startstr, string value, int len)
        {
            string str = startstr + DateTime.Now.Year.ToString().Substring(2, 2);
            int l = len - value.Length;
            if (l - str.Length >= 0)
            { str += value.PadLeft(len - str.Length, '0'); }
            else if (l >= 0)
            {
                str = str.Substring(0, l) + value;
            }
            else { str = value; }
            return str;
        }
    }
}
