using System;
using InventoryLibrary;
using System.Collections.Generic;
using System.Linq;

namespace main
{
    class Program
    {
        static void Main(string[] args)
        {
            User myObject = new User("John");
            Console.WriteLine(myObject.name);
        }
    }
}
