//Write program that calculates the surface of a triangle by given two sides and an angle between them.
namespace _07.Triangle_surface_by_two_sides_and_an_angle
{
    using System;

    class TriangleSurface
    {
        static double CalculeteSurface(double a, double b, double alfa)
        {
            return (a * b * Math.Sin(alfa * Math.PI / 180)) / 2;
        }

        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double alfa = double.Parse(Console.ReadLine());
            double surface = CalculeteSurface(a, b, alfa);
            
            Console.WriteLine("{0:F2}",surface);
        }
    }
}
