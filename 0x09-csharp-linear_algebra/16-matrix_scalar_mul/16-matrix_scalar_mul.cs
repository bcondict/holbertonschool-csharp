using System;

class MatrixMath
{
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        // matrix that contain -1 value to say it fails
        double[,] fail = new double[,] { { -1 } };

        // to check if matrix has same size, if it's 2d or 3d valid
        if (matrix.GetLength(0) != matrix.GetLength(1))
            return fail;

        // to check if matrix has a valid size 
        if ((matrix.GetLength(0) > 3 || matrix.GetLength(0) < 2) || (matrix.GetLength(1) > 3 || matrix.GetLength(1) < 2))
            return fail;

        double[,] result_matrix = new double[matrix.GetLength(0), matrix.GetLength(1)];

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
                result_matrix[row, col] = matrix[row, col] * scalar;
        }

        return result_matrix;
    }
}
