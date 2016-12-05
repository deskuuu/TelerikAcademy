namespace _08.Matrix
{
    using System;
    using System.Text;

    public class Matrix<T>
    {
        // Define a class Matrix<T> to hold a matrix of numbers(e.g.integers, floats, decimals).
        private T[,] matrix;

        public Matrix(int row, int col)
        {
            this.Row = row;
            this.Col = col;
            matrix = new T[row, col];
        }

        public int Col { get; set; }
        public int Row { get; set; }
        // Implement an indexer this[row, col] to access the inner matrix cells.
        public T this[int row, int col]
        {
            get
            {
                return matrix[row, col];
            }
            set
            {
                matrix[row, col] = value;
            }
        }

        // Implement the operators + and - (addition and subtraction of matrices of the same size) and* for matrix multiplication.
        // Throw an exception when the operation cannot be performed.
        // Implement the true operator (check for non-zero elements).
        public static Matrix<T> operator +(Matrix<T> m1, Matrix<T> m2)
        {
            CheckMatrices(m1, m2);

            int rows = m1.matrix.GetLength(0);
            int cols = m1.matrix.GetLength(1);
            var newMatrix = new Matrix<T>(rows, cols);

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    newMatrix[row, col] = (dynamic)m1[row, col] + m2[row, col];
                }
            }

            return newMatrix;
        }

        public static Matrix<T> operator -(Matrix<T> m1, Matrix<T> m2)
        {
            CheckMatrices(m1, m2);

            int rows = m1.matrix.GetLength(0);
            int cols = m1.matrix.GetLength(1);
            var newMatrix = new Matrix<T>(rows, cols);

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    newMatrix[row, col] = (dynamic)m1[row, col] - m2[row, col];
                }
            }

            return newMatrix;
        }

        public static Matrix<T> operator *(Matrix<T> m1, Matrix<T> m2)
        {
            CheckMatrices(m1, m2);

            int rows = m1.matrix.GetLength(0);
            int cols = m1.matrix.GetLength(1);
            var newMatrix = new Matrix<T>(rows, cols);

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    newMatrix[row, col] = (dynamic)m1[row, col] * m2[row, col];
                }
            }

            return newMatrix;
        }

        public static bool operator true(Matrix<T> matrix)
        {
            var isTrue = true;
            int rows = matrix.matrix.GetLength(0);
            int cols = matrix.matrix.GetLength(1);

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if ((dynamic)matrix[row, col] == 0)
                    {
                        isTrue = false;
                    }
                }
            }

            return isTrue;
        }

        public static bool operator false(Matrix<T> matrix)
        {
            var isFalse = false;
            int rows = matrix.matrix.GetLength(0);
            int cols = matrix.matrix.GetLength(1);

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if ((dynamic)matrix[row, col] != 0)
                    {
                        isFalse = true;
                    }
                }
            }

            return isFalse;
        }

        public override string ToString()
        {
            StringBuilder matrixResult = new StringBuilder();

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrixResult.AppendFormat("{0,5} ", matrix[row, col]);
                }
                matrixResult.Append("\n");
            }

            return matrixResult.ToString();
        }

        private static void CheckMatrices(Matrix<T> m1, Matrix<T> m2)
        {
            if ((m1.matrix.GetLength(0) != m2.matrix.GetLength(0))
                && m1.matrix.GetLength(1) != m2.matrix.GetLength(1))
            {
                throw new ArgumentException("Matrices must have the same dimensions.");
            }
        }
    }
}
