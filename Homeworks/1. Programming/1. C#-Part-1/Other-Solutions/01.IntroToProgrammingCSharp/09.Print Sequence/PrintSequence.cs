/*Problem 9. Print sequence
Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...
 */
namespace _09.Print_Sequence
{
    using System;

    class PrintSequence
    {
        static void Main()
        {
            int n;

            // Console.WriteLine("Enter a number 'N': ");
            n = 10; // int.Parse(Console.ReadLine());

            PrintSequenceToN(n);
        }

        static void PrintSequenceToN(int n)
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
