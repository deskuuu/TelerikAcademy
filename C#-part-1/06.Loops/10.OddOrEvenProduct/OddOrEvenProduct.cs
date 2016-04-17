/*Problem 10. Odd and Even Product

You are given n integers (given in a single line, separated by a space).
Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
*/
using System;
class OddOrEvenProduc
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string input = Console.ReadLine();
        var arrayOfNumbers = input.Split(' ');
        long oddSum = 1;
        long evenSum = 1;

        for (int i = 1; i < arrayOfNumbers.Length + 1; i++)
        {
            if (i % 2 != 0)
            {
                oddSum *= int.Parse(arrayOfNumbers[i - 1]);
            }
            else
            {
                evenSum *= int.Parse(arrayOfNumbers[i - 1]);
            }
        }
        bool isEqual = (oddSum == evenSum);
        Console.WriteLine(isEqual ? "yes {0}" : "no {0} {1}", oddSum, evenSum);
    }
}
