using System;

class MatrixMath
{
    public static double[,] Inverse2D(double[,] matrix)
    {
        // matrix that contain -1 value to say it fails
        double[,] fail = new double[,] { { -1 } };

        // to check if matrix has same size, if it's 2d
        if (matrix.GetLength(0) != matrix.GetLength(1))
            return fail;

        // to check if matrix has a valid size 2d
        if (matrix.GetLength(0) != 2)
            return fail;

        double determinant_val = matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
        if (determinant_val == 0)
            return fail;

        double[,] transpose_val = { {matrix[1, 1], matrix[0, 1] * -1}, {matrix[1, 0] * -1, matrix[0, 0]} };
        double[,] result_matrix = new double[matrix.GetLength(1), matrix.GetLength(0)];
        for (int i = 0; i < result_matrix.GetLength(0); i++)
        {
            for (int j = 0; j < result_matrix.GetLength(1); j++)
                result_matrix[i, j] = Math.Round(transpose_val[i, j] / determinant_val, 2);
        }

        return result_matrix;
    }
}
