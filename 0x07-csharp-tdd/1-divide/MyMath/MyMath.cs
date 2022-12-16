using System;

namespace MyMath
{
    /// <sumary> Class contains multiple method for matrix</sumary>
    public class Matrix
    {
        /// <sumary> Divide the values of a matrix by a given num</sumary>
        /// <result> New list with numbes divided by given number</result>
        public static int[,] Divide(int[,] matrix, int num)
        {
            if (matrix == null)
                return null;

            int [,] result = new int [matrix.GetLength(0), matrix.GetLength(1)];
            int temp = 0;

            try
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        temp = matrix[i, j] / num;
                        result[i, j] = temp;
                    }
                }
            }

            catch (DivideByZeroException)
            {
                Console.WriteLine("Num cannot be 0");
                return null;
            }
            return result;
        }
    }
}

