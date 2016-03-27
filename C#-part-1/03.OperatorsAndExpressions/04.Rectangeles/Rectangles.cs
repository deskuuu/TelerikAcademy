/*Problem 4. Rectangles
Write an expression that calculates rectangle’s perimeter and
area by given width and height. The width and height should be read from the console.
*/
using System;
class IsPrime
{
    static void Main()
    {
    	 Console.WriteLine("Write a width :");
         double width = double.Parse(Console.ReadLine());
         Console.WriteLine("Write a height :");
         double height = double.Parse(Console.ReadLine());
         
         double rectangleArea = width * height;
         double rectanglePerimeter = 2 * (width + height);
         
         Console.WriteLine("{0:f2} {1:f2}",rectanglePerimeter,rectangleArea);
    }
}
     

