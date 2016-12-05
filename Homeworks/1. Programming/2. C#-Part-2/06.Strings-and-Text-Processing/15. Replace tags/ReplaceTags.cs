//Write a program that replaces in a HTML document given as string all the tags<a href="URL">TEXT</a> with corresponding markdown notation[TEXT](URL).
namespace _15.Replace_tags
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;

    class ReplaceTags
    {
        static void ReplaceSite(string input)
        {
            int start = input.IndexOf("<a");
            int text = input.IndexOf("\"");
            var href = input.Substring(start, 2);
            input.Insert(start, href);
            Console.WriteLine(input);
            Console.WriteLine(Regex.Replace(input, @"<a\b[^>]+>([^<]*(?:(?!</a)<[^<]*)*)</a>", "$1"));
        }

        static void Main()
        {
            var input = Console.ReadLine();
            ReplaceSite(input);
        }
    }
}