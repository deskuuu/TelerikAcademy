/*Problem 16.* Print Long Sequence

Write a program that prints the first 1001 members of the sequence: 2, -3, 4, -5, 6, -7, …
You might need to learn how to use loops in C# (search in Internet).
*/
using System;

class PrintLongSequence
{
    static void Main(string[] args)
    {
        for (int i = 2; i <= 1001; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
            else
            {
                Console.WriteLine("-" + i);
            }
        }

    }
}
