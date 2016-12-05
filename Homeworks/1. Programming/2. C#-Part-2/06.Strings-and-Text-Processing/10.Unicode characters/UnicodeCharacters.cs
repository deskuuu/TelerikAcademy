//Write a program that converts a string to a sequence of C# Unicode character literals.
namespace _10.Unicode_characters
{
    using System;

    class UnicodeCharacters
    {

        static void EscapeSequence(char c)
        {
            var escaped = "\\u" + ((int)c).ToString("X4");
            Console.Write(escaped);
        }

        static void Main()
        {
            string input = Console.ReadLine();

            foreach (var item in input)
            {
                EscapeSequence(item);
            }

        }
    }
}
