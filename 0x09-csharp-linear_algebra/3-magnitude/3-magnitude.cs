using System;

/// <summary>
/// class that cointain diferent method to handle vectors
/// </summary>
class VectorMath
{
    /// calculates and returns the lenght of a given vector
    /// </summary>
    /// <param name="vector"></param>
    /// <returns>Magnitud of a given vector</returns>
    public static double Magnitude(double[] vector)
    {
        double a = Math.Pow(vector[0], 2);
        double b = Math.Pow(vector[1], 2);

        if (vector.Length == 2)
        {
            return (Math.Round(Math.Sqrt(a + b), 2));
        }

        if (vector.Length == 3)
        {
            double c = Math.Pow(vector[2], 2);

            return (Math.Round(Math.Sqrt(a + b + c), 2));
        }

        return (-1);
    }
}
