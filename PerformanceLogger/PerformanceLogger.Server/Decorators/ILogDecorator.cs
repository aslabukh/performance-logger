using PerformanceLogger.Core.Models;

namespace PerformanceLogger.Server.Decorators
{
    internal interface ILogDecorator
    {
        void Decorate(ILog log);
    }
}
