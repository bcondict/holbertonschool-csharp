using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class List
{
    public static int Sum(List<int> myList)
    {
        HashSet<int> result = new HashSet<int>(myList);
        int sum = 0;

        foreach (var item in result)
        {
            sum += item;
        }
        return sum;
    }
}
