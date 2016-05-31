//Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements. Print that sum.
namespace Maximal_Sum
{
    using System;
    using System.Linq;

    class Program
    {
        static int[,] ReadMatrixIndex(int rows,int cols)
        {
            var matrix = new int[rows,cols];

            for (int i = 0; i < rows; i++)
            {
                var values = (Console.ReadLine().Split(' '));
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = int.Parse(values[j]);
                }
            }

            return matrix;
        }

        static int FindMaxSum(int[,] matrix)
        {
            var bestSum = int.MinValue;

            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 1 + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 1 + 1] + matrix[row + 1 + 1, col] + matrix[row + 1 + 1, col + 1] + matrix[row + 1 + 1, col + 1 + 1];

                    if (sum > bestSum)
                    {
                        bestSum = sum;
                    }
                }
            }

            return bestSum;
        }

        static void Main()
        {
            int[] numbers = Console
                 .ReadLine()
                 .Split(' ')
                 .Select(item => int.Parse(item))
                 .ToArray();
            int rows = numbers[0];
            int cols = numbers[1];

            int result = FindMaxSum(ReadMatrixIndex(rows,cols));

            Console.WriteLine(result);
        }
    }
}


