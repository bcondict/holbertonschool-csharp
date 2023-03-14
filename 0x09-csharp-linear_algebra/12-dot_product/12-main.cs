using System;

class Program
{
    static void Main(string[] args)
    {
        double[] vector1 = new double[] {1, 2};
        double[] vector2 = new double[] {1, 2};

        Console.WriteLine(VectorMath.DotProduct(vector1, vector2));
    }
}
