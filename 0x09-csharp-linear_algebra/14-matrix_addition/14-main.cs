using System;

class Program
{
    static void Main(string[] args)
    {
        // double[,] matrix1 = { {1, 2}, {3, 4} };
        // double[,] matrix2 = { {1, 2}, {3, 4} };
        double[,] matrix1 = { {1, 2, 3}, {4, 5, 6}, {7, 8, 9}};
        double[,] matrix2 = { {1, 2, 3}, {4, 5, 6}, {7, 8, 9}};
        double[,] result = MatrixMath.Add(matrix1, matrix2);

        for (int i = 0; i < result.GetLength(0); i++)
        {
            for (int j = 0; j < result.GetLength(1); j++)
                Console.Write(result[i, j] + " ");
            Console.Write("\n");
        }
    }
}
