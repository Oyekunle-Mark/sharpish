﻿using System;

namespace recursive_fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            // returns the nth fibonacci number from the fibonacci sequence using recursion
            // check if the number is 1 or 2
            // return 1
            // nthNumber will the result of calling FindFibonacciNumber
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
