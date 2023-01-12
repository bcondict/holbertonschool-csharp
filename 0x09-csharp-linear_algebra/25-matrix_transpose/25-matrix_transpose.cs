using System;

class MatrixMath
{
    public static double[,] Transpose(double[,] matrix)
    {
        double[,] result_matrix = new double[matrix.GetLength(1), matrix.GetLength(0)];

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                result_matrix[col, row] = matrix[row, col];
            }
        }

        return result_matrix;
    }
}
