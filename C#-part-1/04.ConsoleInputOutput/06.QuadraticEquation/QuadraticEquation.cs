/*Problem 6. Quadratic Equation

Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).
Examples:

a	b	c	roots
2	5	-3	x1=-3; x2=0.5
-1	3	0	x1=3; x2=0
-0.5	4	-8	x1=x2=4
5	2	8	no real roots
*/
using System;

   class Program
    {
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a coefficent a:");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter a coefficent b:");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter a coefficent c:");
        double c = double.Parse(Console.ReadLine());
        double d = b * b - 4 * a * c;

        if (d < 0)
        {
            Console.WriteLine("no real roots");
        }
        if (d > 0)
        {
            Console.WriteLine("x1 = {0}", (- b + Math.Sqrt(d))/ (2 * a));
            Console.WriteLine("x2 = {0} ", (-b - Math.Sqrt(d)) / (2 * a));
        }
        else
        {
            double x = - b / (2 * a);
            Console.WriteLine("x1=x2= {0}", x);
        }

    }
 }
    

