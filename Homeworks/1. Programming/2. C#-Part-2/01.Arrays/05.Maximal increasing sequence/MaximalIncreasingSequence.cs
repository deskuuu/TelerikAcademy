//Write a program that finds the length of the maximal increasing sequence in an array of N integers.
namespace Maximal_increasing_sequence
{
    using System;

    class MaximalIncreasingSequence
    {
        static double FindMaxIncreaseSequence(double[] arr)
        {
            for (int index = 0; index < arr.Length; index++)
            {
                arr[index] = double.Parse(Console.ReadLine());
            }

            double maxLength = 1;
            double currentCount = 1;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > arr[i - 1])
                {
                    currentCount++;
                    maxLength = maxLength > currentCount ? maxLength : currentCount;
                }
                else
                {
                    maxLength = maxLength > currentCount ? maxLength : currentCount;
                    currentCount = 1;
                }
            }

            return maxLength;
        }

        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            var arr = new double[input];
            var output = FindMaxIncreaseSequence(arr);

            Console.WriteLine(output);
        }
    }
}