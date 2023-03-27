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
            string path = "../storage/inventory_manager.json";
            string json = JsonSerializer.Serialize(objects, options);
            File.WriteAllText(path, json);
        }

        public void Load()
        {
            string path = "../storage/inventory_manager.json";
            string json = File.ReadAllText(path);
            if (json == null || json == "")
                return;

            // objects = JsonSerializer.Deserialize<Dictionary<string, object>>(json);
            JsonDocument doc = JsonDocument.Parse(json);

            // generate by IA, incredible
            foreach (JsonProperty property in doc.RootElement.EnumerateObject())
            {
                string key = property.Name;
                JsonElement value = property.Value;

                // extract the type name from the key
                int index = key.IndexOf(".");
                string typeName = key.Substring(0, index);

                // get the type of the object based on the type name
                Type type = Type.GetType($"InventoryLibrary.{typeName}");

                // deserialize the object using the appropriate type
                object obj = JsonSerializer.Deserialize(value.GetRawText(), type);
                objects[key] = obj;
            }
        }
    }
}
