//Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.
namespace _23.Series_of_letters
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class SeriesOfLetters
    {
        static void RemoveDuplicates(string input)
        {
            var res = new StringBuilder();
            char index = input[0];
            int counter = 0;

            foreach (var item in input)
            {
                if (item == index)
                {
                    res.Append(item);
                }

                counter++;
            }

            Console.WriteLine(res.ToString());

        }

        static void Main()
        {
            var input = Console.ReadLine();
            RemoveDuplicates(input);
        }
    }
}
