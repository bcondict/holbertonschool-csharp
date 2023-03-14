using System;

class Program
{
    static void Main(string[] args)
    {
        double[] vector1 = new double[] { 2, 4 };
        double[] vector2 = new double[] { 2, 4 };
        double[] new_vector = VectorMath.Add(vector1, vector2);
        PrintArray(new_vector);
    }

    static void PrintArray(double[] array)
    {
        int i;

        for (i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]);
            if (i < array.Length - 1)
                Console.Write(" ");
        }

        Console.WriteLine();
    }
}
