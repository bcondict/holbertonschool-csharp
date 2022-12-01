using System;
using System.Collections.Generic;

class LList
{
    public static int GetNode(LinkedList<int> myLList, int n)
    {
        int i = 0;
        foreach (var item in myLList)
        {
            if (n == i)
                return item;
            i++;
        }
        return 0;
    }
}
