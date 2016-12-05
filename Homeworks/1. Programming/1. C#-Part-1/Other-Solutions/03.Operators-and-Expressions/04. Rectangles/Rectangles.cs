/*Problem 4. Rectangles
Write an expression that calculates rectangle’s perimeter and
area by given width and height. The width and height should be read from the console.
*/
namespace _04.Rectangles
{
    using System;

    class Rectangles
    {
        static void Main()
        {
            double rectangleWidth = double.Parse(Console.ReadLine());
            double rectangleHeght = double.Parse(Console.ReadLine());

            double rectangleArea= CalculateRectangleArea(rectangleWidth, rectangleHeght);
            double rectanglePerimeter = CalculateRectanglePerimeter(rectangleWidth, rectangleHeght);
           
            // Console.WriteLine($"{rectangleArea:F2} {rectanglePerimeter:F2}");
            Console.WriteLine("{0:F2} {1:F2}", rectangleArea, rectanglePerimeter);
        }

        static double CalculateRectangleArea(double rectangleWidth, double rectangleHeght)
        {
            double rectangleArea = rectangleWidth * rectangleHeght;

            return rectangleArea;
        }

        static double CalculateRectanglePerimeter(double rectangleWidth, double rectangleHeght)
        {
            double rectanglePerimeter = 2 * (rectangleWidth + rectangleHeght);

            return rectanglePerimeter;
        }
    }
}
