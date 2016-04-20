/*Problem 16. GCD
 
Write a program that calculates the greatest common divisor (GCD) of given two integers A and B.
*/

using System;
class GCD
{
    static int FindGCD(int a,int b)
    {
        int max = Math.Max(a, b);
        int divisor = 0;

        for (int i = 1; i <= max; i++)
        {
            if (a % i == 0 && b % i == 0)
            {
                divisor = i;
            }
        }

        return divisor;
    }

    static void Main()
    {
        string[] numbers = Console.ReadLine().Split(' ');

        int a = int.Parse(numbers[0]);
        int b = int.Parse(numbers[1]);

        Console.Write(FindGCD(a,  b));
    }

}

