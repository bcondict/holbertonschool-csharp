using System.Text.Json;
using System.Collections.Generic;
using System.IO;

namespace InventoryLibrary;
public class JSONStorage
{
    Dictionary<string, dynamic> objects = new Dictionary<string, dynamic>();

    public static dynamic All()
    {
        return objects;
    }

    public static void New(dynamic obj)
    {
        try
        {
            objects.Add($"obj.GetType().Name.{obj.id}", obj);
        }
        catch (System.ArgumentException)
        {
            Console.WriteLine("An element with Key = \"obj.GetType().Name.{obj.id}\" already exists.");
        }
    }

    public static void Save()
    {
        string path = "../../../../storage/inventory_manager.json";
        string json = JsonConvert.SerializeObject(objects, Formatting.Indented);
        File.WriteAllText(path, json);
    }

    public static void Load()
    {
        string path = "../../../../storage/inventory_manager.json";
        string json = File.ReadAllText(path);
        objects = JsonConvert.DeserializeObject<Dictionary<string, dynamic>>(json);
    }
}
