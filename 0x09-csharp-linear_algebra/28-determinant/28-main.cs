using System;

class Program
{
    static void Main(string[] args)
    {
        // double[,] matrix1 = { {1, 2}, {3, 4} };
        // double[,] matrix1 = { {1, 2, 3}, {4, 5, 6}, {7, 8, 9}};
        // double[,] matrix1 = { {-4, 9, 0}, {1, -2, 1}, {3, -4, 2}};
        double[,] matrix1 = { {11, 8, 7}, {2, 13, 1}, {4, 0, 17}};
        double result = MatrixMath.Determinant(matrix1);
        // double[,] matrix1 = { {13, 0}, {1, 17} };
        // double[,] matrix2 = { {8, 0}, {7, 17} };
        // double[,] matrix3 = { {8, 13}, {7, 1} };
        // double[,] matrix4 = { {2, 4}, {1, 17} };
        // double[,] matrix5 = { {11, 4}, {7, 17} };
        // double[,] matrix6 = { {11, 2}, {7, 1} };
        // double[,] matrix7 = { {2, 4}, {13, 0} };
        // double[,] matrix8 = { {11, 4}, {8, 0} };
        // double[,] matrix9 = { {11, 2}, {8, 13} };

        // // double result1 = MatrixMath.Determinant(matrix1);
        // // double result2 = MatrixMath.Determinant(matrix2);
        // // double result3 = MatrixMath.Determinant(matrix3);

        // // double result4 = MatrixMath.Determinant(matrix4);
        // // double result5 = MatrixMath.Determinant(matrix5);
        // // double result6 = MatrixMath.Determinant(matrix6);

        // // double result7 = MatrixMath.Determinant(matrix7);
        // // double result8 = MatrixMath.Determinant(matrix8);
        // // double result9 = MatrixMath.Determinant(matrix9);
        Console.WriteLine(result);
        // Console.WriteLine(result1);
        // Console.WriteLine(result2);
        // Console.WriteLine(result3);

        // Console.WriteLine(result4);
        // Console.WriteLine(result5);
        // Console.WriteLine(result6);

        // Console.WriteLine(result7);
        // Console.WriteLine(result8);
        // Console.WriteLine(result9);
    }
}
