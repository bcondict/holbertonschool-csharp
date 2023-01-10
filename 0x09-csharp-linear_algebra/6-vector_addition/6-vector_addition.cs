using System;
using System.Collections.Generic;

/// <summary>
/// class that cointain diferent method to handle vectors
/// </summary>
class VectorMath
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="vector1"></param>
    /// <param name="vector2"></param>
    /// <returns></returns>
    public static double[] Add(double[] vector1, double[] vector2)
    {
        double[] fail = new double[] {-1}; 
        if (vector1.Length != vector2.Length)
            return fail;


        if (vector1.Length == 2 || vector1.Length == 3)
        {
            double[] new_vect = new double[vector1.Length];

            for (int i = 0; i < vector1.Length; i++)
            {
                new_vect[i] = vector1[i] + vector2[i];
            }

            return (new_vect);
        }

        return (fail);
    }
}
