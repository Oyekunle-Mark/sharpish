using System;

namespace reverse_array
{
    class Program
    {
        static void Main(string[] args)
        {
            // call generate numbers to get array
            int[] numberArray = GenerateNumbers(9);
            // pass the number to reverse number
            ReverseArray(numberArray);
            // print number
            PrintArray(numberArray);
        }

        /// <summary>
        /// Generates an array of int.
        /// </summary>
        /// <param name="length">Length of the array to be generated.</param>
        /// <returns>The generated array</returns>
        static int[] GenerateNumbers(int length)
        {
            int[] numbers = new int[length];

            for (int i = 0; i < length; i++)
                numbers[i] = i + 1;


            return numbers;
        }

        /// <summary>
        /// Reverses the array
        /// </summary>
        /// <param name="array">The array to be reversed</param>
        static void ReverseArray(int[] array)
        {
            int start = 0;
            int end = array.Length - 1;

            while (start < end)
            {
                int temp = array[start];
                array[start] = array[end];
                array[end] = temp;

                start++;
                end--;
            }
        }

        static void PrintArray(int[] array)
        {
            foreach (int value in array)
                Console.Write($"{value } \n");
        }
    }
}
