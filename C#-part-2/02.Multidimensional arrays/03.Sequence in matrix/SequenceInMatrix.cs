//Write a program that finds the longest sequence of equal strings in the matrix and prints its length.

namespace _03.Sequence_in_matrix
{
    using System;
    using System.Linq;

    class SequenceInMatrix
    {
        static int[,] ReadMatrixIndex(int rows, int cols)
        {
            var matrix = new int[rows, cols];

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

        static int FindSequences(int[,] matrix)
        {
            int counter = 0;
            int maxCounter = 0;
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    for (int i = col; i < cols - 1; i++)
                    {
                        if (matrix[row, i] == matrix[row, i + 1])
                        {
                            counter++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    if (counter > maxCounter)
                    {
                        maxCounter = counter;
                    }

                    counter = 1;
                }
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
            int result = FindSequences(ReadMatrixIndex(rows, cols));

            Console.WriteLine(result);
        }
    }
}
