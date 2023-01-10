using System;

class VectorMath
{
    public static double[] Multiply(double[] vector, double scalar)
    {
        double[] fail = new double[] {-1}; 
        if (vector.Length > 3 || vector.Length < 2)
            return fail;

        double[] new_vect = new double[vector.Length];
        for (int i = 0; i < vector.Length; i++)
            new_vect[i] = vector[i] * scalar;

        return new_vect;
    }
}
