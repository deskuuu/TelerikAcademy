//Write a program that finds the largest area of equal neighbour elements in a rectangular matrix and prints its size.

namespace _07.Largest_area_in_matrix
{
    using System;

    class LargestAreaInMatrix
    {
        static void Main()
        {
            int n = 5;
            var matrix = new int[n, n];


            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write(matrix[row,col]);
                }

                Console.WriteLine();
            }
        }
    }
}
