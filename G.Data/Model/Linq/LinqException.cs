using System;
using System.Runtime.Serialization;
using G.Core;

namespace G.Data.Model.Linq
{
    [Serializable]
    public class LinqException : CoreException
    {
        public LinqException() { }
        public LinqException(string errorMessage) : base(errorMessage) { }
        public LinqException(string msgFormat, params object[] os) : base(String.Format(msgFormat, os)) { }
        protected LinqException(SerializationInfo info, StreamingContext context) : base(info, context) { }
        public LinqException(string message, Exception innerException) : base(message, innerException) { }
    }
}