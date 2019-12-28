using System;

namespace fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program gets an input from the user and prints out the number at that position in the Fibonacci sequence!\n");

            Console.Write("Enter the number: ");
            string numberAsString = Console.ReadLine();
            int number = Convert.ToInt32(numberAsString);

            int fibonacciNumber = GetFibonacciNumber(number);
            Console.WriteLine($"The {number}nth number is {fibonacciNumber}");
        }
    }
}
