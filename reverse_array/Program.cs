using System;

namespace reverse_array
{
    class Program
    {
        static void Main(string[] args)
        {
            // call generate numbers to get array
            int[] numberArray = GenerateNumber();
            // pass the number to reverse number
            ReverseArray(numberArray);
            // print number
            PrintArray(numberArray);
        }
    }
}
