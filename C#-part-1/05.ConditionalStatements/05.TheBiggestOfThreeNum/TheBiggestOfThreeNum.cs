/*Problem 5. The Biggest of 3 Numbers

Write a program that finds the biggest of three numbers.
Examples:

a	b	c	biggest
5	2	2	5
-2	-2	1	1
-2	4	3	4
0	-2.5	5	5
-0.1	-0.5	-1.1	-0.1
*/

using System;

    class TheBiggestOfThreeNum
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Enter a first number :");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter a second number :");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter a third number :");
        double c = double.Parse(Console.ReadLine());

        if (a > b  || a > c)
        {
            Console.WriteLine("The biggest is {0}", a);
        }
        else if (a < b || b > c)
        {
            Console.WriteLine("The biggest is {0}", b);
        }
        else
        {
            Console.WriteLine("The biggest is {0}", c);
        }
    }
}

