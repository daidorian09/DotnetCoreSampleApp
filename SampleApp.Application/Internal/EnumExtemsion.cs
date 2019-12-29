using System;

namespace SampleApp.Application.Internal
{
    public static class EnumExtemsion
    {
        public static int EnumToInt<TValue>(this TValue value) where TValue : Enum
            => (int)(object)value;
    }
}