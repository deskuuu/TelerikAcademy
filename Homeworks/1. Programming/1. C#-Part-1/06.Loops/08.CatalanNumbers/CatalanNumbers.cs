/*Problem 8. Catalan Numbers

In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula
Write a program to calculate the nth Catalan number by given n (0 ≤ n ≤ 100).
*/

using System;
using System.Numerics;
class CatalanNumbers
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
        BigInteger sum = SumFactorial(2 * n) / (SumFactorial(n + 1) * SumFactorial(n));
        Console.WriteLine(sum);
    }
}
