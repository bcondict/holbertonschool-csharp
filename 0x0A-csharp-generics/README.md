# 0x0A. C# - Generics

What you'll find?
This part of my Learning process is about:
- What are generics and what are their purpose
- What common generic classes and interfaces are provided in the .NET class library
- When and how to create generic classes
- When and how to create generic methods
- How access modifiers affect a class and its members
- What is the default(T) expression used for
- What is covariance and contravariance

Here are the task I solve to answer those question and more. The solution to every task is on the file with the same name than the task.

My challenge for you is to try to solve all of this task and after see the way I did it.

To see my solution you need to build the project, to do that you need to run `dotnet build` inside of the task directory.

To run a specific task run `dotnet run` inside of the task directory.

All of this code was me on .NET version 2.1, asked for Holberton School.

All your public classes and their members should have XML documentation tags

In your `.csproj` file, make sure you have the following line:
<DocumentationFile>bin\$(Configuration)\$(TargetFramework)\$(AssemblyName).xml</DocumentationFile>

All the intellectual property belongs to Holberton School.

#### 0. Queue
Create a new class called `Queue<T>`.

- `Queue<T>` should not inherit from other classes or interfaces.
- Within `Queue<T>`, create a new method `CheckType()` that returns the Queue’s type.
- You are **not** allowed to use `System.Collections` or `System.Collections`.Generic for this project.
- **NOTE**: Your file name for this task will be `queue.cs` not `0-queue.cs` because we will be using this file in subsequent tasks.

#### 1. Enqueue
Based on `0-queue`, within `Queue<T>`, create a public class called `Node` with the following properties:

- `value`: can be of any type, set its initial value to `null`
- `next`: must be an object of type `Node`, set its initial value to `null`
Define a constructor that takes a `value` for a new `Node` as its only parameter and sets it

Within `Queue<T>`, add the following properties:
- `head`: must be an object of type `Node`
- `tail`: must be an object of type `Node`
- `count`: type `int`
Add a new method `Enqueue()` to the class `Queue` that creates a new `Node` and adds it to the end of the queue.
- If the queue is empty, the method should make the new node the head of the queue
- `count` should update every time a new node is added

Add a new method `Count()` to the class that returns the number of nodes in the Queue.


#### 2. Dequeue
Based on `1-enqueue`, add a new method `Dequeue()` to the class `Queue<T>` that removes the first node in the queue and returns its value.

- If the queue is empty, the method should write `Queue is empty` to the console and return the default value of the parameter’s type


#### 3. Peek
Based on `2-dequeue`, add a new method `Peek()` to the class `Queue<T>` that returns the value of the first node of the queue without removing the node.

- If the queue is empty, the method should write `Queue is empty` to the console and return the default value of the parameter’s type


#### 4. Print
Based on `3-peek`, add a new method `Print()` to the class `Queue<T>` that prints the queue, starting from the head.
- If the queue is empty, the method should write `Queue is empty` to the console


#### 5. Concatenate
Based on `4-print`, create a method `Concatenate()` that concatenates all values in the queue only if the queue is of type `String` or `Char`.
- If queue is empty, print `Queue is empty` and return `null`
- If the queue is not of type `String` or `Char`, print `Concatenate() is for a queue of Strings or Chars only`. to the console and return `null`
