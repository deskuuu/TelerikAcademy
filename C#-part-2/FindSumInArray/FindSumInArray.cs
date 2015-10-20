/*
Problem 10. Find sum in array

Write a program that finds in given array of integers a sequence of given sum S (if present).
 */
using System;


	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Write the lenght of an array:");
			int n = int.Parse(Console.ReadLine());
			int[] arr = new int[n];
			Console.WriteLine("Write the sum to check- S of an array:");
			int sum = int.Parse(Console.ReadLine());
			
			for (int i = 0; i < arr.Length; i++)
			{
				Console.Write("Enter element[{0}]: ", i);
				arr[i] = int.Parse(Console.ReadLine());
			}
			
			int currSum = 0;
            int start = 0;
            int sequence = 0;
            bool isSum = false;
            for (int k = 0; k < arr.Length; k++)
            {
               for (int l = k; l < arr.Length; l++)
               {     
                currSum += arr[l];

                 if (currSum == sum)
                 {
                    start = k;
                    sequence = l - k;
                    isSum = true;
                 }
               }
              currSum = 0;
            }

           if (isSum==false)
           {
            sequence = 0;
           }
           else
           {
            sequence++;
           }
        
        Console.WriteLine("The needed sum is present in the array -> {0}", isSum);
        Console.WriteLine("For sum S={0}", sum);
        Console.Write("The sequence of elements is: {");
		}
	}
