//Write a program that reads a year from the console and checks whether it is a leap one.
namespace _01.Leap_year
{
    using System;

    class LeapYear
    {
        static void Leap(int year)
        {
            bool isLeap = DateTime.IsLeapYear(year);
            Console.WriteLine(isLeap ? "Leap" : "Common");
        }

        static void Main()
        {
            int year = int.Parse(Console.ReadLine());
            Leap(year);
        }
    }
}
