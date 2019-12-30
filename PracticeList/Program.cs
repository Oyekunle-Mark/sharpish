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

            PracticeList<string> listString = new PracticeList<string>();
            listString.Add("Hello");
            listString.Add("World");
            listString.Add("!");

            Console.WriteLine($"The third item is {listString.GetItem(2)}");
        }
    }
}
