/*Problem 8. Numbers from 1 to n

Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n], each on a single line.
Note: You may need to use a for-loop.

*/
using System;

    class NumFromOneToN
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Enter a number:");
        
        int number = int.Parse(Console.ReadLine());

        for (int i = 0; i < number; i++)
        {

            Console.WriteLine("\n {0}",i);
        }

     }
  }
