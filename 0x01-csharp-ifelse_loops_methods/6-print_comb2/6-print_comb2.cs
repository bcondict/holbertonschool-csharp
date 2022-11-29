using System;

namespace _6_print_comb2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 9; i++)
            {
                for (int j = 0; j <= 8 && j != i; j++)
                {
                    if (i == 9 && j == 8)
                    {
                        Console.WriteLine("89");
                    }
                    else
                    {
                        Console.Write(j);
                        Console.Write("{0}, ", i);
                    }
                }
            }
        }
    }
}
