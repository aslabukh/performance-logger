using PerformanceLogger.Core.Models;

namespace PerformanceLogger.Server.Implementations
{
    interface ILoggerImplementation
    {
        void Log(ILog log);
    }
}
