using System;
using G.Core.Ioc;

namespace G.Core.Logging
{
    [DependenceEntry]
	public interface ILogRecorder
	{
        void ProcessLog(SysLogType type, string name, string message, Exception exception);
	}
}
