/*Problem 7. Calculate N! / (K! * (N-K)!)

In combinatorics, the number of ways to choose k different members out of a group of n different elements
(also known as the number of combinations) is calculated by the following formula: formula For example,
there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). Try to use only two loops.
*/

using System;
  class CalculateCombinatorics
    {
        static void Main()
        {

        Console.WriteLine("Enter a number n:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter a number k:");
        int k = int.Parse(Console.ReadLine());
        int nFactorial = 1;
        int kFactorial = 1;
        int counter = 1;
        int sum = 1;

        while (counter <= n)
        {
            nFactorial *= counter;

            if (counter <= k)
            {
                kFactorial *= counter;
            }
            counter++;
        }

        counter = 1;
        while (counter <= (n - k))
        {
            sum *= counter;
            counter++;
        }

        sum = (nFactorial / (kFactorial * sum));

        Console.WriteLine(sum);
    }
}
       