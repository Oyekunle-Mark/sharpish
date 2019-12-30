using System;

namespace color_class
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The color class.\n");

            Color color = new Color(129, 232, 45);
            color.SetBlue(0);

            Console.WriteLine($"The color properties are {color.GetRed()}R {color.GetGreen()}G {color.GetBlue()}B {color.GetAlpha()}A");
            Console.WriteLine($"The grayscale is {color.FindGrayscale()}");
        }
    }
}
