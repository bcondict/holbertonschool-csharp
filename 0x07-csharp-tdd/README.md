# 0x07. C# - Test Driven Development

#### What you'll find? This part of my learning process is about:
- What are solutions in VSCode
- How are solutions different from projects in VSCode
- What is a class library
- What is a unit test
- What are the benefits of unit testing
- How to create and run tests using NUnit
- What is the Arrange, Act, Assert methodology
- How to effectively name your unit tests
- How to utilize the TDD approach
- How to consider edge cases

Here are the task I solve to answer those question and more. The solution to every task is on the file with the same name than the task.

My challenge for you is to try to solve all of this task and after see the way I did it.

To see my solution you need to build the project, to do that you need to run `dotnet build` inside of the task directory.

To run a specific task use `dotnet run` inside of the task directory.

All of this code was me on .NET version 2.1, asked for Holberton School.

#### More Info

In past C# assignments, you have been creating individual console application projects for each task. In this assignment, you are going to create a solution file to allow you to manage multiple projects. Each task is one solution containing two projects: one class library solving the task and one test library to test the class library.

For each task in this project:

1. Create task directory (ex: `0-add`)
2. Inside that directory, run `dotnet new sln`
3. Create a new directory for your task solution based on the namespace given (ex: `MyMath`). This directory will hold your new standard class library.
4. Inside that directory, run `dotnet new classlib`. Rename the resulting .cs file after the namespace (ex: `MyMath.cs`)
5. Enable XML documentation by adding `<DocumentationFile>bin\$(Configuration)\$(TargetFramework)\$(AssemblyName).xml</DocumentationFile>` to `MyMath.csproj`
    - The target framework for this standard class library should be `netstandard2.0`
6. Change directory back to the root directory of the task (ex: `0-add`) and run `dotnet sln add <classlibrary/classlibrary.csproj>` (ex. `dotnet sln add MyMath/MyMath.csproj`)
7. Create a new directory for your tests based on the namespace given plus `.Tests` (ex: `MyMath.Tests`). This directory will hold your test library.
    - The target framework for this library should be `netcoreapp2.1`
8. Inside that directory, run `dotnet new nunit`. Rename the resulting `.cs` file after the namespace of classes you are testing plus `.Tests` (ex: `MyMath.Tests.cs`)
9. To add your class library as a dependency to the project, run `dotnet add reference <../classlibrary/classlibrary.csproj>` (ex: `dotnet add reference ../MyMath/MyMath.csproj`)
10. In the task’s root directory, run `dotnet sln add <testlibrary/testlibrary.csproj>` (ex: `dotnet sln add MyMath.Tests/MyMath.Tests.csproj`)
11. If you’d like to run your class library method in a console application, create a new directory and run `dotnet new console` inside it. Run `dotnet add reference <../classlibrary/classlibrary.csproj>` and you can then call your class library methods inside the console application.
For more detail, read the [Unit Testing C# with NUnit and .NET Core tutorial.](https://docs.microsoft.com/en-us/dotnet/core/testing/unit-testing-with-nunit)

The resulting directory hierarchy for task #0 will look like this:
```
/0-add
    0-add.sln
    /MyMath
        MyMath.cs
        MyMath.csproj
    /MyMath.Tests
        MyMath.Tests.cs
        MyMath.Tests.csproj
```

To simplify this I created an script that make all of this for you, you can find it in the root directory of this repository. To use it you need to run `./script`, that recive two arguments, the first one is the name namespace and the second one is the name of the task or folder (ex: `./script MyMath 0-add`).

If NUnit is not already installed, use the command: `dotnet new -i NUnit3.DotNetNew.Template`

### Tasks

#### 0. Add integers
Write a method that adds 2 numbers

- Namespace: `MyMath`
- Class: `Operations`
- Prototype: `public static int Add(int a, int b)`
- Returns: sum of `a` and `b`
- Test Library Namespace: `MyMath.Tests`
- It is not necessary to account for integer overflow in this task

#### 1. Divide a matrix
Write a method that divides all elements of a matrix.

- Namespace: `MyMath`
- Class: `Matrix
- Prototype: `public static int[,] Divide(int[,] matrix, int num)`
- Returns: a new matrix containing divided elements
- If `num` is `0`, print `Num cannot be 0` and return `null`. (Hint: use `try` / `catch`)
- If `matrix` is `null`, return `null`

#### 2. Max integer
Write a method that returns the max integer in a list of integers.

- Namespace: `MyMath`
- Class: `Operations`
- Prototype: `public static int Max(List<int> nums)`
- Returns: max integer in list
- If `nums` is empty, return `0`

#### 3. Desserts, I stressed!
Write a method that returns `True` if a string is a palindrome or `False` if it’s not.

- Namespace: `Text`
- Class: `Str`
- Prototype: `public static bool IsPalindrome(string s)`
- Returns: `True` if string is a palindrome, `False` if it’s not
- In this task, palindromes are **not** case sensitive
    - `Racecar` = True
    - `level` = True
- Spaces and punctuation should be ignored
    - `A man, a plan, a canal: Panama.` = True
- An empty string is considered a palindrome

#### 4. Unique character
Write a method that returns the index of the first non-repeating character of a string.

- Namespace: `Text`
- Class: `Str`
- Prototype: `public static int UniqueChar(string s)`
- Returns: index of first non-repeating character or `-1` if there is no non-repeating character
- You can assume the string contains only lowercase letters, no spaces or special characters

#### 5. camelCase
Write a method that determines how many words are in a string. Each word begins with a capital letter except the first word.

- Namespace: `Text`
- Class: `Str`
- Prototype: `public static int CamelCase(string s)`
- Returns: number of words in `s`
