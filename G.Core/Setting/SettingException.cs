using System;
using System.Runtime.Serialization;

namespace G.Core
{
    [Serializable]
    public class SettingException : CoreException
    {
		public SettingException():base("设置错误.") { }
		public SettingException(string errorMessage) : base(errorMessage) { }
        public SettingException(string msgFormat, params object[] os) : base(String.Format(msgFormat, os)) { }
		protected SettingException(SerializationInfo info, StreamingContext context) : base(info, context) { }
        public SettingException(string message, Exception innerException) : base(message, innerException) { }
    }
}
