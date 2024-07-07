using System;

namespace Utils
{
    public static class Utils
    {
        public static T GetRandomValueFromEnum<T>()
            where T : Enum
        {
            var values = Enum.GetValues(typeof(T));
            var randomT = (T)values.GetValue(new Random().Next(values.Length));

            return randomT;
        }
    }
}