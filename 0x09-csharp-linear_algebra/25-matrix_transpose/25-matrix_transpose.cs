using System;

class MatrixMath
{
    public static double[,] Transpose(double[,] matrix)
    {
        double[,] result_matrix = new double[matrix.GetLength(0), matrix.GetLength(1)];
        if (matrix.GetLength(0) == 0)
            return result_matrix;

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
