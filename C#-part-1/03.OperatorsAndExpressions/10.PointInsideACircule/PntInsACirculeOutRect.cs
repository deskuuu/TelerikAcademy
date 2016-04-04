/*Problem 10. Point Inside a Circle & Outside of a Rectangle

Write a program that reads a pair of coordinates x and y and uses an expression to checks for given point (x, y) 
if it is within the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2).
*/
using System;
class PointCircleRectangle
	{
		public static void Main()
		{
		 double x = double.Parse(Console.ReadLine());
         double y = double.Parse(Console.ReadLine());
          
         bool isInCircle = (x - 1) * (x - 1) + (y - 1) * (y - 1) <= 1.5 * 1.5;
         bool isInRectangle = (x >= 1 || x <= 6) && (y <= -1 || y >= 2);
         bool isCircleOutsideRect = isInCircle && isInRectangle;
         
         if (isCircleOutsideRect)
         {
         	Console.WriteLine("inside circle outside rectangle");
         }
         else if (isInCircle && !isInRectangle)
         {
         	Console.WriteLine("inside circle inside rectangle");
         }
         else if (!isInCircle && isInRectangle)
         {
         	Console.WriteLine("outside circle outside rectangle");
         }
         else if (!isInCircle && !isInRectangle)
         {
         	Console.WriteLine("outside circle inside rectangle");
         }
		
		}
	}

