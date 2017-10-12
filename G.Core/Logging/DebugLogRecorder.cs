using System;
using System.Diagnostics;
using G.Core.Ioc;

namespace G.Core.Logging
{
    [Implementation("Debug")]
    public class DebugLogRecorder : ILogRecorder
    {
        public void ProcessLog(SysLogType type, string name, string message, Exception exception)
        {
            DebugPrint("{0},{1},{2},{3}", type, name, message, exception);
        }

        private static void DebugPrint(string msg, params object[] os)
        {
            ClassHelper.CallFunction(typeof(Debug), "Print", msg, os);
        }
    }
}
