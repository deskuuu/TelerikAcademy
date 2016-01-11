/*
Problem 2. Maximal sum

Write a program that reads a rectangular matrix 
of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.
 */
using System;
class MaximalSum
{
	public static void Main()
	{			
		Console.Write("Enter the size of matrix`s rows n:");
		int n = int.Parse(Console.ReadLine());
		Console.Write("Enter the size of matrix`s cols m:");
		int m = int.Parse(Console.ReadLine());
		int[,] matrix = new int[n, m];
       
		int counter = 1;
		int sum = 0;
		int biggestSum = int.MinValue;
        
		
		int[,] biggestSumMatrix = new int[3, 3];
		for (int row = 0; row < matrix.GetLength(0) - 2; row++) {
			for (int col = 0; col < matrix.GetLength(1) - 2; col++) {
				sum = matrix[row, col] + matrix[row + 1, col] + matrix[row + 2, col] + matrix[row, col + 1] + matrix[row, col + 2] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

				if (sum > biggestSum) {
					biggestSum = sum;

					biggestSumMatrix[0, 0] = matrix[row, col];
					biggestSumMatrix[0, 1] = matrix[row, col + 1];
					biggestSumMatrix[0, 2] = matrix[row, col + 2];
					biggestSumMatrix[1, 0] = matrix[row + 1, col];
					biggestSumMatrix[1, 1] = matrix[row + 1, col + 1];
					biggestSumMatrix[1, 2] = matrix[row + 1, col + 2];
					biggestSumMatrix[2, 0] = matrix[row + 2, col];
					biggestSumMatrix[2, 1] = matrix[row + 2, col + 1];
					biggestSumMatrix[2, 2] = matrix[row + 2, col + 2];
				}
			}
		}
		Console.WriteLine("Biggest sum is: {0}", biggestSum);
		Console.WriteLine("3x3 part of the biggest sum: ");
		for (int row = 0; row < biggestSumMatrix.GetLength(0); row++)
            {
                for (int col = 0; col < biggestSumMatrix.GetLength(1); col++)
                {
                    Console.Write("{0} ", biggestSumMatrix[row, col]);
                }

                Console.WriteLine();
            }

        
		Console.Write("Press any key to continue . . . ");
		Console.ReadKey(true);
	}
			
}
