//Write program that calculates the surface of a triangle by given its three sides.
namespace _05.Triangle_surface_by_three_sides
{
    using System;

    class Program
    {
        static double CalculeteSurface(double a, double b, double c)
        {
            //Area	= √	 p	 (	p	−	a	) 	(	p	−	b	)	 (	p	−	c	)     Herons formula
            //p=(a	+	b	+	c )/2
            double p = (a + b + c) / 2.0;
            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return area;
        }

        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double surface = CalculeteSurface(a, b, c);

            Console.WriteLine("{0:F2}", surface);
        }
    }
}
