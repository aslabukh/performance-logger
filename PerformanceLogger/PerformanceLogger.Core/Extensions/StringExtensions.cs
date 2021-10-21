using System;

namespace PerformanceLogger.Core.Extensions
{
    public static class StringExtensions
    {
        public static bool CompareWithIgnoreCase(this string currentValue, string compareWithValue)
        {
            return string.Equals(currentValue, compareWithValue, StringComparison.OrdinalIgnoreCase);
        }
    }
}
