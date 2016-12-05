//Write a program to calculate N!.
namespace _10.N_Factorial
{
    using System;
    using System.Numerics;

    class NFactorial
    {
        static BigInteger Factorial(int n)
        {
            BigInteger result = 1;
            BigInteger num = n;

            for (int i = 1; i <= n; i++)
            {
                result *= num;
                num--;
            }

            return result;
        }

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger output = Factorial(n);

            Console.WriteLine(output);
        }
    }
}
