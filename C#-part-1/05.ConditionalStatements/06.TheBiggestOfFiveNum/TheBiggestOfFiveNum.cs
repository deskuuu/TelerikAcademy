/*Problem 6. The Biggest of Five Numbers

Write a program that finds the biggest of five numbers by using only five if statements.
Examples:

a	b	c	d	e	biggest
5	2	2	4	1	5
-2	-22	1	0	0	1
-2	4	3	2	0	4
0	-2.5	0	5	5	5
-3	-0.5	-1.1	-2	-0.1	-0.1
*/

using System;

    class TheBiggestOfFiveNum
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Enter a first number :");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter a second number :");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter a third number :");
        double c = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter a forth number :");
        double d = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter a fifth number :");
        double e = double.Parse(Console.ReadLine());
        double biggest = 0;

        if (a > b)
        {
            biggest = a;

            if (c > biggest)
            {
                biggest = c;

            }

            if (d > biggest)
            {
                biggest = d;
            }

            if (e > biggest)
            {
                biggest = e;
            }
        }
        else
        {
            biggest = b;

            if (c > biggest)
            {
                biggest = c;
            }

            if (d > biggest)
            {
                biggest = d;
            }

            if (e > biggest)
            {
                biggest = e;
            }
        }

        Console.WriteLine("The biggest is  {0}", biggest);
    }
}
    

