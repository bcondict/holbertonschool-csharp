using System;

class MatrixMath
{
    public static double Determinant(double[,] matrix)
    {
        // matrix that contain -1 value to say it fails
        double fail = -1;

        // to check if matrix has same size, if it's 2d
        if (matrix.GetLength(0) != matrix.GetLength(1))
            return fail;

        // to check if matrix has a valid size 2d or 3d 
        if (matrix.GetLength(0) < 2 || matrix.GetLength(0) > 3)
            return fail;

        double determinatn_val = 0;
        if (matrix.GetLength(0) == 2)
        {
            determinatn_val = matrix[0, 0] * matrix[1, 1] + matrix[1, 0] * matrix[0, 1];
            return Math.Round(determinatn_val); 
        }

        if (matrix.GetLength(0) == 3)
        {
            double first_val = 0;
            double second_val = 0;
            double third_val = 0;

            first_val = matrix[0, 0] * (matrix[1, 1] * matrix[2, 2] - matrix[2, 1] * matrix[1, 2]);
            second_val = matrix[0, 1] * (matrix[1, 0] * matrix[2, 2] - matrix[2, 0] * matrix[1, 2]);
            third_val = matrix[0, 2] * (matrix[1, 0] * matrix[2, 1] - matrix[2, 0] * matrix[1, 1]);

            determinatn_val = first_val - second_val + third_val;
        }

        return Math.Round(determinatn_val); 
    }
}
