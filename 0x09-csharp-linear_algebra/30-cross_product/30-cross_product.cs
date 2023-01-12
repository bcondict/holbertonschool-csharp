using System;

class VectorMath
{
    public static double[] CrossProduct(double[] vector1, double[] vector2)
    {
        // matrix that contain -1 value to say it fails
        double[] fail = new double[] { -1 };

        // to check if matrix has same size, if it's 2d
        if (vector1.Length != vector2.Length)
            return fail;

        // to check if vect has sizes 3d
        if (vector1.Length != 3)
            return fail;

        double[] new_vector = new double[vector1.Length]; 

        new_vector[0] = vector1[1] * vector2[2] - vector1[2] * vector2[1];
        new_vector[1] = vector1[2] * vector2[0] - vector1[0] * vector2[2];
        new_vector[2] = vector1[0] * vector2[1] - vector1[1] * vector2[0];

        return new_vector;
    }
}
