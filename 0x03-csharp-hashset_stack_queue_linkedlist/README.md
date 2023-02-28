# 0x03. C# - Data Structures: HashSet, Stack, Queue, LinkedList

What you'll find? This part of my Learning process is about:
- How to create and use arrays
- What are Collections in C#?
- How to create and use hashsets
- How to create and use stacks
- How to create and use queues
- How to create and use linked lists
- How to use foreach

Here are the task I solve to answer those question and more. The solution to every task is on the file with the same name than the task.

My challenge for you is to try to solve all of this task and after see the way I did it.

There are some task that may need a main file, all the main code would be in main directory, it must be at the same directory of the task to work properly.

To see my solution you need to build the project, to do that you need to run `dotnet build` inside of the task directory.

To run a specific task run dotnet run inside of the task directory.

All of this code was me on .NET version 2.1, asked for Holberton School.

#### 0. Unique addition
Write a method that adds all unique integers in a list.
- Class Name: `List`
- Prototype: `public static int Sum(List<int> myList)`
- Returns the sum of unique integers in given list


#### 1. Present in both
Write a method that returns a sorted list of common elements in two lists.
- Class Name: `List`
- Prototype: `public static List<int> CommonElements(List<int> list1, List<int> list2)`
- Returns a new sorted list of common elements in two given lists
- You cannot use `LINQ`
- You cannot use `SortedList`


#### 2. Only differents
Write a method that returns a sorted list of common elements in two lists.
- Class Name: `List`
- Prototype: `public static List<int> CommonElements(List<int> list1, List<int> list2)`
- Returns a new sorted list of common elements in two given lists
- You cannot use `LINQ`
- You cannot use `SortedList`


#### 3. Full stack
Given a Stack<string>, write a method that does the following:
- Class: `MyStack`
- Prototype: `public static Stack<string> Info(Stack<string> aStack, string newItem, string search)`
- Print the number of items in `aStack`
- Format: `Number of items: <number>`
- Print the item at the top of `aStack` without removing it
    * Format: `Top item: <item>`
    * If `aStack` is empty, print `Stack is empty`
- Print if `aStack` contains a given item `search`
    * Format: `Stack contains <search>: <True / False>`
- If `aStack` contains the given item `search`, remove all items up to and including `search`; otherwise, leave `aStack` as is
    * You can use `.Pop()` only once
- Add a new given item `newItem` to `aStack`
- Return `aStack`

The output should be this:
```sh
3-stack_push_pop$ dotnet run
Ruby
React
Python
Javascript
HTML
C
------
Number of items: 6
Top item: Ruby
Stack contains "Javascript": True
------
C#
HTML
C
3-stack_push_pop$ 
```


#### 4. Queue it up
Given a Queue<string>, write a method that does the following:
- Class: `MyQueue`
- Prototype: `public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)`
- Print the number of items in `aQueue`
    * Format: `Number of items: <number>`
- Print the item at the top of `aQueue` without removing it
    * Format: `First item: <item>`
    * If `aQueue` is empty, print `Queue is empty`
- Add a new given item `newItem` to `aQueue`
- Print if `aQueue` contains a given item `search`
    * Format: `Queue contains <search>: <True / False>`
- If `aQueue` contains the given item `search`, remove all items up to and including `search`; otherwise, leave `aQueue` as is
    * You can use `.Dequeue()` only once
- Return `aQueue`

The output should be this:
```
4-queue_enqueue_dequeue$ dotnet run
C
HTML
Javascript
Python
React
Ruby
------
Number of items: 6
First item: C
Queue contains "Javascript": True
------
Python
React
Ruby
C#
carrie@ubuntu:~/0x03/4-queue_enqueue_dequeue$ 
```


#### 5. Print a LinkedList
Write a method that creates and prints a LinkedList of integers of a given size.
- Class Name: `LList`
- Prototype: `public static LinkedList<int> CreatePrint(int size)`
- Returns the newly created list
- If `size` is negative, return an empty list


#### 6. LinkedList length
Write a method that returns the number of elements in a LinkedList.
- Class Name: `LList`
- Prototype: `public static int Length(LinkedList<int> myLList)`
- Returns the number of elements in a given LinkedList
- You are not allowed to use `.Count()`


#### 7. Add node to the beginning
Write a method that adds a node to the beginning of a LinkedList.
- Class Name: `LList`
- Prototype: `public static LinkedListNode<int> Add(LinkedList<int> myLList, int n)`
- Returns the newly added node


#### 8. Find value
Write a method that finds a value in a LinkedList and returns its index position in the list.
- Class Name: `LList`
- Prototype: `public static int FindNode(LinkedList<int> myLList, int value)`
- Returns the index position of the first occurrence of the value given or `-1` if the value is not in the list
- You are not allowed to use `.Find()` or `FindLast()`


#### 9. Pop
Write a method that deletes the head node of a LinkedList and returns that node’s data.
- Class Name: LList
- Prototype: public static int Pop(LinkedList<int> myLList)
- Returns the value of the head node
- If the list is empty, return 0


#### 10. Get node at index
Write a method that returns the value of the nth node of a LinkedList.
- Class Name: `LList`
- Prototype: `public static int GetNode(LinkedList<int> myLList, int n)`
- Returns the value of the node at the given index
- If the node doesn’t exist, return `0`
- Indexing starts at 0


#### 11. LinkedList sum
Write a method that returns the sum of all the data of a LinkedList.
- Class Name: `LList`
- Prototype: `public static int Sum(LinkedList<int> myLList)`
- Returns the sum of the data in the LinkedList


#### 12. Insert in order
Write a method that inserts a new node in the correct position in an ordered LinkedList.
- Class Name: `LList`
- Prototype: `public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)`
- Returns the newly created node


#### 13. Delete at index
Write a method that deletes the node at given position in a LinkedList.
- Class Name: `LList`
- Prototype: `public static void Delete(LinkedList<int> myLList, int index)`
