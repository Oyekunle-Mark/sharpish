using System;

namespace recursive_fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            // returns the nth fibonacci number from the fibonacci sequence using recursion
            Console.WriteLine("This program prints the nth Fibonacci Number from the Fibonacci sequence!\n");

            Console.Write("Enter the nth Fibonacci number to print: ");
            string inputString = Console.ReadLine();
            int inputNumber = Convert.ToInt32(inputString);

            // will hold the nth fibonacci number
            int answer;
            // create an array of length inputNumber 
            int[] fibNumbers = new int[inputNumber];

            //and add the first and second number
            fibNumbers[0] = 1;
            fibNumbers[1] = 1;

            // check if the inputNumber is 1 or 2
            if (inputNumber == 1 || inputNumber == 2)
                // set answer to 1
                answer = 1;
            // nthNumber will the result of calling FindFibonacciNumber
            else
                answer = FindFibonacciNumber(fibNumbers, inputNumber, 2);

            Console.WriteLine($"The {inputNumber}th Fibonacci number is: {answer}");
        }

        static int FindFibonacciNumber(int[] fibNumbers, int position, int current)
        {
            // check if current equals position - 1
            if (current == position - 1)
                // return sum of the last two numbers in fibNumbers
                return fibNumbers[current - 1] + fibNumbers[current - 2];

            // otherwise, set fibNumbers at current to sum of the last two numbers in fibNumbers
            fibNumbers[current] = fibNumbers[current - 1] + fibNumbers[current - 2];

            // make a recursive call to FindFibonacciNumber
            // passing fibNumbers, position and current + 1
            return FindFibonacciNumber(fibNumbers, position, current + 1);
        }
    }
}
