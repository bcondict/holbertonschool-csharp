using System;

class Program
{
    static void Main(string[] args)
    {
        // double[,] matrix1 = { {1, 2}, {3, 4} };
        // double[,] matrix1 = { {1, 2, 3}, {4, 5, 6}, {7, 8, 9}};
        double[,] matrix1 = { {11, 8, 7}, {2, 13, 1}, {4, 0, 17}};
        double[,] result = MatrixMath.Transpose(matrix1);

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
