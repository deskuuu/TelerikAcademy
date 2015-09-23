/*Problem 1. Sum of 3 Numbers

Write a program that reads 3 real numbers from the console and prints their sum.
Examples:

a	b	c	sum
3	4	11	18
-2	0	3	1
5.5	4.5	20.1	30.1
*/

using System;

class SumOfThreeNum
    {
        static void Main(string[] args)
        {

        Console.WriteLine("Enter a first number:");
        int first = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter a second number:");
        int second = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter a third number:");
        int third = int.Parse(Console.ReadLine());
        
        Console.WriteLine("The sum of your three numbers is : {0}",first + second + third);

    }
}

