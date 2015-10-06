/*Problem 5. Calculate 1 + 1!/X + 2!/X^2 + … + N!/X^N

Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
Use only one loop. Print the result with 5 digits after the decimal point.
Examples:

n	x	S
3	2	2.75000
4	3	2.07407
5	-4	0.75781
*/
using System;
using System.Numerics;

class CalculateBy2Int
{
        static void Main()
        {
        Console.WriteLine("Enter a first integer n:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter a second integer x:");
        int x = int.Parse(Console.ReadLine());
        int counter = 1;
        double sum = 1;
        double nFactorial = 1;
        double xP = 1;

        while (counter <= n)
        {
            nFactorial *= counter;
            xP = Math.Pow(x, counter);
            sum += (nFactorial / xP);
            counter++;
        }

        Console.WriteLine("S = {0:0.00000}", sum);
    }
    }

