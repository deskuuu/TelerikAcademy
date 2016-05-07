//write a program that reads two integer arrays of size n from the console and compares them element by element.
namespace Compare_arrays
{
    using System;

    class CompareCharArrays
    {
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());
            var firstNumbers = new int[size];
            var secondNumbers = new int[size];

            for (int i = 0; i < firstNumbers.Length; i++)
            {
                firstNumbers[i] = int.Parse(Console.ReadLine());
            }

            for (int j = 0; j < secondNumbers.Length; j++)
            {
                secondNumbers[j] = int.Parse(Console.ReadLine());
            }

            bool isEqual = false;
            for (int l = 0; l < size; l++)
            {
                if (firstNumbers[l] == secondNumbers[l])
                {
                    isEqual = true;
                }
                else
                {
                    isEqual = false;
                    break;
                }
            }

            Console.WriteLine(isEqual ? "Equal" : "Not equal");
        }
    }
}
