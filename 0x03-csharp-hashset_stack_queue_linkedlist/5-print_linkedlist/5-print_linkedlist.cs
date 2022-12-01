using System;
using System.Collections.Generic;

class LList
{
    public static LinkedList<int> CreatePrint(int size)
    {
        LinkedList<int> MyLinkedList = new LinkedList<int>();
        if (size < 0)
            return MyLinkedList;

        for (int i = 0; i < size; i++)
        {
            MyLinkedList.AddLast(i);
            Console.WriteLine(i);
        }
        return MyLinkedList;
    }
}
