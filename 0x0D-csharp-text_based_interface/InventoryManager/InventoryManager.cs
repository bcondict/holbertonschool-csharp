using System;
using InventoryLibrary;
using System.Collections.Generic;
using System.Linq;

namespace InventoryManager
{
    class Program
    {
        static void Main(string[] args)
        {
            JSONStorage jsonStorage = new JSONStorage();
            jsonStorage.Load();

            string input;
            string[] inputSplit;

            List<string> commands = new List<string>() {"ClassNames", "All", "Create", "Show", "Update", "Delete", "Exit", "Help"};
            Commands command = new Commands();

            // print all possible commands
            Prompt.Print();

            // infinite loop
            while (true)
            {
                input = "";
                input = Console.ReadLine();
                inputSplit = input.Split();

                if (inputSplit[0].Equals("Help", StringComparison.OrdinalIgnoreCase))
                {
                    Prompt.Print();
                }
                if (inputSplit[0].Equals("ClassNames", StringComparison.OrdinalIgnoreCase))
                {
                    command.ClassNames(jsonStorage);
                }
                if (inputSplit[0].Equals("All", StringComparison.OrdinalIgnoreCase))
                {
                    if (inputSplit.Length > 2)
                    {
                        Console.WriteLine("\nUsage: All <ClassName>");
                        Console.WriteLine("--- To list all ClassNames, type ClassNames ---");
                    }
                    if (inputSplit.Length == 1)
                        command.All(jsonStorage);
                    if (inputSplit.Length == 2)
                        command.All(jsonStorage, inputSplit[1]);
                }
                if (inputSplit[0].Equals("Create", StringComparison.OrdinalIgnoreCase))
                {
                    if (inputSplit.Length != 2)
                    {
                        Console.WriteLine("\nUsage: Create <ClassName>");
                        Console.WriteLine("--- To list all ClassNames, type ClassNames ---");
                    }
                    else
                        command.Create(jsonStorage, inputSplit[1]);
                }
                if (inputSplit[0].Equals("Show", StringComparison.OrdinalIgnoreCase))
                {
                    if (inputSplit.Length != 3)
                    {
                        Console.WriteLine("\nUsage: Show <ClassName> <Id>");
                        Console.WriteLine("--- To list all ClassNames, type ClassNames ---");
                    }
                    else
                        command.Show(jsonStorage, inputSplit[1], inputSplit[2]);
                }
                if (inputSplit[0].Equals("Update", StringComparison.OrdinalIgnoreCase))
                {
                    if (inputSplit.Length != 3)
                    {
                        Console.WriteLine("\nUsage: Update <ClassName> <Id>");
                        Console.WriteLine("--- To list all ClassNames, type ClassNames ---");
                    }

                    else
                        command.Update(jsonStorage, inputSplit[1], inputSplit[2]);
                }
                if (inputSplit[0].Equals("Delete", StringComparison.OrdinalIgnoreCase))
                {
                    if (inputSplit.Length != 3)
                    {
                        Console.WriteLine("\nUsage: Delete <ClassName> <Id>");
                        Console.WriteLine("--- To list all ClassNames, type ClassNames ---");
                    }
                    else
                        command.Delete(jsonStorage, inputSplit[1], inputSplit[2]);
                }
                if (inputSplit[0].Equals("Exit", StringComparison.OrdinalIgnoreCase))
                {
                    command.Exit(jsonStorage);
                }
                if (!commands.Contains(inputSplit[0], StringComparer.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Please input a valid command.");
                }

                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("\r\n__________________________\n");
            }
        }
    }
}
