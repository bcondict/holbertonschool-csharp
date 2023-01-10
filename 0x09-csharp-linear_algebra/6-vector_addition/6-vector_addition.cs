using System;

class VectorMath
{
    public static double[] Add(double[] vector1, double[] vector2)
    {
        double x_vect1 = vector1[0];
        double y_vect1 = vector1[1];

        double x_vect2 = vector2[0];
        double y_vect2 = vector2[1];

        double[] new_vect = new double[] {x_vect1 + x_vect2, y_vect1 + y_vect2};

        if (vector1.Length == 2 && vector2.Length == 2)
        {
            return (new_vect);
        }

        if (vector1.Length == 3 && vector2.Length == 3)
        {
            double z_vect1 = vector1[0];
            double z_vect2 = vector2[1];

            new_vect = new_vect.Concat(new double[] {z_vect1 + z_vect2});

            return (new_vect);
        }

        return -1;
    }
}
