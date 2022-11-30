using System;
using System.Collections.Generic;

class Dictionary
{
    public static Dictionary<string, int> MultiplyBy2(Dictionary<string, int> myDict)
    {
        if (myDict == null)
            return myDict;
        
        // Create a new dictionary
        Dictionary<string, int> newDict = new Dictionary<string, int>();
        foreach (var key in myDict.Keys)
        {
            newDict.Add(key, myDict[key] * 2);
        }
        return newDict;
    }
}
