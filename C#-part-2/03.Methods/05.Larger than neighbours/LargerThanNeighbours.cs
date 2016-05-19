//Write program that reads an array of numbers and prints how many of them are larger than their neighbours.
namespace _05.Larger_than_neighbours
{
    using System;
    using System.Linq;

    class LargerThanNeighbours
    {
        static int FindLargerThanTwo(int[] arr)
        {
            int counter = 0;

            for (int i = 1; i < arr.Length-1; i++)
            {
                if (arr[i] >arr[i+1]&&arr[i]>arr[i-1])
                {
                    counter++;
                }
            }
              
            return counter;
        }

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var input = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            int result = FindLargerThanTwo(input);

            Console.WriteLine(result);
        }
    }
}
