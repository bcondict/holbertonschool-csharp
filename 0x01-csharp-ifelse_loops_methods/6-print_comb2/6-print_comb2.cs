using System;

namespace _6_print_comb2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int j = 0;
            for (i = 0; i <= 8; i++)
            {
                while (j <= 9)
                {
                    if (i == 8 && j == 9)
                    {
                        Console.WriteLine("89");
                    }
                    else if (i != j)
                    {
                        Console.Write("{0}{1}, ", i, j);
                    }
                    j++;
                }
                j = i + 1;
            }
        }
    }
}
