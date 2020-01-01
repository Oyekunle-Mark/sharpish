using System;
using System.Threading;

namespace frog_race
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(FrogRace);
            t1.Start(1);

            Thread t2 = new Thread(FrogRace);
            t2.Start(2);

            Thread t3 = new Thread(FrogRace);
            t3.Start(3);

            t1.Join();
            t2.Join();
            t3.Join();
        }

        public static void FrogRace(object input)
        {
            int frogNumber = (int)input;
            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Frog #{frogNumber} jumped!");
                Thread.Sleep((random.Next(1) + 1) * 1000);
            }

            Console.WriteLine($"Frog #{frogNumber} finished!");
        }
    }
}
