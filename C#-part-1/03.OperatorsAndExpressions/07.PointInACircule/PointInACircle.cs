/*Problem 7. Point in a Circle

Write a program that reads the coordinates of a point x and y and using an expression checks if given
point (x, y) is inside a circle K({0, 0}, 2) - the center has coordinates (0, 0) and the circle has radius 2.
The program should then print "yes DISTANCE" if the point is inside the circle or "no DISTANCE" if the point is outside the circle.
*/
using System;
class PointInACircule
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());

        //Formula is (x-k)^2 + (y-k)^2 = r^2
        bool isInside = ((x * x + y * y) - 2 * (x - y + x)) <= 2 * 2;
        Console.WriteLine(isInside);
    }
}

