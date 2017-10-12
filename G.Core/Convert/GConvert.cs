using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Drawing;

namespace G.Core
{
    public static class GConvert
    {
        #region common
        public static string ToString(this object obj) {
            string s = "";
            if (obj!=null) {
                s = obj.ToString();
            }
            return s;
        }
        public static int ToInt(this string str)
        {
            int i = 0;
            try { i = int.Parse(str); }
            catch { }
            return i;
        }
        public static decimal ToDecimal(this string str, int digits)
        {
            decimal d = 0;
            try
            {
                d = decimal.Parse(str);
                d = decimal.Round(d, digits);
            }
            catch { }
            return d;
        }
        public static int ToInt(this object obj)
        {
            int i = 0;
            try
            {
                string type = obj.GetType().Name;
                switch (type)
                {
                    case "Double":
                    case "Decimal":
                        i = System.Convert.ToInt32(obj);
                        break;
                    case "Boolean":
                        if ((bool)obj) { i = 1; }
                        else i = 0;
                        break;
                    case "Int32":
                        i= System.Convert.ToInt32(obj);
                        break;
                    default:
                        i = System.Convert.ToInt32(obj.ToString());
                        break;
                }
            }
            catch { }
            return i;
        }
        public static decimal ToDecimal(this object obj, int digits)
        {
            decimal d = 0;
            try
            {
                d = System.Convert.ToDecimal(obj);
                d = decimal.Round(d, digits);
            }
            catch { }
            return d;
        }
        public static decimal ToDecimal(this object obj)
        {
            decimal d = 0;
            try
            {
                d = System.Convert.ToDecimal(obj);
            }
            catch { }
            return d;
        }
        public static bool ToBool(this object obj)
        {
            bool b = false;
            try
            {
                Type t = obj.GetType();
                
                switch (t.Name) {
                    case "Boolean":
                        b = System.Convert.ToBoolean(obj);
                        break;
                    default:
                        obj = ToInt(obj);
                        b = System.Convert.ToBoolean(obj);
                        break;
                }
                
            }
            catch { }
            return b;
        }
        public static bool ToBool(this bool? obj) {
            bool b = false;
            b = (Boolean)obj;
            return b;
        }
        public static DateTime ToDateTime(this object obj){
                return DateTime.Parse(obj.ToString());
        }
        public static string ToShortDateTime(this object obj)
        {
            string s = "";
            try{
            if (!obj.Equals(System.DBNull.Value)) {
                s=ToDateTime(obj).ToShortDateString();   
            }
            }
            catch{}
            return s;
        }
        
        public static Color GetColor(int argb)
        {
            return Color.FromArgb(argb);
        }
        public static string GetColorString(Color c)
        {
            return c.ToArgb().ToString();
        }
        #endregion
        #region 转换人民币大小金额
        /// <summary>
        /// 转换人民币大小金额
        /// </summary>
        /// <param name="num">金额</param>
        /// <returns>返回大写形式</returns>
        public static string ToRMB(this decimal num)
        {
            string str1 = "零壹贰叁肆伍陆柒捌玖";            //0-9所对应的汉字
            string str2 = "万仟佰拾亿仟佰拾万仟佰拾元角分"; //数字位所对应的汉字
            string str3 = "";    //从原num值中取出的值
            string str4 = "";    //数字的字符串形式
            string str5 = "";  //人民币大写金额形式
            int i;    //循环变量
            int j;    //num的值乘以100的字符串长度
            string ch1 = "";    //数字的汉语读法
            string ch2 = "";    //数字位的汉字读法
            int nzero = 0;  //用来计算连续的零值是几个
            int temp;            //从原num值中取出的值

            num = Math.Round(Math.Abs(num), 2);    //将num取绝对值并四舍五入取2位小数
            str4 = ((long)(num * 100)).ToString();        //将num乘100并转换成字符串形式
            j = str4.Length;      //找出最高位
            if (j > 15) { return "溢出"; }
            str2 = str2.Substring(15 - j);   //取出对应位数的str2的值。如：200.55,j为5所以str2=佰拾元角分

            //循环取出每一位需要转换的值
            for (i = 0; i < j; i++)
            {
                str3 = str4.Substring(i, 1);          //取出需转换的某一位的值
                temp = System.Convert.ToInt32(str3);      //转换为数字
                if (i != (j - 3) && i != (j - 7) && i != (j - 11) && i != (j - 15))
                {
                    //当所取位数不为元、万、亿、万亿上的数字时
                    if (str3 == "0")
                    {
                        ch1 = "";
                        ch2 = "";
                        nzero = nzero + 1;
                    }
                    else
                    {
                        if (str3 != "0" && nzero != 0)
                        {
                            ch1 = "零" + str1.Substring(temp * 1, 1);
                            ch2 = str2.Substring(i, 1);
                            nzero = 0;
                        }
                        else
                        {
                            ch1 = str1.Substring(temp * 1, 1);
                            ch2 = str2.Substring(i, 1);
                            nzero = 0;
                        }
                    }
                }
                else
                {
                    //该位是万亿，亿，万，元位等关键位
                    if (str3 != "0" && nzero != 0)
                    {
                        ch1 = "零" + str1.Substring(temp * 1, 1);
                        ch2 = str2.Substring(i, 1);
                        nzero = 0;
                    }
                    else
                    {
                        if (str3 != "0" && nzero == 0)
                        {
                            ch1 = str1.Substring(temp * 1, 1);
                            ch2 = str2.Substring(i, 1);
                            nzero = 0;
                        }
                        else
                        {
                            if (str3 == "0" && nzero >= 3)
                            {
                                ch1 = "";
                                ch2 = "";
                                nzero = nzero + 1;
                            }
                            else
                            {
                                if (j >= 11)
                                {
                                    ch1 = "";
                                    nzero = nzero + 1;
                                }
                                else
                                {
                                    ch1 = "";
                                    ch2 = str2.Substring(i, 1);
                                    nzero = nzero + 1;
                                }
                            }
                        }
                    }
                }
                if (i == (j - 11) || i == (j - 3))
                {
                    //如果该位是亿位或元位，则必须写上
                    ch2 = str2.Substring(i, 1);
                }
                str5 = str5 + ch1 + ch2;

                if (i == j - 1 && str3 == "0")
                {
                    //最后一位（分）为0时，加上“整”
                    str5 = str5 + '整';
                }
            }
            if (num == 0)
            {
                str5 = "零元整";
            }
            return str5;
        }

        #endregion
        #region
        public static string ToStringByBits(byte[] bytes)
        {
            ASCIIEncoding encoding = new ASCIIEncoding();
            string s = encoding.GetString(bytes);
            return s;
        }
        public static string GetBytesString(byte[] bytes, int index, int count, string sep)
        {
            //----menthod------------------------------
            var sb = new StringBuilder();

            for (int i = index; i < count - 1; i++)
            {
                sb.Append(bytes[i].ToString("X2") + sep);
            }
            sb.Append(bytes[index + count - 1].ToString("X2"));
            return sb.ToString();

            //return String.Join(sep, bytes.Skip(index).Take(count).Select(b => b.ToString("X2")));

        }
        public static string GetIntsString(int[] ints, string sep)
        {
            //----menthod------------------------------
            var sb = new StringBuilder();

            for (int i = 0; i < ints.Length - 1; i++)
            {
                sb.Append(ints[i].ToString() + sep);
            }
            sb.Append(ints[ints.Length - 1].ToString());
            return sb.ToString();

            //return String.Join(sep, bytes.Skip(index).Take(count).Select(b => b.ToString("X2")));

        }
        public static bool[] Bytes2Bits(byte[] byts)
        {
            bool[] bits = new bool[1];
            BitArray bitArray = new BitArray(byts);
            bits = new bool[bitArray.Count];
            bitArray.CopyTo(bits, 0);
            return bits;
        }
        public static int[] Bytes2Ints(byte[] byts)
        {
            int[] word = new int[1];
            if (byts.Length >= 2)
            {
                word = new int[byts.Length / 2];
                for (int x = 0; x < byts.Length; x = x + 2)
                {
                    word[x / 2] = byts[x] * 256 + byts[x + 1];
                }
            }
            return word;
        }
        public static string Bytes2BitsString(byte[] bytes, int index, int count)
        {
            //byte[] array = { 0x00, 0xFF, 0xAB };
            //string binary = Convert.ToString(array[0], 2).PadLeft(8, '0');
            //Console.WriteLine(binary);
            var sb = new StringBuilder();

            for (int i = index; i < index + count - 1; i++)
            {
                sb.Append(System.Convert.ToString(bytes[i], 2).PadLeft(8, '0'));
            }
            sb.Append(System.Convert.ToString(bytes[index + count - 1], 2).PadLeft(8, '0'));
            return sb.ToString();
        }
        public static string Bytes2IntsString(byte[] bytes, int index, int count)
        {
            //byte[] array = { 0x00, 0xFF, 0xAB };
            //string binary = Convert.ToString(array[0], 2).PadLeft(8, '0');
            //Console.WriteLine(binary);
            var sb = new StringBuilder();

            for (int i = index; i < index + count - 1; i++)
            {
                sb.Append(System.Convert.ToString(bytes[i], 10));
            }
            sb.Append(System.Convert.ToString(bytes[index + count - 1], 10));
            return sb.ToString();
        }
        public static string Bytes2IntsString2(byte[] bytes, int index, int count)
        {
            //byte[] array = { 0x00, 0xFF, 0xAB };
            //string binary = Convert.ToString(array[0], 2).PadLeft(8, '0');
            //Console.WriteLine(binary);
            var sb = new StringBuilder();

            for (int i = index; i < index + count - 2; i++)
            {
                sb.Append(System.Convert.ToString(bytes[i], 10) + ',');
            }
            sb.Append(System.Convert.ToString(bytes[index + count - 1], 10));
            return sb.ToString();
        }
        /// <summary>
        /// type 类型 bit byte word
        /// value 值
        /// </summary>
        /// <param name="length"></param>
        /// <param name="type"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static byte[] GetBytes(string type, string[] value)
        {
            int num = value.Length;
            bool[] bits = new bool[num];
            byte[] data = new Byte[num];
            int[] word = new int[num];

            switch (type)
            {
                case "bit":
                    for (int i = 0; i < value.Length; i++)
                    {
                        bits[i] = System.Convert.ToBoolean(System.Convert.ToByte(ToInt(value[i])));
                    }
                    int numBytes = (byte)(num / 8 + (num % 8 > 0 ? 1 : 0));
                    data = new Byte[numBytes];
                    BitArray bitArray = new BitArray(bits);
                    bitArray.CopyTo(data, 0);
                    break;
                case "byte":
                    for (int i = 0; i < value.Length; i++)
                    {
                        data[i] = System.Convert.ToByte(ToInt(value[i]));
                    }
                    break;
                case "word":
                    for (int i = 0; i < value.Length; i++)
                    {
                        word[i] = ToInt(value[i]);
                    }
                    data = new Byte[num * 2];
                    for (int x = 0; x < num; x++)
                    {
                        byte[] dat = BitConverter.GetBytes((short)IPAddress.HostToNetworkOrder((short)word[x]));
                        data[x * 2] = dat[0];
                        data[x * 2 + 1] = dat[1];
                    }
                    break;
            }
            return data;
        }
        public static byte[] GetBytes(string type, int[] value)
        {
            int num = value.Length;
            bool[] bits = new bool[num];
            byte[] data = new Byte[num];

            switch (type)
            {
                case "bit":
                    for (int i = 0; i < value.Length; i++)
                    {
                        bits[i] = System.Convert.ToBoolean(System.Convert.ToByte(value[i]));
                    }
                    int numBytes = (byte)(num / 8 + (num % 8 > 0 ? 1 : 0));
                    data = new Byte[numBytes];
                    BitArray bitArray = new BitArray(bits);
                    bitArray.CopyTo(data, 0);
                    break;
                case "byte":
                    for (int i = 0; i < value.Length; i++)
                    {
                        data[i] = System.Convert.ToByte(value[i]);
                    }
                    break;
                case "word":
                    data = new Byte[num * 2];
                    for (int x = 0; x < num; x++)
                    {
                        byte[] dat = BitConverter.GetBytes((short)IPAddress.HostToNetworkOrder((short)value[x]));
                        data[x * 2] = dat[0];
                        data[x * 2 + 1] = dat[1];
                    }
                    break;
            }
            return data;
        }
        public static Dictionary<int, byte[]> GetBytes(string type, int[,] value)
        {


            Dictionary<int, byte[]> data = new Dictionary<int, byte[]>();
            switch (type)
            {
                case "bit":
                    for (int i = 0; i < value.GetLength(0); i++)
                    {
                        int num = value.GetLength(1);
                        bool[] bits = new bool[num];
                        for (int j = 0; j < value.GetLength(1); j++)
                        {
                            bits[j] = System.Convert.ToBoolean(System.Convert.ToByte(value[i, j]));
                        }
                        int numBytes = (byte)(num / 8 + (num % 8 > 0 ? 1 : 0));
                        Byte[] bytearr = new Byte[numBytes];
                        BitArray bitArray = new BitArray(bits);
                        bitArray.CopyTo(bytearr, 0);
                        data.Add(i, bytearr);
                    }

                    break;
                case "byte":
                    for (int i = 0; i < value.GetLength(0); i++)
                    {
                        int num = value.GetLength(1);
                        Byte[] bits = new Byte[num];
                        for (int j = 0; j < value.GetLength(1); j++)
                        {
                            bits[j] = System.Convert.ToByte(value[i, j]);
                        }
                        data.Add(i, bits);
                    }
                    break;
                case "word":
                    for (int i = 0; i < value.GetLength(0); i++)
                    {
                        int num = value.GetLength(1);
                        Byte[] bits = new Byte[num * 2];
                        for (int j = 0; j < value.GetLength(1); j++)
                        {
                            byte[] dat = BitConverter.GetBytes((short)IPAddress.HostToNetworkOrder((short)value[i, j]));
                            bits[j * 2] = dat[0];
                            bits[j * 2 + 1] = dat[1];
                        }
                        data.Add(i, bits);
                    }
                    break;
            }
            return data;
        }
        #endregion
        #region siemens
        public static float DwordToFloat(uint ui) {
            byte[] ba = System.BitConverter.GetBytes(ui);
            float f = System.BitConverter.ToSingle(ba, 0);
            return f;
        }
        public static uint FloatToDword(float f) {
            uint ui = System.BitConverter.ToUInt32(System.BitConverter.GetBytes(f), 0);
            return ui;
        }
        public static int WordToInt(ushort us) {
            byte[] ba = System.BitConverter.GetBytes(us);
            int f = (int)System.BitConverter.ToInt16(ba, 0);
            return f;
        }
        public static ushort IntToWord(int f)
        {
            ushort us = System.BitConverter.ToUInt16(System.BitConverter.GetBytes(f), 0);
            return us;
        }
        #endregion
    }
}
