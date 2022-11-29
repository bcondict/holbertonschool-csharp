using System;

class Program
{
    static void Main(string[] args)
    {
        Random rndm = new Random();
        int number = rndm.Next(-10000, 10000);
        int LastDigit = number % 10;

        Console.WriteLine("The las digit of {0} is {1} and is {2}", number, LastDigit,
        LastDigit > 5 ? "greater than 5" : ( LastDigit == 0 ? "0" : "less than 6 and not 0"));
    }
}