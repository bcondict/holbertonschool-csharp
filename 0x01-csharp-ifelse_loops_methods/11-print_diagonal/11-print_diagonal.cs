using System;

class Line
{
    public static void PrintDiagonal(int length)
    {
        int j = 0;
        if (length >= 0)
            Console.WriteLine();
        for (int i = 0; i < length; i++)
        {
            while (j < i);
            {
                Console.WriteLine(" ");
                j++;
            }
            Console.WriteLine("\\")
        }
    }
}
