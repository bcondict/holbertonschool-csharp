using System;
using System.Collections.Generic;

class LList 
{
    public static int Length(LinkedList<int> myLlist)
    {
        int count = 0;
        foreach (int item in myLlist)
        {
            count++;
        }
        return count;
    }
}
