using System;
using System.Collections.Generic;

class List
{
    public static List<int> CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        if (size == 0)
            Console.WriteLine();

        List<int> new_list = new List<int>();
        new_list = new List<int>(size);
        for (int i = 0; i < size; i++)
        {
            new_list.Add(i);
            if (i == size - 1)
            {
                Console.WriteLine(new_list[i]);
                break;
            }
            Console.Write(new_list[i] + " ");
        }
        return new_list;
    }
} 
