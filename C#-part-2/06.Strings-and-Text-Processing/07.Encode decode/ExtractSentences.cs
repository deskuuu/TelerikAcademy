//Write a program that extracts from a given text all sentences containing given word.
namespace _07.Encode_decode
{
    using System;
    using System.Linq;

    class ExtractSentences
    {
        static void ExtractSentence(string word, string text)
        {
            string[] splitted = text.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
            char[] separators = text.Where(c => !char.IsLetter(c))
                                     .Distinct() //returns an unordered sequence that contains no duplicate values
                                     .ToArray();

            word.ToLower();

            foreach (var sent in splitted)
            {
                string[] words = sent.Split(separators, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < words.Length; i++)
                {
                    if (word == words[i].Trim())
                    {
                        Console.Write(sent.Trim() + ". ");
                        break;
                    }

                }
            }

        }

        static void Main()
        {
            string word = Console.ReadLine();
            string text = Console.ReadLine();

            ExtractSentence(word, text);
        }
    }
}
