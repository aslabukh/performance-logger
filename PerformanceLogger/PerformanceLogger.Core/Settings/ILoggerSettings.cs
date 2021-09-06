using PerformanceLogger.Core.EnumTypes;

namespace PerformanceLogger.Core.Settings
{
    internal interface ILoggerSettings
    {
        LogLevel LogLevel { get; }
        OperationsType Operation { get; }
        ObjectType ObjectType { get; }
        ErrorType ErrorType { get; }
    }
}
