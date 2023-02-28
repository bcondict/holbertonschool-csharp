# 0x04. C# - Exceptions

What you'll find? This part of my learning process is about:
- What are exceptions and when to use them
- What is the purpose of catching exceptions
- How to handle exceptions
- How to use try, catch, finally
- How to raise built-in exceptions
- When to implement clean-up actions after exceptions

Here are the task I solve to answer those question and more. The solution to every task is on the file with the same name than the task.

My challenge for you is to try to solve all of this task and after see the way I did it.

There are some task that may need a main file, all the main file would be in main directory. Make sure to move them to the appropriate folder for proper functioning, it must be at the same directory of the task to work properly.

To run a specific task use `dotnet run` inside of the task directory.

All of this code was me on .NET version 2.1, asked for Holberton School.

#### 0. Safe list printing
Write a method that prints n elements of a list.

- Class Name: `List`
- Prototype: `public static int SafePrint(List<int> myList, int n)`
- `n` represents the number of elements to print
- `n` can be bigger than the length of `myList`
- Returns number of elements actually printed
- You have to use `try` / `catch`

#### 1. Integer division
Write a function that divides 2 integers and prints the result.

- Class Name: `Int`
- Prototype: `public static void divide(int a, int b)`
- You can assume that `a` and `b` are integers
- You have to use `try` / `catch` / `finally`
- The result of the division should print in the `finally` section in the format shown in the example

#### 2. Divide lists
Write a function that divides element by element 2 lists.

- Class Name: `List`
- Prototype: `public static List<int> Divide(List<int> list1, List<int> list2, int listLength)`
- `length` can be bigger than the length of either list
- Returns a new list of all division results
- If 2 elements can’t be divided, the division result should be equal to `0`
- If the division can’t be done (dividing by 0):
    - print `Cannot divide by zero`
- If either list is too short:
    - print `Out of range`
- You have to use `try` / `catch`

#### 3. Throw exception
Write a function that throws an Exception.

- Class Name: `Except`
Prototype: `public static void Throw()`

#### 4. Throw exception with message
Write a method that throws an Exception with a message.

Class Name: `Except`
Prototype: `public static void ThrowMsg(string msg)`
