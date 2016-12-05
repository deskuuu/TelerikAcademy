/*Problem 16. Long sequence
Write a program that prints the first 1000 members of the sequence: 2, -3, 4, -5, 6, -7, …
 */
namespace _16.PrintLongSequence
{
    using System;

    class PrintLongSequence
    {
        static void Main()
        {
            int n;

            // Console.WriteLine("Enter a number 'N': ");
            n = 1000; // int.Parse(Console.ReadLine());

            PrintLongSequenceToN(n);
        }

        static void PrintLongSequenceToN(int n)
        {
            bool condition;

            for (int i = 2; i <= n + 1; i++)
            {
                condition = i % 2 == 0; // (i & 1) == 0

                Console.WriteLine(condition ? i : -i);
            }
        }
    }
}
