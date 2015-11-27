/*
Problem 8. Maximal sum

Write a program that finds the sequence of maximal sum in given array.
 */
using System;


	class Program
	{
		public static void Main()
		{
	    Console.Write("Enter the array lenght:");
        int n = int.Parse(Console.ReadLine());

        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter element[{0}]: ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        
        Console.WriteLine(string.Join(",", array));
        Console.WriteLine();
        
        
		}
	}
