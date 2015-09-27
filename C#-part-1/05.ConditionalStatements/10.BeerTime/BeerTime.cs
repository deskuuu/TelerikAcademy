
/*Problem 10.* Beer Time

A beer time is after 1:00 PM and before 3:00 AM.
Write a program that enters a time in format “hh:mm tt” (an hour in range [01...12], a minute in range [00…59] and AM / PM designator)
and prints beer time or non-beer time according to the definition above or invalid time if the time cannot be parsed.
Note: You may need to learn how to parse dates and times.using System;
*/

using System;

    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Enter a time in format hh:mm PM or AM");
        DateTime time = DateTime.Parse(Console.ReadLine());
        DateTime startBeerTime = DateTime.Parse("1:00 PM");
        DateTime endBeerTime = DateTime.Parse("1:00 PM").AddHours(14).AddMinutes(-1);

        if ((time.Hour < 12)) 
        {
            time = time.AddDays(1);
        }

        if ((time >= startBeerTime) && (time <= endBeerTime))

        {
            Console.WriteLine("Yep it`s a beer time");
        }
        else
        {
            Console.WriteLine("Sorry it`s non a beer time,you can try tomorrow");
        }
     }
  }

