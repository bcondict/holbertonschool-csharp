# 0x08. C# - Inheritance

What you'll find? This part of my Learning process is about:
- What is inheritance
- How is polymorphism achieved with inheritance
- What is a base class
- What is a derived class
- How to create a derived class
- How to override a method or property inherited from the base class
- What is the difference between the override and new modifiers
- What are is, .GetType(), TypeOf(), .IsInstanceOfType(), and .IsSubclassOf() and when to use them

Here are the task I solve to answer those question and more. The solution to every task is on the file with the same name than the task.

My challenge for you is to try to solve all of this task and after see the way I did it.

There are some task that may need a main file, all the main code would be in main directory, it must be at the same directory of the task to work properly.

To see my solution you need to build the project, to do that you need to run `dotnet build` inside of the task directory.

To run a specific task run `dotnet run` inside of the task directory.

All of this code was me on .NET version 2.1, asked for Holberton School.

#### 0. This is one of these
Write a method that returns True if the object is an int, otherwise return False.
- Class: `Obj`
- Prototype: `public static bool IsOfTypeInt(object obj)`

#### 1. For instance
Write a method that returns True if the object is an instance of, or if the object is an instance of a class that inherited from, Array, otherwise return False.
- Class: `Obj`
- Prototype: `public static bool IsInstanceOfArray(object obj)`

#### 2. Only subclass
Write a method that prints the names of the available properties and methods of an object. See example for output format.
- Class: `Obj`
- Prototype: `public static void Print(object myObj)`

#### 3. Type
Write a method that prints the names of the available properties and methods of an object. See example for output format.
- Class: `Obj`
- Prototype: `public static void Print(object myObj)`

#### 4. It's not a lesson in classes and inheritance without a Dog
Write a empty class Dog that inherits from empty class Animal.
- Base Class: `Animal`
- Derived Class: `Dog`

#### 5. Basic shapes
Write a class Shape.
- class: `Shape`
    * public method: `public virtual int Area()`
        - Throws an `NotImplementedException` with the message `Area() is not implemented`

#### 6. Rectangle
Based on `5-shape`, write a class Rectangle that inherits from Shape.
- Class: `Rectangle`
    * private field: `private int width`
    * private field: `private int height`
    * public property: `public int Width`
        - `get`: retrieve `width`
        - `set`: if Value is negative, throw an `ArgumentException` with the message `Width must be greater than or equal to 0`. Otherwise, set `width` to the value.
    * public property: `public int Height`
        - `get`: retrieve `height`
        - `set`: if value is negative, throw an `ArgumentException` with the message `Height must be greater than or equal to 0`. Otherwise, set `Height` to the value.

#### 7. Full rectangle
Based on `6-shape`, write a class Rectangle that inherits from Shape.
- Class: `Rectangle`
    * private field: `private int width`
    * private field: `private int height`
    * public property: `public int Width`
        - `get`: retrieve `width`
        - `set`: if Value is negative, throw an `ArgumentException` with the message `Width must be greater than or equal to 0`. Otherwise, set `width` to the value.
    * public property: `public int Height`
        - `get`: retrieve `height`
        - `set`: if value is negative, throw an `ArgumentException` with the message `Height must be greater than or equal to 0`. Otherwise, set `Height` to the value.
    * public method: `public new int Area()`
        - This will override the Area() method defined in the `Shape` base class. (Try changing `new` to `override` and run the program. What happens?) returns the area of the rectangle
    * public method: `public override string ToString()`
        - returns `[Rectangle] <width> / <height>`

#### 8. Square #1
Based on `7-shape`, write a class Square that inherits from Rectangle
- Class: `Square`
    * private field: `private int size`
    * public property: `public int Size`
        - `get`: retrieve `size`
        - `set`: if value is negative, throw an `ArguementException` with the message `Size must be greater than or equal to 0`. Otherwise, set `size`, `height`, and `width` to the value.

#### 9. Square #2
Based on `8-shape`, write a class `Square` that inherits from `Rectangle`
- Class: `Square`
    * private field: `private int size`
    * public property: `public int size`
        - `get`: retrieve `size`
        - `set`: if value is negative, throw an `ArgumentException` with the message `Size must be greater than or equal to 0`. Otherwise, set `size`, `Height`, and `Width` to the value.
    * `Area()` should work **without** writing a new `Area()` method within your `Square` class
    * `.ToString()` should return `[Square] <size> / <size>`

#### 10. Liskov
Write a blog post that explains the problem with implementing a Square class as a derived class of Rectangle. It should cover:
- what Liskov’s substitution principle is
- why Square inheriting from Rectangle is not an ideal design choice
- ways that this class hierarchy could be improved
Your posts should have examples and at least one picture, at the top. Publish your blog post on Medium or LinkedIn, and share it at least on Twitter and LinkedIn.
Please, remember that these blogs must be written in English to further your technical ability in a variety of settings.
