using System;

namespace vector
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector v1 = new Vector(2, 3, 2);
            Vector v2 = new Vector(3, 5, 9);

            Vector plusVector = v1 + v2;
            plusVector.PrintVector();

            Vector minusVector = v1 - v2;
            minusVector.PrintVector();

            Vector negateVector = !minusVector;
            negateVector.PrintVector();

            Vector multiplyVector = v2 * 2.0;
            multiplyVector.PrintVector();

            Vector divideVector = v1 / 3;
            divideVector.PrintVector();
        }
    }
}
