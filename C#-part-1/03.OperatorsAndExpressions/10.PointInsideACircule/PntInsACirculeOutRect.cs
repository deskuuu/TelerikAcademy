/*Problem 10. Point Inside a Circle & Outside of a Rectangle

Write a program that reads a pair of coordinates x and y and uses an expression to checks for given point (x, y)
if it is within the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2).
*/
using System;
class PntInsACirculeOutRect
{
    static void Main()
    {
         double x = double.Parse(Console.ReadLine());
         double y = double.Parse(Console.ReadLine());
     
         //Formula  for circle is (x-k)^2 + (y-k)^2 = r^2
         bool inCircle = ((x - 1) * (x - 1) + (y - 1) * (y - 1)) <= 1.5 * 1.5;
         bool outsideRectangle = (x <= -1 || x >= 6) || (y <= -1 || y >= 2);
         bool inCircleOutsideRect = inCircle && outsideRectangle;
         
         Console.WriteLine(inCircleOutsideRect ? "yes" : "no");
   }
}

