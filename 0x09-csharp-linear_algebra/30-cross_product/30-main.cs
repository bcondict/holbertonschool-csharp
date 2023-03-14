using System;

class Program
{
    static void Main(string[] args)
    {
        double[] test1 = {1, 2, 3};
        double[] test2 = {1, 2, 3};
        // double[] test1 = {2, -2, 1};
        // double[] test2 = {-8, 8, -4};

        double[] result = VectorMath.CrossProduct(test1, test2);

        for (int i = 0; i < 3; i++)
            Console.WriteLine("res = " + result[i]);
    }
}
