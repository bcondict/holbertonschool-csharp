# 0x05. C# - Structs, Enumerations

What you'll find? This part of my learning process is about:
- What is a struct
- What is a constructor
- What is a field
- What is a property
- What is an enumeration and when to use them
- What does toString do and how to override it

Here are the task I solve to answer those question and more. The solution to every task is on the file with the same name than the task.

My challenge for you is to try to solve all of this task and after see the way I did it.

There are some task that may need a main file, all the main file would be in main directory. Make sure to move them to the appropriate folder for proper functioning, it must be at the same directory of the task to work properly.


To see my solution you need to build the project, to do that you need to run `dotnet build` inside of the task directory.

To run a specific task use `dotnet run` inside of the task directory.

All of this code was me on .NET version 2.1, asked for Holberton School.

#### 0. They're good dogs
Define a new enum `Rating` with the values `Good`, `Great`, `Excellent`.

#### 1. Chief Puppy Officer
Based on `0-dog`, define a new struct `Dog` with the following members:

- `name`, type: `public string`
- `age`, type: `public float`
- `owner`, type: `public string`
- `rating`, type `public Rating`

#### 2. A dog is the only thing on earth that loves you more than you love yourself
Based on `1-dog`, add a constructor to struct `Dog` that takes parameters.

#### 3. A dog will teach you unconditional love. If you can have that in your life, things won't be too bad
Based on `2-dog`, override the `.ToString()` method to print the Dog object’s attributes to stdout.
Format:
```
Dog Name: <name>
Age: <age>
Owner: <owner>
Rating: <rating>
```
