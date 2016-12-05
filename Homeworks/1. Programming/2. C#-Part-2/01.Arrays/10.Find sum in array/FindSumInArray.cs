//Write a program that finds in given array of integers a sequence of given sum S
namespace _10.Find_sum_in_array
{
    using System;

    class FindSumInArray
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            int sum = int.Parse(Console.ReadLine());

            var arr = new int[input];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int result = 0;
            bool isSum = false;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i; j < arr.Length; j++)
                {
                    result += arr[j];

                    if (result == sum)
                    {
                        isSum = true;

                        for (int p = 0; p <= j; p++)
                        {
                            Console.Write(arr[p] + " ");
                        }

                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
