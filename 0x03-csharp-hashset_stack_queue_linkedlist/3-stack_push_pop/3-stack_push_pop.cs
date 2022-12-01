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

        Console.WriteLine("Stack contains {0}: {1}", search, aStack.Contains(search));

        Stack<string> copy = new Stack<string>(aStack);

        if (aStack.Contains(search))
        {
            foreach (var item in copy)
            {
                aStack.Pop();
                if (item == search)
                {
                    aStack.Pop();
                    break;
                } 
            }
        }
        aStack.Push(newItem);
        return aStack;
    }
}
