/*Problem 10. Point Inside a Circle & Outside of a Rectangle
Write a program that reads a pair of coordinates x and y and 
uses an expression to checks for given point(x, y) if it is within the 
circle K({ 1, 1}, 1.5) and out of the rectangle R(top= 1, left= -1, width= 6, height= 2).
*/
namespace _10.Point_InsideCircleOutsideRectangle
{
    using System;

    class PointInsideCircleOutsideRectangle
    {
        static void Main()
        {
            double pointX = double.Parse(Console.ReadLine());
            double pointY = double.Parse(Console.ReadLine());
            double radius = 1.5; // int.Parse(Console.ReadLine());

            int left = -1;// int.Parse(Console.ReadLine());
            int top = 1;// int.Parse(Console.ReadLine());
            int width = 5;// int.Parse(Console.ReadLine());

            bool isInCircle = IsInCircle(pointX, pointY, radius);
            bool isInRectangle = IsInsideRectangle(pointX, pointY, left, top, width);

            if (isInCircle && isInRectangle)
            {
                Console.WriteLine("inside circle inside rectangle");
            }
            if (!isInCircle && isInRectangle)
            {
                Console.WriteLine("outside circle inside rectangle");
            }
            if (isInCircle && !isInRectangle)
            {
                Console.WriteLine("inside circle outside rectangle");
            }
            if (!isInCircle && !isInRectangle)
            {
                Console.WriteLine("outside circle outside rectangle");
            }
        }

        static bool IsInCircle(double pointX, double pointY, double radius)
        {
            int x0 = 1;
            int y0 = 1;

            bool isInCircle = Math.Sqrt(pointX - x0) + Math.Sqrt(pointY - y0) <= Math.Sqrt(radius);

            return isInCircle;
        }

        static bool IsInsideRectangle(double pointX, double pointY, int left, int top, int width)
        {
            bool isInsideRect = (pointX >= left && pointX <= width) && (pointY <= top && pointY >= left);

            return isInsideRect;
        }
    }
}
