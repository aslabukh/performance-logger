using System;
using PerformanceLogger.Core.Models;

namespace PerformanceLogger.Core.Factory
{
    public class LogFactory : ILogFactory
    {
        public ILog CreateLog()
        {
            return new Log();
        }

        public ITimeLog CreateTimeLog()
        {
            return new TimeLog { StartDateTimeUtc = DateTime.UtcNow };
        }
    }
}
