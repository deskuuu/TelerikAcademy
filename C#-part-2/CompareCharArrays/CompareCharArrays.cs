/*Problem 3. Compare char arrays

Write a program that compares two char arrays lexicographically (letter by letter).
*/
using System;

    class CompareCharArrays
    {
        static void Main ()
        {
        Console.WriteLine("Enter the lenght of first char :");
        int firstC = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the lenght of second char :");
        int secondC = int.Parse(Console.ReadLine());

        char[] first = new char[firstC];
        char[] second = new char[secondC];

        if (firstC == secondC)
        {
            for (int i = 0; i < first.Length; i++)
            {
                first[i] = char.Parse(Console.ReadLine());
            }

            for (int i = 0; i < second.Length; i++)
            {
                second[i] = char.Parse(Console.ReadLine());
            }

            for (int i = 0; i < first.Length; i++)
            {
                if (first[i] != second[i])
                {
                    Console.WriteLine("The arrays are not equal.");
                }
            }
        }
        else
        {
            Console.WriteLine("The arrays are equal.");
        }
    }
    }

