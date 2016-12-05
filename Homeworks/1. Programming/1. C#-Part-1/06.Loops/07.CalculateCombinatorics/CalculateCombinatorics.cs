/*Problem 7. Calculate N! / (K! * (N-K)!)

Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). Try to use only two loops.
*/
using System;
using System.Numerics;
class CalculateCombinatorics
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
    	
      BigInteger sum = SumFactorial(n) / (SumFactorial(k) * SumFactorial(n-k));
      Console.WriteLine(sum);
    }
}
