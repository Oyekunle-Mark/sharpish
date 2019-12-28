using System;

namespace celcius_fahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Celcius-Fahrenheit Converter 1.0!");
            Console.Write("Enter the temperature in Fahrenheit");

            string fahrenheitTemp = Console.ReadLine();
            Console.WriteLine($"You entered: {fahrenheitTemp}");
        }
    }
}
