using PerformanceLogger.Core.Models;
using PerformanceLogger.Server.Decorators;
using PerformanceLogger.Server.Implementations;
using System;

namespace PerformanceLogger.Server
{
    class Logger : ILogger
    {
        private readonly ILoggerImplementation _implementation;
        private readonly ILogDecorator _decorator;
        private readonly ILogConfigValidator _validator;

        public Logger(ILoggerImplementation implementation, ILogDecorator decorator, ILogConfigValidator validator)
        {
            _implementation = implementation;
            _decorator = decorator;
            _validator = validator;
        }

        public void Log(ILog log)
        {
            if(_validator.IsValid(log.Operation))
            {
                _decorator.Decorate(log);
                try
                {
                    _implementation.Log(log);
                }
                catch
                {
                    // ignore
                }
            }
        }

        public void Log(ITimeLog timeLog)
        {
            if (timeLog.ExecutionTime.Equals(TimeSpan.MinValue))
            {
                timeLog.ExecutionTime = DateTime.UtcNow - timeLog.StartDateTimeUtc;
            }

            Log((ILog)timeLog);
        }
    }
}
