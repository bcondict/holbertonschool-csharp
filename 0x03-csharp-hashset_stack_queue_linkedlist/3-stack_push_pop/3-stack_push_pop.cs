using System;
using System.Collections.Generic;

class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        Console.WriteLine("Number of items: " + aStack.Count);
        if (aStack.Count == 0)
            Console.WriteLine("Stack is empty");
        else
            Console.WriteLine("Top item: " + aStack.Peek());

        Console.WriteLine("Stack contains \"{0}\": {1}", search, aStack.Contains(search));

        List<string> items = new List<string>(aStack);

        if (aStack.Contains(search))
        {
            for (int i = 0; i < items.Count; i++)
            {
                aStack.Pop();
                if (items[i] == search)
                    break;
            }
        }
        aStack.Push(newItem);
        return aStack;
    }
}
