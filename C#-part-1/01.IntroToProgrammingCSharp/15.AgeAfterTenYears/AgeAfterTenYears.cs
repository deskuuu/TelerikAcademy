/*Problem 15.* Age after 10 Years

Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.
*/

using System;

class AfterTenYears
{
    static void Main()
    {
        Console.WriteLine("Write your age :");
        byte age = byte.Parse(Console.ReadLine());
        int afterTenYears = age + 10;
        Console.WriteLine("{0}{1}", "After ten years you will be ",afterTenYears);
    }
}

