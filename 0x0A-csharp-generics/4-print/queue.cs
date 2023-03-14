using System;

/// <summary> Custom Generic Queue class </summary>
/// <typeparam name="T"> Generic type </typeparam>
public class Queue<T>
{
    public Node head = null;
    public Node tail = null;
    public int count = 0;

    /// <summary>
    /// Check the type of the Queue
    /// </summary>
    /// <returns>Return the Queue's type</returns>
    public string CheckType()
    {
        return typeof(T).ToString();
    }

    /// <summary>
    /// Node - singly linked list
    /// </summary>
    public class Node
    {
        public T value = default(T);
        public Node next = null;

        /// <summary>
        /// Constructor for Node class
        /// </summary>
        /// <param name="value">can be any type</param>
        public Node(T value)
        {
            this.value = value;
        }
    }

    /// <summary>
    /// that creates a new Node and adds it to the end of the queue.
    /// </summary>
    /// <param name="value">Value of node can be any type</param>
    public void Enqueue(T value)
    {
        Node newNode = new Node(value);
        if (head == null)
        {
            head = newNode;
            tail = newNode;
            head.next = null;
        }
        else
        {
            tail.next = newNode;
            tail = newNode;
        }
        this.count++;
    }

    /// <summary>
    /// count of nodes in the Queue
    /// </summary>
    /// <returns> Number of node in Queue </returns>
    public int Count()
    {
        return count;
    }

    /// <summary>
    /// removes the first node in the queue.
    /// </summary>
    /// <returns>returns value of deleted node</returns>
    public T Dequeue()
    {
        Node temp = head;

        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }

        head = head.next;
        count--;
        return temp.value;
    }

    /// <summary>
    /// returns the value of the first node of the queue without removing the node.
    /// </summary>
    /// <returns> returns the value of the first node</returns>
    public T Peek()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }
        return head.value;
    }

    /// <summary>
    /// prints the queue, starting from the head.
    /// if is empty prints "Queue is empty"
    /// </summary>
    public void Print()
    {
        Node temp = head;
        if (temp == null)
            Console.WriteLine("Queue is empty");
        while (temp != null)
        {
            Console.WriteLine(temp.value);
            temp = temp.next;
        }
    }
}

