//Write a method that returns the index of the first element in array that is larger than its neighbours, or -1, if there is no such element
namespace _06.First_larger_than_neighbours
{
    using System;
    using System.Linq;

    class FirstLargerThanNeighbours
    {
        static int FindFirstLarger(int[] arr)
        {
            int counter = 0;

            for (int i = 1; i < arr.Length - 1; i++)
            {
                if (arr[i] > arr[i + 1] && arr[i] > arr[i - 1])
                {
                    counter = i; break;
                }
                else
                {
                    counter = -1;
                }
            }

            return counter;
        }

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var input = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            int index = FindFirstLarger(input);

            Console.WriteLine(index);
        }
    }
}

