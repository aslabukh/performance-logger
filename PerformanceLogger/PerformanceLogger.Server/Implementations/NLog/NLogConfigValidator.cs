using System.Collections.Generic;
using System.Linq;
using NLog;
using NLog.Config;
using PerformanceLogger.Core.EnumTypes;
using PerformanceLogger.Core.Extensions;

namespace PerformanceLogger.Server.Implementations.NLog
{
    class NLogConfigValidator : ILogConfigValidator
    {
        public bool IsValid(OperationsType operationType)
        {
            LoggingConfiguration configuration = LogManager.Configuration;
            if (configuration == null)
                return false;

            IList<LoggingRule> rules = configuration.LoggingRules;
            string operation = operationType.ToString();
            IEnumerable<LoggingRule> operationRules = rules.Where(rule => rule.LoggerNamePattern.CompareWithIgnoreCase(operation) &&
                                                                          rule.Targets.Any());
            if (operationRules.Any())
                return true;

            return false;
        }
    }
}
