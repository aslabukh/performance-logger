using PerformanceLogger.Core.Models;

namespace PerformanceLogger.Core.Factory
{
    public interface ILogFactory
    {
        ILog CreateLog();
        ITimeLog CreateTimeLog();
    }
}
