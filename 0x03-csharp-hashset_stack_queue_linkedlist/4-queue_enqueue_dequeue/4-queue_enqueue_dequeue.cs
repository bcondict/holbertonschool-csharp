using System;
using System.Collections.Generic;

class MyQueue
{
    public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
    {
        Console.WriteLine("Number of items: {0}", aQueue.Count);

        if (aQueue.Count == 0)
        {
            Console.WriteLine("Queue is empty");
            return aQueue;
        }
        else
            Console.WriteLine("First item: {0}", aQueue.Peek());

        Console.WriteLine("Queue contains \"{0}\": {1}", search, aQueue.Contains(search));

        aQueue.Enqueue(newItem);

        List<string> items = new List<string>(aQueue);
        if (aQueue.Contains(search))
        {
            for (int i = 0; i < items.Count; i++)
            {
                aQueue.Dequeue();
                if (items[i].Equals(search))
                    break;
            }
        }
        return aQueue;
    }
}
