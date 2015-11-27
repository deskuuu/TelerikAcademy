/*
 Write a program that reads two integer numbers N and K and an array of N elements from the console.
 Find in the array those K elements that have maximal sum.
 */
using System;

	class MaximalKSum
	{
	       static void Main()
		{
			Console.WriteLine("Enter Lenht of array N:");
			int n = int.Parse(Console.ReadLine());
			Console.WriteLine("Enter maximal sum in K elements of array:");
			int k = int.Parse(Console.ReadLine());
			int[] arr = new int[n];
			int sum = 0;
			
			for (int i = 0; i < arr.Length; i++)
			{
				arr[i] = int.Parse(Console.ReadLine());
			}
			
			foreach (int item in arr)
            {
            Console.Write(item + ",");
            }
			Console.WriteLine();
			
			for (int i = 0; i < arr.Length - 1; i++) 
            {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] > arr[j])
                {
                    int tmp = arr[j];
                    arr[j] = arr[i];
                    arr[i] = tmp;
                }
            }
            for (int l = n - 1; l >= (n - k); l--) 
            {
            sum += arr[i];
            }
            Console.WriteLine();
        }
		}
	}
