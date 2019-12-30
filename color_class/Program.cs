using System;

namespace color_class
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The color class.\n");

            Color color = new Color() { Red = 23, Green = 232, Blue = 023 };

            Console.WriteLine($"The color properties are {color.Red}R {color.Green}G {color.Blue}B {color.Alpha}A");
            Console.WriteLine($"The grayscale is {color.FindGrayscale()}");
        }
    }
}
