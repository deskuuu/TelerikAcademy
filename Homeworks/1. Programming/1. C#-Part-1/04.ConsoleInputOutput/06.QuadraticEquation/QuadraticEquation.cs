/*Problem 6. Quadratic Equation

Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).
*/
using System;
class Program
{
   static void Main()
   {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double d = b * b - 4 * a * c;

        if (d < 0)
        {
            Console.WriteLine("no real roots");
        }
        if (d > 0)
        {
            Console.WriteLine("{0:F2}", (-b - Math.Sqrt(d)) / (2 * a));
            Console.WriteLine("{0:F2}", (-b + Math.Sqrt(d))/ (2 * a));
        }
        else if (d == 0)
        {
            double x = - b / (2 * a);
            Console.WriteLine("{0:F2}", x);
        }

   }
}

