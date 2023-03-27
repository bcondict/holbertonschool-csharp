using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace InventoryLibrary
{
    /// <summary>
    /// class to save the objects in a json file
    /// </summary>
    public class JSONStorage
    {
        /// <summary>
        /// Dictionary to save the objects created in a json file
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, object> objects = new Dictionary<string, object>();

        /// <summary>
        /// all method to return the dictionary
        /// </summary>
        /// <returns>dictorionary of objects</returns>
        public Dictionary<string, object> All()
        {
            return objects;
        }

        /// <summary>
        /// create new object and add to the dictionary
        /// </summary>
        /// <param name="obj">object create and save</param>
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

        /// <summary>
        /// save the dictionary in a json file
        /// </summary>
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

        /// <summary>
        /// load the dictionary from a json file
        /// </summary>
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
