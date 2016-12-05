//Write a program that finds the length of the maximal sequence of equal elements in an array of N integers.
namespace Maximal_sequence
{
    using System;

    class MaximalSequence
    {
        static int FindLengthOfMaSequence(int[] arr)
        {
            int maxCount = 0;
            int currentCount = 1;

            for (int index = 0; index < arr.Length; index++)
            {
                arr[index] = int.Parse(Console.ReadLine());
                if (index != 0)
                {
                    if (arr[index] == arr[index - 1])
                    {
                        currentCount++;
                    }
                    else
                    {
                        currentCount = 1;
                    }
                    if (currentCount > maxCount)
                    {
                        maxCount = currentCount;
                    }

                }
            }
            return maxCount;
        }

        static void Main()
        {
            var input = int.Parse(Console.ReadLine());
            var arr = new int[input];

            Console.WriteLine(FindLengthOfMaSequence(arr)); 
        }
    }
}
