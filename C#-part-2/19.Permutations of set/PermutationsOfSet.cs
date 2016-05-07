//Write a program that reads a number N and generates and prints all the permutations of the numbers[1 … N].
namespace _19.Permutations_of_set
{
    using System;
    using System.Collections.Generic;

    class PermutationsOfSet
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());

            var arr = new List<int>(input);

            for (int i = 0; i <= input - 1; i++)
            {
                arr.Add(i + 1);
            }

            //TODO: think about logic!
        }
    }
}
