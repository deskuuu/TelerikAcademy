//n the first line you will receive the number N
//On the second line you will receive a character(a, b, c, d*) which determines how to fill the matrix
namespace _01.Fill_the_matrix
{
    using System;

    class FillTheMatrix
    {

        static int[,] MatrixA(int input)
        {
            var matrix = new int[input, input];
            int current = 1;

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    matrix[cols, rows] = current;
                    current++;
                }
            }

            return matrix;
        }

        static int[,] MatrixB(int input)
        {
            var matrix = new int[input, input];
            int current = 1;

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                if (rows % 2 == 0)
                {
                    for (int cols = 0; cols < matrix.GetLength(1); cols++)
                    {
                        matrix[cols, rows] = current++;
                    }
                }
                else
                {
                    for (int cols = matrix.GetLength(1) - 1; cols >= 0; cols--)
                    {
                        matrix[cols, rows] = current++;
                    }
                }
            }

            return matrix;
        }

        static int[,] MatrixC(int input)
        {
            var matrix = new int[input, input];
            int current = 1;

            for (int row = input - 1; row >= 0; row--)
            {
                for (int col = 0; col < input - row; col++)
                {
                    matrix[row + col, col] = current++;
                }
            }

            for (int col = 1; col < input; col++)
            {
                for (int row = 0; row < input - col; row++)
                {
                    matrix[row, col + row] = current++;
                }
            }

            return matrix;
        }

        static int[,] MatrixD(int input)
        {
            var matrix = new int[input, input];
            int[] rowDRUL = new int[] { 1, 0, -1, 0 };
            int[] colDRUL = new int[] { 0, 1, 0, -1 };
            int direction = 0;
            int number = 1;
            int row = 0;
            int col = 0;
            int nextRow;
            int nextCol;

            while (number <= input * input)
            {
                matrix[row, col] = number++;
                nextRow = row + rowDRUL[direction];
                nextCol = col + colDRUL[direction];

                if ((nextRow < 0 || nextRow >= input) ||
                    (nextCol < 0 || nextCol >= input) ||
                    matrix[nextRow, nextCol] != 0)
                {
                    direction = (direction + 1) % 4;
                }

                row += rowDRUL[direction];
                col += colDRUL[direction];
            }
            
            return matrix;
        }
        static void PrintMatrix(int[,] arr)
        {
            for (int row = 0; row < arr.GetLength(0); row++)
            {
                for (int col = 0; col < arr.GetLength(1); col++)
                {
                    if (col == arr.GetLength(1) - 1)
                    {
                        Console.Write(arr[row, col]);
                        continue;
                    }
                    Console.Write("{0} ", arr[row, col]);
                }

                Console.WriteLine();
            }
        }

        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            char inputC = char.Parse(Console.ReadLine());

            if (inputC == 'a')
            {
                PrintMatrix(MatrixA(input));
            }
            else if (inputC == 'b')
            {
                PrintMatrix(MatrixB(input));
            }
            else if (inputC == 'c')
            {
                PrintMatrix(MatrixC(input));
            }
            else if (inputC == 'd')
            {
                PrintMatrix(MatrixD(input));
            }
        }
    }
}
