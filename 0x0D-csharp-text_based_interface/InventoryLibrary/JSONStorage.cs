using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace InventoryLibrary
{
    public class JSONStorage
    {
        public Dictionary<string, object> objects = new Dictionary<string, object>();

        public Dictionary<string, object> All()
        {
            return objects;
        }

        public void New(BaseClass obj)
        {
            try
            {
                objects.Add($"{obj.GetType().Name}.{obj.id}", obj);
            }
            catch (System.Exception)
            {
                Console.WriteLine("An element with Key = {0} already exists.", $"{obj.GetType().Name}.{obj.id}");
            }
        }

        public void Save()
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
            };
            string path = "../../storage/inventory.json";
            // string json = JsonSerializer.Serialize(objects, Formatting.Indented);
            string json = JsonSerializer.Serialize(objects, options);
            File.WriteAllText(path, json);
        }
        public void Load()
        {
            string path = "../../storage/inventory.json";
            string json = File.ReadAllText(path);
            objects = JsonSerializer.Deserialize<Dictionary<string, object>>(json);
        }
    }
}
