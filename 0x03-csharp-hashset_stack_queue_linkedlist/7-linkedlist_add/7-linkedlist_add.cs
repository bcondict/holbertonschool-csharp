using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Add(LinkedList<int> myLlist, int n)
    {
        LinkedListNode<int> node = new LinkedListNode<int>(n);
        myLlist.AddFirst(node);

        return node;
    }
}
