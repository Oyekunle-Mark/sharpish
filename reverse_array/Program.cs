using System;

namespace reverse_array
{
    class Program
    {
        static void Main(string[] args)
        {
            // call generate numbers to get array
            int[] numberArray = GenerateNumbers(10);
            // pass the number to reverse number
            ReverseArray(numberArray);
            // print number
            PrintArray(numberArray);
        }

        static int[] GenerateNumbers(int length) {
            int[] numbers = new int[length];

            for (int i = 0; i < length; i++) {
                numbers[i] = i;
            }

            return numbers;
        }
    }
}
