namespace _08.Matrix
{
    using System;

    class TestMatrix
    {
        static void Main()
        {
            int row = 4, col = 5;
            var matrixOne = new Matrix<int>(row, col);
            for (int r = 0; r < row; r++)
            {
                for (int c = 0; c < col; c++)
                {
                    matrixOne[r, c] = r + c;
                }
            }

            Console.WriteLine("Matrix One:");
            Console.WriteLine(matrixOne.ToString());

            var matrixTwo = new Matrix<int>(row, col);
            for (int r = 0; r < row; r++)
            {
                for (int c = 0; c < col; c++)
                {
                    matrixTwo[r, c] = (r + c) * 2;
                }
            }

            Console.WriteLine("Second matrix:");
            Console.WriteLine(matrixOne.ToString());

            var sum = matrixOne + matrixTwo;
            Console.WriteLine($"Sum: \n{sum.ToString()}");
            var minus = matrixOne - matrixTwo;
            Console.WriteLine($"Minus:\n {minus.ToString()}");
            var multy = matrixOne * matrixTwo;
            Console.WriteLine($"Multy: \n{multy.ToString()}");
        }
    }
}
