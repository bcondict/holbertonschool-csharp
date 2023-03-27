using System;
using InventoryLibrary;

/// <summary>
/// class prompt to print the prompt
/// </summary>
public static class Prompt
{
    /// <summary>
    /// print the prompt to the user
    /// </summary>
    public static void Print()
    {
        Console.WriteLine();
        Console.WriteLine(@"Inventory Manager
-------------------------
<ClassNames> show all ClassNames of objects
<All> show all objects
<All [ClassName]> show all objects of a ClassName
<Create [ClassName]> a new object
<Show [ClassName object_id]> an object
<Update [ClassName object_id]> an object
<Delete [ClassName object_id]> an object
<Exit>");

        Console.WriteLine("\r\nPlease input a command:");
        Console.WriteLine();
    }
}
