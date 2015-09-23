/*Problem 4. Number Comparer

Write a program that gets two numbers from the console and prints the greater of them.
Try to implement this without if statements.
Examples:

a	b	greater
5	6	6
10	5	10
0	0	0
-5	-2	-2
1.5	1.6	1.6
*/
using System;

class NumberComparer
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Enter a first number:");
        int first = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter a second number:");
        int second = int.Parse(Console.ReadLine());
        bool greater = first == second;
        bool greaterN = first > second;
        Console.WriteLine("The greater is : {0}", greaterN ? "first" : "second");
        Console.WriteLine("The numbers are the same : {0}", greater ? "true" : "false");

        }
    }
