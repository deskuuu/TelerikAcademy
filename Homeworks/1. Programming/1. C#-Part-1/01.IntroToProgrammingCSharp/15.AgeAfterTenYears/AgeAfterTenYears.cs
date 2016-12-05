﻿/*Problem 15.* Age after 10 Years

Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.
*/

using System;
class AfterTenYears
{
    static void Main()
    {
        DateTime ageNow = DateTime.Parse(Console.ReadLine());
        DateTime now = DateTime.Now;
        TimeSpan age = (now.Subtract(ageNow));
        Console.WriteLine("{0}\n{1}", new DateTime(age.Ticks).Year -1, (new DateTime(age.Ticks).Year - 1)+10);
    }
}

