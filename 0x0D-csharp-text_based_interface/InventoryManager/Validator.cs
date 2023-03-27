using System;
using System.Collections.Generic;
using System.Linq;

namespace InventoryLibrary
{
    /// <summary>
    /// validator class to validate object
    /// </summary>
    public class Validator
    {

        /// <summary>
        /// valudate exitence in storage
        /// </summary>
        /// <param name="storage">storage from read data</param>
        /// <param name="ClassName">classname of object</param>
        /// <param name="Id">id of object to search exitence</param>
        /// <returns>key if object exist, "none" if don't</returns>
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
