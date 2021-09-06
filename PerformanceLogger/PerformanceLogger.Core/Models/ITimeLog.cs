using System;

namespace PerformanceLogger.Core.Models
{
    public interface ITimeLog : ILog
    {
        DateTime StartDateTimeUtc { get; set; }
    }
}
