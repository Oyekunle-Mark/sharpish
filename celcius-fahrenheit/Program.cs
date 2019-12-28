using System;

namespace celcius_fahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Celcius-Fahrenheit Converter 1.0!");
            Console.Write("Enter the temperature in Fahrenheit: ");

            string fahrenheitTemp = Console.ReadLine();
            double fahrenheit = Convert.ToDouble(fahrenheitTemp);

            double celcius = (5.0 / 9.0) * (fahrenheit - 32.0);
            Console.WriteLine($"{fahrenheit}F is equivalent to {celcius}C.");
        }
    }
}
