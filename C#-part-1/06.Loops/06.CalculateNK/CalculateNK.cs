/*Problem 6. Calculate N! / K!

Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
*/
using System;
using System.Numerics;
class CalculateNK
{
    static BigInteger SumFactorial(int n)
    {
        BigInteger result = 1;
        while (true)
        {
            if (n == 1)
            {
                break;
            }
            result *= n;
            n--;
        }
        return result;
    }
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        BigInteger sum = SumFactorial(n) / SumFactorial(k);
        Console.Write(sum);
    }
}
