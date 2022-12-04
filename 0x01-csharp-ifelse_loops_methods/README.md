# 0x01. C# - if/else, loops, functions

More about C# and .NET. In this case we will find out about if/else statements, loops and functions.
The solution to every task is on the file with the same name than the task.

My challenge for you is to try to solve all of this taks and after see the way I did it.

All the main code would be in `main` directory, it must be at same directory of the task to work properly.

all of this code was made on .NET version 2.1, asked for Holberton School.


#### 0. Positive anything is better than negative nothing
This program will assign a random signed number to the variable `number` each time it is executed. Complete the [source code](https://github.com/holbertonschool/0x01.cs/blob/master/0-positive_or_negative.cs) in order to print whether the number stored in the variable `number` is positive or negative.
- The variable `number` will store a different value every time you will run this program.
- You don't have to undertand what `Random` does. Please do not touch this code
- The output of the program should be:
    * The number, followed by
        - if the number is greater than 0: `is positive`
        - if the number is 0: `is zero`
        - if the number is less than 0: `is negative`
    * followed by a new line


#### 1. The last digit
This program will assign a randome signed number to the variable `number` each time it is executed. Complete the [source code](https://github.com/holbertonschool/0x01.cs/blob/master/1-last_digit.cs) in order to print whether the number stored in the variable `number` is 0, greater than 5 or less than 6.
- The variable `number will store a different value every time you willrun this program
- You don't have to understand what `Random` does. Please do not touch this code
- The output of the program should be:
    * The string `The last digit of`, followed by
    * The `number`, followed by
    * The string `is`, followed by
        - if the last digit is greater than 5: the digit `and is greater than 5`
        - if the last digit is 0: the digit `and is 0`
        - if the las digit is less than 6 and not 0: the digit `and is leses than 6 and not 0`
    * followed by a new line


#### 2. I sometimes suffer from insomnia. And when I can't fall asleep, I play what I call the alphabet game
Write a program tha prints the alphabet, in lowecase, not followed by a new line.
- You can only use `Console.Write` once
- You cna onle use one loop in your code


#### 3. When I was having that alphabet soup, I never thought that it would pay off
Write a program that prints the alphabet, in lowercase, not followed by a new line.
- Print all the letter except `q` and `e`
- You can use `Console.Write` once
- You can only use one loop in your code


#### 4. Hexadecimal printing
Write a program that prints all numbers from 0 to 98 in decimal and hexadecimal (as in the following example)
- You can use `Console.Write` once
- You can only use one loop in your code
```
    0 = 0x0
    1 = 0x1
    2 = 0x2
    ...
    10 = 0xa
    11 = 0xb
    12 = 0xc
    ...
    96 = 0x60
    97 = 0x61
    98 = 0x62
```


#### 5. 00...99
Write a program that prints numbers from `0` to `99`.
- Numbers must be separated by by `,`, followed by a space
- numbers should be printed in ascending order, with two digits
- The last number should be followed by a new line
- You can onle use `Console.Write` no more than twice
- You can onle use one loop in your code
```
00, 01, 02, 03, 04, 05, 06, 07, 08, 09, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99
```


#### 6. Inventing is a combination of brains and materials. The more brains you use, the less material you need
Write a program that prints all possible different combinations of two digits.
- Numbers must be separated by `,`, followed bya a space
- The two digits must be different
- 01 and 10 are the considered the same combination of two digits 0 and 1
- print only the smallest combination of two digits
- Numbers should be printed in ascending order, with two digits
- The last number should be followed by a new line
- You can only ose `Console.Write` and `Console.WriteLine` no more than three times total
- You can only use no more than 2 loops in your code
```
01, 02, 03, 04, 05, 06, 07, 08, 09, 12, 13, 14, 15, 16, 17, 18, 19, 23, 24, 25, 26, 27, 28, 29, 34, 35, 36, 37, 38, 39, 45, 46, 47, 48, 49, 56, 57, 58, 59, 67, 68, 69, 78, 79, 89
```


#### 7. islower
Write a method that checks for lowecase character.
- Class Nama: `class Character`
- Prototype: `public static bool IsLower(char c)`
- Returns `True` if `c` is lowercase
- Returns `False` otherwise
- You are not allowed to use `Char.IsLower()` or `Char.IsUpper()`

#### 8. There are only 3 colors, 10 digits, and 7 notes; its what we do with them that's important
Write a method that prints the last digit of a number.
- Class Nama: `class Number`
- Prototype: `public static int PrintLastDigit(int number)`
- Returns the value of the last digit


#### 9. a + b
Write a method that adds two integers and returns the result.
- Class Nama: `class Number`
- Prototype: `public static int Add(int a, int b)`
- Returns the value of a + b


#### 10. The shortest distance between two points is a straight line
Write a method that draws a straight line in the terminal.
- Class Nama: `class Line`
- Prototype: `public static void PrintLine(int length)
- Where `leght` is the number of times the character `_` sould be printed
- The line should end with a new line
- If `length` is `0` or less, the function should only print a new line


#### 11. I feel like I am diagonally parked in a parallel universe
Write a method that draws a diagonal line in the terminal.
- Class Name: class Line
- Prototype: public static void PrintDiagonal(int length)
0 Where `length` is the number of times the character `\` should be printed
- The line should end with a new line
- If `length` is `0` or less, the function should only print a new line


#### 12. Fizz Buzz
Write a program that prints the numbers from 1 to 100 separated by a space.
- For multiples of three print `Fizz` instead of the number and for multiples of five print `Buzz`.
- For numbers which are multiples of both three and five print `FizzBuzz`.
- Each element should be followed by a space
- The last element should be followed by a new line
