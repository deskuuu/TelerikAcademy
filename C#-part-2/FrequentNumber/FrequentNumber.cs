/*
Problem 9. Frequent number

Write a program that finds the most frequent number in an array.
 */
using System;


	class FrequentNumber
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Write lenght of an array:");
			int n = int.Parse(Console.ReadLine());
			int[] arr = new int[n];
			
			for (int i = 0; i < n; i++)
            {
            Console.Write("Enter element[{0}]: ", i);
            arr[i] = int.Parse(Console.ReadLine());
            }
			
			Console.WriteLine(string.Join(",", arr));
            Console.WriteLine();
		    
			int biggestCounter = 0;
            int frequentNum = 0;			
			int counter = 1;
			for (int i = 0; i < arr.Length - 1; i++)
            {
            if (arr[i] == arr[i + 1])
            {
                counter++;
            }
            else 
            {
                if (counter > biggestCounter)
                {
                    biggestCounter = counter;
                    frequentNum = arr[i];
                }
                counter = 1;
            }
            }
            Console.WriteLine("{0} ({1} times)", frequentNum, biggestCounter);
			
		}
	}
