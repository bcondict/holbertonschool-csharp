# 0x06. C# - Classes and Namespaces

#### What you'll find? This part of my learning process is about:

How to document C# code with XML comments
What is object-oriented programming?
What is a namespace
What is a class
What are objects and instances
What is the difference between a class and an object or instance
What is a field
What is a constructor
What is a property
How to use get and set
When to use a constructor and when to use a property
What is this and when to use it
What is a method
What are access modifiers
What is a static class
What is a static member
What is encapsulation
What is polymorphism
What is abstraction
What does toString do and how to override it
What is the difference between a class and a struct
When to use a class and when to use a struct
What is garbage collection in C#

#### More Info
- Use [XML documentation comments](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/xmldoc/recommended-tags)
- [XML Documentation Best Practices](https://blog.rsuter.com/best-practices-for-writing-xml-documentation-phrases-in-c/)
- All public types / classes and their members should be documented with `<summary>` tags
- Private members should be documented but without XML comments
- To enable XML documentation in your project, you must add this line to the `PropertyGroup` in your `.csproj` file:
    * `<DocumentationFile>bin\$(Configuration)\$(TargetFramework)\$(AssemblyName).xml</DocumentationFile>`
- Compiling your project with `/doc` will create an XML file in the directory specified above. With the `.xml` in the same directory as the compiled assembly, VSCode will automatically read the XML file and use it to provide tooltips with your documentation. Keep this in mind as you write your comments; they should give the programmer clear, concise information about your methods’ purpose and usage.

Here are the task I solve to answer those question and more. The solution to every task is on the file with the same name than the task.

My challenge for you is to try to solve all of this task and after see the way I did it.

There are some task that may need a main file, all the main file would be in main directory. Make sure to move them to the appropriate folder for proper functioning, it must be at the same directory of the task to work properly.

To see my solution you need to build the project, to do that you need to run `dotnet build` inside of the task directory.

To run a specific task use `dotnet run` inside of the task directory.

All of this code was me on .NET version 2.1, asked for Holberton School.

#### 0. Braaainsss
Create a new namespace `Enemies`. Create an empty public class `Zombie` within `Enemies` that defines a zombie.

#### 1. Healthy competition
Based on `0-enemy`, write a public class `Zombie` that defines a zombie by:

- public field `health`
- `health` should be an int and have no value
- public constructor: `public Zombie()`
    - sets the value of `health` to `0`

#### 2. Health validation
Based on `1-enemy`, write a public class `Zombie` that defines a zombie by:

- public field `health`
- `health` should be an int and have no value
- public constructor: `public Zombie()`
    - sets the value of `health` to `0`
- a new public constructor: `public Zombie(int value)`
    - `value` must be greater than or equal to 0
    - if `value` is less than 0, throw an `ArgumentException` with the message `Health must be greater than or equal to 0`

#### 3. Zombie health
Based on `2-enemy`, write a public class `Zombie` that defines a zombie by:

- **private** field `health`
- `health` should be an int and have no value
- public constructor: `public Zombie()`
    - sets the value of `health` to `0`
- public constructor: `public Zombie(int value)`
    - `value` must be greater than or equal to 0
- public method `public int GetHealth()` that returns the value of health of the Zombie object

#### 4. Hello, my name is
Based on `3-enemy`, write a public class `Zombie` that defines a zombie by:

- private field `health`
- `health` should be an int and have no value
- public constructor: `public Zombie()`
    - sets the value of `health` to `0`
- public constructor: `public Zombie(int value)`
    - `value` must be greater than or equal to 0
- private field `name`
- `name` should be a string and have a default value of `(No name)`
- public property `Name`
    - `get`: retrieve name
    - `set`: set name
- public method `public int GetHealth()` that returns the value of health of the Zombie object

#### 5. Printing a zombie
Based on `4-enemy`, write a public class `Zombie` that defines a zombie by:

- private field `health`
- `health` should be an int and have no value
- public constructor: `public Zombie()`
    - sets the value of `health` to `0`
- public constructor: `public Zombie(int value)`
    - `value` must be greater than or equal to 0
- private field `name`
- `name` should be a string and have a default value of `(No name)`
- public property `Name`
    - `get`: retrieve name
    - `set`: set name
- public method `public int GetHealth()` that returns the value of health of the Zombie object
- public `.toString()` override that prints the Zombie object’s attributes to stdout
    - Format: `Zombie Name: <name> / Total Health: <health>` (see example below)
