using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        int i = 0;
        LinkedListNode<int> mynode = new LinkedListNode<int>(n);
        LinkedListNode<int> node = myLList.First;

        if (mynode.Value < node.Value)
        {
            myLList.AddFirst(n);
            return mynode;
        }

        for (i = 0; i < myLList.Count; i++)
        {
            if (mynode.Value < node.Value)
            {
                node = node.Previous;
                break;
            }

            if (i != myLList.Count - 1)
                node = node.Next;
        }
        myLList.AddAfter(node, n);
        return mynode;
    }
}
