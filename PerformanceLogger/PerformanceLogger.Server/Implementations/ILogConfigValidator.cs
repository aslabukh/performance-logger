using PerformanceLogger.Core.EnumTypes;

namespace PerformanceLogger.Server.Implementations
{
    interface ILogConfigValidator
    {
        bool IsValid(OperationsType operation);
    }
}
