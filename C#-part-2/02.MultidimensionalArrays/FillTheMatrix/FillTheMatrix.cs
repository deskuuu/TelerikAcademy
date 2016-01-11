/*
Problem 1. Fill the matrix

Write a program that fills and prints a matrix of size (n, n) as shown below:
Example for n=4:

1	5	9	13
2	6	10	14
3	7	11	15
4	8	12	16
 */
using System;


	class SequenceNMatrix
	{
		public static void Main()
		{
		Console.Write("Enter the size of matrix n:");
        int n = int.Parse(Console.ReadLine());

        int[,] matrix = new int[n, n];
        int count = 1;
        for (int row = 0; row < matrix.GetLength(0); row++)
            {
            for (int col = 0; col < matrix.GetLength(1); col++)
                {
                matrix[row, col] = count;
                count++;
                }
            }
              for (int row = 0; row < matrix.GetLength(0); row++)
              {
                 for (int col = 0; col < matrix.GetLength(1); col++)
                  {
                 	Console.Write("{0}\t",matrix[row,col]);
                  }
                  Console.WriteLine();
              }
             Console.WriteLine();
             
             Console.Write("Press any key to continue . . . ");
			 Console.ReadKey(true);
		 }
	}
