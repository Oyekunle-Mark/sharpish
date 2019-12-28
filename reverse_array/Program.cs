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

        static void ReverseArray(int[] array) {
            int start = 0;
            int end = array.Length - 1;

            while(start < end) {
                int temp = array[start];
                array[start] = array[end];
                array[end] = array[start];

                start++;
                end--;
            }
        }
    }
}
