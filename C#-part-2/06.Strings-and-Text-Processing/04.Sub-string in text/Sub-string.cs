//Write a program that finds how many times a sub-string is contained in a given text(perform case insensitive search).
namespace _04.Sub_string_in_text
{
    using System;
    using System.Text.RegularExpressions;

    class SubString
    {
        static int CountSubString(string word, string text)
        {
            int counter = 0;
            int nextIndex = text.IndexOf(word);

            while (nextIndex != -1)
            {
                nextIndex = text.IndexOf(word, nextIndex + 1);
                counter++;
            }

            return counter;
        }

        static void Main()
        {
            var input = Console.ReadLine();
            input = input.ToLower();
            var text = Console.ReadLine();
            text = text.ToLower();
            //With Regex 
            //var counter = Regex.Matches(text, input).Count;
            // int counter = CountSubString(input, text);
            //other way to find char repeated
            //int counter = text.Split(input.ToCharArray()).Length-1;
            int counter = CountSubString(input, text);
            Console.WriteLine(counter);
        }
    }
}
