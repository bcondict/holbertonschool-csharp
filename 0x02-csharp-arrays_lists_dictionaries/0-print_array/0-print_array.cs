using System;

class Array
{
    public static int[] CreatePrint(int size)
    {
        if (size == 0)
            Console.WriteLine();

        else if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }

        int[] new_array = new int[size];

        for (int i = 0; i < size; i++)
        {
            new_array[i] = i;
            if (i != size - 1)
                Console.Write(i + " ");
            else
                Console.WriteLine(i);
        }
        return new_array;
    }
} 
