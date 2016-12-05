//Write a program that sorts an array of integers using the Merge sort algorithm.
namespace _13.Quick_sort
{
    using System;

    class QuickSort
    {
        static void SortNumbers(int input)
        {
            var numbers = new int[input];

            for (int i = 0; i < input; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(numbers);

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
        }

        static void Main()
        {
            int input = int.Parse(Console.ReadLine());

            SortNumbers(input);
        }
    }
}
