//Write a program that creates an array containing all letters from the alphabet(a-z). Read a word from the console and print the index of each of its letters in the array.
namespace _12.Index_of_letters
{
    using System;

    class IndexOfLetters
    {
        static int[] FillArrayWithAlpabets()
        {
            var arr = new int[26];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = 'a' + i;
            }

            return arr;
        }

        static void PrintResult(string input)
        {
           var letters= FillArrayWithAlpabets();

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < letters.Length; j++)
                {
                    if (input[i] == letters[j])
                    {
                        Console.WriteLine(j);
                        break;
                    }
                }
            }
        }

        static void Main()
        {
            string input = Console.ReadLine();

            PrintResult(input);
        }
    }
}
