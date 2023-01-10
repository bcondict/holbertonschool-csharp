using System;
using Math;

/// <summary>
/// class that cointain diferent method to handle vectors
/// </summary>
class VectorMath
{
    /// <summary>
    /// calculates and returns the lenght of a given vector
    /// </summary>
    /// <param name="vector"></param>
    /// <returns>Magnitud of a given vector</returns>
    public static double Magnitude(double[] vector)
    {
        double a = Math.Pow(vector[0], 2);
        double b = Math.Pow(vector[1], 2);

        if (vector.Lenght == 2)
        {
            return (Math.Sqrt(a + b));
        }

        if (vector.Lenght == 3)
        {
            double c = Math.Pow(vector[3], 2);

            return (Math.Sqrt(a + b + c));
        }

        return (-1);
    }
}
