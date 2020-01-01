using System;
using System.Threading;

namespace frog_race
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static void FrogRace(object input)
        {
            int frogNumber = (int)input;
            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Frog #{frogNumber} jumped!");
                Thread.Sleep(random.Next(1) + 1);
            }

            Console.WriteLine($"Frog #{frogNumber} finished!");
        }
    }
}
