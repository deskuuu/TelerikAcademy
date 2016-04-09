/*Problem 10. Point Inside a Circle & Outside of a Rectangle
*/
using System;
class PntInsACirculeOutRect
{
    static void Main()
    {
       
	 double x = double.Parse(Console.ReadLine());
         double y = double.Parse(Console.ReadLine());
     
         //The formula for circle is (x-k)^2 + (y-k)^2 = r^2
         bool IsInCircle = ((x - 1) * (x - 1) + (y - 1) * (y - 1)) <= 1.5 * 1.5;
         bool IsInsideRectangle = (x >= -1 && x <= 5) && (y <= 1 && y >= -1);
         bool isInCircleOutsideRect = IsInCircle && IsInsideRectangle;
         
         if (isInCircleOutsideRect)
         {
         	Console.WriteLine("inside circle inside rectangle");
         }
         else if (IsInCircle && !IsInsideRectangle)
         {
         	Console.WriteLine("inside circle outside rectangle");
         }
         else if (!IsInCircle && IsInsideRectangle)
         {
         	Console.WriteLine("outside circle inside rectangle");
         }
         else if (!IsInCircle && !IsInsideRectangle)
         {
         	Console.WriteLine("outside circle outside rectangle");
         }
   }
}
