//Write a program that compares two char arrays lexicographically(letter by letter).
namespace Compare_char_arrays
{
    using System;

    class CompareCharArrays
    {
        static void Main()
        {
            string first = Console.ReadLine();
            string second = Console.ReadLine();
            var areEquals = false;
            var output = string.Empty;

            if (first.Length == second.Length)
            {
                for (int i = 0; i < first.Length; i++)
                {
                    if (first[i] == second[i])
                    {
                        areEquals = true;
                    }
                    else
                    {
                        areEquals = false;
                        output = first[i] < second[i] ? "<" : ">";
                        break;
                    }
                }

                Console.WriteLine(areEquals ? "=" : output);
            }
            else if (first.Length > second.Length)
            {
                Console.WriteLine(">");
            }
            else 
            {
                Console.WriteLine("<");
            }
        }
    }
}
