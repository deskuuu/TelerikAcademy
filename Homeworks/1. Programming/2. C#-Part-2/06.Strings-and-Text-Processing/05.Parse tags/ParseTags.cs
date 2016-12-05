//You are given a text.Write a program that changes the text in all regions surrounded by the tags<upcase> and</upcase> to upper-case.

namespace _05.Parse_tags
{
    using System;
    using System.Text.RegularExpressions;

    class ParseTags
    {
        static void Main()
        {
            var text = Console.ReadLine();

            Console.WriteLine(Regex.Replace(text, "<upcase>(.*?)</upcase>", m => m.Groups[1].Value.ToUpper()));
        }
    }
}
