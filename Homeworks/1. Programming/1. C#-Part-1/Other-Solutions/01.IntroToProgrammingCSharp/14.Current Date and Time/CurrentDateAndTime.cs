/*Problem 14. Current Date and Time
Create a console application that prints the current date and time.
 */
namespace _14.Current_Date_and_Time
{
    using System;

    class CurrentDateAndTime
    {
        static void Main()
        {
            PrintCurrentTime();
        }

        static void PrintCurrentTime()
        {
            Console.WriteLine(DateTime.Now);
        }
    }
}
