using System;
using Extensions;

namespace extension_method
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "I am invincible. Hahahahahaaaa!!! Oh!";
            int len = text.CountWords();

            Console.WriteLine($"{text} has {len} words.");
        }
    }
}
