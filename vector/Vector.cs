using System;

namespace vector
{
    class Vector
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Vector(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public static Vector operator +(Vector v1, Vector v2) => new Vector(v1.X + v2.X, v1.Y + v2.Y, v1.Z + v2.Z);

        public static Vector operator -(Vector v1, Vector v2) => new Vector(v1.X - v2.X, v1.Y - v2.Y, v1.Z - v2.Z);

        public static Vector operator !(Vector v) => new Vector(-v.X, -v.Y, -v.Z);

        public static Vector operator *(Vector v, double scalar) => new Vector(v.X * scalar, v.Y * scalar, v.Z * scalar);

        public static Vector operator /(Vector v, double scalar) => new Vector(v.X / scalar, v.Y / scalar, v.Z / scalar);

        /// <summary>
        /// Pretty prints the values of the Vector instance variables
        /// </summary>
        public void PrintVector() => Console.WriteLine($"(X: {X}, Y: {Y}, Z: {Z})");

    }
}
