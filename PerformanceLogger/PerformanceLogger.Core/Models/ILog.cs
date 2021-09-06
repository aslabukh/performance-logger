using System;
using PerformanceLogger.Core.EnumTypes;

namespace PerformanceLogger.Core.Models
{
    public interface ILog
    {
        ErrorType ErrorType { get; set; }
        LogLevel LogLevel { get; set; }
        string Message { get; set; }
        string ObjectId { get; set; }
        ObjectType ObjectType { get; set; }
        OperationsType Operation { get; set; }
        TimeSpan ExecutionTime { get; set; }
        string SessionId { get; set; }
        string StackTrace { get; set; }
        string UserId { get; set; }
        string MachineName { get; set; }
    }
}
