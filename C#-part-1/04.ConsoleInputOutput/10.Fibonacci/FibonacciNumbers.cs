/*Problem 10. Fibonacci Numbers

Write a program that reads a number n and prints on the console the first n members of the 
Fibonacci sequence (at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….
*/
using System;
using System.Numerics;
class FibonacciNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        BigInteger firstNumber = 0;
        BigInteger secondNumber = 1;
        BigInteger temp = 0;
        int i = 2;
        
        if (n == 1)
        {
           Console.WriteLine(firstNumber);
           return;
        }
        else if (n == 2)
        {
           Console.WriteLine(firstNumber + ", " + secondNumber);
           return;
        }
        Console.Write(firstNumber + ", " + secondNumber + ", ");

        for (i = 2; i < n - 1; i++)
        {
           temp = firstNumber + secondNumber;
           Console.Write(temp + ", ");
           firstNumber = secondNumber;
           secondNumber = temp;
        }
        i++;
        
        temp = firstNumber + secondNumber;
        
        if (i == n)
        {
           Console.Write(temp);
        }
        Console.WriteLine();
    }
}
