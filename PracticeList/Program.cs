using System;
using ListClass;

namespace PracticeList
{
    class Program
    {
        static void Main(string[] args)
        {
            PracticeList<int> list = new PracticeList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);

            Console.WriteLine($"The third item is {list.GetItem(2)}");
        }
    }
}
