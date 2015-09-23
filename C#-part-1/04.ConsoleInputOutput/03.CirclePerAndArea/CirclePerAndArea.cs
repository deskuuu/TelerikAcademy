/*Problem 3. Circle Perimeter and Area

Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.
Examples:

r	perimeter	area
2	12.57	12.57
3.5	21.99	38.48
*/
using System;

    class CirclePerAndArea
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Enter a circle radius:");
        double radius = double.Parse(Console.ReadLine());
        double area = (double) Math.PI * radius * radius;
        double perimeter = 2 * (double) Math.PI * radius;
        Console.WriteLine("The perimeter is:");
        Console.WriteLine("{0:0.00}", perimeter);
        Console.WriteLine("The area is :");
        Console.WriteLine("{0:0.00}", area);
       
    }
 }

