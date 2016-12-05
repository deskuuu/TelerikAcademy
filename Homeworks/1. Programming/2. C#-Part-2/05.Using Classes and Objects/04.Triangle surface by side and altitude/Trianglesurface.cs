//Write program that calculates the surface of a triangle by given a side and an altitude to it.
namespace _04.Triangle_surface_by_side_and_altitude
{
    using System;

    class Trianglesurface
    {
        static double CalculeteSurface(double a, double altitude)
        {
            return a * altitude / 2;
        }
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double altitude = double.Parse(Console.ReadLine());
            double surface = CalculeteSurface(a, altitude);

            Console.WriteLine("{0:F2}", surface);
        }
    }
}
