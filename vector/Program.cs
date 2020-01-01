using System;

namespace vector
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector v1 = new Vector(2, 3, 2);
            Vector v2 = new Vector(3, 5, 9);

            Vector newVector = v1 + v2;
        }
    }
}
