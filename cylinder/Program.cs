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

            Console.WriteLine("You entered: " + radius + " and " + height);
        }
    }
}
