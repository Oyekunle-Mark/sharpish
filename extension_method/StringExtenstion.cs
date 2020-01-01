using System;

namespace Extensions
{
    public static class StringExtension
    {
        /// <summary>
        /// Count the number of words in a string
        /// </summary>
        /// <param name="text">The text to be counted</param>
        /// <returns>The number of words.</returns>
        public static int CountWords(this string text)
        {
            return text.Split(' ').Length;
        }
    }
}
