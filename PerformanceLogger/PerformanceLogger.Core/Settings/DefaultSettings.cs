using PerformanceLogger.Core.EnumTypes;

namespace PerformanceLogger.Core.Settings
{
    public class DefaultSettings : ILoggerSettings
    {
        public LogLevel LogLevel => LogLevel.Info;
        public OperationsType Operation => OperationsType.None;
        public ObjectType ObjectType => ObjectType.None;
        public ErrorType ErrorType => ErrorType.None;
    }
}
