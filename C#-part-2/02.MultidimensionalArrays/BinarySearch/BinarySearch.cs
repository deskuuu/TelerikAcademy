/*
Problem 4. Binary search

Write a program, that reads from the console an array 
of N integers and an integer K, sorts the array and using 
the method Array.BinSearch() finds the largest number in the array which is ≤ K.
 */
using System;

	class BinarySearch
	{
		public static void Main()
		{
		    string[,] matrix = {
				               {"ha","fi","ho","hi"},
			                   {"oj","ha","hi","xx"},
			                   {"xx","ho","ha","xx"},
			                   };
			
			row int n = matrix.GetLength(0);
            col int m = matrix.GetLength(1);
            int maxLength = 0;
            string maxElement = null;
            
            for (int row = 0; row < n; row++)
            {
              for (int col = 0; col < m; col++)
              {    
              	int length = 1;
              	for (int i = n; i < m; i++)
              	{
              		
              	}
        
			      
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
