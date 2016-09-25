namespace _03.Range_Exceptions
{
    using System;

    class Test
    {
        static void Main()
        {
            // numbers cheker
            InvalidRangeException<int> someIntExeption =
                 new InvalidRangeException<int>("Numbers must be from 0 do 100!", 1, 100);

            Console.WriteLine("Enter 3 numbers to check:");
            for (int i = 0; i < 3; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number < someIntExeption.Start || number > someIntExeption.End)
                {
                    throw someIntExeption;
                }
                else
                {
                    Console.WriteLine("The number is correct!");
                }
            }
            // date checker
            string startDate = "1/1/1980";
            string endDate = "31/12/2013";

            InvalidRangeException<DateTime> someDateExpection =
                new InvalidRangeException<DateTime>("The date must be in the range from 1980 to 2013!", 
                          DateTime.Parse(startDate), DateTime.Parse(endDate));

            Console.WriteLine("Enter 2 dates to check:");
            for (int i = 0; i < 3; i++)
            {
                string date = Console.ReadLine();
                DateTime someDate = DateTime.Parse(date);
                if (someDate.Year < someDateExpection.Start.Year || someDate.Year > someDateExpection.End.Year)
                {
                    throw someDateExpection;
                }
                else
                {
                    Console.WriteLine("The date is correct!");
                }
            }
        }
    }
}