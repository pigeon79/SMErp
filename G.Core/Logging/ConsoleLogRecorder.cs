using System;
using G.Core.Ioc;

namespace G.Core.Logging
{
    [Implementation("Console")]
    public class ConsoleLogRecorder : ILogRecorder
	{
        public void ProcessLog(SysLogType type, string name, string message, Exception exception)
        {
            Console.WriteLine("{0},{1},{2},{3}", type, name, message, exception);
        }
    }
}
