using System;

class Matrix
{
    public static int[,] Square(int[,] myMatrix)
    {
        int[,] square_matrix = myMatrix.Clone() as int[,];
        for (int i = 0; i < myMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < myMatrix.GetLength(1); j++)
            {
                square_matrix[i, j] = myMatrix[i, j] * myMatrix[i, j];
            }
        }
        return square_matrix;
    }
}
