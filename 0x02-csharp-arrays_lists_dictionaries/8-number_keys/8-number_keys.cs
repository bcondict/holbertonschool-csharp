using System;
using System.Collections.Generic;

class Dictionary
{
    public static int NumberOfKeys(Dictionary<string, string> myDict)
    {
        if (myDict == null)
            return 0;

        int keyCount = 0;
        foreach (var key in myDict)
        {
            keyCount++;
        }
        return keyCount;
    }
}
