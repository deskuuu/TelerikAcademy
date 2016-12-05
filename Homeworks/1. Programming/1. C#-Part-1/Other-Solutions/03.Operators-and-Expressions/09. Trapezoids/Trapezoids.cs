/*Problem 9. Trapezoids
Write an expression that calculates trapezoid's area by given sides a and b and height h.
The three values should be read from the console in the order shown below. All three value will be floating-point numbers.
*/
namespace _09.Trapezoids
{
    using System;

    class Trapezoids
    {
        static void Main()
        {
            double sideA = double.Parse(Console.ReadLine());
            double sideB = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double trapArea = CalculateTrapezoidArea(sideA, sideB, height);

            // Console.WriteLine($"{trapArea:F7}");
            Console.WriteLine("{0:F7}", trapArea);
        }

        static double CalculateTrapezoidArea(double sideA,double sideB,double height)
        {
            double trapezoidArea = ((sideA + sideB) / 2) * height;

            return trapezoidArea;
        }
    }
}
