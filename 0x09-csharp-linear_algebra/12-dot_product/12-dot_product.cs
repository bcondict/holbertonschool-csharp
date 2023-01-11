using System;

class VectorMath
{
    public static double DotProduct(double[] vector1, double[] vector2)
    {
        if (vector1.Length != vector2.Length)
            return -1;

        if (vector1.Length > 3 || vector1.Length < 2)
            return -1

        double[] new_vect = new double[vector.Length];
        double result = 0;

        for (int i = 0; i < vector1.Length; i++)
            new_vect[i] = vector1[i] * vector2[i];

        for (int i = 0; i < vector1.Length; i++)
            result += new_vect[i];

        return result;
    }
}
