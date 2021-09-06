using PerformanceLogger.Core.Models;

namespace PerformanceLogger.Core.Factory
{
    internal interface ILogFactory
    {
        ILog CreateLog();
        ITimeLog CreateTimeLog();
    }
}
