using System;
using System.Collections.Generic;
using System.Linq;

namespace InventoryLibrary
{
    public class Validator
    {
        public static string Validate(JSONStorage storage, string ClassName, string Id)
        {
            List<string> validClass = new List<string> {"Item", "User", "Inventory"};
            string key = "";
            Console.ForegroundColor = ConsoleColor.Red;

            if (!validClass.Contains(ClassName, StringComparer.OrdinalIgnoreCase))
            {
                Console.WriteLine("\nClass not found.");
                Console.ResetColor();
                return ("none");
            }
            // Check for invalid search
            foreach (string validClassName in validClass)
            {
                if (!StringComparer.OrdinalIgnoreCase.Equals(ClassName, validClassName))
                    continue;

                else
                    key = $"{validClassName}.{Id}";

                if (!storage.objects.ContainsKey(key))
                {
                    Console.WriteLine("\nClass not found.");
                    Console.ResetColor();
                    return ("none");
                }
            }

            return key;
        }
    }
}
