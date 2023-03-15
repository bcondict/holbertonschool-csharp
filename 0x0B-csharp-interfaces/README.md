# 0x0B. C# - Interfaces

#### What you'll find here? This part of my learning process is about interfaces in C#.
- What is an interface
- What are interfaces used for
- How do interfaces, classes, and structs differ
- What is an abstract class
- How are interfaces different from abstract classes
- How is an interface implemented explicitly
- What is the as keyword and how to use it

Here are the task I solve to answer those question and more. The solution to every task is on the file with the same name than the task.

My challenge for you is to try to solve all of this task and after see the way I did it.

All the main code would be in `main` directory, it must be at same directory of the task to work properly.

To see my solution you need to build the project, to do that you need to run `dotnet build` inside of the task directory.

To run a specific task run `dotnet run` inside of the task directory.

All of this code was me on .NET version 2.1, asked for Holberton School.

All your public classes and their members should have XML documentation tags

In your `.csproj` file, make sure you have the following line:
`<DocumentationFile>bin\$(Configuration)\$(TargetFramework)\$(AssemblyName).xml</DocumentationFile>`

All the intellectual property belongs to Holberton School.


#### 0. Abstract thinking
Create an abstract class called `Base` containing the following:
- public property name
    - `name` should be a string
- override `ToString()` method to return the following:
    - `<name> is a <type>` (ex. `Garden Gate is a Door`)


#### 1. User interface
Based on `0-abstract_thinking`, create an interface called `IInteractive`.
- method `void Interact()`

Create an interface called `IBreakable`
- property `durability`
    - `durability` should be an int
- method `void Break()`

Create an interface called `ICollectable`.
- property `isCollected`
    - `isCollected` should be a bool
- method `void Collect()`
You do not need to fully implement the methods for this task.

Create a new class called `TestObject` that inherits from `Base` and all three interfaces.


#### 2. Escape room
Based on `1-user_interface`, delete the `TestObject` class. Create a new class called `Door` that inherits from `Base` and `IInteractive`.

- define constructor that sets the value of `name`
    - if `name` isn’t provided, the default value should be `Door`
- implement `Interact()` so that it prints:
    - `You try to open the <name>. It's locked.`


#### 3. Interior decorating
Based on `2-doors`, create a new class called `Decoration` that inherits from `Base`, `IInteractive`, and `IBreakable`.
- add public bool `isQuestItem`
- define constructor that sets the value of `name`, `durability`, and `isQuestItem`
    - the method declaration should use `name`, `durability`, and `isQuestItem` as the parameter names ([why?](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/named-and-optional-arguments))
    - if `name` isn’t provided, the default value should be `Decoration`
    - if `durability` isn’t provided, the default value should be `1`
    - if `durability` is 0 or less, throw an exception that states `Durability must be greater than 0`
    - if `isQuestItem` isn’t provided, the default value should be `false`
- implement `Interact()`
    - if the `durability` is `0` or less, print:
        - `The <name> has been broken.`
    - otherwise, if `isQuestItem` is `true`, print:
        - `You look at the <name>. There's a key inside.`
    - if `isQuestItem` is `false`, write:
        - `You look at the <name>. Not much to see here.`
- implement `Break()` so that it decrements `durability` by 1
    - if `durability` is greater than `0`, print:
        - `You hit the <name>. It cracks.`
    - if `durability` is `0`, print:
        - `You smash the <name>. What a mess.`
    - if `durability` is less than `0`, print:
        - `The <name> is already broken.`


#### 4. Key collecting
Based on `3-decorations`, create a new class called `Key` that inherits from `Base` and `ICollectable`.
- define constructor that sets the value of `name` and `isCollected`
    - the method declaration should use `name` and `isCollected` as the parameter names ([why?](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/named-and-optional-arguments))
    - if `name` isn’t provided, the default value should be `Key`
    - if `isCollected` isn’t provided, the default value should be `false`
- implement `Collect()`
    - if `isCollected` is `false`, set it to `true` and print:
        - `You pick up the <name>.`
    - if `isCollected` is `true`, print:
        - `You have already picked up the <name>.`


#### 5. Iterate and act
Based on `4-keys`, create a new class called `RoomObjects` and a method called `IterateAction`. This method should take a list of all objects, iterate through it, and execute methods depending on what interface that item implements. (ex: if the item uses `IInteractive`, your `IterateAction` method should call `Interact()` on it)
- Class: `RoomObjects`
- Prototype: `public static void IterateAction(List<Base> roomObjects, Type type)`


#### 6. Better iterating and acting
Based on `5-iterate_act`, remove the `RoomObjects` class created in the previous task. Create a new generic class `Objs<T> `that creates a collection of type `T` objects that can be iterated through using `foreach`.

Class: `Objs<T>`
`Objs<T>` must inherit from and implement `IEnumerable<T>`
