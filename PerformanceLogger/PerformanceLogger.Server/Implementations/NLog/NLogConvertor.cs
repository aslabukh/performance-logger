using NLogLogLevel = NLog.LogLevel;
using PerformanceLogger.Core.EnumTypes;
using System;

namespace PerformanceLogger.Server.Implementations.NLog
{
    class NLogConvertor
    {
        public static NLogLogLevel ConvertToLogLevel(LogLevel internalLevel)
        {
            switch (internalLevel)
            {
                case LogLevel.Debug:
                    return NLogLogLevel.Debug;
                case LogLevel.Error:
                    return NLogLogLevel.Error;
                case LogLevel.Fatal:
                    return NLogLogLevel.Fatal;
                case LogLevel.Info:
                    return NLogLogLevel.Info;
                case LogLevel.None:
                    return NLogLogLevel.Off;
                case LogLevel.Trace:
                    return NLogLogLevel.Trace;
                case LogLevel.Warning:
                    return NLogLogLevel.Warn;
                default:
                    throw new ArgumentOutOfRangeException(nameof(internalLevel), internalLevel, "Can't find log level type");
            }
        }
    }
}
