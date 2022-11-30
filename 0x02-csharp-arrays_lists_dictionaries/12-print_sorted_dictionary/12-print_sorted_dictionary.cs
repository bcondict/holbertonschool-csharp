using System;
using System.Linq;
using System.Collections.Generic;

class Dictionary
{
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        var sorted_key = from entry in myDict orderby entry.Key ascending select entry;
        foreach (var key in sorted_key)
        {
            Console.WriteLine(key.Key + ": " + key.Value);
        }
    }
}
