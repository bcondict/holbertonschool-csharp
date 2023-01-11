using System;

class MatrixMath
{
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        // matrix that contain -1 value to say it fails
        double[,] fail = new double[,] { { -1 } };

        // to check if matrix1 have a different size than matrix 2
        if (matrix1.GetLength(0) != matrix2.GetLength(0) || (matrix1.GetLength(1) != matrix2.GetLength(1)))
            return fail;

        if ((matrix1.GetLength(0) > 3 || matrix1.GetLength(0) < 2) || (matrix1.GetLength(1) > 3 || matrix1.GetLength(1) < 2))
            return fail;

        // to check if matrix has same size, if it's 2d or 3d valid
        if (matrix1.GetLength(0) != matrix1.GetLength(1) || matrix2.GetLength(0) != matrix2.GetLength(1))
            return fail;

        double[,] result_matrix = new double[matrix1.GetLength(0), matrix1.GetLength(1)];

        for (int row = 0; row < matrix1.GetLength(0); row++)
        {
            for (int col = 0; col < matrix1.GetLength(1); col++)
                result_matrix[row, col] = matrix1[row, col] + matrix2[row, col];
        }

        return result_matrix;
    }
}
