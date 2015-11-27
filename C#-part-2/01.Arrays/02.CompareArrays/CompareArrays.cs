/*Problem 2. Compare arrays

Write a program that reads two integer arrays from the console and compares them element by element.
*/
using System;

    class CompareArrays
    {
        static void Main()
        {
        Console.WriteLine("Enter lenght of first array:");
        int firstArr = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter lenght of second array:");
        int secondArr = int.Parse(Console.ReadLine());

        int[] first = new int[firstArr];
        int[] second = new int[secondArr];

        if (first.Length > second.Length)
        {
            Console.WriteLine("The first array is greather.");
        }
        else
        {
            Console.WriteLine("The second array is greather.");
        }

    }
}

