//Write a program to sort an array.
namespace Selection_sort
{
    using System;

    class SelectionSort
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

        static void PrintSorted(int[] arr)
        {
            Array.Sort(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        static void Main()
        {
            int input = int.Parse(Console.ReadLine());

            PrintSorted(FillArray(input));
        }
    }
}
