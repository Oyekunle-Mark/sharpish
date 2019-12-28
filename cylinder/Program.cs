using System;

namespace cylinder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cylinder application 1.0!");

            Console.Write("Enter the radius of the cylinder: ");
            string radiusAsString = Console.ReadLine();
            double radius = Convert.ToDouble(radiusAsString);

            Console.Write("Enter the height of the cylinder: ");
            string heightAsString = Console.ReadLine();
            double height = Convert.ToDouble(heightAsString);

            // represent the pi constant
            double pi = 3.141592654;

            // calculate the volume
            double volume = pi * radius * radius * height;
            // calculate the surface area
            double surfaceArea = 2 * pi * radius * (radius + height);

            // prints result of  computation
            Console.WriteLine($"The volume of the cylinder is :{volume} cubic units.");
            Console.WriteLine($"The surface area of the cylinder is: {surfaceArea} square units.");
        }
    }
}
