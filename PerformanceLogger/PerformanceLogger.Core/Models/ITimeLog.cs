using System;

namespace PerformanceLogger.Core.Models
{
    internal interface ITimeLog : ILog
    {
        DateTime StartDateTimeUtc { get; set; }
    }
}
