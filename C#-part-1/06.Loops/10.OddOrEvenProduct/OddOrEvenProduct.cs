/*Problem 10. Odd and Even Product

You are given n integers (given in a single line, separated by a space).
Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
Elements are counted from 1 to n, so the first element is odd, the second is even, etc.
*/

using System;

    class OddOrEvenProduct
    {
        static void Main()
        {
        Console.WriteLine("Enter numbers separated by space:");
        string[] input = Console.ReadLine().Trim().Split(' ');
        decimal oddP = 1;
        decimal evenP = 1;

        foreach (string num in input)
        {
            if (int.Parse(num) % 2 == 0)
            {
                oddP *= int.Parse(num);
            }
            else
            {
                evenP *= int.Parse(num);
            }
        }
        string isEqual = (oddP == evenP) ? "is equal" : "isn`t equal";
        Console.WriteLine("The product of the even elements {0} {1} to the product of the odd elements {2}.", evenP, isEqual, oddP);
        }
    }

