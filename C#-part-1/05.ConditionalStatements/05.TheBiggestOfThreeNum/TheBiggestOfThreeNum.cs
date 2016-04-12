/*Problem 5. The Biggest of 3 Numbers

Write a program that finds the biggest of three numbers.
*/

using System;
class TheBiggestOfThreeNum
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        if (a > b || a > c)
        {
            Console.WriteLine(a);
        }
        else if (a < b || b > c)
        {
            Console.WriteLine(b);
        }
        else
        {
            Console.WriteLine(c);
        }
    }
}

