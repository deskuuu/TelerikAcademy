//Write a program that sorts a given array.
namespace _09.Sorting_array
{
    using System;
    using System.Linq;

    class SortingArray
    {
        class NumberAsArray
        {
            static void Main()
            {
                Console.ReadLine();
                var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                Array.Sort(input);

                Console.WriteLine(string.Join(" ", input));
            }
        }
    }
}
