namespace PrimeCheck
{
    using System;
    using System.Collections.Generic;

    class PrimeCheck
    {
        static void Main()
        {
            //var number = int.Parse(Console.ReadLine());
            //var isPrime = CheckIsPrime(number);

            //Console.WriteLine(isPrime);

            var from = int.Parse(Console.ReadLine());
            var to = int.Parse(Console.ReadLine());
            var primesInRane = FindPrimesInRane(from, to);

            Console.WriteLine(string.Join(", ", primesInRane));
        }

        private static IList<int> FindPrimesInRane(int from, int to)
        {
            var primes = new List<int>();

            for (int index = from; index <= to; index++)
            {
                if (CheckIsPrime(index))
                {
                    primes.Add(index);
                }
            }

            return primes;
        }

        private static bool CheckIsPrime(int number)
        {
            var isPrime = true;

            if (number == 2)
            {
                return true;
            }
            else if (number < 2)
            {
                return false;
            }

            for (int index = 2; index <= Math.Sqrt(number); index++)
            {
                if (number % index == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            return isPrime;
        }
    }
}
