using PerformanceLogger.Core.EnumTypes;
using System;

namespace PerformanceLogger.Core.Models
{
    internal class Log : ILog
    {
        public ErrorType ErrorType { get ; set; }
        public LogLevel LogLevel { get; set; }
        public string Message { get; set; }
        public string ObjectId { get; set; }
        public ObjectType ObjectType { get; set; }
        public OperationsType Operation { get; set; }
        public TimeSpan ExecutionTime { get; set; }
        public string SessionId { get; set; }
        public string StackTrace { get; set; }
        public string UserId { get; set; }
        public string MachineName { get; set; }
    }
}
