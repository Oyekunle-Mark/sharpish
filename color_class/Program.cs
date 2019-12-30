using System;

namespace color_class
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The color class.\n");

            Color color = new Color(129, 232, 45);

            Console.WriteLine($"The color properties are {color.Red}R {color.Green}G {color.Blue}B {color.Alpha}A");
            Console.WriteLine($"The grayscale is {color.FindGrayscale()}");
        }
    }
}
