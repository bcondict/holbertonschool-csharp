﻿using System;

namespace _12_fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    Console.Write("FizzBuzz ");
                else if (i % 3 == 0)
                    Console.Write("Fizz ");
                else if (i % 5 == 0)
                    if (i == 100)
                        Console.Write("Buzz\n");
                    else
                        Console.Write("Buzz ");
                else
                    Console.Write("{0} ", i);
            }
        }
    }
}
