using System;
using InventoryLibrary;

namespace InventoryManager
{
    class Program
    {
        static void Main(string[] args)
        {
            JSONStorage jsonStorage = new JSONStorage();
            jsonStorage.Load();
        }
    }
}
