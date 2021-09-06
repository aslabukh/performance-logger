using System;

namespace PerformanceLogger.Core.Models
{
    internal class TimeLog : Log, ITimeLog
    {
        public DateTime StartDateTimeUtc { get; set; }
    }
}
