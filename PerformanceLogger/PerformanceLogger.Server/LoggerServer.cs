using PerformanceLogger.Core.Factory;
using PerformanceLogger.Server.Factory;

namespace PerformanceLogger.Server
{
    public class LoggerServer
    {
        public ILoggerFactory CreateLoggerFactory()
        {
            return new LoggerFactory();
        }

        public ILogFactory CreateLogFactory()
        {
            return new LogFactory();
        }
    }
}
