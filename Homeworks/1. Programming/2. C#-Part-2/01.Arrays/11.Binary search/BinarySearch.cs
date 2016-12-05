//Write a program that finds the index of given element X in a sorted array of N integers by using the Binary search algorithm.
namespace Binary_search
{
    using System;

    class BinarySearch
    {
        static int[] FillArray(int length)
        {
            var arr = new int[length];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            return arr;
        }

        static int BinarySearchh(int[] arr, int lowBound, int highBound, int value)
        {
            int mid;

            while (lowBound <= highBound)
            {
                mid = (lowBound + highBound) / 2;
                if (arr[mid] < value)
                {
                    lowBound = mid + 1;
                    continue;
                }
                else if (arr[mid] > value)
                {
                    highBound = mid - 1;
                    continue;
                }
                else
                {
                    return mid;
                }
            }
            return -1;
        }

        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            var arr = FillArray(input);
            int x = int.Parse(Console.ReadLine());

            int result = BinarySearchh(arr, 0, input, x);
            Console.WriteLine(result);
        }
    }
}
