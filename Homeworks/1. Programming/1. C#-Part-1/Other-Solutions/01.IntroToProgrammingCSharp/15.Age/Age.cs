/*Problem 15. Age
Write a program that reads your birthday(in the format MM.DD.YYYY) from 
the console and prints on the console how old you are you now and how old will you be after 10 years.
 */
namespace _15.Age
{
    using System;

    class Age
    {
        static void Main()
        {
            PrintAgeAfterTenYears();
        }

        static void PrintAgeAfterTenYears()
        {
            // Console.WriteLine("Enter your birthday in the format MM.DD.YYYY: ");
            DateTime ageNow = DateTime.Parse(Console.ReadLine());

            DateTime now = DateTime.Now;
            TimeSpan age = (now.Subtract(ageNow));

            int ageNoww = new DateTime(age.Ticks).Year - 1;
            int ageAfterTenYears = ageNoww + 10;

            // Console.WriteLine($"Now you are: {ageNoww} years old\nAfter 10, you`ll be: {ageAfterTenYears} years old");
            Console.WriteLine("{0}\n{1}", ageNoww, ageAfterTenYears);
        }
    }
}