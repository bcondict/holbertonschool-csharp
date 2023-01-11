using System;

/// <summary>
/// class that cointain diferent method to handle vectors
/// </summary>
class VectorMath
{
    /// <summary>
    /// calculates and returns the lenght of a given vector
    /// </summary>
    /// <param name="vector">Vector to find the magnitud</param>
    /// <returns>Magnitud of a given vector</returns>
    public static double Magnitude(double[] vector)
    {
        double b = Math.Pow(vector[1], 2);

        if (vector.Length == 2)
        {
            double res = Math.Pow(vector[0], 2) + Math.Pow(vector[1], 2);
            return (Math.Round(Math.Sqrt(res), 2));
        }

        if (vector.Length == 3)
        {
            double res = Math.Pow(vector[0], 2) + Math.Pow(vector[1], 2) + Math.Pow(vector[2], 2);
            return (Math.Round(Math.Sqrt(res), 2));
        }

        return -1;
    }
}
