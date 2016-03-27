/*Problem 9. Trapezoids

Write an expression that calculates trapezoid's area by given sides a and b and height h.
The three values should be read from the console in the order shown below. All three value will be floating-point numbers.
*/
using System;
class Trapezoids
{
   static void Main()
   {
       Console.WriteLine("Write a small-side:");
       double a = double.Parse(Console.ReadLine());
       Console.WriteLine("Write a big-side:");
       double b = double.Parse(Console.ReadLine());
       Console.WriteLine("Write a height:");
       double h = double.Parse(Console.ReadLine());
       double trapArea = ((a + b) / 2) * h;

       Console.WriteLine("{0:f7}", trapArea);
    }
}

