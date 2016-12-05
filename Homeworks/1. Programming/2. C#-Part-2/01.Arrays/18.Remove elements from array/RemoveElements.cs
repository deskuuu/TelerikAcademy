//Write a program that reads an array of integers and removes from it a minimal number of elements in such a way that the remaining array is sorted in increasing order.Print the minimal number of elements that need to be removed in order for the array to become sorted.
namespace _18.Remove_elements_from_array
{
    using System;
    using System.Linq;

    class RemoveElements
    {
        static int[] FillArray(int length)
        {
            var arr = new int[length];

            for (int i = 0; i < length; i++)
            {
                arr[i]=int.Parse(Console.ReadLine());
            }

            return arr;
        }

        static int FindMinNumbersToSortArr(int[] numbers, int input)
        {
            var prev = new int[input];

            for (int i = 0; i < input; i++)
            {
                prev[i] = 1;
            }

            for (int i = 1; i < input; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (numbers[i] >= numbers[j])
                    {
                        prev[i] = Math.Max(prev[i], prev[j] + 1);
                    }
                }
            }

            return input - prev.Max();
        }

        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            var arr = FillArray(input);
            int result = FindMinNumbersToSortArr(arr, input);

            Console.WriteLine(result);
        }
    }
}
