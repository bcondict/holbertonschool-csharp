using System;

class Program
{
    static void Main(string[] args)
    {
        double[,] matrix1 = { {1, 2}, {3, 4} };
        double[,] result = MatrixMath.Shear2D(matrix1, 'y', 2);

        for (int i = 0; i < result.GetLength(0); i++)
        {
            for (int j = 0; j < result.GetLength(1); j++)
                Console.Write(result[i, j] + " ");
            Console.Write("\n");
        }
    }
}
