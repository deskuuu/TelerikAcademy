/*Problem 7. QuotesInStrings
Write a program that outputs: The "use" of quotations causes difficulties.
*/
namespace _07.Quotes_in_Strings
{
    using System;

    class QuotesInStrings
    {
        static void Main()
        {
            string userStringToPrint = Console.ReadLine();

            PrintWithQuotes(userStringToPrint);
        }

        static void PrintWithQuotes(string toPrint)
        {
            if (string.IsNullOrEmpty(toPrint))
            {
                throw new ArgumentNullException("Your input string is missing...");
            }

             // Console.WriteLine("The \"use\" of quotations causes difficulties.");
            //  Console.WriteLine(@"The ""use"" of quotations causes difficulties.");
            Console.WriteLine($@"{toPrint}");
        }
    }
}
