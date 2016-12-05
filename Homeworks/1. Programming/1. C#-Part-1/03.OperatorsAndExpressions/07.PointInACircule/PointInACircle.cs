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
	     
            //The formula is (x-k)^2 + (y-k)^2 = r^2
            double point = Math.Sqrt((x * x) + (y * y));
            bool isInside = point <= 2;
            
            if (isInside)
            {
            	 Console.WriteLine("yes {0:f2}", point);
            }
            else
            {
            	 Console.WriteLine("no {0:f2}", point);
            }
          
    }
}

