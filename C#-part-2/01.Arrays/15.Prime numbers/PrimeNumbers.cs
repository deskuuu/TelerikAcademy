//Write a program that finds all prime numbers in the range[1...N]. Use the Sieve of Eratosthenes algorithm.The program should print the biggest prime number which is <= N.
namespace _15.Prime_numbers
{
    using System;

    class PrimeNumbers
    {
        static void FindMostPrmeNumbersFromN(int n)
        {
            for (int i = n; i >= 1; i--)
            {
                bool isPrime = true;

                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }

        static void Main()
        {
            int input = int.Parse(Console.ReadLine());

            FindMostPrmeNumbersFromN(input);
        }
    }
}
