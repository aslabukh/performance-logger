using System;

namespace PerformanceLogger.Core.Models
{
    class TimeLog : Log, ITimeLog
    {
        public DateTime StartDateTimeUtc { get; set; }
    }
}
