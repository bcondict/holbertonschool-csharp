using System;
using System.Collections.Generic;
using System.Linq;
using InventoryLibrary;
using System.Text.Json;

namespace InventoryLibrary
{
    public class Commands
    {
        public void ClassNames(JSONStorage storage)
        {
            List<string> classes = new List<string>() {};

            Console.WriteLine("\nClasses:");
            Console.WriteLine("- Item\r\n- User\r\n- Inventory");
            foreach (KeyValuePair<string, object> item in storage.objects)
            {
                // classes.Add(item.Key.Split('.')[0]);
                classes.Add(item.Value.GetType().Name);
            }

            HashSet<string> uniqueClasses = new HashSet<string>(classes);
            string[] uniqueClassesArray = uniqueClasses.ToArray();

            Console.ForegroundColor = ConsoleColor.Red;
            if (uniqueClassesArray.Length == 0)
            {
                Console.WriteLine("\nNo classes found.");
                Console.ResetColor();
                return;
            }

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\nResult:");
            Console.ResetColor();

            Console.WriteLine(string.Join(", ", uniqueClassesArray));
        }

        public void Create(JSONStorage storage, string ClassName)
        {
            Console.ForegroundColor = ConsoleColor.Red;

            if (StringComparer.OrdinalIgnoreCase.Equals(ClassName, "Item"))
            {
                Console.WriteLine("\nCreating new Item...");
                Console.ResetColor();

                Console.WriteLine("\nPlease input the name of the new Item:");
                Console.WriteLine("--- Name is required to create a new item, it cannot be left blank. ---\n");
                string name = Console.ReadLine();
                if (name == "")
                {
                    Console.WriteLine("Name cannot be left blank.");
                    return;
                }

                Console.WriteLine("\nPlease input the description of the new Item:");
                Console.WriteLine("--- Description is not required to create a new item. ---\n");
                string description = Console.ReadLine();

                Console.WriteLine("\nPlease input the price of the new Item:");
                Console.WriteLine("--- Price is not required to create a new item. ---\n");
                string price = Console.ReadLine();
                float priceFloat = 0;

                if (price != "")
                {
                    try
                    {
                        priceFloat = float.Parse(price);
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Price must be a number.");
                        return;
                    }
                }

                Console.WriteLine("\nPlease input the tags of the new Item:");
                Console.WriteLine("--- Tags are not required to create a new item. ---\n");
                List<string> tags = new List<string>() {};
                tags = Console.ReadLine().Split().ToList();

                Item item = new Item(name, description, priceFloat, tags);
                storage.New(item);
                storage.Save();

                Console.WriteLine("...Saving...");

                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("\nNew Item created: " + item.id);
            }

            else if (StringComparer.OrdinalIgnoreCase.Equals(ClassName, "User"))
            {
                Console.WriteLine("\nCreating new User...");
                Console.ResetColor();

                Console.WriteLine("\nPlease input the name of the new User:");
                Console.WriteLine("--- Name is required to create a new user, it cannot be left blank. ---\n");
                string name = Console.ReadLine();

                User user = new User(name);
                storage.New(user);
                storage.Save();

                Console.WriteLine("...Saving...");

                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("\nNew User created: " + user.id);
            }

            else if (StringComparer.OrdinalIgnoreCase.Equals(ClassName, "Inventory"))
            {
                Console.WriteLine("\nCreating new Inventory...");
                Console.ResetColor();

                Console.WriteLine("\nPlease input the id of the User for the new Inventory:");
                Console.WriteLine("--- User id cannot be left blank. ---\n");
                string userId = Console.ReadLine();
                if (userId == "")
                    return;

                Console.WriteLine("\nPlease input the id of the Item for the new Inventory:");
                Console.WriteLine("--- Item id cannot be left blank. ---\n");
                string itemId = Console.ReadLine();
                if (itemId == "")
                {
                    return;
                }

                Inventory inventory = new Inventory(userId, itemId, 1);
                storage.New(inventory);
                storage.Save();

                Console.WriteLine("...Saving...");

                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("\nNew Inventory created: " + inventory.id);
            }

            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("\nClass not found.");
            }
            Console.ResetColor();
        }

        public void All(JSONStorage storage, string ClassName = null)
        {

            if (storage.objects.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nNo objects found.");
                Console.ResetColor();
                return;
            }

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            if (ClassName == null)
            {
                Console.WriteLine("\nResult all disponible objects:");

                Console.ResetColor();
                foreach (KeyValuePair<string, object> item in storage.objects)
                {
                    Console.WriteLine($"\n{item.Key}: {item.Value}");
                }
                return;
            }

            Console.WriteLine($"\nResult all {ClassName} objects:");
            Console.ResetColor();
            foreach (KeyValuePair<string, object> item in storage.objects)
            {
                if (StringComparer.OrdinalIgnoreCase.Equals(ClassName, item.Key.Split('.')[0]))
                    Console.WriteLine($"\n{item.Key}: {item.Value}");
            }
        }

        public void Show(JSONStorage storage, string ClassName, string Id)
        {
            string key = Validator.Validate(storage, ClassName, Id);
            if (key == "none")
                return;

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\nResult:");
            Console.ResetColor();

            Console.WriteLine(storage.objects[key].ToString());
        }

        public void Update(JSONStorage storage, string ClassName, string Id)
        {
            string key = Validator.Validate(storage, ClassName, Id);
            if (key == "none")
                return;
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            if (StringComparer.OrdinalIgnoreCase.Equals(ClassName, "Item"))
            {
                Item item = (Item)storage.objects[key];
                Console.WriteLine("\nUpdating Item...");
                Console.ResetColor();

                Console.WriteLine("\nPlease input the new name of the Item:");
                string name = Console.ReadLine();
                if (name == "")
                {
                    name = item.name;
                }

                Console.WriteLine("\nPlease input the new description of the Item:");
                string description = Console.ReadLine();
                if (description == "")
                {
                    description = item.description;
                }

                Console.WriteLine("\nPlease input the new price of the Item:");
                string price = Console.ReadLine();
                float priceFloat = 0;

                if (price != "")
                {
                    try
                    {
                        priceFloat = float.Parse(price);
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Price must be a number.");
                        return;
                    }
                }

                if (priceFloat == 0)
                    priceFloat = item.price;

                Console.WriteLine("\nPlease input the new tags of the Item:");
                List<string> tags = new List<string>() {};
                tags = Console.ReadLine().Split().ToList();
                if (tags.Count == 0)
                {
                    tags = item.tags;
                }

                item.name = name;
                item.description = description;
                item.price = priceFloat;
                item.tags = tags;
                item.date_updated = DateTime.Now;

                storage.Save();

                Console.WriteLine("...Saving...");

                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("\nItem updated: " + item.id);
            }

            else if (StringComparer.OrdinalIgnoreCase.Equals(ClassName, "User"))
            {
                Console.WriteLine("\nUpdating User...");
                Console.ResetColor();

                User user = (User) storage.objects[key];

                Console.WriteLine("\nPlease input the name of the User:");
                string name = Console.ReadLine();
                if (name == "")
                {
                    name = user.name;
                }

                user.name = name;

                storage.Save();

                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("\nUser updated: " + user.id);
            }

            else if (StringComparer.OrdinalIgnoreCase.Equals(ClassName, "Inventory"))
            {
                Console.WriteLine("\nUpdating Inventory...");
                Console.ResetColor();

                Inventory inventory = (Inventory) storage.objects[key];

                Console.WriteLine("\nPlease input the id of the User for the Inventory:");
                string userId = Console.ReadLine();
                if (userId == "")
                {
                    userId = inventory.user_id;
                }

                Console.WriteLine("\nPlease input the id of the Item for the Inventory:");
                string itemId = Console.ReadLine();
                if (itemId == "")
                {
                    itemId = inventory.item_id;
                }

                Console.WriteLine("\nPlease input the quantity of the Item for the Inventory:");
                string quantity = Console.ReadLine();
                int quantityInt = 0;
                try
                {
                    quantityInt = int.Parse(quantity);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Quantity must be a number.");
                    return;
                }

                if (quantityInt == 0)
                    quantityInt = inventory.quantity;

                inventory.user_id = userId;
                inventory.item_id = itemId;
                inventory.quantity = quantityInt;

                storage.Save();

                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("\nInventory updated: " + inventory.id);
            }
            Console.ResetColor();
        }

        public void Delete(JSONStorage storage, string ClassName, string Id)
        {
            string key = Validator.Validate(storage, ClassName, Id);
            if (key == "none")
                return;

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\nDeleting...");

            storage.objects.Remove(key);

            storage.Save();

            Console.WriteLine("\nObject deleted: " + key);
            Console.ResetColor();
        }

        public void Exit(JSONStorage storage)
        {
            storage.Save();
            Console.WriteLine("\nGoodbye!");
            Environment.Exit(0);
        }
    }
}
