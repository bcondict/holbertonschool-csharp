using System;

class MatrixMath
{
    public static double[,] Shear2D(double[,] matrix, char direction, double factor)
    {
        // matrix that contain -1 value to say it fails
        double[,] fail = new double[,] { { -1 } };

        if (direction != 'x' && direction != 'y')
            return fail;

        // to check if matrix has same size, if it's 2d
        if (matrix.GetLength(0) != matrix.GetLength(1))
            return fail;

        // to check if matrix has a valid size 
        if (matrix.GetLength(0) != 2)
            return fail;

        double[,] result_matrix = new double[matrix.GetLength(0), matrix.GetLength(1)];
        if (direction == 'x')
        {
            result_matrix[0, 0] = matrix[0, 0] + factor * matrix[0, 1];
            result_matrix[0, 1] = matrix[0, 1];
            result_matrix[1, 0] = matrix[1, 0] + factor * matrix[1, 1];
            result_matrix[1, 1] = matrix[1, 1];
        }

        if (direction == 'y')
        {
            result_matrix[0, 0] = matrix[0, 0];
            result_matrix[0, 1] = matrix[0, 1] + factor * matrix[0, 0];
            result_matrix[1, 0] = matrix[1, 0];
            result_matrix[1, 1] = matrix[1, 1] + factor * matrix[1, 0];
        }

        return result_matrix;
    }
}
