﻿/*Problem 1. Odd or Even Integers

Write an expression that checks if given integer is odd or even.
Examples:

n	Odd?
3	true
2	false
-2	false
-1	true
0	false
*/
using System;

  class OddOrEvenIntegers
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Write an integer.");
        int number = int.Parse(Console.ReadLine());

        if (number % 2 == 0)
        {
            Console.WriteLine("The integer is even.");
        }
        else
        {
            Console.WriteLine("The integere is odd.");
        }


    }
 }

