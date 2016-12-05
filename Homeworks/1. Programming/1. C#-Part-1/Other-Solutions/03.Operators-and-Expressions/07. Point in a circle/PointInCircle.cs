/*Problem 7. Point in a Circle
Write a program that reads the coordinates of a point x and y and using an expression checks if given
point (x, y) is inside a circle K({0, 0}, 2) - the center has coordinates (0, 0) and the circle has radius 2.
The program should then print "yes DISTANCE" if the point is inside the circle or "no DISTANCE" if the point is outside the circle.
*/
namespace _07.Point_in_a_circle
{
    using System;

    class PointInCircle
    {
        static void Main()
        {
            double pointX = double.Parse(Console.ReadLine());
            double pointY = double.Parse(Console.ReadLine());
            int radius = 2; // int.Parse(Console.ReadLine());

            IsInCircle(pointX, pointY, radius);
        }

        static void IsInCircle(double pointX, double pointY, int radius)
        {
            //The formula is (x-k)^2 + (y-k)^2 = r^2
            double pointCordinates = Math.Sqrt((pointX * pointX) + (pointY * pointY));
            bool isInside = pointCordinates <= radius;

            Console.WriteLine(isInside ? "yes {0:F2}" : "no {0:F2}", pointCordinates);
        }
    }
}
