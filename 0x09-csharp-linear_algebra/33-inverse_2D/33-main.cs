using System;

class Program
{
    static void Main(string[] args)
    {
        double[,] matrix1 = { {1, 2}, {3, 4} };
        double[,] result = MatrixMath.Inverse2D(matrix1);

        to_print(result);

    }
    static void to_print(double[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
                Console.Write(matrix[i, j] + " ");
            Console.Write("\n");
        }
    }
}
