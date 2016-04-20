/*Problem 17. Trailing 0 in N!
 
Write a program that calculates with how many zeroes the factorial of a given number N has at its end.
*/

using System;
class TrailingZero
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int counterZeroes = 0;
        int divider = 5;

        while (n / divider >= 1)
        {
            counterZeroes += n / divider;
            divider *= 5;
        }

        Console.WriteLine(counterZeroes);
    }

}

