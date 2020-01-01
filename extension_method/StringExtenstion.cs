using System;

namespace Extensions
{
    public static class StringExtension
    {
        public static int CountWords(this string text)
        {
            return text.Split(' ').Length;
        }
    }
}
