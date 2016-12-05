//Write a program that reads a string of positive integers separated by spaces and prints their sum.
namespace _08.Sum_integers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class SumIntegers
    {
        static int Sum(int[] numbers)
        {
            var list = new List<int>();
            int size = numbers.Length;

            for (int i = 0; i < size; i++)
            {
                list.Add(numbers[i]);
            }

            int sum=list.Sum();
            return sum;
        }

        static void Main()
        {
            var input = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            int sum = Sum(input);

            Console.WriteLine(sum);
        }
    }
}
