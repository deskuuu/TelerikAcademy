//Write a program that finds the maximal sum of consecutive elements in a given array of N numbers.
namespace _08.Maximal_sum
{
    using System;

    class MaximalSum
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

        static int FindMaxSum(int[] arr)
        {
            var maxSum = 0;
            var currentSum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                currentSum += arr[i];

                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                }
                else if (currentSum < 0)
                {
                    currentSum = 0;
                }
            }

            return maxSum;
        }

        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            int output = FindMaxSum(FillArray(input));

            Console.WriteLine(output);
        }
    }
}
