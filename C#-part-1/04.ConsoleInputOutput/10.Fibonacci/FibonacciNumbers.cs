/*Problem 10. Fibonacci Numbers

Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence (at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….
Note: You may need to learn how to use loops.

Examples:

n	comments
1	0
3	0 1 1
10	0 1 1 2 3 5 8 13 21 34
*/

using System;
using System.Numerics;

class FibonacciNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter lenght of Fib.Numbers: ");
        int n = int.Parse(Console.ReadLine());
        BigInteger firstNumber = 0;
        BigInteger secondNumber = 1;
        BigInteger temp = 0;
        Console.Write(firstNumber + " " + secondNumber + " ");

        for (int i = 2; i < n; i++)
        {
            temp = firstNumber + secondNumber;
            Console.Write(temp + " ");
            firstNumber = secondNumber;
            secondNumber = temp;

        }
        Console.WriteLine();
    }
}
