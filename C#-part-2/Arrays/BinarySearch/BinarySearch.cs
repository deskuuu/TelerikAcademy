/*
Problem 11. Binary search

Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.
 */
using System;

	class BinarySearch
	{
		public static void Main()
		{
	    int[] bSearch = { 7, 14, 2, 5, 7, 9, 15, 77, 7 };
        Array.Sort(bSearch);
        int element = int.Parse(Console.ReadLine());
        Console.WriteLine(Array.BinarySearch(bSearch, element));
		}
	}
