using PerformanceLogger.Core.EnumTypes;
using PerformanceLogger.Core.Models;
using PerformanceLogger.Core.Settings;

namespace PerformanceLogger.Server.Decorators
{
    internal class EmptyValuesFromSettingsDecorator : ILogDecorator
    {
        private readonly ILoggerSettings _loggerSettings;

        public EmptyValuesFromSettingsDecorator(ILoggerSettings loggerSettings)
        {
            _loggerSettings = loggerSettings;
        }

        public void Decorate(ILog log)
        {
            if (log.ErrorType == ErrorType.None)
            {
                log.ErrorType = _loggerSettings.ErrorType;
            }

            if (log.LogLevel == LogLevel.None)
            {
                log.LogLevel = _loggerSettings.LogLevel;
            }

            if (log.ObjectType == ObjectType.None)
            {
                log.ObjectType = _loggerSettings.ObjectType;
            }

            if (log.Operation == OperationsType.None)
            {
                log.Operation = _loggerSettings.Operation;
            }
        }
    }
}
