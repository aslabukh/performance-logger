using PerformanceLogger.Core.Models;

namespace PerformanceLogger.Server
{
    public interface ILogger
    {
        void Log(ILog log);
        void Log(ITimeLog timeLog);
    }
}
