/*Problem 1. Exchange If Greater

Write an if-statement that takes two double variables a and b and exchanges their values if the first one is greater than the second one. As a result print the values a and b, separated by a space.
Examples:

a	b	result
5	2	2 5
3	4	3 4
5.5	4.5	4.5 5.5
*/

using System;

    class ExchangeIfGreater
{
        static void Main(string[] args)
        {
        Console.WriteLine("Enter variable a :");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter variable b :");
        double b = double.Parse(Console.ReadLine());

        if ( a > b)
        {
            Console.WriteLine("{0} , {1}", b, a);
        }
        else
        {
            Console.WriteLine("{0} , {1}", a, b);
        }
    }
 }

