using System.Runtime.CompilerServices;

namespace PersonalAssistant.Services.External.Messages
{
    public class Range<T>
    {
        public T Min { get; set; }

        public T Max { get; set; }
    }

    public static class RangeExtension
    {
        public static bool IsNull<T>(this Range<T> range)
        {
            if (range == null || range.Min == null && range.Max == null)
                return true;
            return false;
        }
    }
}