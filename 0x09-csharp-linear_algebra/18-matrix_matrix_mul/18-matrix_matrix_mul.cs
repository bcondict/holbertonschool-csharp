using System;

class MatrixMath
{
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        // matrix that contain -1 value to say it fails
        double[,] fail = new double[,] { { -1 } };

        if (matrix1.GetLength(1) != matrix2.GetLength(0))
            return fail;

        double[,] result_matrix = new double[matrix1.GetLength(0), matrix1.GetLength(1)];
        int row = 0, col = 0;
        double value = 0;
        for (row = 0; row < result_matrix.GetLength(0); row++)
        {
            for (col = 0; col < result_matrix.GetLength(1); col++)
            {
                value = 0;
                for (int inner_row = 0; inner_row < matrix1.GetLength(1); inner_row++)
                {
                    value += matrix1[row, inner_row] * matrix2[inner_row, col];
                }
                result_matrix[row, col] = value;
            }
        }

        return result_matrix;
    }
}
