using System;
using PerformanceLogger.Core.EnumTypes;
using PerformanceLogger.Core.Settings;
using PerformanceLogger.Server.Decorators;
using PerformanceLogger.Server.Implementations.NLog;

namespace PerformanceLogger.Server.Factory
{
    class LoggerFactory : ILoggerFactory
    {
        public ILogger CreateLogger(LoggerType loggerType)
        {
            var defaultSettings = new DefaultSettings();
            switch (loggerType)
            {
                case LoggerType.NLog:
                    return new Logger(new NLogImplementation(), new EmptyValuesFromSettingsDecorator(defaultSettings), new NLogConfigValidator());
                default:
                    throw new ArgumentOutOfRangeException(nameof(loggerType), loggerType, "Can't find logger type");
            }
        }
    }
}
