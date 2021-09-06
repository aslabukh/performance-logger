using PerformanceLogger.Core.EnumTypes;

namespace PerformanceLogger.Server.Factory
{
    public interface ILoggerFactory
    {
        ILogger CreateLogger(LoggerType loggerType);
    }
}
