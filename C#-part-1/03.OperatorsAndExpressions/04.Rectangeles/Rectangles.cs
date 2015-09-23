/*Problem 4. Rectangles

Write an expression that calculates rectangle’s perimeter and area by given width and height.
Examples:

width	height	perimeter	area
3	4	14	12
2.5	3	11	7.5
5	5	20	25
*/
using System;

   class Rectangles
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Write a width :");
        double width = int.Parse(Console.ReadLine());
        Console.WriteLine("Write a height :");
        double height = int.Parse(Console.ReadLine());

        double rectangleArea = width * height;
        double rectanglePerimeter = 2 * (width + height);

        Console.WriteLine("{0}\n{1}\n{2}\n{3}", "The rectangle area is ",rectangleArea, "The rectangle perimeter is ",rectanglePerimeter);
    }
}

