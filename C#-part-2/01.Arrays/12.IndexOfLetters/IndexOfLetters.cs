/*
Problem 12. Index of letters

Write a program that creates an array containing all letters from the alphabet (A-Z).
Read a word from the console and print the index of each of its letters in the array.
 */
using System;

	class IndexOfLetters
	{
		public static void Main()
		{
			char[] letters = {'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
			Console.WriteLine("Enter a word");
			string word = Console.ReadLine();

           for (int i = 0; i < word.Length; i++)
           {
            Console.Write(Array.IndexOf(letters, word[i]) + " ");
           }
           Console.WriteLine();
			
		}
	}
