using System;
using PerformanceLogger.Core.Models;

namespace PerformanceLogger.Server
{
    public class Logger : ILogger
    {
        public void Log(ILog log)
        {
            throw new System.NotImplementedException();
            
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
